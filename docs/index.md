# Partner API SDK for C#
## Installation

nuget.orgからインストールすることができます。[パッケージはこちら](https://www.nuget.org/packages/pokepay-partner-csharp-sdk/)

```
PM> Install-Package pokepay-partner-csharp-sdk
```
or
```
$ dotnet add package pokepay-partner-csharp-sdk
```

プロジェクトにて、以下のようにインポートします。

```csharp
using PokepayPartnerCsharpSdk;
// もしくは
using PokepayPartnerCsharpSdk;
using PokepayPartnerCsharpSdk.Request;
using PokepayPartnerCsharpSdk.Response;
```

## Getting started

基本的な使い方は次のようになります。

- ライブラリをロード
- 設定ファイル(後述)から `Client` オブジェクトを作る
- リクエストオブジェクトを作り Send() 関数に `Client` オブジェクトを渡す。
- レスポンスオブジェクトを得る

典型的には以下のようなコードになります。

```csharp
using PokepayPartnerCsharpSdk;
// ...
Client client = new Client("/path/to/config.ini");
Request.SendEcho request = new Request.SendEcho("hello");
Response.Echo response = await request.Send(client);
```

リクエストオブジェクトは、必須のパラメータはコンストラクタの引数に与える必要があります。
オプショナルなパラメーターは、 オブジェクト初期化子 `object initializer` (`{ }`)で与えることができます。

```csharp
// (例) 必須パラメーターとオプショナルパラメータの指定
Request.CreateBill request = new Request.CreateBill(
    "1b598fcb-2662-4b91-bcb1-62ded4d691b1",
    "817a81d1-44d4-4615-89c8-56cd3c83db30"
) {
    Amount = 120,
    Description = "120マネーの支払いQRコード1"
};
Response.Bill response = await request.Send(client);
```

レスポンスオブジェクトの中には必要なデータが含まれています。

注意: Client は内部で SSL クライアント証明書をキャッシュしていますので、初期化後は使いまわしてください。
Client をリクエストごとに頻繁に再生成するとオーバーヘッドになる可能性があります。

## Settings

設定はINIファイルに記述し、`Client` のコンストラクタにファイルパスを指定します。

SDKプロジェクトルートに `config.ini.sample` というファイルがありますのでそれを元に必要な情報を記述してください。特に以下の情報は通信の安全性のため必要な項目です。これらはパートナー契約時にお渡ししているものです。

- `CLIENT_ID`: パートナーAPI クライアントID
- `CLIENT_SECRET`: パートナーAPI クライアント秘密鍵
- `SSL_KEY_FILE`: SSL秘密鍵ファイルパス
- `SSL_CERT_FILE`: SSL証明書ファイルパス

この他に接続先のサーバURL情報が必要です。

- `API_BASE_URL`: パートナーAPI サーバURL

また、この設定ファイルには認証に必要な情報が含まれるため、ファイルの管理・取り扱いに十分注意してください。

設定ファイル記述例(`config.ini.sample`)

```
CLIENT_ID        = xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx
CLIENT_SECRET    = yyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyy
API_BASE_URL     = https://partnerapi-sandbox.pokepay.jp
SSL_KEY_FILE     = /path/to/key.pem
SSL_CERT_FILE    = /path/to/cert.pem
```

## Overview

### APIリクエスト

Partner APIへの通信はリクエストオブジェクトを作り、`Request.Send()` メソッドに `Client` を渡すことで行われます。
また `Request.Send()` は `非同期関数` で `Task<Response>` を返します。`await` することができます。
たとえば `SendEcho` は送信した内容をそのまま返す処理です。

```csharp
Request.SendEcho request = new Request.SendEcho("hello");
Response.Echo response = await request.Send(client);
```

通信の結果として、レスポンスオブジェクトが得られます。

```csharp
response {
    Status = "OK",
    Message = "hello"
}
```

利用可能なAPI操作については [API Operations](#api-operations) で紹介します。

<a name="paging"></a>
### ページング

API操作によっては、大量のデータがある場合に備えてページング処理があります。
その処理では以下のようなプロパティを持つレスポンスオブジェクトを返します。

- rows : 列挙するレスポンスクラスのオブジェクトの配列
- count : 全体の要素数
- pagination : 以下のインスタンス変数を持つオブジェクト
  - current : 現在のページ位置(1からスタート)
  - per_page : 1ページ当たりの要素数
  - max_page : 最後のページ番号
  - has_prev : 前ページを持つかどうかの真理値
  - has_next : 次ページを持つかどうかの真理値

ページングクラスは `Pagination` で定義されています。

以下にコード例を示します。

```csharp
Request.ListTransactions request = new Request.ListTransactions {
    Page = 1,
    PerPage = 50
};
Response.PaginatedTransaction response = await request.Send(client);

if (response.Pagination.HasNext) {
    int nextPage = response.Pagination.Current + 1;
    Request.ListTransactions request = new Request.ListTransactions {
        Page = nextPage,
        PerPage = 50
    };
    Response.PaginatedTransaction response = await request.Send(client);
}
```

### エラーハンドリング

API呼び出し時のエラーの場合は `HttpRequestException` が `throw` されます。
参考: https://docs.microsoft.com/ja-jp/dotnet/api/system.net.http.httprequestexception?view=net-5.0

* e.Message に内容
* e.StatusCode にHttpステータスコード
* e.Data["Type"] にエラータイプ
* e.Data["Message"] に詳細理由

がそれぞれ設定されています。

```csharp
try {
    Request.SendEcho request = new Request.SendEcho("hello");
    Response.Echo response = await request.Send(client);
} catch (HttpRequestException e) {
    e.StatusCode // Httpステータスコード
    e.Message // 内容
    e.Data["Type"] // エラータイプ
    e.Data["Message"] // 詳細内容
}
```
<a name="api-operations"></a>
## API Operations

- [ListTransactions](#list-transactions): 取引履歴を取得する
- [CreateTransaction](#create-transaction): チャージする(廃止予定)
- [CreateTopupTransaction](#create-topup-transaction): チャージする
- [CreatePaymentTransaction](#create-payment-transaction): 支払いする
- [CreateTransferTransaction](#create-transfer-transaction): 個人間送金
- [CreateExchangeTransaction](#create-exchange-transaction): 
- [GetTransaction](#get-transaction): 取引情報を取得する
- [RefundTransaction](#refund-transaction): 返金する
- [ListTransfers](#list-transfers): 
- [CreateTopupTransactionWithCheck](#create-topup-transaction-with-check): チャージQRコードを読み取ることでチャージする
- [ListBills](#list-bills): 支払いQRコード一覧を表示する
- [CreateBill](#create-bill): 支払いQRコードの発行
- [UpdateBill](#update-bill): 支払いQRコードの更新
- [CreateCashtray](#create-cashtray): Cashtrayを作る
- [GetCashtray](#get-cashtray): Cashtrayの情報を取得する
- [CancelCashtray](#cancel-cashtray): Cashtrayを無効化する
- [UpdateCashtray](#update-cashtray): Cashtrayの情報を更新する
- [GetAccount](#get-account): ウォレット情報を表示する
- [UpdateAccount](#update-account): ウォレット情報を更新する
- [ListAccountBalances](#list-account-balances): エンドユーザーの残高内訳を表示する
- [ListAccountExpiredBalances](#list-account-expired-balances): エンドユーザーの失効済みの残高内訳を表示する
- [GetCustomerAccounts](#get-customer-accounts): エンドユーザーのウォレット一覧を表示する
- [CreateCustomerAccount](#create-customer-account): 新規エンドユーザーウォレットを追加する
- [GetShopAccounts](#get-shop-accounts): 店舗ユーザーのウォレット一覧を表示する
- [ListCustomerTransactions](#list-customer-transactions): 取引履歴を取得する
- [ListShops](#list-shops): 店舗一覧を取得する
- [CreateShop](#create-shop): 新規店舗を追加する(廃止予定)
- [CreateShopV2](#create-shop-v2): 新規店舗を追加する
- [GetShop](#get-shop): 店舗情報を表示する
- [UpdateShop](#update-shop): 店舗情報を更新する
- [ListUserAccounts](#list-user-accounts): エンドユーザー、店舗ユーザーのウォレット一覧を表示する
- [GetPrivateMoneys](#get-private-moneys): マネー一覧を取得する
- [GetPrivateMoneyOrganizationSummaries](#get-private-money-organization-summaries): 決済加盟店の取引サマリを取得する
- [BulkCreateTransaction](#bulk-create-transaction): CSVファイル一括取引
### Transaction
<a name="list-transactions"></a>
#### 取引履歴を取得する
取引一覧を返します。
```csharp
Request.ListTransactions request = new Request.ListTransactions() {
    From = "2017-05-10T09:01:07.000000+09:00",  // 開始日時
    To = "2017-02-12T17:02:56.000000+09:00",  // 終了日時
    Page = 1,  // ページ番号
    PerPage = 50,  // 1ページ分の取引数
    ShopId = "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx",  // 店舗ID
    CustomerId = "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx",  // エンドユーザーID
    CustomerName = "太郎",  // エンドユーザー名
    TerminalId = "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx",  // 端末ID
    TransactionId = "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx",  // 取引ID
    OrganizationCode = "pocketchange",  // 組織コード
    PrivateMoneyId = "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx",  // マネーID
    IsModified = false,  // キャンセルフラグ
    Types = new string[]{"topup", "payment"},  // 取引種別 (複数指定可)、チャージ=topup、支払い=payment
    Description = "店頭QRコードによる支払い",  // 取引説明文
};
Response.PaginatedTransaction response = await request.Send(client!);
```

---
`from`  
```json
{
  "type": "string",
  "format": "date-time"
}
```
抽出期間の開始日時です。

フィルターとして使われ、開始日時以降に発生した取引のみ一覧に表示されます。

---
`to`  
```json
{
  "type": "string",
  "format": "date-time"
}
```
抽出期間の終了日時です。

フィルターとして使われ、終了日時以前に発生した取引のみ一覧に表示されます。

---
`page`  
```json
{
  "type": "integer",
  "minimum": 1
}
```
取得したいページ番号です。

---
`per_page`  
```json
{
  "type": "integer",
  "minimum": 1
}
```
1ページ分の取引数です。

---
`shop_id`  
```json
{
  "type": "string",
  "format": "uuid"
}
```
店舗IDです。

フィルターとして使われ、指定された店舗での取引のみ一覧に表示されます。

---
`customer_id`  
```json
{
  "type": "string",
  "format": "uuid"
}
```
エンドユーザーIDです。

フィルターとして使われ、指定されたエンドユーザーでの取引のみ一覧に表示されます。

---
`customer_name`  
```json
{
  "type": "string",
  "maxLength": 256
}
```
エンドユーザー名です。

フィルターとして使われ、入力された名前に部分一致するエンドユーザーでの取引のみ一覧に表示されます。

---
`terminal_id`  
```json
{
  "type": "string",
  "format": "uuid"
}
```
端末IDです。

フィルターとして使われ、指定された端末での取引のみ一覧に表示されます。

---
`transaction_id`  
```json
{
  "type": "string",
  "format": "uuid"
}
```
取引IDです。

フィルターとして使われ、指定された取引のみ一覧に表示されます。

---
`organization_code`  
```json
{
  "type": "string",
  "maxLength": 32,
  "pattern": "^[a-zA-Z0-9-]*$"
}
```
組織コードです。

フィルターとして使われ、指定された組織での取引のみ一覧に表示されます。

---
`private_money_id`  
```json
{
  "type": "string",
  "format": "uuid"
}
```
マネーIDです。

フィルターとして使われ、指定したマネーでの取引のみ一覧に表示されます。

---
`is_modified`  
```json
{ "type": "boolean" }
```
キャンセルフラグです。

これにtrueを指定するとキャンセルされた取引のみ一覧に表示されます。
デフォルト値はfalseで、キャンセルの有無にかかわらず一覧に表示されます。

---
`types`  
```json
{
  "type": "array",
  "items": {
    "type": "string",
    "enum": {
      "topup": "payment",
      "exchange_outflow": "exchange_inflow"
    }
  }
}
```
取引の種類でフィルターします。

以下の種類を指定できます。

1. topup
   店舗からエンドユーザーへの送金取引(チャージ)

2. payment
   エンドユーザーから店舗への送金取引(支払い)

3. exchange-outflow
　　他マネーへの流出

4. exchange-inflow
   他マネーからの流入

---
`description`  
```json
{
  "type": "string",
  "maxLength": 200
}
```
取引を指定の取引説明文でフィルターします。

取引説明文が完全一致する取引のみ抽出されます。取引説明文は最大200文字で記録されています。

---
成功したときは[PaginatedTransaction](#paginated-transaction)オブジェクトを返します
<a name="create-transaction"></a>
#### チャージする(廃止予定)
チャージ取引を作成します。このAPIは廃止予定です。以降は `CreateTopupTransaction` を使用してください。
```csharp
Request.CreateTransaction request = new Request.CreateTransaction(
    "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx",
    "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx",
    "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx"
) {
    MoneyAmount = 5545,
    PointAmount = 6708,
    PointExpiresAt = "2024-02-06T11:02:52.000000+09:00",  // ポイント有効期限
    Description = "CafuN856J50SdiADG37eydGENMPuSUGCPNHip0",
};
Response.Transaction response = await request.Send(client!);
```

---
`point_expires_at`  
```json
{
  "type": "string",
  "format": "date-time"
}
```
ポイントをチャージした場合の、付与されるポイントの有効期限です。
省略した場合はマネーに設定された有効期限と同じものがポイントの有効期限となります。

---
成功したときは[Transaction](#transaction)オブジェクトを返します
<a name="create-topup-transaction"></a>
#### チャージする
チャージ取引を作成します。
```csharp
Request.CreateTopupTransaction request = new Request.CreateTopupTransaction(
    "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx", // 店舗ID
    "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx", // エンドユーザーのID
    "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx" // マネーID
) {
    BearPointShopId = "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx",  // ポイント支払時の負担店舗ID
    MoneyAmount = 7001.0,  // マネー額
    PointAmount = 650.0,  // ポイント額
    PointExpiresAt = "2018-05-18T16:46:21.000000+09:00",  // ポイント有効期限
    Description = "初夏のチャージキャンペーン",  // 取引履歴に表示する説明文
    RequestId = "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx",  // リクエストID
};
Response.Transaction response = await request.Send(client!);
```

---
`shop_id`  
```json
{
  "type": "string",
  "format": "uuid"
}
```
店舗IDです。

送金元の店舗を指定します。

---
`customer_id`  
```json
{
  "type": "string",
  "format": "uuid"
}
```
エンドユーザーIDです。

送金先のエンドユーザーを指定します。

---
`private_money_id`  
```json
{
  "type": "string",
  "format": "uuid"
}
```
マネーIDです。

マネーを指定します。

---
`bear_point_shop_id`  
```json
{
  "type": "string",
  "format": "uuid"
}
```
ポイント支払時の負担店舗IDです。

ポイント支払い時に実際お金を負担する店舗を指定します。

---
`money_amount`  
```json
{
  "type": "number",
  "minimum": 0
}
```
マネー額です。

送金するマネー額を指定します。

---
`point_amount`  
```json
{
  "type": "number",
  "minimum": 0
}
```
ポイント額です。

送金するポイント額を指定します。

---
`point_expires_at`  
```json
{
  "type": "string",
  "format": "date-time"
}
```
ポイントをチャージした場合の、付与されるポイントの有効期限です。
省略した場合はマネーに設定された有効期限と同じものがポイントの有効期限となります。

---
`description`  
```json
{
  "type": "string",
  "maxLength": 200
}
```
取引説明文です。

任意入力で、取引履歴に表示される説明文です。

---
`request_id`  
```json
{
  "type": "string",
  "format": "uuid"
}
```
取引作成APIの羃等性を担保するためのリクエスト固有のIDです。

取引作成APIで結果が受け取れなかったなどの理由で再試行する際に、二重に取引が作られてしまうことを防ぐために、クライアント側から指定されます。指定は任意で、UUID V4フォーマットでランダム生成した文字列です。リクエストIDは一定期間で削除されます。

リクエストIDを指定したとき、まだそのリクエストIDに対する取引がない場合、新規に取引が作られレスポンスとして返されます。もしそのリクエストIDに対する取引が既にある場合、既存の取引がレスポンスとして返されます。

---
成功したときは[Transaction](#transaction)オブジェクトを返します
<a name="create-payment-transaction"></a>
#### 支払いする
支払取引を作成します。
支払い時には、エンドユーザーの残高のうち、ポイント残高から優先的に消費されます。

```csharp
Request.CreatePaymentTransaction request = new Request.CreatePaymentTransaction(
    "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx", // 店舗ID
    "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx", // エンドユーザーID
    "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx", // マネーID
    6244.0 // 支払い額
) {
    Description = "たい焼き(小倉)",  // 取引履歴に表示する説明文
    RequestId = "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx",  // リクエストID
};
Response.Transaction response = await request.Send(client!);
```

---
`shop_id`  
```json
{
  "type": "string",
  "format": "uuid"
}
```
店舗IDです。

送金先の店舗を指定します。

---
`customer_id`  
```json
{
  "type": "string",
  "format": "uuid"
}
```
エンドユーザーIDです。

送金元のエンドユーザーを指定します。

---
`private_money_id`  
```json
{
  "type": "string",
  "format": "uuid"
}
```
マネーIDです。

マネーを指定します。

---
`amount`  
```json
{
  "type": "number",
  "minimum": 0
}
```
マネー額です。

送金するマネー額を指定します。

---
`description`  
```json
{
  "type": "string",
  "maxLength": 200
}
```
取引説明文です。

任意入力で、取引履歴に表示される説明文です。

---
`request_id`  
```json
{
  "type": "string",
  "format": "uuid"
}
```
取引作成APIの羃等性を担保するためのリクエスト固有のIDです。

取引作成APIで結果が受け取れなかったなどの理由で再試行する際に、二重に取引が作られてしまうことを防ぐために、クライアント側から指定されます。指定は任意で、UUID V4フォーマットでランダム生成した文字列です。リクエストIDは一定期間で削除されます。

リクエストIDを指定したとき、まだそのリクエストIDに対する取引がない場合、新規に取引が作られレスポンスとして返されます。もしそのリクエストIDに対する取引が既にある場合、既存の取引がレスポンスとして返されます。

---
成功したときは[Transaction](#transaction)オブジェクトを返します
<a name="create-transfer-transaction"></a>
#### 個人間送金
エンドユーザー間での送金取引(個人間送金)を作成します。
個人間送金で送れるのはマネーのみで、ポイントを送ることはできません。送金元のマネー残高のうち、有効期限が最も遠いものから順に送金されます。

```csharp
Request.CreateTransferTransaction request = new Request.CreateTransferTransaction(
    "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx", // 送金元ユーザーID
    "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx", // 受取ユーザーID
    "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx", // マネーID
    2754.0 // 送金額
) {
    Description = "たい焼き(小倉)",  // 取引履歴に表示する説明文
    RequestId = "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx",  // リクエストID
};
Response.Transaction response = await request.Send(client!);
```

---
`sender_id`  
```json
{
  "type": "string",
  "format": "uuid"
}
```
エンドユーザーIDです。

送金元のエンドユーザー(送り主)を指定します。

---
`receiver_id`  
```json
{
  "type": "string",
  "format": "uuid"
}
```
エンドユーザーIDです。

送金先のエンドユーザー(受け取り人)を指定します。

---
`private_money_id`  
```json
{
  "type": "string",
  "format": "uuid"
}
```
マネーIDです。

マネーを指定します。

---
`amount`  
```json
{
  "type": "number",
  "minimum": 0
}
```
マネー額です。

送金するマネー額を指定します。

---
`description`  
```json
{
  "type": "string",
  "maxLength": 200
}
```
取引説明文です。

任意入力で、取引履歴に表示される説明文です。

---
`request_id`  
```json
{
  "type": "string",
  "format": "uuid"
}
```
取引作成APIの羃等性を担保するためのリクエスト固有のIDです。

取引作成APIで結果が受け取れなかったなどの理由で再試行する際に、二重に取引が作られてしまうことを防ぐために、クライアント側から指定されます。指定は任意で、UUID V4フォーマットでランダム生成した文字列です。リクエストIDは一定期間で削除されます。

リクエストIDを指定したとき、まだそのリクエストIDに対する取引がない場合、新規に取引が作られレスポンスとして返されます。もしそのリクエストIDに対する取引が既にある場合、既存の取引がレスポンスとして返されます。

---
成功したときは[Transaction](#transaction)オブジェクトを返します
<a name="create-exchange-transaction"></a>
#### 
```csharp
Request.CreateExchangeTransaction request = new Request.CreateExchangeTransaction(
    "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx",
    "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx",
    "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx",
    7140.0
) {
    Description = "Xe1sIjLSVztCspdpKcDGU85LATApzQ2dQG1XtK0UfX1fzmKZw4jAX5TdVMZA3FsBWHTaR7q8iHovbTWoPNbCUX3WmvU0lnYW7MWulxJqejEoXiemEzy22TP2wtSY9IoDSrJUA2sSTBsOwjVmr0",
    RequestId = "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx",  // リクエストID
};
Response.Transaction response = await request.Send(client!);
```

---
`request_id`  
```json
{
  "type": "string",
  "format": "uuid"
}
```
取引作成APIの羃等性を担保するためのリクエスト固有のIDです。

取引作成APIで結果が受け取れなかったなどの理由で再試行する際に、二重に取引が作られてしまうことを防ぐために、クライアント側から指定されます。指定は任意で、UUID V4フォーマットでランダム生成した文字列です。リクエストIDは一定期間で削除されます。

リクエストIDを指定したとき、まだそのリクエストIDに対する取引がない場合、新規に取引が作られレスポンスとして返されます。もしそのリクエストIDに対する取引が既にある場合、既存の取引がレスポンスとして返されます。

---
成功したときは[Transaction](#transaction)オブジェクトを返します
<a name="get-transaction"></a>
#### 取引情報を取得する
取引を取得します。
```csharp
Request.GetTransaction request = new Request.GetTransaction(
    "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx" // 取引ID
);
Response.Transaction response = await request.Send(client!);
```

---
`transaction_id`  
```json
{
  "type": "string",
  "format": "uuid"
}
```
取引IDです。

フィルターとして使われ、指定した取引IDの取引を取得します。

---
成功したときは[Transaction](#transaction)オブジェクトを返します
<a name="refund-transaction"></a>
#### 返金する
```csharp
Request.RefundTransaction request = new Request.RefundTransaction(
    "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx" // 取引ID
) {
    Description = "返品対応のため",  // 取引履歴に表示する返金事由
};
Response.Transaction response = await request.Send(client!);
```
成功したときは[Transaction](#transaction)オブジェクトを返します
<a name="list-transfers"></a>
#### 
```csharp
Request.ListTransfers request = new Request.ListTransfers() {
    From = "2020-12-08T12:26:18.000000+09:00",
    To = "2017-11-24T07:36:36.000000+09:00",
    Page = 4740,
    PerPage = 1712,
    ShopId = "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx",
    ShopName = "79fqhITnnz7WaCAiQd9B8sle88sl7rSWKN9oQjHsNX48VkSyiuzE1L2wv36YuE4jwp0IiR44I5KLiOrRKq3qxtTGifN6KrraD5uojwDmQdLNOKHIlDiaOh78QfhNbZ3YfGhlbqaOElvScjtjkG1",
    CustomerId = "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx",
    CustomerName = "WEjltqaYkhp7caXjUtBcNe9XyY4wthFo0glXBErIUB1p7aPMzXnAdDrY96Gn0OAQ9xSN0zfKx7ivixiVqjgvBNcsQLQxAtJm",
    TransactionId = "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx",
    PrivateMoneyId = "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx",
    IsModified = true,
    TransactionTypes = new string[]{"transfer", "payment", "topup", "exchange"},
    TransferTypes = new string[]{"exchange", "payment", "campaign", "transfer"},  // 取引明細の種類でフィルターします。
    Description = "店頭QRコードによる支払い",  // 取引詳細説明文
};
Response.PaginatedTransfers response = await request.Send(client!);
```

---
`transfer_types`  
```json
{
  "type": "array",
  "items": {
    "type": "string",
    "enum": {
      "topup": "payment",
      "exchange": "transfer",
      "coupon": "campaign"
    }
  }
}
```
取引明細の種類でフィルターします。

以下の種類を指定できます。

1. topup
店舗からエンドユーザーへの送金取引(チャージ)、またはそのキャンセル取引

2. payment
エンドユーザーから店舗への送金取引(支払い)、またはそのキャンセル取引

3. exchange
他マネーへの流出/流入

4. campaign
取引に対するポイント還元キャンペーンによるポイント付与、またはそのキャンセル取引

5. coupon
クーポンによる値引き処理、またはそのキャンセル取引

---
`description`  
```json
{
  "type": "string",
  "maxLength": 200
}
```
取引詳細を指定の取引詳細説明文でフィルターします。

取引詳細説明文が完全一致する取引のみ抽出されます。取引詳細説明文は最大200文字で記録されています。

---
成功したときは[PaginatedTransfers](#paginated-transfers)オブジェクトを返します
### Check
店舗ユーザが発行し、エンドユーザーがポケペイアプリから読み取ることでチャージ取引が発生するQRコードです。

チャージQRコードを解析すると次のようなURLになります(URLは環境によって異なります)。

`https://www-sandbox.pokepay.jp/checks/xxxxxxxx-xxxx-xxxxxxxxx-xxxxxxxxxxxx`

QRコードを読み取る方法以外にも、このURLリンクを直接スマートフォン(iOS/Android)上で開くことによりアプリが起動して取引が行われます。(注意: 上記URLはsandbox環境であるため、アプリもsandbox環境のものである必要があります) 上記URL中の `xxxxxxxx-xxxx-xxxxxxxxx-xxxxxxxxxxxx` の部分がチャージQRコードのIDです。

<a name="create-topup-transaction-with-check"></a>
#### チャージQRコードを読み取ることでチャージする
通常チャージQRコードはエンドユーザーのアプリによって読み取られ、アプリとポケペイサーバとの直接通信によって取引が作られます。 もしエンドユーザーとの通信をパートナーのサーバのみに限定したい場合、パートナーのサーバがチャージQRの情報をエンドユーザーから代理受けして、サーバ間連携APIによって実際のチャージ取引をリクエストすることになります。

エンドユーザーから受け取ったチャージ用QRコードのIDをエンドユーザーIDと共に渡すことでチャージ取引が作られます。

```csharp
Request.CreateTopupTransactionWithCheck request = new Request.CreateTopupTransactionWithCheck(
    "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx", // チャージ用QRコードのID
    "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx" // エンドユーザーのID
);
Response.Transaction response = await request.Send(client!);
```

---
`check_id`  
```json
{
  "type": "string",
  "format": "uuid"
}
```
チャージ用QRコードのIDです。

QRコード生成時に送金元店舗のウォレット情報や、送金額などが登録されています。

---
`customer_id`  
```json
{
  "type": "string",
  "format": "uuid"
}
```
エンドユーザーIDです。

送金先のエンドユーザーを指定します。

---
成功したときは[Transaction](#transaction)オブジェクトを返します
### Bill
支払いQRコード
<a name="list-bills"></a>
#### 支払いQRコード一覧を表示する
支払いQRコード一覧を表示します。
```csharp
Request.ListBills request = new Request.ListBills() {
    Page = 5974,  // ページ番号
    PerPage = 4994,  // 1ページの表示数
    BillId = "kNd3",  // 支払いQRコードのID
    PrivateMoneyId = "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx",  // マネーID
    OrganizationCode = "jUp3-N--X92Fbs--D0fn--Hx6Q-zy1",  // 組織コード
    Description = "test bill",  // 取引説明文
    CreatedFrom = "2017-04-21T18:37:28.000000+09:00",  // 作成日時(起点)
    CreatedTo = "2021-05-08T05:36:00.000000+09:00",  // 作成日時(終点)
    ShopName = "bill test shop1",  // 店舗名
    ShopId = "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx",  // 店舗ID
    LowerLimitAmount = 6767,  // 金額の範囲によるフィルタ(下限)
    UpperLimitAmount = 2585,  // 金額の範囲によるフィルタ(上限)
    IsDisabled = false,  // 支払いQRコードが無効化されているかどうか
};
Response.PaginatedBills response = await request.Send(client!);
```

---
`page`  
```json
{
  "type": "integer",
  "minimum": 1
}
```
取得したいページ番号です。

---
`per_page`  
```json
{
  "type": "integer",
  "minimum": 1
}
```
1ページに表示する支払いQRコードの数です。

---
`bill_id`  
```json
{ "type": "string" }
```
支払いQRコードのIDを指定して検索します。IDは前方一致で検索されます。

---
`private_money_id`  
```json
{
  "type": "string",
  "format": "uuid"
}
```
支払いQRコードの送金元ウォレットのマネーIDでフィルターします。

---
`organization_code`  
```json
{
  "type": "string",
  "maxLength": 32,
  "pattern": "^[a-zA-Z0-9-]*$"
}
```
支払いQRコードの送金元店舗が所属する組織の組織コードでフィルターします。

---
`description`  
```json
{
  "type": "string",
  "maxLength": 200
}
```
支払いQRコードを読み取ることで作られた取引の説明文としてアプリなどに表示されます。

---
`created_from`  
```json
{
  "type": "string",
  "format": "date-time"
}
```
支払いQRコードの作成日時でフィルターします。

これ以降に作成された支払いQRコードのみ一覧に表示されます。

---
`created_to`  
```json
{
  "type": "string",
  "format": "date-time"
}
```
支払いQRコードの作成日時でフィルターします。

これ以前に作成された支払いQRコードのみ一覧に表示されます。

---
`shop_name`  
```json
{
  "type": "string",
  "maxLength": 256
}
```
支払いQRコードを作成した店舗名でフィルターします。店舗名は部分一致で検索されます。

---
`shop_id`  
```json
{
  "type": "string",
  "format": "uuid"
}
```
支払いQRコードを作成した店舗IDでフィルターします。

---
`lower_limit_amount`  
```json
{
  "type": "integer",
  "format": "decimal",
  "minimum": 0
}
```
支払いQRコードの金額の下限を指定してフィルターします。

---
`upper_limit_amount`  
```json
{
  "type": "integer",
  "format": "decimal",
  "minimum": 0
}
```
支払いQRコードの金額の上限を指定してフィルターします。

---
`is_disabled`  
```json
{ "type": "boolean" }
```
支払いQRコードが無効化されているかどうかを表します。デフォルト値は偽(有効)です。

---
成功したときは[PaginatedBills](#paginated-bills)オブジェクトを返します
<a name="create-bill"></a>
#### 支払いQRコードの発行
支払いQRコードの内容を更新します。支払い先の店舗ユーザーは指定したマネーのウォレットを持っている必要があります。
```csharp
Request.CreateBill request = new Request.CreateBill(
    "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx", // 支払いマネーのマネーID
    "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx" // 支払い先(受け取り人)の店舗ID
) {
    Amount = 8458.0,  // 支払い額
    Description = "test bill",  // 説明文(アプリ上で取引の説明文として表示される)
};
Response.Bill response = await request.Send(client!);
```

---
`amount`  
```json
{
  "type": "number",
  "format": "decimal",
  "minimum": 0
}
```
支払いQRコードを支払い額を指定します。省略するかnullを渡すと任意金額の支払いQRコードとなり、エンドユーザーがアプリで読み取った際に金額を入力します。

---
成功したときは[Bill](#bill)オブジェクトを返します
<a name="update-bill"></a>
#### 支払いQRコードの更新
支払いQRコードの内容を更新します。パラメータは全て省略可能で、指定したもののみ更新されます。
```csharp
Request.UpdateBill request = new Request.UpdateBill(
    "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx" // 支払いQRコードのID
) {
    Amount = 45.0,  // 支払い額
    Description = "test bill",  // 説明文
    IsDisabled = false,  // 無効化されているかどうか
};
Response.Bill response = await request.Send(client!);
```

---
`bill_id`  
```json
{
  "type": "string",
  "format": "uuid"
}
```
更新対象の支払いQRコードのIDです。

---
`amount`  
```json
{
  "type": "number",
  "format": "decimal",
  "minimum": 0
}
```
支払いQRコードを支払い額を指定します。nullを渡すと任意金額の支払いQRコードとなり、エンドユーザーがアプリで読み取った際に金額を入力します。

---
`description`  
```json
{
  "type": "string",
  "maxLength": 200
}
```
支払いQRコードの詳細説明文です。アプリ上で取引の説明文として表示されます。

---
`is_disabled`  
```json
{ "type": "boolean" }
```
支払いQRコードが無効化されているかどうかを指定します。真にすると無効化され、偽にすると有効化します。

---
成功したときは[Bill](#bill)オブジェクトを返します
### Cashtray
Cashtrayは支払いとチャージ両方に使えるQRコードで、店舗ユーザとエンドユーザーの間の主に店頭などでの取引のために用いられます。
Cashtrayによる取引では、エンドユーザーがQRコードを読み取った時点で即時取引が作られ、ユーザに対して受け取り確認画面は表示されません。
Cashtrayはワンタイムで、一度読み取りに成功するか、取引エラーになると失効します。
また、Cashtrayには有効期限があり、デフォルトでは30分で失効します。

<a name="create-cashtray"></a>
#### Cashtrayを作る
Cashtrayを作成します。

エンドユーザーに対して支払いまたはチャージを行う店舗の情報(店舗ユーザーIDとマネーID)と、取引金額が必須項目です。
店舗ユーザーIDとマネーIDから店舗ウォレットを特定します。

その他に、Cashtrayから作られる取引に対する説明文や失効時間を指定できます。

```csharp
Request.CreateCashtray request = new Request.CreateCashtray(
    "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx", // マネーID
    "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx", // 店舗ユーザーID
    6575.0 // 金額
) {
    Description = "たい焼き(小倉)",  // 取引履歴に表示する説明文
    ExpiresIn = 1228,  // 失効時間(秒)
};
Response.Cashtray response = await request.Send(client!);
```

---
`private_money_id`  
```json
{
  "type": "string",
  "format": "uuid"
}
```
取引対象のマネーのIDです(必須項目)。

---
`shop_id`  
```json
{
  "type": "string",
  "format": "uuid"
}
```
店舗のユーザーIDです(必須項目)。

---
`amount`  
```json
{ "type": "number" }
```
マネー額です(必須項目)。
正の値を与えるとチャージになり、負の値を与えると支払いとなります。

---
`description`  
```json
{
  "type": "string",
  "maxLength": 200
}
```
Cashtrayを読み取ったときに作られる取引の説明文です(最大200文字、任意項目)。
アプリや管理画面などの取引履歴に表示されます。デフォルトでは空文字になります。

---
`expires_in`  
```json
{
  "type": "integer",
  "minimum": 1
}
```
Cashtrayが失効するまでの時間を秒単位で指定します(任意項目、デフォルト値は1800秒(30分))。

---
成功したときは[Cashtray](#cashtray)オブジェクトを返します
<a name="get-cashtray"></a>
#### Cashtrayの情報を取得する
Cashtrayの情報を取得します。

Cashtrayの現在の状態に加え、エンドユーザーのCashtray読み取りの試行結果、Cashtray読み取りによって作られた取引情報が取得できます。

レスポンス中の `attempt` には、このCashtrayをエンドユーザーが読み取った試行結果が入ります。
`account` はエンドユーザーのウォレット情報です。
成功時には `attempt` 内の `status_code` に200が入ります。

まだCashtrayが読み取られていない場合は `attempt` の内容は `NULL` になります。
エンドユーザーのCashtray読み取りの際には、様々なエラーが起き得ます。
エラーの詳細は `attempt` 中の `error_type` と `error_message` にあります。主なエラー型と対応するステータスコードを以下に列挙します。

- `cashtray_already_proceed (422)`
  - 既に処理済みのCashtrayをエンドユーザーが再び読み取ったときに返されます
- `cashtray_expired (422)`
  - 読み取り時点でCashtray自体の有効期限が切れているときに返されます。Cashtrayが失効する時刻はレスポンス中の `expires_at` にあります
- `cashtray_already_canceled (422)`
  - 読み取り時点でCashtrayが無効化されているときに返されます
- `account_balance_not_enough (422)`
  - 支払い時に、エンドユーザーの残高が不足していて取引が完了できなかったときに返されます
- `account_balance_exceeded`
  - チャージ時に、エンドユーザーのウォレット上限を超えて取引が完了できなかったときに返されます
- `account_transfer_limit_exceeded (422)`
  - マネーに設定されている一度の取引金額の上限を超えたため、取引が完了できなかったときに返されます
- `account_not_found (422)`
  - Cashtrayに設定されたマネーのウォレットをエンドユーザーが持っていなかったときに返されます


レスポンス中の `transaction` には、このCashtrayをエンドユーザーが読み取ることによって作られる取引データが入ります。まだCashtrayが読み取られていない場合は `NULL` になります。

以上をまとめると、Cashtrayの状態は以下のようになります。

- エンドユーザーのCashtray読み取りによって取引が成功した場合
  - レスポンス中の `attempt` と `transaction` にそれぞれ値が入ります
- 何らかの理由で取引が失敗した場合
  - レスポンス中の `attempt` にエラー内容が入り、 `transaction` には `NULL` が入ります
- まだCashtrayが読み取られていない場合
  - レスポンス中の `attempt` と `transaction` にそれぞれ `NULL` が入ります。Cashtrayの `expires_at` が現在時刻より前の場合は有効期限切れ状態です。

Cashtrayの取り得る全ての状態を擬似コードで記述すると以下のようになります。
```
if (attempt == null) {
  // 状態は未確定
  if (canceled_at != null) {
    // 無効化済み
  } else if (expires_at < now) {
    // 失効済み
  } else {
    // まだ有効で読み取られていない
  }
} else if (transaction != null) {
  // 取引成功確定。attempt で読み取ったユーザなどが分かる
} else {
  // 取引失敗確定。attempt で失敗理由などが分かる
}
```
```csharp
Request.GetCashtray request = new Request.GetCashtray(
    "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx" // CashtrayのID
);
Response.CashtrayWithResult response = await request.Send(client!);
```

---
`cashtray_id`  
```json
{
  "type": "string",
  "format": "uuid"
}
```
情報を取得するCashtrayのIDです。

---
成功したときは[CashtrayWithResult](#cashtray-with-result)オブジェクトを返します
<a name="cancel-cashtray"></a>
#### Cashtrayを無効化する
Cashtrayを無効化します。

これにより、 `GetCashtray` のレスポンス中の `canceled_at` に無効化時点での現在時刻が入るようになります。
エンドユーザーが無効化されたQRコードを読み取ると `cashtray_already_canceled` エラーとなり、取引は失敗します。
```csharp
Request.CancelCashtray request = new Request.CancelCashtray(
    "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx" // CashtrayのID
);
Response.Cashtray response = await request.Send(client!);
```

---
`cashtray_id`  
```json
{
  "type": "string",
  "format": "uuid"
}
```
無効化するCashtrayのIDです。

---
成功したときは[Cashtray](#cashtray)オブジェクトを返します
<a name="update-cashtray"></a>
#### Cashtrayの情報を更新する
Cashtrayの内容を更新します。bodyパラメーターは全て省略可能で、指定したもののみ更新されます。
```csharp
Request.UpdateCashtray request = new Request.UpdateCashtray(
    "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx" // CashtrayのID
) {
    Amount = 7001.0,  // 金額
    Description = "たい焼き(小倉)",  // 取引履歴に表示する説明文
    ExpiresIn = 6822,  // 失効時間(秒)
};
Response.Cashtray response = await request.Send(client!);
```

---
`cashtray_id`  
```json
{
  "type": "string",
  "format": "uuid"
}
```
更新対象のCashtrayのIDです。

---
`amount`  
```json
{ "type": "number" }
```
マネー額です(任意項目)。
正の値を与えるとチャージになり、負の値を与えると支払いとなります。

---
`description`  
```json
{
  "type": "string",
  "maxLength": 200
}
```
Cashtrayを読み取ったときに作られる取引の説明文です(最大200文字、任意項目)。
アプリや管理画面などの取引履歴に表示されます。

---
`expires_in`  
```json
{
  "type": "integer",
  "minimum": 1
}
```
Cashtrayが失効するまでの時間を秒で指定します(任意項目、デフォルト値は1800秒(30分))。

---
成功したときは[Cashtray](#cashtray)オブジェクトを返します
### Customer
<a name="get-account"></a>
#### ウォレット情報を表示する
ウォレットを取得します。
```csharp
Request.GetAccount request = new Request.GetAccount(
    "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx" // ウォレットID
);
Response.AccountDetail response = await request.Send(client!);
```

---
`account_id`  
```json
{
  "type": "string",
  "format": "uuid"
}
```
ウォレットIDです。

フィルターとして使われ、指定したウォレットIDのウォレットを取得します。

---
成功したときは[AccountDetail](#account-detail)オブジェクトを返します
<a name="update-account"></a>
#### ウォレット情報を更新する
ウォレットの状態を更新します。現在はウォレットの凍結/凍結解除の切り替えにのみ対応しています。
```csharp
Request.UpdateAccount request = new Request.UpdateAccount(
    "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx" // ウォレットID
) {
    IsSuspended = false,  // ウォレットが凍結されているかどうか
};
Response.AccountDetail response = await request.Send(client!);
```

---
`account_id`  
```json
{
  "type": "string",
  "format": "uuid"
}
```
ウォレットIDです。

指定したウォレットIDのウォレットの状態を更新します。

---
`is_suspended`  
```json
{ "type": "boolean" }
```
ウォレットの凍結状態です。真にするとウォレットが凍結され、そのウォレットでは新規取引ができなくなります。偽にすると凍結解除されます。

---
成功したときは[AccountDetail](#account-detail)オブジェクトを返します
<a name="list-account-balances"></a>
#### エンドユーザーの残高内訳を表示する
エンドユーザーのウォレット毎の残高を有効期限別のリストとして取得します。
```csharp
Request.ListAccountBalances request = new Request.ListAccountBalances(
    "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx" // ウォレットID
) {
    Page = 2373,  // ページ番号
    PerPage = 451,  // 1ページ分の取引数
    ExpiresAtFrom = "2023-01-18T09:59:31.000000+09:00",  // 有効期限の期間によるフィルター(開始時点)
    ExpiresAtTo = "2016-09-25T04:41:30.000000+09:00",  // 有効期限の期間によるフィルター(終了時点)
    Direction = "asc",  // 有効期限によるソート順序
};
Response.PaginatedAccountBalance response = await request.Send(client!);
```

---
`account_id`  
```json
{
  "type": "string",
  "format": "uuid"
}
```
ウォレットIDです。

フィルターとして使われ、指定したウォレットIDのウォレット残高を取得します。

---
`page`  
```json
{
  "type": "integer",
  "minimum": 1
}
```
取得したいページ番号です。デフォルト値は1です。

---
`per_page`  
```json
{
  "type": "integer",
  "minimum": 1
}
```
1ページ分のウォレット残高数です。デフォルト値は30です。

---
`expires_at_from`  
```json
{
  "type": "string",
  "format": "date-time"
}
```
有効期限の期間によるフィルターの開始時点のタイムスタンプです。デフォルトでは未指定です。

---
`expires_at_to`  
```json
{
  "type": "string",
  "format": "date-time"
}
```
有効期限の期間によるフィルターの終了時点のタイムスタンプです。デフォルトでは未指定です。

---
`direction`  
```json
{
  "type": "string",
  "enum": { "asc": "desc" }
}
```
有効期限によるソートの順序を指定します。デフォルト値はasc (昇順)です。

---
成功したときは[PaginatedAccountBalance](#paginated-account-balance)オブジェクトを返します
<a name="list-account-expired-balances"></a>
#### エンドユーザーの失効済みの残高内訳を表示する
エンドユーザーのウォレット毎の失効済みの残高を有効期限別のリストとして取得します。
```csharp
Request.ListAccountExpiredBalances request = new Request.ListAccountExpiredBalances(
    "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx" // ウォレットID
) {
    Page = 1228,  // ページ番号
    PerPage = 7032,  // 1ページ分の取引数
    ExpiresAtFrom = "2023-02-16T15:27:38.000000+09:00",  // 有効期限の期間によるフィルター(開始時点)
    ExpiresAtTo = "2025-04-18T14:51:29.000000+09:00",  // 有効期限の期間によるフィルター(終了時点)
    Direction = "asc",  // 有効期限によるソート順序
};
Response.PaginatedAccountBalance response = await request.Send(client!);
```

---
`account_id`  
```json
{
  "type": "string",
  "format": "uuid"
}
```
ウォレットIDです。

フィルターとして使われ、指定したウォレットIDのウォレット残高を取得します。

---
`page`  
```json
{
  "type": "integer",
  "minimum": 1
}
```
取得したいページ番号です。デフォルト値は1です。

---
`per_page`  
```json
{
  "type": "integer",
  "minimum": 1
}
```
1ページ分のウォレット残高数です。デフォルト値は30です。

---
`expires_at_from`  
```json
{
  "type": "string",
  "format": "date-time"
}
```
有効期限の期間によるフィルターの開始時点のタイムスタンプです。デフォルトでは未指定です。

---
`expires_at_to`  
```json
{
  "type": "string",
  "format": "date-time"
}
```
有効期限の期間によるフィルターの終了時点のタイムスタンプです。デフォルトでは未指定です。

---
`direction`  
```json
{
  "type": "string",
  "enum": { "asc": "desc" }
}
```
有効期限によるソートの順序を指定します。デフォルト値はdesc (降順)です。

---
成功したときは[PaginatedAccountBalance](#paginated-account-balance)オブジェクトを返します
<a name="get-customer-accounts"></a>
#### エンドユーザーのウォレット一覧を表示する
マネーを指定してエンドユーザーのウォレット一覧を取得します。
```csharp
Request.GetCustomerAccounts request = new Request.GetCustomerAccounts(
    "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx" // マネーID
) {
    Page = 4539,  // ページ番号
    PerPage = 2772,  // 1ページ分のウォレット数
    CreatedAtFrom = "2023-12-25T19:33:57.000000+09:00",  // ウォレット作成日によるフィルター(開始時点)
    CreatedAtTo = "2020-11-16T21:21:47.000000+09:00",  // ウォレット作成日によるフィルター(終了時点)
    IsSuspended = true,  // ウォレットが凍結状態かどうかでフィルターする
    ExternalId = "vjsqVkcSInvOjFPIL9qlVM",  // 外部ID
    Tel = "07018335-9579",  // エンドユーザーの電話番号
    Email = "805Swtsg2N@kJBD.com",  // エンドユーザーのメールアドレス
};
Response.PaginatedAccountWithUsers response = await request.Send(client!);
```

---
`private_money_id`  
```json
{
  "type": "string",
  "format": "uuid"
}
```
マネーIDです。

一覧するウォレットのマネーを指定します。このパラメータは必須です。

---
`page`  
```json
{
  "type": "integer",
  "minimum": 1
}
```
取得したいページ番号です。デフォルト値は1です。

---
`per_page`  
```json
{
  "type": "integer",
  "minimum": 1
}
```
1ページ分のウォレット数です。デフォルト値は30です。

---
`created_at_from`  
```json
{
  "type": "string",
  "format": "date-time"
}
```
ウォレット作成日によるフィルターの開始時点のタイムスタンプです。デフォルトでは未指定です。

---
`created_at_to`  
```json
{
  "type": "string",
  "format": "date-time"
}
```
ウォレット作成日によるフィルターの終了時点のタイムスタンプです。デフォルトでは未指定です。

---
`is_suspended`  
```json
{ "type": "boolean" }
```
このパラメータが指定されている場合、ウォレットの凍結状態で結果がフィルターされます。デフォルトでは未指定です。

---
`external_id`  
```json
{
  "type": "string",
  "maxLength": 50
}
```
外部IDでのフィルタリングです。デフォルトでは未指定です。

---
`tel`  
```json
{
  "type": "string",
  "pattern": "^0[0-9]{1,3}-?[0-9]{2,4}-?[0-9]{3,4}$"
}
```
エンドユーザーの電話番号でのフィルタリングです。デフォルトでは未指定です。

---
`email`  
```json
{
  "type": "string",
  "format": "email"
}
```
エンドユーザーのメールアドレスでのフィルタリングです。デフォルトでは未指定です。

---
成功したときは[PaginatedAccountWithUsers](#paginated-account-with-users)オブジェクトを返します
<a name="create-customer-account"></a>
#### 新規エンドユーザーウォレットを追加する
指定したマネーのウォレットを作成し、同時にそのウォレットを保有するユーザも作成します。
```csharp
Request.CreateCustomerAccount request = new Request.CreateCustomerAccount(
    "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx" // マネーID
) {
    UserName = "ポケペイ太郎",  // ユーザー名
    AccountName = "ポケペイ太郎のアカウント",  // アカウント名
    ExternalId = "WoqdLq3QmHRbZpwbP",  // 外部ID
};
Response.AccountWithUser response = await request.Send(client!);
```

---
`private_money_id`  
```json
{
  "type": "string",
  "format": "uuid"
}
```
マネーIDです。

これによって作成するウォレットのマネーを指定します。

---
`user_name`  
```json
{
  "type": "string",
  "maxLength": 256
}
```
ウォレットと共に作成するユーザ名です。省略した場合は空文字となります。

---
`account_name`  
```json
{
  "type": "string",
  "maxLength": 256
}
```
作成するウォレット名です。省略した場合は空文字となります。

---
`external_id`  
```json
{
  "type": "string",
  "maxLength": 50
}
```
PAPIクライアントシステムから利用するPokepayユーザーのIDです。デフォルトでは未指定です。

---
成功したときは[AccountWithUser](#account-with-user)オブジェクトを返します
<a name="get-shop-accounts"></a>
#### 店舗ユーザーのウォレット一覧を表示する
マネーを指定して店舗ユーザーのウォレット一覧を取得します。
```csharp
Request.GetShopAccounts request = new Request.GetShopAccounts(
    "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx" // マネーID
) {
    Page = 83,  // ページ番号
    PerPage = 5866,  // 1ページ分のウォレット数
    CreatedAtFrom = "2021-03-18T09:33:18.000000+09:00",  // ウォレット作成日によるフィルター(開始時点)
    CreatedAtTo = "2019-10-15T23:24:49.000000+09:00",  // ウォレット作成日によるフィルター(終了時点)
    IsSuspended = false,  // ウォレットが凍結状態かどうかでフィルターする
};
Response.PaginatedAccountWithUsers response = await request.Send(client!);
```

---
`private_money_id`  
```json
{
  "type": "string",
  "format": "uuid"
}
```
マネーIDです。

一覧するウォレットのマネーを指定します。このパラメータは必須です。

---
`page`  
```json
{
  "type": "integer",
  "minimum": 1
}
```
取得したいページ番号です。デフォルト値は1です。

---
`per_page`  
```json
{
  "type": "integer",
  "minimum": 1
}
```
1ページ分のウォレット数です。デフォルト値は30です。

---
`created_at_from`  
```json
{
  "type": "string",
  "format": "date-time"
}
```
ウォレット作成日によるフィルターの開始時点のタイムスタンプです。デフォルトでは未指定です。

---
`created_at_to`  
```json
{
  "type": "string",
  "format": "date-time"
}
```
ウォレット作成日によるフィルターの終了時点のタイムスタンプです。デフォルトでは未指定です。

---
`is_suspended`  
```json
{ "type": "boolean" }
```
このパラメータが指定されている場合、ウォレットの凍結状態で結果がフィルターされます。デフォルトでは未指定です。

---
成功したときは[PaginatedAccountWithUsers](#paginated-account-with-users)オブジェクトを返します
<a name="list-customer-transactions"></a>
#### 取引履歴を取得する
取引一覧を返します。
```csharp
Request.ListCustomerTransactions request = new Request.ListCustomerTransactions(
    "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx" // マネーID
) {
    SenderCustomerId = "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx",  // 送金エンドユーザーID
    ReceiverCustomerId = "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx",  // 受取エンドユーザーID
    Type = "B6hajGJrCJ",  // 取引種別、チャージ=topup、支払い=payment、個人間送金=transfer
    IsModified = true,  // キャンセル済みかどうか
    From = "2019-02-13T12:10:46.000000+09:00",  // 開始日時
    To = "2017-02-20T06:05:40.000000+09:00",  // 終了日時
    Page = 1,  // ページ番号
    PerPage = 50,  // 1ページ分の取引数
};
Response.PaginatedTransaction response = await request.Send(client!);
```

---
`private_money_id`  
```json
{
  "type": "string",
  "format": "uuid"
}
```
マネーIDです。
フィルターとして使われ、指定したマネーでの取引のみ一覧に表示されます。

---
`sender_customer_id`  
```json
{
  "type": "string",
  "format": "uuid"
}
```
送金ユーザーIDです。

フィルターとして使われ、指定された送金ユーザーでの取引のみ一覧に表示されます。

---
`receiver_customer_id`  
```json
{
  "type": "string",
  "format": "uuid"
}
```
受取ユーザーIDです。

フィルターとして使われ、指定された受取ユーザーでの取引のみ一覧に表示されます。

---
`type`  
```json
{ "type": "string" }
```
取引の種類でフィルターします。

以下の種類を指定できます。

1. topup
   店舗からエンドユーザーへの送金取引(チャージ)
2. payment
   エンドユーザーから店舗への送金取引(支払い)
3. exchange
   他マネーへの流出(outflow)/他マネーからの流入(inflow)
4. transfer
   個人間送金

---
`is_modified`  
```json
{ "type": "boolean" }
```
キャンセル済みかどうかを判定するフラグです。

これにtrueを指定するとキャンセルされた取引のみ一覧に表示されます。
falseを指定するとキャンセルされていない取引のみ一覧に表示されます
何も指定しなければキャンセルの有無にかかわらず一覧に表示されます。

---
`from`  
```json
{
  "type": "string",
  "format": "date-time"
}
```
抽出期間の開始日時です。

フィルターとして使われ、開始日時以降に発生した取引のみ一覧に表示されます。

---
`to`  
```json
{
  "type": "string",
  "format": "date-time"
}
```
抽出期間の終了日時です。

フィルターとして使われ、終了日時以前に発生した取引のみ一覧に表示されます。

---
`page`  
```json
{
  "type": "integer",
  "minimum": 1
}
```
取得したいページ番号です。

---
`per_page`  
```json
{
  "type": "integer",
  "minimum": 1
}
```
1ページ分の取引数です。

---
成功したときは[PaginatedTransaction](#paginated-transaction)オブジェクトを返します
### Organization
### Shop
<a name="list-shops"></a>
#### 店舗一覧を取得する
```csharp
Request.ListShops request = new Request.ListShops() {
    OrganizationCode = "pocketchange",  // 組織コード
    PrivateMoneyId = "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx",  // マネーID
    Name = "oxスーパー三田店",  // 店舗名
    PostalCode = "800-9576",  // 店舗の郵便番号
    Address = "東京都港区芝...",  // 店舗の住所
    Tel = "089682-5023",  // 店舗の電話番号
    Email = "jlaztijN3v@ebjT.com",  // 店舗のメールアドレス
    ExternalId = "69RjYRPCqvnZ1YzdrhGH7XKNoGDpqqjY",  // 店舗の外部ID
    Page = 1,  // ページ番号
    PerPage = 50,  // 1ページ分の取引数
};
Response.PaginatedShops response = await request.Send(client!);
```

---
`organization_code`  
```json
{
  "type": "string",
  "maxLength": 32,
  "pattern": "^[a-zA-Z0-9-]*$"
}
```
このパラメータを渡すとその組織の店舗のみが返され、省略すると加盟店も含む店舗が返されます。


---
`private_money_id`  
```json
{
  "type": "string",
  "format": "uuid"
}
```
このパラメータを渡すとそのマネーのウォレットを持つ店舗のみが返されます。


---
`name`  
```json
{
  "type": "string",
  "minLength": 1,
  "maxLength": 256
}
```
このパラメータを渡すとその名前の店舗のみが返されます。


---
`postal_code`  
```json
{
  "type": "string",
  "pattern": "^[0-9]{3}-?[0-9]{4}$"
}
```
このパラメータを渡すとその郵便番号が登録された店舗のみが返されます。


---
`address`  
```json
{
  "type": "string",
  "maxLength": 256
}
```
このパラメータを渡すとその住所が登録された店舗のみが返されます。


---
`tel`  
```json
{
  "type": "string",
  "pattern": "^0[0-9]{1,3}-?[0-9]{2,4}-?[0-9]{3,4}$"
}
```
このパラメータを渡すとその電話番号が登録された店舗のみが返されます。


---
`email`  
```json
{
  "type": "string",
  "format": "email",
  "maxLength": 256
}
```
このパラメータを渡すとそのメールアドレスが登録された店舗のみが返されます。


---
`external_id`  
```json
{
  "type": "string",
  "maxLength": 36
}
```
このパラメータを渡すとその外部IDが登録された店舗のみが返されます。


---
`page`  
```json
{
  "type": "integer",
  "minimum": 1
}
```
取得したいページ番号です。

---
`per_page`  
```json
{
  "type": "integer",
  "minimum": 1
}
```
1ページ分の取引数です。

---
成功したときは[PaginatedShops](#paginated-shops)オブジェクトを返します
<a name="create-shop"></a>
#### 新規店舗を追加する(廃止予定)
新規店舗を追加します。このAPIは廃止予定です。以降は `CreateShopV2` を使用してください。
```csharp
Request.CreateShop request = new Request.CreateShop(
    "oxスーパー三田店" // 店舗名
) {
    ShopPostalCode = "5142087",  // 店舗の郵便番号
    ShopAddress = "東京都港区芝...",  // 店舗の住所
    ShopTel = "0074-18354932",  // 店舗の電話番号
    ShopEmail = "YdhYyR9ZtW@hMAK.com",  // 店舗のメールアドレス
    ShopExternalId = "ZHQ2Tjahc0hASAcEibjk",  // 店舗の外部ID
    OrganizationCode = "ox-supermarket",  // 組織コード
};
Response.User response = await request.Send(client!);
```
成功したときは[User](#user)オブジェクトを返します
<a name="create-shop-v2"></a>
#### 新規店舗を追加する
```csharp
Request.CreateShopV2 request = new Request.CreateShopV2(
    "oxスーパー三田店" // 店舗名
) {
    PostalCode = "5184159",  // 店舗の郵便番号
    Address = "東京都港区芝...",  // 店舗の住所
    Tel = "07-97912",  // 店舗の電話番号
    Email = "FrkXVihIdQ@Wu7J.com",  // 店舗のメールアドレス
    ExternalId = "4NYirXryPP6taqbm6hsnA9hELka",  // 店舗の外部ID
    OrganizationCode = "ox-supermarket",  // 組織コード
    PrivateMoneyIds = new string[]{"xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx"},  // 店舗で有効にするマネーIDの配列
    CanTopupPrivateMoneyIds = new string[]{"xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx", "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx", "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx"},  // 店舗でチャージ可能にするマネーIDの配列
};
Response.ShopWithAccounts response = await request.Send(client!);
```

---
`name`  
```json
{
  "type": "string",
  "minLength": 1,
  "maxLength": 256
}
```
店舗名です。

同一組織内に同名の店舗があった場合は`name_conflict`エラーが返ります。

---
`private_money_ids`  
```json
{
  "type": "array",
  "minItems": 1,
  "items": {
    "type": "string",
    "format": "uuid"
  }
}
```
店舗で有効にするマネーIDの配列を指定します。

店舗が所属する組織が発行または加盟しているマネーのみが指定できます。利用できないマネーが指定された場合は`unavailable_private_money`エラーが返ります。
このパラメータを省略したときは、店舗が所属する組織が発行または加盟している全てのマネーのウォレットができます。

---
`can_topup_private_money_ids`  
```json
{
  "type": "array",
  "minItems": 0,
  "items": {
    "type": "string",
    "format": "uuid"
  }
}
```
店舗でチャージ可能にするマネーIDの配列を指定します。

このパラメータは発行体のみが指定でき、自身が発行しているマネーのみを指定できます。加盟店が他発行体のマネーに加盟している場合でも、そのチャージ可否を変更することはできません。
省略したときは対象店舗のその発行体の全てのマネーのアカウントがチャージ不可となります。

---
成功したときは[ShopWithAccounts](#shop-with-accounts)オブジェクトを返します
<a name="get-shop"></a>
#### 店舗情報を表示する
店舗情報を表示します。

権限に関わらず自組織の店舗情報は表示可能です。それに加え、発行体は自組織の発行しているマネーの加盟店組織の店舗情報を表示できます。
```csharp
Request.GetShop request = new Request.GetShop(
    "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx" // 店舗ユーザーID
);
Response.ShopWithAccounts response = await request.Send(client!);
```
成功したときは[ShopWithAccounts](#shop-with-accounts)オブジェクトを返します
<a name="update-shop"></a>
#### 店舗情報を更新する
店舗情報を更新します。bodyパラメーターは全て省略可能で、指定したもののみ更新されます。
```csharp
Request.UpdateShop request = new Request.UpdateShop(
    "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx" // 店舗ユーザーID
) {
    Name = "oxスーパー三田店",  // 店舗名
    PostalCode = "376-2080",  // 店舗の郵便番号
    Address = "東京都港区芝...",  // 店舗の住所
    Tel = "041115489",  // 店舗の電話番号
    Email = "VIgVP7fIz1@xemn.com",  // 店舗のメールアドレス
    ExternalId = "x9P7H",  // 店舗の外部ID
    PrivateMoneyIds = new string[]{"xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx", "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx", "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx"},  // 店舗で有効にするマネーIDの配列
    CanTopupPrivateMoneyIds = new string[]{},  // 店舗でチャージ可能にするマネーIDの配列
};
Response.ShopWithAccounts response = await request.Send(client!);
```

---
`name`  
```json
{
  "type": "string",
  "minLength": 1,
  "maxLength": 256
}
```
店舗名です。

同一組織内に同名の店舗があった場合は`shop_name_conflict`エラーが返ります。

---
`postal_code`  
```json
{
  "type": "string",
  "pattern": "^[0-9]{3}-?[0-9]{4}$"
}
```
店舗住所の郵便番号(7桁の数字)です。ハイフンは無視されます。明示的に空の値を設定するにはNULLを指定します。

---
`tel`  
```json
{
  "type": "string",
  "pattern": "^0[0-9]{1,3}-?[0-9]{2,4}-?[0-9]{3,4}$"
}
```
店舗の電話番号です。ハイフンは無視されます。明示的に空の値を設定するにはNULLを指定します。

---
`email`  
```json
{
  "type": "string",
  "format": "email",
  "maxLength": 256
}
```
店舗の連絡先メールアドレスです。明示的に空の値を設定するにはNULLを指定します。

---
`external_id`  
```json
{
  "type": "string",
  "maxLength": 36
}
```
店舗の外部IDです(最大36文字)。明示的に空の値を設定するにはNULLを指定します。

---
`private_money_ids`  
```json
{
  "type": "array",
  "minItems": 0,
  "items": {
    "type": "string",
    "format": "uuid"
  }
}
```
店舗で有効にするマネーIDの配列を指定します。

店舗が所属する組織が発行または加盟しているマネーのみが指定できます。利用できないマネーが指定された場合は`unavailable_private_money`エラーが返ります。
店舗が既にウォレットを持っている場合に、ここでそのウォレットのマネーIDを指定しないで更新すると、そのマネーのウォレットは凍結(無効化)されます。

---
`can_topup_private_money_ids`  
```json
{
  "type": "array",
  "minItems": 0,
  "items": {
    "type": "string",
    "format": "uuid"
  }
}
```
店舗でチャージ可能にするマネーIDの配列を指定します。

このパラメータは発行体のみが指定でき、発行しているマネーのみを指定できます。加盟店が他発行体のマネーに加盟している場合でも、そのチャージ可否を変更することはできません。
省略したときは対象店舗のその発行体の全てのマネーのアカウントがチャージ不可となります。

---
成功したときは[ShopWithAccounts](#shop-with-accounts)オブジェクトを返します
### Account
<a name="list-user-accounts"></a>
#### エンドユーザー、店舗ユーザーのウォレット一覧を表示する
ユーザーIDを指定してそのユーザーのウォレット一覧を取得します。
```csharp
Request.ListUserAccounts request = new Request.ListUserAccounts(
    "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx" // ユーザーID
);
Response.PaginatedAccounts response = await request.Send(client!);
```

---
`user_id`  
```json
{
  "type": "string",
  "format": "uuid"
}
```
ユーザーIDです。

指定したユーザーIDのウォレット一覧を取得します。パートナーキーと紐づく組織が発行しているマネーのウォレットのみが表示されます。

---
成功したときは[PaginatedAccounts](#paginated-accounts)オブジェクトを返します
### Private Money
<a name="get-private-moneys"></a>
#### マネー一覧を取得する
マネーの一覧を取得します。
パートナーキーの管理者が発行体組織に属している場合、自組織が加盟または発行しているマネーの一覧を返します。また、`organization_code`として決済加盟店の組織コードを指定した場合、発行マネーのうち、その決済加盟店組織が加盟しているマネーの一覧を返します。
パートナーキーの管理者が決済加盟店組織に属している場合は、自組織が加盟しているマネーの一覧を返します。
```csharp
Request.GetPrivateMoneys request = new Request.GetPrivateMoneys() {
    OrganizationCode = "ox-supermarket",  // 組織コード
    Page = 1,  // ページ番号
    PerPage = 50,  // 1ページ分の取得数
};
Response.PaginatedPrivateMoneys response = await request.Send(client!);
```

---
`organization_code`  
```json
{
  "type": "string",
  "maxLength": 32,
  "pattern": "^[a-zA-Z0-9-]*$"
}
```
パートナーキーの管理者が発行体組織に属している場合、発行マネーのうち、この組織コードで指定した決済加盟店組織が加盟しているマネーの一覧を返します。決済加盟店組織の管理者は自組織以外を指定することはできません。

---
成功したときは[PaginatedPrivateMoneys](#paginated-private-moneys)オブジェクトを返します
<a name="get-private-money-organization-summaries"></a>
#### 決済加盟店の取引サマリを取得する
```csharp
Request.GetPrivateMoneyOrganizationSummaries request = new Request.GetPrivateMoneyOrganizationSummaries(
    "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx" // マネーID
) {
    From = "2016-05-21T23:00:33.000000+09:00",  // 開始日時(toと同時に指定する必要有)
    To = "2021-05-24T13:34:12.000000+09:00",  // 終了日時(fromと同時に指定する必要有)
    Page = 1,  // ページ番号
    PerPage = 50,  // 1ページ分の取引数
};
Response.PaginatedPrivateMoneyOrganizationSummaries response = await request.Send(client!);
```
`from`と`to`は同時に指定する必要があります。

成功したときは[PaginatedPrivateMoneyOrganizationSummaries](#paginated-private-money-organization-summaries)オブジェクトを返します
### Bulk
<a name="bulk-create-transaction"></a>
#### CSVファイル一括取引
CSVファイルから一括取引をします。
```csharp
Request.BulkCreateTransaction request = new Request.BulkCreateTransaction(
    "lwWZKuWWf4n5wNPq2rjN28", // 一括取引タスク名
    "QfQLnQ9Qr", // 取引する情報のCSV
    "2gs4rAyEVt2ws7WkJzpgGUX4mtxobZ9ZCpNJ" // リクエストID
) {
    Description = "ZG6LzTWIbd8ZNVrafdiivNn4NbNLXIdoiqtrelImUNmLeKEfXUc2dQExu22E4bXnTsrAuXzc",  // 一括取引の説明
};
Response.BulkTransaction response = await request.Send(client!);
```

---
`name`  
```json
{
  "type": "string",
  "maxLength": 32
}
```
一括取引タスクの管理用の名前です。

---
`description`  
```json
{
  "type": "string",
  "maxLength": 128
}
```
一括取引タスクの管理用の説明文です。

---
`content`  
```json
{ "type": "string" }
```
一括取引する情報を書いたCSVの文字列です。
1行目はヘッダ行で、2行目以降の各行にカンマ区切りの取引データを含みます。
カラムは以下の7つです。任意のカラムには空文字を指定します。

- `type`: 取引種別
  - 必須。'topup' または 'payment'
- `sender_id`: 送金ユーザーID
  - 必須。UUID
- `receiver_id`: 受取ユーザーID
  - 必須。UUID
- `private_money_id`: マネーID
  - 必須。UUID
- `money_amount`: マネー額
  - 任意。ただし `point_amount` といずれかが必須。0以上の数字
- `point_amount`: ポイント額
  - 任意。ただし `money_amount` といずれかが必須。0以上の数字
- `description`: 取引の説明文
  - 任意。200文字以内。取引履歴に表示される文章
- `bear_account_id`: ポイント負担ウォレットID
  - `point_amount` があるときは必須。UUID
- `point_expires_at`: ポイントの有効期限
  - 任意。指定がないときはマネーに設定された有効期限を適用

---
`request_id`  
```json
{
  "type": "string",
  "minLength": 36,
  "maxLength": 36
}
```
重複したリクエストを判断するためのユニークID。ランダムな36字の文字列を生成して渡してください。

---
成功したときは[BulkTransaction](#bulk-transaction)オブジェクトを返します
## Responses


<a name="account-with-user"></a>
## AccountWithUser
* `Id (string)`: 
* `Name (string)`: 
* `IsSuspended (bool)`: 
* `PrivateMoney (PrivateMoney)`: 
* `User (User)`: 
* `ExternalId (string)`: 

`private_money`は [PrivateMoney](#private-money) オブジェクトを返します。

`user`は [User](#user) オブジェクトを返します。

<a name="account-detail"></a>
## AccountDetail
* `Id (string)`: 
* `Name (string)`: 
* `IsSuspended (bool)`: 
* `Balance (double)`: 
* `MoneyBalance (double)`: 
* `PointBalance (double)`: 
* `PrivateMoney (PrivateMoney)`: 

`private_money`は [PrivateMoney](#private-money) オブジェクトを返します。

<a name="bill"></a>
## Bill
* `Id (string)`: 支払いQRコードのID
* `Amount (double)`: 支払い額
* `MaxAmount (double)`: 支払い額を範囲指定した場合の上限
* `MinAmount (double)`: 支払い額を範囲指定した場合の下限
* `Description (string)`: 支払いQRコードの説明文(アプリ上で取引の説明文として表示される)
* `Account (AccountWithUser)`: 支払いQRコード発行ウォレット
* `IsDisabled (bool)`: 無効化されているかどうか
* `Token (string)`: 支払いQRコードを解析したときに出てくるURL

`account`は [AccountWithUser](#account-with-user) オブジェクトを返します。

<a name="cashtray"></a>
## Cashtray
* `Id (string)`: Cashtray自体のIDです。
* `Amount (double)`: 取引金額
* `Description (string)`: Cashtrayの説明文
* `Account (AccountWithUser)`: 発行店舗のウォレット
* `ExpiresAt (string)`: Cashtrayの失効日時
* `CanceledAt (string)`: Cashtrayの無効化日時。NULLの場合は無効化されていません
* `Token (string)`: CashtrayのQRコードを解析したときに出てくるURL

`account`は [AccountWithUser](#account-with-user) オブジェクトを返します。

<a name="cashtray-with-result"></a>
## CashtrayWithResult
* `Id (string)`: CashtrayのID
* `Amount (double)`: 取引金額
* `Description (string)`: Cashtrayの説明文(アプリ上で取引の説明文として表示される)
* `Account (AccountWithUser)`: 発行店舗のウォレット
* `ExpiresAt (string)`: Cashtrayの失効日時
* `CanceledAt (string)`: Cashtrayの無効化日時。NULLの場合は無効化されていません
* `Token (string)`: CashtrayのQRコードを解析したときに出てくるURL
* `Attempt (CashtrayAttempt)`: Cashtray読み取り結果
* `Transaction (Transaction)`: 取引結果

`account`は [AccountWithUser](#account-with-user) オブジェクトを返します。

`attempt`は [CashtrayAttempt](#cashtray-attempt) オブジェクトを返します。

`transaction`は [Transaction](#transaction) オブジェクトを返します。

<a name="user"></a>
## User
* `Id (string)`: ユーザー (または店舗) ID
* `Name (string)`: ユーザー (または店舗) 名
* `IsMerchant (bool)`: 店舗ユーザーかどうか

<a name="transaction"></a>
## Transaction
* `Id (string)`: 取引ID
* `Type (string)`: 取引種別 (チャージ=topup, 支払い=payment)
* `IsModified (bool)`: 返金された取引かどうか
* `Sender (User)`: 送金者情報
* `SenderAccount (Account)`: 送金ウォレット情報
* `Receiver (User)`: 受取者情報
* `ReceiverAccount (Account)`: 受取ウォレット情報
* `Amount (double)`: 決済総額 (マネー額 + ポイント額)
* `MoneyAmount (double)`: 決済マネー額
* `PointAmount (double)`: 決済ポイント額
* `DoneAt (string)`: 取引日時
* `Description (string)`: 取引説明文

`receiver`と`sender`は [User](#user) オブジェクトを返します。

`receiver_account`と`sender_account`は [Account](#account) オブジェクトを返します。

<a name="shop-with-accounts"></a>
## ShopWithAccounts
* `Id (string)`: 店舗ID
* `Name (string)`: 店舗名
* `OrganizationCode (string)`: 組織コード
* `PostalCode (string)`: 店舗の郵便番号
* `Address (string)`: 店舗の住所
* `Tel (string)`: 店舗の電話番号
* `Email (string)`: 店舗のメールアドレス
* `ExternalId (string)`: 店舗の外部ID
* `Accounts (ShopAccount[])`: 

`accounts`は [ShopAccount](#shop-account) オブジェクトの配列を返します。

<a name="bulk-transaction"></a>
## BulkTransaction
* `Id (string)`: 
* `RequestId (string)`: リクエストID
* `Name (string)`: バルク取引管理用の名前
* `Description (string)`: バルク取引管理用の説明文
* `Status (string)`: バルク取引の状態
* `Error (string)`: バルク取引のエラー種別
* `ErrorLineno (int)`: バルク取引のエラーが発生した行番号
* `SubmittedAt (string)`: バルク取引が登録された日時
* `UpdatedAt (string)`: バルク取引が更新された日時

<a name="paginated-private-money-organization-summaries"></a>
## PaginatedPrivateMoneyOrganizationSummaries
* `Rows (PrivateMoneyOrganizationSummary[])`: 
* `Count (int)`: 
* `Pagination (Pagination)`: 

`rows`は [PrivateMoneyOrganizationSummary](#private-money-organization-summary) オブジェクトの配列を返します。

`pagination`は [Pagination](#pagination) オブジェクトを返します。

<a name="paginated-transaction"></a>
## PaginatedTransaction
* `Rows (Transaction[])`: 
* `Count (int)`: 
* `Pagination (Pagination)`: 

`rows`は [Transaction](#transaction) オブジェクトの配列を返します。

`pagination`は [Pagination](#pagination) オブジェクトを返します。

<a name="paginated-transfers"></a>
## PaginatedTransfers
* `Rows (Transfer[])`: 
* `Count (int)`: 
* `Pagination (Pagination)`: 

`rows`は [Transfer](#transfer) オブジェクトの配列を返します。

`pagination`は [Pagination](#pagination) オブジェクトを返します。

<a name="paginated-accounts"></a>
## PaginatedAccounts
* `Rows (Account[])`: 
* `Count (int)`: 
* `Pagination (Pagination)`: 

`rows`は [Account](#account) オブジェクトの配列を返します。

`pagination`は [Pagination](#pagination) オブジェクトを返します。

<a name="paginated-account-with-users"></a>
## PaginatedAccountWithUsers
* `Rows (AccountWithUser[])`: 
* `Count (int)`: 
* `Pagination (Pagination)`: 

`rows`は [AccountWithUser](#account-with-user) オブジェクトの配列を返します。

`pagination`は [Pagination](#pagination) オブジェクトを返します。

<a name="paginated-account-balance"></a>
## PaginatedAccountBalance
* `Rows (AccountBalance[])`: 
* `Count (int)`: 
* `Pagination (Pagination)`: 

`rows`は [AccountBalance](#account-balance) オブジェクトの配列を返します。

`pagination`は [Pagination](#pagination) オブジェクトを返します。

<a name="paginated-shops"></a>
## PaginatedShops
* `Rows (ShopWithMetadata[])`: 
* `Count (int)`: 
* `Pagination (Pagination)`: 

`rows`は [ShopWithMetadata](#shop-with-metadata) オブジェクトの配列を返します。

`pagination`は [Pagination](#pagination) オブジェクトを返します。

<a name="paginated-bills"></a>
## PaginatedBills
* `Rows (Bill[])`: 
* `Count (int)`: 
* `Pagination (Pagination)`: 

`rows`は [Bill](#bill) オブジェクトの配列を返します。

`pagination`は [Pagination](#pagination) オブジェクトを返します。

<a name="paginated-private-moneys"></a>
## PaginatedPrivateMoneys
* `Rows (PrivateMoney[])`: 
* `Count (int)`: 
* `Pagination (Pagination)`: 

`rows`は [PrivateMoney](#private-money) オブジェクトの配列を返します。

`pagination`は [Pagination](#pagination) オブジェクトを返します。

<a name="private-money"></a>
## PrivateMoney
* `Id (string)`: マネーID
* `Name (string)`: マネー名
* `Unit (string)`: マネー単位 (例: 円)
* `IsExclusive (bool)`: 会員制のマネーかどうか
* `Description (string)`: マネー説明文
* `OnelineMessage (string)`: マネーの要約
* `Organization (Organization)`: マネーを発行した組織
* `MaxBalance (double)`: ウォレットの上限金額
* `TransferLimit (double)`: マネーの取引上限額
* `Type (string)`: マネー種別 (自家型=own, 第三者型=third-party)
* `ExpirationType (string)`: 有効期限種別 (チャージ日起算=static, 最終利用日起算=last-update, 最終チャージ日起算=last-topup-update)
* `EnableTopupByMember (bool)`: 加盟店によるチャージが有効かどうか

`organization`は [Organization](#organization) オブジェクトを返します。

<a name="cashtray-attempt"></a>
## CashtrayAttempt
* `Account (AccountWithUser)`: エンドユーザーのウォレット
* `StatusCode (double)`: ステータスコード
* `ErrorType (string)`: エラー型
* `ErrorMessage (string)`: エラーメッセージ
* `CreatedAt (string)`: Cashtray読み取り記録の作成日時

`account`は [AccountWithUser](#account-with-user) オブジェクトを返します。

<a name="account"></a>
## Account
* `Id (string)`: ウォレットID
* `Name (string)`: ウォレット名
* `IsSuspended (bool)`: ウォレットが凍結されているかどうか
* `PrivateMoney (PrivateMoney)`: 設定マネー情報

`private_money`は [PrivateMoney](#private-money) オブジェクトを返します。

<a name="shop-account"></a>
## ShopAccount
* `Id (string)`: ウォレットID
* `Name (string)`: ウォレット名
* `IsSuspended (bool)`: ウォレットが凍結されているかどうか
* `CanTransferTopup (bool)`: チャージ可能かどうか
* `PrivateMoney (PrivateMoney)`: 設定マネー情報

`private_money`は [PrivateMoney](#private-money) オブジェクトを返します。

<a name="private-money-organization-summary"></a>
## PrivateMoneyOrganizationSummary
* `OrganizationCode (string)`: 
* `Topup (OrganizationSummary)`: 
* `Payment (OrganizationSummary)`: 

`payment`と`topup`は [OrganizationSummary](#organization-summary) オブジェクトを返します。

<a name="pagination"></a>
## Pagination
* `Current (int)`: 
* `PerPage (int)`: 
* `MaxPage (int)`: 
* `HasPrev (bool)`: 
* `HasNext (bool)`: 

<a name="transfer"></a>
## Transfer
* `Id (string)`: 
* `SenderAccount (AccountWithoutPrivateMoneyDetail)`: 
* `ReceiverAccount (AccountWithoutPrivateMoneyDetail)`: 
* `Amount (double)`: 
* `MoneyAmount (double)`: 
* `PointAmount (double)`: 
* `DoneAt (string)`: 
* `Type (string)`: 
* `Description (string)`: 
* `TransactionId (string)`: 

`receiver_account`と`sender_account`は [AccountWithoutPrivateMoneyDetail](#account-without-private-money-detail) オブジェクトを返します。

<a name="account-balance"></a>
## AccountBalance
* `ExpiresAt (string)`: 
* `MoneyAmount (double)`: 
* `PointAmount (double)`: 

<a name="shop-with-metadata"></a>
## ShopWithMetadata
* `Id (string)`: 店舗ID
* `Name (string)`: 店舗名
* `OrganizationCode (string)`: 組織コード
* `PostalCode (string)`: 店舗の郵便番号
* `Address (string)`: 店舗の住所
* `Tel (string)`: 店舗の電話番号
* `Email (string)`: 店舗のメールアドレス
* `ExternalId (string)`: 店舗の外部ID

<a name="organization"></a>
## Organization
* `Code (string)`: 組織コード
* `Name (string)`: 組織名

<a name="organization-summary"></a>
## OrganizationSummary
* `Count (int)`: 
* `MoneyAmount (double)`: 
* `MoneyCount (int)`: 
* `PointAmount (double)`: 
* `PointCount (int)`: 

<a name="account-without-private-money-detail"></a>
## AccountWithoutPrivateMoneyDetail
* `Id (string)`: 
* `Name (string)`: 
* `IsSuspended (bool)`: 
* `PrivateMoneyId (string)`: 
* `User (User)`: 

`user`は [User](#user) オブジェクトを返します。
