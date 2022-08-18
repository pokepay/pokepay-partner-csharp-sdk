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
* e.Data["StatusCode"] にHttpステータスコード
* e.Data["Type"] にエラータイプ
* e.Data["Message"] に詳細理由

がそれぞれ設定されています。

```csharp
try {
    Request.SendEcho request = new Request.SendEcho("hello");
    Response.Echo response = await request.Send(client);
} catch (HttpRequestException e) {
    e.Message // 内容
    e.Data["StatusCode"] // Httpステータスコード
    e.Data["Type"] // エラータイプ
    e.Data["Message"] // 詳細内容
}
```
<a name="api-operations"></a>
## API Operations

- [GetCpmToken](#get-cpm-token): CPMトークンの状態取得
- [ListTransactions](#list-transactions): 取引履歴を取得する
- [CreateTransaction](#create-transaction): チャージする(廃止予定)
- [ListTransactionsV2](#list-transactions-v2): 取引履歴を取得する
- [CreateTopupTransaction](#create-topup-transaction): チャージする
- [CreatePaymentTransaction](#create-payment-transaction): 支払いする
- [CreateCpmTransaction](#create-cpm-transaction): CPMトークンによる取引作成
- [CreateTransferTransaction](#create-transfer-transaction): 個人間送金
- [CreateExchangeTransaction](#create-exchange-transaction): 
- [GetTransaction](#get-transaction): 取引情報を取得する
- [RefundTransaction](#refund-transaction): 取引をキャンセルする
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
- [DeleteAccount](#delete-account): ウォレットを退会する
- [ListAccountBalances](#list-account-balances): エンドユーザーの残高内訳を表示する
- [ListAccountExpiredBalances](#list-account-expired-balances): エンドユーザーの失効済みの残高内訳を表示する
- [UpdateCustomerAccount](#update-customer-account): ウォレット情報を更新する
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
- [CreateUserAccount](#create-user-account): エンドユーザーのウォレットを作成する
- [GetPrivateMoneys](#get-private-moneys): マネー一覧を取得する
- [GetPrivateMoneyOrganizationSummaries](#get-private-money-organization-summaries): 決済加盟店の取引サマリを取得する
- [GetPrivateMoneySummary](#get-private-money-summary): 取引サマリを取得する
- [BulkCreateTransaction](#bulk-create-transaction): CSVファイル一括取引
- [CreateExternalTransaction](#create-external-transaction): ポケペイ外部取引を作成する
- [RefundExternalTransaction](#refund-external-transaction): ポケペイ外部取引をキャンセルする
- [CreateCampaign](#create-campaign): ポイント付与キャンペーンを作る
- [ListCampaigns](#list-campaigns): キャンペーン一覧を取得する
- [GetCampaign](#get-campaign): キャンペーンを取得する
- [UpdateCampaign](#update-campaign): ポイント付与キャンペーンを更新する
### Transaction
<a name="get-cpm-token"></a>
#### CPMトークンの状態取得
CPMトークンの現在の状態を取得します。CPMトークンの有効期限やCPM取引の状態を返します。
```csharp
Request.GetCpmToken request = new Request.GetCpmToken(
    "fneXYRV1FBu9VqwmK2QWEk" // CPMトークン
);
Response.CpmToken response = await request.Send(client);
```

---
`cpm_token`  
```json
{
  "type": "string",
  "minLength": 22,
  "maxLength": 22
}
```
CPM取引時にエンドユーザーが店舗に提示するバーコードを解析して得られる22桁の文字列です。

---
成功したときは[CpmToken](#cpm-token)オブジェクトを返します
<a name="list-transactions"></a>
#### 取引履歴を取得する
取引一覧を返します。
```csharp
Request.ListTransactions request = new Request.ListTransactions() {
    From = "2017-04-13T00:30:31.000000+09:00",  // 開始日時
    To = "2019-02-02T05:22:00.000000+09:00",  // 終了日時
    Page = 1,  // ページ番号
    PerPage = 50,  // 1ページ分の取引数
    ShopId = "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx",  // 店舗ID
    CustomerId = "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx",  // エンドユーザーID
    CustomerName = "太郎",  // エンドユーザー名
    TerminalId = "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx",  // 端末ID
    TransactionId = "3Nf",  // 取引ID
    OrganizationCode = "pocketchange",  // 組織コード
    PrivateMoneyId = "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx",  // マネーID
    IsModified = false,  // キャンセルフラグ
    Types = new string[]{"topup", "payment"},  // 取引種別 (複数指定可)、チャージ=topup、支払い=payment
    Description = "店頭QRコードによる支払い",  // 取引説明文
};
Response.PaginatedTransaction response = await request.Send(client);
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
{ "type": "string" }
```
取引IDです。

フィルターとして使われ、指定された取引IDに部分一致(前方一致)する取引のみが一覧に表示されます。

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
      "exchange_outflow": "exchange_inflow",
      "cashback": "expire"
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

5. cashback
   退会時返金取引

6. expire
   退会時失効取引

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
    MoneyAmount = 5552,
    PointAmount = 436,
    PointExpiresAt = "2015-10-09T10:16:09.000000+09:00",  // ポイント有効期限
    Description = "AeRoMBnYRrC4cXtKQ0a4OPrt",
};
Response.TransactionDetail response = await request.Send(client);
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
成功したときは[TransactionDetail](#transaction-detail)オブジェクトを返します
<a name="list-transactions-v2"></a>
#### 取引履歴を取得する
取引一覧を返します。
```csharp
Request.ListTransactionsV2 request = new Request.ListTransactionsV2(
    "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx" // マネーID
) {
    OrganizationCode = "pocketchange",  // 組織コード
    ShopId = "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx",  // 店舗ID
    TerminalId = "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx",  // 端末ID
    CustomerId = "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx",  // エンドユーザーID
    CustomerName = "太郎",  // エンドユーザー名
    Description = "店頭QRコードによる支払い",  // 取引説明文
    TransactionId = "tro",  // 取引ID
    IsModified = false,  // キャンセルフラグ
    Types = new string[]{"topup", "payment"},  // 取引種別 (複数指定可)、チャージ=topup、支払い=payment
    From = "2019-10-28T05:23:30.000000+09:00",  // 開始日時
    To = "2019-04-04T18:54:33.000000+09:00",  // 終了日時
    NextPageCursorId = "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx",  // 次のページへ遷移する際に起点となるtransactionのuuid
    PrevPageCursorId = "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx",  // 前のページへ遷移する際に起点となるtransactionのuuid
    PerPage = 50,  // 1ページ分の取引数
};
Response.PaginatedTransactionV2 response = await request.Send(client);
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

指定したマネーでの取引が一覧に表示されます。

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
`transaction_id`  
```json
{ "type": "string" }
```
取引IDです。

フィルターとして使われ、指定された取引IDに部分一致(前方一致)する取引のみが一覧に表示されます。

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
    "enum": [ "topup", "payment", "exchange_outflow", "exchange_inflow", "cashback" ]
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

5. cashback
   退会時返金取引

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
`next_page_cursor_id`  
```json
{
  "type": "string",
  "format": "uuid"
}
```
次のページへ遷移する際に起点となるtransactionのuuid(前のページの末尾の要素のuuid)です。

prev_page_cursor_idのtransaction自体は次のページには含まれない。

---
`prev_page_cursor_id`  
```json
{
  "type": "string",
  "format": "uuid"
}
```
前のページへ遷移する際に起点となるtransactionのuuid(次のページの先頭の要素のuuid)です。

next_page_cursor_idのtransaction自体は前のページには含まれない。

---
`per_page`  
```json
{
  "type": "integer",
  "minimum": 1,
  "maximum": 1000
}
```
1ページ分の取引数です。

デフォルト値は50です。

---
成功したときは[PaginatedTransactionV2](#paginated-transaction-v2)オブジェクトを返します
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
    MoneyAmount = 186,  // マネー額
    PointAmount = 5581,  // ポイント額
    PointExpiresAt = "2021-03-03T07:02:32.000000+09:00",  // ポイント有効期限
    Description = "初夏のチャージキャンペーン",  // 取引履歴に表示する説明文
    Metadata = "{\"key\":\"value\"}",  // 取引メタデータ
    RequestId = "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx",  // リクエストID
};
Response.TransactionDetail response = await request.Send(client);
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
  "type": "integer",
  "minimum": 0
}
```
マネー額です。

送金するマネー額を指定します。
デフォルト値は0で、money_amountとpoint_amountの両方が0のときにはinvalid_parameter_both_point_and_money_are_zero(エラーコード400)が返ります。

---
`point_amount`  
```json
{
  "type": "integer",
  "minimum": 0
}
```
ポイント額です。

送金するポイント額を指定します。
デフォルト値は0で、money_amountとpoint_amountの両方が0のときにはinvalid_parameter_both_point_and_money_are_zero(エラーコード400)が返ります。

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
`metadata`  
```json
{
  "type": "string",
  "format": "json"
}
```
取引作成時に指定されるメタデータです。

任意入力で、全てのkeyとvalueが文字列であるようなフラットな構造のJSON文字列で指定します。

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
成功したときは[TransactionDetail](#transaction-detail)オブジェクトを返します
<a name="create-payment-transaction"></a>
#### 支払いする
支払取引を作成します。
支払い時には、エンドユーザーの残高のうち、ポイント残高から優先的に消費されます。

```csharp
Request.CreatePaymentTransaction request = new Request.CreatePaymentTransaction(
    "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx", // 店舗ID
    "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx", // エンドユーザーID
    "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx", // マネーID
    3923 // 支払い額
) {
    Description = "たい焼き(小倉)",  // 取引履歴に表示する説明文
    Metadata = "{\"key\":\"value\"}",  // 取引メタデータ
    Products = new object[]{new Dictionary<string, object>(){{"jan_code","abc"}, {"name","name1"}, {"unit_price",100}, {"price",100}, {"is_discounted",false}, {"other","{}"}}, new Dictionary<string, object>(){{"jan_code","abc"}, {"name","name1"}, {"unit_price",100}, {"price",100}, {"is_discounted",false}, {"other","{}"}}},  // 商品情報データ
    RequestId = "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx",  // リクエストID
};
Response.TransactionDetail response = await request.Send(client);
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
  "type": "integer",
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
`metadata`  
```json
{
  "type": "string",
  "format": "json"
}
```
取引作成時に指定されるメタデータです。

任意入力で、全てのkeyとvalueが文字列であるようなフラットな構造のJSON文字列で指定します。

---
`products`  
```json
{
  "type": "array",
  "items": { "type": "object" }
}
```
一つの取引に含まれる商品情報データです。
以下の内容からなるJSONオブジェクトの配列で指定します。

- `jan_code`: JANコード。64字以下の文字列
- `name`: 商品名。256字以下の文字列
- `unit_price`: 商品単価。0以上の数値
- `price`: 全体の金額(例: 商品単価 × 個数)。0以上の数値
- `is_discounted`: 賞味期限が近いなどの理由で商品が値引きされているかどうかのフラグ。boolean
- `other`: その他商品に関する情報。JSONオブジェクトで指定します。

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
成功したときは[TransactionDetail](#transaction-detail)オブジェクトを返します
<a name="create-cpm-transaction"></a>
#### CPMトークンによる取引作成
CPMトークンにより取引を作成します。
CPMトークンに設定されたスコープの取引を作ることができます。

```csharp
Request.CreateCpmTransaction request = new Request.CreateCpmTransaction(
    "yWPQ4b5EvFhF0JaiWpiphX", // CPMトークン
    "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx", // 店舗ID
    1694.0 // 取引金額
) {
    Description = "たい焼き(小倉)",  // 取引説明文
    Metadata = "{\"key\":\"value\"}",  // 店舗側メタデータ
    Products = new object[]{new Dictionary<string, object>(){{"jan_code","abc"}, {"name","name1"}, {"unit_price",100}, {"price",100}, {"is_discounted",false}, {"other","{}"}}},  // 商品情報データ
    RequestId = "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx",  // リクエストID
};
Response.TransactionDetail response = await request.Send(client);
```

---
`cpm_token`  
```json
{
  "type": "string",
  "minLength": 22,
  "maxLength": 22
}
```
エンドユーザーによって作られ、アプリなどに表示され、店舗に対して提示される22桁の文字列です。

エンドユーザーによって許可された取引のスコープを持っています。

---
`shop_id`  
```json
{
  "type": "string",
  "format": "uuid"
}
```
店舗IDです。

支払いやチャージを行う店舗を指定します。

---
`amount`  
```json
{ "type": "number" }
```
取引金額を指定します。

正の値を与えるとチャージになり、負の値を与えると支払いとなります。

---
`description`  
```json
{
  "type": "string",
  "maxLength": 200
}
```
取引説明文です。

エンドユーザーアプリの取引履歴などに表示されます。

---
`metadata`  
```json
{
  "type": "string",
  "format": "json"
}
```
取引作成時に店舗側から指定されるメタデータです。

任意入力で、全てのkeyとvalueが文字列であるようなフラットな構造のJSON文字列で指定します。

---
`products`  
```json
{
  "type": "array",
  "items": { "type": "object" }
}
```
一つの取引に含まれる商品情報データです。
以下の内容からなるJSONオブジェクトの配列で指定します。

- `jan_code`: JANコード。64字以下の文字列
- `name`: 商品名。256字以下の文字列
- `unit_price`: 商品単価。0以上の数値
- `price`: 全体の金額(例: 商品単価 × 個数)。0以上の数値
- `is_discounted`: 賞味期限が近いなどの理由で商品が値引きされているかどうかのフラグ。boolean
- `other`: その他商品に関する情報。JSONオブジェクトで指定します。

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
成功したときは[TransactionDetail](#transaction-detail)オブジェクトを返します
<a name="create-transfer-transaction"></a>
#### 個人間送金
エンドユーザー間での送金取引(個人間送金)を作成します。
個人間送金で送れるのはマネーのみで、ポイントを送ることはできません。送金元のマネー残高のうち、有効期限が最も遠いものから順に送金されます。

```csharp
Request.CreateTransferTransaction request = new Request.CreateTransferTransaction(
    "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx", // 送金元ユーザーID
    "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx", // 受取ユーザーID
    "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx", // マネーID
    220.0 // 送金額
) {
    Metadata = "{\"key\":\"value\"}",  // 取引メタデータ
    Description = "たい焼き(小倉)",  // 取引履歴に表示する説明文
    RequestId = "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx",  // リクエストID
};
Response.TransactionDetail response = await request.Send(client);
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
`metadata`  
```json
{
  "type": "string",
  "format": "json"
}
```
取引作成時に指定されるメタデータです。

任意入力で、全てのkeyとvalueが文字列であるようなフラットな構造のJSON文字列で指定します。

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
成功したときは[TransactionDetail](#transaction-detail)オブジェクトを返します
<a name="create-exchange-transaction"></a>
#### 
```csharp
Request.CreateExchangeTransaction request = new Request.CreateExchangeTransaction(
    "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx",
    "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx",
    "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx",
    8552.0
) {
    Description = "5XFTYAHJdFeGZi1JIa9NTrkMeAKNU2qNMrw4Jay2YBOfulEIFK5T7Dc8oOst1MM9PmjRDk75J779k3qO5Tt2uQGKACRqDnzgekX1v8d",
    RequestId = "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx",  // リクエストID
};
Response.TransactionDetail response = await request.Send(client);
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
成功したときは[TransactionDetail](#transaction-detail)オブジェクトを返します
<a name="get-transaction"></a>
#### 取引情報を取得する
取引を取得します。
```csharp
Request.GetTransaction request = new Request.GetTransaction(
    "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx" // 取引ID
);
Response.TransactionDetail response = await request.Send(client);
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
成功したときは[TransactionDetail](#transaction-detail)オブジェクトを返します
<a name="refund-transaction"></a>
#### 取引をキャンセルする
取引IDを指定して取引をキャンセルします。

発行体の管理者は自組織の直営店、または発行しているマネーの決済加盟店組織での取引をキャンセルできます。
キャンセル対象の取引に付随するポイント還元キャンペーンやクーポン適用も取り消されます。

チャージ取引のキャンセル時に返金すべき残高が足りないときは `account_balance_not_enough (422)` エラーが返ります。
取引をキャンセルできるのは1回きりです。既にキャンセルされた取引を重ねてキャンセルしようとすると `transaction_already_refunded (422)` エラーが返ります。
```csharp
Request.RefundTransaction request = new Request.RefundTransaction(
    "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx" // 取引ID
) {
    Description = "返品対応のため",  // 取引履歴に表示する返金事由
};
Response.TransactionDetail response = await request.Send(client);
```
成功したときは[TransactionDetail](#transaction-detail)オブジェクトを返します
<a name="list-transfers"></a>
#### 
```csharp
Request.ListTransfers request = new Request.ListTransfers() {
    From = "2021-01-12T01:38:26.000000+09:00",
    To = "2016-04-10T17:15:04.000000+09:00",
    Page = 8261,
    PerPage = 9551,
    ShopId = "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx",
    ShopName = "XLZhDHmMPohPl8jvZE0kmWyBRnvtcRhoAfyfPvqbgkbgVyEBxJxS2dp5fON6g3h5b1QYmVCtk78JxdSgtNZkgpDcQrvPvYu9rBGsdWvnLspaw0X1BOuUcrgAIrlVAxUxxoJ3m2cOYFN3fJYwkLiuasNI3TQ4Ubb8U4LoGEUFzMVQ4l9WdfwN1GBXrbSDIYZlYLOis5sBRV50E243Lt7Q0Ck",
    CustomerId = "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx",
    CustomerName = "QGlHLmFUomkHrvNClWFSWTgMn5wd60p6q",
    TransactionId = "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx",
    PrivateMoneyId = "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx",
    IsModified = true,
    TransactionTypes = new string[]{"topup", "exchange"},
    TransferTypes = new string[]{"cashback", "transfer"},  // 取引明細の種類でフィルターします。
    Description = "店頭QRコードによる支払い",  // 取引詳細説明文
};
Response.PaginatedTransfers response = await request.Send(client);
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
      "coupon": "campaign",
      "cashback": "expire"
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

6. cashback
退会時の返金取引

7. expire
退会時失効取引

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
Response.TransactionDetail response = await request.Send(client);
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
成功したときは[TransactionDetail](#transaction-detail)オブジェクトを返します
### Bill
支払いQRコード
<a name="list-bills"></a>
#### 支払いQRコード一覧を表示する
支払いQRコード一覧を表示します。
```csharp
Request.ListBills request = new Request.ListBills() {
    Page = 4249,  // ページ番号
    PerPage = 4903,  // 1ページの表示数
    BillId = "mfQbT09L",  // 支払いQRコードのID
    PrivateMoneyId = "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx",  // マネーID
    OrganizationCode = "-495StP-1oY-oK78LG2--9R-Xt-",  // 組織コード
    Description = "test bill",  // 取引説明文
    CreatedFrom = "2018-01-11T22:40:16.000000+09:00",  // 作成日時(起点)
    CreatedTo = "2017-01-16T21:05:29.000000+09:00",  // 作成日時(終点)
    ShopName = "bill test shop1",  // 店舗名
    ShopId = "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx",  // 店舗ID
    LowerLimitAmount = 1169,  // 金額の範囲によるフィルタ(下限)
    UpperLimitAmount = 6140,  // 金額の範囲によるフィルタ(上限)
    IsDisabled = false,  // 支払いQRコードが無効化されているかどうか
};
Response.PaginatedBills response = await request.Send(client);
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
    Amount = 2508.0,  // 支払い額
    Description = "test bill",  // 説明文(アプリ上で取引の説明文として表示される)
};
Response.Bill response = await request.Send(client);
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
    Amount = 9810.0,  // 支払い額
    Description = "test bill",  // 説明文
    IsDisabled = false,  // 無効化されているかどうか
};
Response.Bill response = await request.Send(client);
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
    1462.0 // 金額
) {
    Description = "たい焼き(小倉)",  // 取引履歴に表示する説明文
    ExpiresIn = 7615,  // 失効時間(秒)
};
Response.Cashtray response = await request.Send(client);
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
Response.CashtrayWithResult response = await request.Send(client);
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
Response.Cashtray response = await request.Send(client);
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
    Amount = 4279.0,  // 金額
    Description = "たい焼き(小倉)",  // 取引履歴に表示する説明文
    ExpiresIn = 7723,  // 失効時間(秒)
};
Response.Cashtray response = await request.Send(client);
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
Response.AccountDetail response = await request.Send(client);
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
    Status = "pre-closed",  // ウォレット状態
    CanTransferTopup = true,  // チャージ可能かどうか
};
Response.AccountDetail response = await request.Send(client);
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
`status`  
```json
{
  "type": "string",
  "enum": [ "active", "suspended", "pre-closed" ]
}
```
ウォレットの状態です。

---
`can_transfer_topup`  
```json
{ "type": "boolean" }
```
店舗ユーザーがエンドユーザーにチャージ可能かどうかです。真にするとチャージ可能となり、偽にするとチャージ不可能となります。

---
成功したときは[AccountDetail](#account-detail)オブジェクトを返します
<a name="delete-account"></a>
#### ウォレットを退会する
ウォレットを退会します。一度ウォレットを退会した後は、そのウォレットを再び利用可能な状態に戻すことは出来ません。
```csharp
Request.DeleteAccount request = new Request.DeleteAccount(
    "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx" // ウォレットID
) {
    Cashback = true,  // 返金有無
};
Response.AccountDeleted response = await request.Send(client);
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

指定したウォレットIDのウォレットを退会します。

---
`cashback`  
```json
{ "type": "boolean" }
```
退会時の返金有無です。エンドユーザに返金を行う場合、真を指定して下さい。現在のマネー残高を全て現金で返金したものとして記録されます。

---
成功したときは[AccountDeleted](#account-deleted)オブジェクトを返します
<a name="list-account-balances"></a>
#### エンドユーザーの残高内訳を表示する
エンドユーザーのウォレット毎の残高を有効期限別のリストとして取得します。
```csharp
Request.ListAccountBalances request = new Request.ListAccountBalances(
    "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx" // ウォレットID
) {
    Page = 7385,  // ページ番号
    PerPage = 5361,  // 1ページ分の取引数
    ExpiresAtFrom = "2020-05-23T00:51:58.000000+09:00",  // 有効期限の期間によるフィルター(開始時点)
    ExpiresAtTo = "2020-06-15T23:21:04.000000+09:00",  // 有効期限の期間によるフィルター(終了時点)
    Direction = "desc",  // 有効期限によるソート順序
};
Response.PaginatedAccountBalance response = await request.Send(client);
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
    Page = 9875,  // ページ番号
    PerPage = 8487,  // 1ページ分の取引数
    ExpiresAtFrom = "2015-12-19T19:12:14.000000+09:00",  // 有効期限の期間によるフィルター(開始時点)
    ExpiresAtTo = "2023-10-27T08:07:27.000000+09:00",  // 有効期限の期間によるフィルター(終了時点)
    Direction = "desc",  // 有効期限によるソート順序
};
Response.PaginatedAccountBalance response = await request.Send(client);
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
<a name="update-customer-account"></a>
#### ウォレット情報を更新する
ウォレットの状態を更新します。
```csharp
Request.UpdateCustomerAccount request = new Request.UpdateCustomerAccount(
    "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx" // ウォレットID
) {
    Status = "pre-closed",  // ウォレット状態
    AccountName = "MHYRjzAZw05Ty0nenwzHOaIVwMTjPFMGevwVMeZt8EqIvyxvlj5KalqxA7HuqvdSNveWzWI5L6stQvZv",  // アカウント名
    ExternalId = "RJLln3C",  // 外部ID
};
Response.AccountWithUser response = await request.Send(client);
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
`status`  
```json
{
  "type": "string",
  "enum": [ "active", "suspended", "pre-closed" ]
}
```
ウォレットの状態です。

---
`account_name`  
```json
{
  "type": "string",
  "maxLength": 256
}
```
変更するウォレット名です。

---
`external_id`  
```json
{
  "type": "string",
  "maxLength": 50
}
```
変更する外部IDです。

---
成功したときは[AccountWithUser](#account-with-user)オブジェクトを返します
<a name="get-customer-accounts"></a>
#### エンドユーザーのウォレット一覧を表示する
マネーを指定してエンドユーザーのウォレット一覧を取得します。
```csharp
Request.GetCustomerAccounts request = new Request.GetCustomerAccounts(
    "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx" // マネーID
) {
    Page = 5742,  // ページ番号
    PerPage = 2513,  // 1ページ分のウォレット数
    CreatedAtFrom = "2020-06-06T20:19:58.000000+09:00",  // ウォレット作成日によるフィルター(開始時点)
    CreatedAtTo = "2021-10-26T05:16:04.000000+09:00",  // ウォレット作成日によるフィルター(終了時点)
    IsSuspended = true,  // ウォレットが凍結状態かどうかでフィルターする
    Status = "pre-closed",  // ウォレット状態
    ExternalId = "cH2xVBHTbiOHYbzW7EYCf76ToHcl8dtzcqD",  // 外部ID
    Tel = "0107-8624-579",  // エンドユーザーの電話番号
    Email = "gHpZl8InHQ@BhMI.com",  // エンドユーザーのメールアドレス
};
Response.PaginatedAccountWithUsers response = await request.Send(client);
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
`status`  
```json
{
  "type": "string",
  "enum": [ "active", "suspended", "pre-closed" ]
}
```
このパラメータが指定されている場合、ウォレットの状態で結果がフィルターされます。デフォルトでは未指定です。

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
    ExternalId = "rdZJT9MnQgGfElk",  // 外部ID
};
Response.AccountWithUser response = await request.Send(client);
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
    Page = 724,  // ページ番号
    PerPage = 5621,  // 1ページ分のウォレット数
    CreatedAtFrom = "2023-06-06T12:17:12.000000+09:00",  // ウォレット作成日によるフィルター(開始時点)
    CreatedAtTo = "2019-12-06T00:26:46.000000+09:00",  // ウォレット作成日によるフィルター(終了時点)
    IsSuspended = true,  // ウォレットが凍結状態かどうかでフィルターする
};
Response.PaginatedAccountWithUsers response = await request.Send(client);
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
    Type = "payment",  // 取引種別
    IsModified = true,  // キャンセル済みかどうか
    From = "2020-04-03T15:24:56.000000+09:00",  // 開始日時
    To = "2022-01-21T20:07:29.000000+09:00",  // 終了日時
    Page = 1,  // ページ番号
    PerPage = 50,  // 1ページ分の取引数
};
Response.PaginatedTransaction response = await request.Send(client);
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
{
  "type": "string",
  "enum": {
    "topup": "payment",
    "exchange": "transfer",
    "cashback": "expire"
  }
}
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
5. cashback
   ウォレット退会時返金
6. expire
   ウォレット退会時失効

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
    PostalCode = "520-4958",  // 店舗の郵便番号
    Address = "東京都港区芝...",  // 店舗の住所
    Tel = "0134-8133890",  // 店舗の電話番号
    Email = "GMCke10fAp@KjBH.com",  // 店舗のメールアドレス
    ExternalId = "md",  // 店舗の外部ID
    Page = 1,  // ページ番号
    PerPage = 50,  // 1ページ分の取引数
};
Response.PaginatedShops response = await request.Send(client);
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
    ShopPostalCode = "195-2891",  // 店舗の郵便番号
    ShopAddress = "東京都港区芝...",  // 店舗の住所
    ShopTel = "062940585",  // 店舗の電話番号
    ShopEmail = "FqIXqzelGZ@DONU.com",  // 店舗のメールアドレス
    ShopExternalId = "AJfl2HMto7yaW0Gkt1pOBZosxcU6W1vF",  // 店舗の外部ID
    OrganizationCode = "ox-supermarket",  // 組織コード
};
Response.User response = await request.Send(client);
```
成功したときは[User](#user)オブジェクトを返します
<a name="create-shop-v2"></a>
#### 新規店舗を追加する
```csharp
Request.CreateShopV2 request = new Request.CreateShopV2(
    "oxスーパー三田店" // 店舗名
) {
    PostalCode = "2790572",  // 店舗の郵便番号
    Address = "東京都港区芝...",  // 店舗の住所
    Tel = "0541-64397",  // 店舗の電話番号
    Email = "pysg20fNhP@hFK8.com",  // 店舗のメールアドレス
    ExternalId = "wq4sfxVOVqIgogobrlTBvr",  // 店舗の外部ID
    OrganizationCode = "ox-supermarket",  // 組織コード
    PrivateMoneyIds = new string[]{"xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx", "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx", "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx"},  // 店舗で有効にするマネーIDの配列
    CanTopupPrivateMoneyIds = new string[]{"xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx"},  // 店舗でチャージ可能にするマネーIDの配列
};
Response.ShopWithAccounts response = await request.Send(client);
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
Response.ShopWithAccounts response = await request.Send(client);
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
    PostalCode = "5998063",  // 店舗の郵便番号
    Address = "東京都港区芝...",  // 店舗の住所
    Tel = "07-8413881",  // 店舗の電話番号
    Email = "tPEmOFzye1@0sMn.com",  // 店舗のメールアドレス
    ExternalId = "1hLqgZ4Scflk2",  // 店舗の外部ID
    PrivateMoneyIds = new string[]{"xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx", "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx"},  // 店舗で有効にするマネーIDの配列
    CanTopupPrivateMoneyIds = new string[]{"xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx"},  // 店舗でチャージ可能にするマネーIDの配列
};
Response.ShopWithAccounts response = await request.Send(client);
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
) {
    Page = 1643,  // ページ番号
    PerPage = 402,  // 1ページ分の取引数
};
Response.PaginatedAccountDetails response = await request.Send(client);
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
1ページ当たりのウォレット数です。デフォルト値は50です。

---
成功したときは[PaginatedAccountDetails](#paginated-account-details)オブジェクトを返します
<a name="create-user-account"></a>
#### エンドユーザーのウォレットを作成する
```csharp
Request.CreateUserAccount request = new Request.CreateUserAccount(
    "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx", // ユーザーID
    "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx" // マネーID
) {
    Name = "jOojFztUyYyUwwyS9B5htgNIDpUpzKyj3BEvYp1TbuySIy9vMfjs9RSVIuRLJamUgod9vJRMh5laf7AaoLGt4pe6BC2Sel2QniqdOC9my1YOO8CjR0YFmv40UM5wZgue67e0YlrO8E3L7gW6pVOxZ4jRFNa6hoBOihdHvejLf7HUNUhMpEnczyOhMWAPbHXytdjUT8FkE6WXDem2rgSzz35aQ4D94kR9S0XTdmHcC0cGFAf",  // ウォレット名
    ExternalId = "EKgLlOIWqFFofKhzWzC",  // 外部ID
};
Response.AccountDetail response = await request.Send(client);
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

---
`private_money_id`  
```json
{
  "type": "string",
  "format": "uuid"
}
```
マネーIDです。

作成するウォレットのマネーを指定します。このパラメータは必須です。

---
成功したときは[AccountDetail](#account-detail)オブジェクトを返します
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
Response.PaginatedPrivateMoneys response = await request.Send(client);
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
    From = "2022-06-06T23:07:50.000000+09:00",  // 開始日時(toと同時に指定する必要有)
    To = "2022-11-14T13:22:58.000000+09:00",  // 終了日時(fromと同時に指定する必要有)
    Page = 1,  // ページ番号
    PerPage = 50,  // 1ページ分の取引数
};
Response.PaginatedPrivateMoneyOrganizationSummaries response = await request.Send(client);
```
`from`と`to`は同時に指定する必要があります。

成功したときは[PaginatedPrivateMoneyOrganizationSummaries](#paginated-private-money-organization-summaries)オブジェクトを返します
<a name="get-private-money-summary"></a>
#### 取引サマリを取得する
```csharp
Request.GetPrivateMoneySummary request = new Request.GetPrivateMoneySummary(
    "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx" // マネーID
) {
    From = "2021-02-01T04:36:10.000000+09:00",  // 開始日時
    To = "2024-04-18T16:52:04.000000+09:00",  // 終了日時
};
Response.PrivateMoneySummary response = await request.Send(client);
```
成功したときは[PrivateMoneySummary](#private-money-summary)オブジェクトを返します
### Bulk
<a name="bulk-create-transaction"></a>
#### CSVファイル一括取引
CSVファイルから一括取引をします。
```csharp
Request.BulkCreateTransaction request = new Request.BulkCreateTransaction(
    "nh", // 一括取引タスク名
    "L16", // 取引する情報のCSV
    "oNA3cZ4NnyIEjaN6dYZY4p9bZgscBV3pXiPP" // リクエストID
) {
    Description = "iW2qUm4FbQucsmz0GYwY85K8kF9CcO2FCZ7wQECuEigH9T54l9EXWThBhNBtq0Hlr5VUDcRjPWhcWE5Ed0Dp6qm5enNIYlp4WuULLQB3hzZG357PPnWlMQlOO65IFrI",  // 一括取引の説明
};
Response.BulkTransaction response = await request.Send(client);
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
### Event
<a name="create-external-transaction"></a>
#### ポケペイ外部取引を作成する
ポケペイ外部取引を作成します。

ポケペイ外の現金決済やクレジットカード決済に対してポケペイのポイントを付けたいというときに使用します。

```csharp
Request.CreateExternalTransaction request = new Request.CreateExternalTransaction(
    "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx", // 店舗ID
    "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx", // エンドユーザーID
    "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx", // マネーID
    433 // 取引額
) {
    Description = "たい焼き(小倉)",  // 取引説明文
    Metadata = "{\"key\":\"value\"}",  // ポケペイ外部取引メタデータ
    Products = new object[]{new Dictionary<string, object>(){{"jan_code","abc"}, {"name","name1"}, {"unit_price",100}, {"price",100}, {"is_discounted",false}, {"other","{}"}}, new Dictionary<string, object>(){{"jan_code","abc"}, {"name","name1"}, {"unit_price",100}, {"price",100}, {"is_discounted",false}, {"other","{}"}}},  // 商品情報データ
    RequestId = "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx",  // リクエストID
};
Response.ExternalTransaction response = await request.Send(client);
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

ポケペイ外部取引が行なう店舗を指定します。

---
`customer_id`  
```json
{
  "type": "string",
  "format": "uuid"
}
```
エンドユーザーIDです。

エンドユーザーを指定します。

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
  "type": "integer",
  "minimum": 0
}
```
取引金額です。

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
`metadata`  
```json
{
  "type": "string",
  "format": "json"
}
```
ポケペイ外部取引作成時に指定され、取引と紐付けられるメタデータです。

任意入力で、全てのkeyとvalueが文字列であるようなフラットな構造のJSONで指定します。

---
`products`  
```json
{
  "type": "array",
  "items": { "type": "object" }
}
```
一つの取引に含まれる商品情報データです。
以下の内容からなるJSONオブジェクトの配列で指定します。

- `jan_code`: JANコード。64字以下の文字列
- `name`: 商品名。256字以下の文字列
- `unit_price`: 商品単価。0以上の数値
- `price`: 全体の金額(例: 商品単価 × 個数)。0以上の数値
- `is_discounted`: 賞味期限が近いなどの理由で商品が値引きされているかどうかのフラグ。boolean
- `other`: その他商品に関する情報。JSONオブジェクトで指定します。

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
成功したときは[ExternalTransaction](#external-transaction)オブジェクトを返します
<a name="refund-external-transaction"></a>
#### ポケペイ外部取引をキャンセルする
取引IDを指定して取引をキャンセルします。

発行体の管理者は自組織の直営店、または発行しているマネーの決済加盟店組織での取引をキャンセルできます。
キャンセル対象のポケペイ外部取引に付随するポイント還元キャンペーンも取り消されます。

取引をキャンセルできるのは1回きりです。既にキャンセルされた取引を重ねてキャンセルしようとすると `transaction_already_refunded (422)` エラーが返ります。
```csharp
Request.RefundExternalTransaction request = new Request.RefundExternalTransaction(
    "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx" // 取引ID
) {
    Description = "返品対応のため",  // 取引履歴に表示する返金事由
};
Response.ExternalTransaction response = await request.Send(client);
```
成功したときは[ExternalTransaction](#external-transaction)オブジェクトを返します
### Campaign
<a name="create-campaign"></a>
#### ポイント付与キャンペーンを作る
ポイント付与キャンペーンを作成します。

```csharp
Request.CreateCampaign request = new Request.CreateCampaign(
    "JMiWPv5dAbUBWta68v79KNgsodWT1kP64chZLEzZTeXAsCUOeSILicKJugPMhkbNW44x5lpizelx6Zw3ANkreMSnigb4Yb3t6kmvyhjD7Y1lgzqIh5MLpUpAeuRnJqWXlTPA3BNnPJo0CH10GQb96Jzcef7f3He1f0QYEkgJnc3iiJ3NDVFkNizSfk2HEbXxayx", // キャンペーン名
    "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx", // マネーID
    "2017-08-06T14:18:51.000000+09:00", // キャンペーン開始日時
    "2015-12-06T10:06:06.000000+09:00", // キャンペーン終了日時
    4786, // キャンペーンの適用優先度
    "payment" // イベント種別
) {
    BearPointShopId = "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx",  // ポイント負担先店舗ID
    Description = "ghdc2Ljaj2GsuiV9UsDnl2m8nhmhWmlD5AgJ4dO8VEt3hyN01xWKpyfSJX1OiNUbqHXuSEWeM8VLmM8qznKIn9uBoqN3XKkwmXFn",  // キャンペーンの説明文
    Status = "enabled",  // キャンペーン作成時の状態
    PointExpiresAt = "2020-11-24T15:21:52.000000+09:00",  // ポイント有効期限(絶対日時指定)
    PointExpiresInDays = 7501,  // ポイント有効期限(相対日数指定)
    IsExclusive = true,  // キャンペーンの重複設定
    Subject = "money",  // ポイント付与の対象金額の種別
    AmountBasedPointRules = new object[]{new Dictionary<string, object>(){{"point_amount",5}, {"point_amount_unit","percent"}, {"subject_more_than_or_equal",1000}, {"subject_less_than",5000}}},  // 取引金額ベースのポイント付与ルール
    ProductBasedPointRules = new object[]{new Dictionary<string, object>(){{"point_amount",5}, {"point_amount_unit","percent"}, {"product_code","4912345678904"}, {"is_multiply_by_count",true}, {"required_count",2}}},  // 商品情報ベースのポイント付与ルール
    ApplicableDaysOfWeek = new int[]{3, 5, 2},  // キャンペーンを適用する曜日 (複数指定)
    ApplicableTimeRanges = new object[]{new Dictionary<string, object>(){{"from","12:00"}, {"to","23:59"}}},  // キャンペーンを適用する時間帯 (複数指定)
    ApplicableShopIds = new string[]{"xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx", "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx", "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx"},  // キャンペーン適用対象となる店舗IDのリスト
    MinimumNumberForCombinationPurchase = 7978,  // 複数種類の商品を同時購入するときの商品種別数の下限
    DestPrivateMoneyId = "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx",  // ポイント付与先となるマネーID
};
Response.Campaign response = await request.Send(client);
```

---
`name`  
```json
{
  "type": "string",
  "maxLength": 256
}
```
キャンペーン名です(必須項目)。

ポイント付与によってできるチャージ取引の説明文に転記されます。取引説明文はエンドユーザーからも確認できます。

---
`private_money_id`  
```json
{
  "type": "string",
  "format": "uuid"
}
```
キャンペーン対象のマネーのIDです(必須項目)。

---
`starts_at`  
```json
{
  "type": "string",
  "format": "date-time"
}
```
キャンペーン開始日時です(必須項目)。
キャンペーン期間中のみポイントが付与されます。
開始日時よりも終了日時が前のときはcampaign_invalid_periodエラー(422)になります。

---
`ends_at`  
```json
{
  "type": "string",
  "format": "date-time"
}
```
キャンペーン終了日時です(必須項目)。
キャンペーン期間中のみポイントが付与されます。
開始日時よりも終了日時が前のときはcampaign_invalid_periodエラー(422)になります。

---
`priority`  
```json
{ "type": "integer" }
```
キャンペーンの適用優先度です。

優先度が大きいものから順に適用判定されていきます。
キャンペーン期間が重なっている同一の優先度のキャンペーンが存在するとcampaign_period_overlapsエラー(422)になります。

---
`event`  
```json
{
  "type": "string",
  "enum": [ "topup", "payment", "external-transaction" ]
}
```
キャンペーンのトリガーとなるイベントの種類を指定します(必須項目)。

以下のいずれかを指定できます。

1. topup
   店舗からエンドユーザーへの送金取引(チャージ)
2. payment
   エンドユーザーから店舗への送金取引(支払い)
3. external-transaction
   ポケペイ外の取引(現金決済など)

---
`bear_point_shop_id`  
```json
{
  "type": "string",
  "format": "uuid"
}
```
ポイントを負担する店舗のIDです。デフォルトではマネー発行体の本店が設定されます。
ポイント負担先店舗は後から更新することはできません。

---
`description`  
```json
{
  "type": "string",
  "maxLength": 200
}
```
キャンペーンの内容を記載します。管理画面などでキャンペーンを管理するための説明文になります。

---
`status`  
```json
{
  "type": "string",
  "enum": { "enabled": "disabled" }
}
```
キャンペーン作成時の状態を指定します。デフォルトではenabledです。

以下のいずれかを指定できます。

1. enabled
   有効
2. disabled
   無効

---
`point_expires_at`  
```json
{
  "type": "string",
  "format": "date-time"
}
```
キャンペーンによって付与されるポイントの有効期限を絶対日時で指定します。
省略した場合はマネーに設定された有効期限と同じものがポイントの有効期限となります。

---
`point_expires_in_days`  
```json
{
  "type": "integer",
  "minimum": 1
}
```
キャンペーンによって付与されるポイントの有効期限を相対日数で指定します。
省略した場合はマネーに設定された有効期限と同じものがポイントの有効期限となります。

---
`is_exclusive`  
```json
{ "type": "boolean" }
```
キャンペーンの重ね掛けを行うかどうかのフラグです。

これにtrueを指定すると他のキャンペーンと同時適用されません。デフォルト値はtrueです。
falseを指定すると次の優先度の重ね掛け可能なキャンペーンの適用判定に進みます。

---
`subject`  
```json
{
  "type": "string",
  "enum": { "money": "all" }
}
```
ポイント付与額を計算する対象となる金額の種類を指定します。デフォルト値はallです。
eventとしてexternal-transactionを指定した場合はポイントとマネーの区別がないためsubjectの指定に関わらず常にallとなります。

以下のいずれかを指定できます。

1. money
moneyを指定すると決済額の中で「マネー」を使って支払った額を対象にします

2. all
all を指定すると決済額全体を対象にします (「ポイント」での取引額を含む)
注意: event を topup にしたときはポイントの付与に対しても適用されます

---
`amount_based_point_rules`  
```json
{
  "type": "array",
  "items": { "type": "object" }
}
```
金額をベースとしてポイント付与を行うルールを指定します。
amount_based_point_rules と product_based_point_rules はどちらか一方しか指定できません。
各ルールは一つのみ適用され、条件に重複があった場合は先に記載されたものが優先されます。

例:
```javascript
[
  // 1000円以上、5000円未満の決済には 5％
  {
    "point_amount": 5,
    "point_amount_unit": "percent",
    "subject_more_than_or_equal": 1000,
    "subject_less_than": 5000
  },
  // 5000円以上の決済には 10%
  {
    "point_amount": 10,
    "point_amount_unit": "percent",
    "subject_more_than_or_equal": 5000
  },
]
```

---
`product_based_point_rules`  
```json
{
  "type": "array",
  "items": { "type": "object" }
}
```
商品情報をベースとしてポイント付与を行うルールを指定します。
ルールは商品ごとに設定可能で、ルールの配列として指定します。
amount_based_point_rules と product_based_point_rules はどちらか一方しか指定できません。
event が payment か external-transaction の時のみ有効です。
各ルールの順序は問わず、適用可能なものは全て適用されます。
一つの決済の中で複数の商品がキャンペーン適用可能な場合はそれぞれの商品についてのルールが適用され、ポイント付与額はその合算になります。

例:
```javascript
[
  // 対象商品の購入額から5%ポイント付与。複数購入時は単価の5%が付与される。
  {
    "point_amount": 5,
    "point_amount_unit": "percent",
    "product_code": "4912345678904",
  },
  // 対象商品の購入額から5%ポイント付与。複数購入時は購入総額の5%が付与される。
  {
    "point_amount": 5,
    "point_amount_unit": "percent",
    "product_code": "4912345678904",
    "is_multiply_by_count": true,
  },
  // 対象商品を2つ以上購入したら500ポイント付与(固定額付与)
  {
    "point_amount": 500,
    "point_amount_unit": "absolute",
    "product_code": "4912345678904",
    "required_count": 2
  },
  // 書籍は10%ポイント付与
  // ※ISBNの形式はレジがポケペイに送信する形式に準じます
  {
    "point_amount": 10,
    "point_amount_unit": "percent",
    "product_code": "978-%",
  },
  // 一部の出版社の書籍は10%ポイント付与
  {
    "point_amount": 10,
    "point_amount_unit": "percent",
    "product_code": "978-4-01-%", // 旺文社
  }
]
```

---
`minimum_number_for_combination_purchase`  
```json
{
  "type": "integer",
  "minimum": 1
}
```
複数種別の商品を同時購入したとき、同時購入キャンペーンの対象となる商品種別数の下限です。デフォルトでは未指定で、指定する場合は1以上の整数を指定します。

このパラメータを指定するときは product_based_point_rules で商品毎のルールが指定されている必要があります。
例えば、A商品とB商品とC商品のうち、キャンペーンの発火のために2商品以上が同時購入される必要があるときは 2 を指定します。

例1: 商品A, Bが同時購入されたときに固定ポイント額(200ポイント)付与
```javascript
{
  minimum_number_for_combination_purchase: 2,
  product_based_point_rules: [
    {
      "point_amount": 100,
      "point_amount_unit": "absolute",
      "product_code": "商品Aの商品コード"
    },
    {
      "point_amount": 100,
      "point_amount_unit": "absolute",
      "product_code": "商品Bの商品コード"
    }
  ]
}
```

例2: 商品A, Bが3個ずつ以上同時購入されたときに固定ポイント額(200ポイント)付与
```javascript
{
  minimum_number_for_combination_purchase: 2,
  product_based_point_rules: [
    {
      "point_amount": 100,
      "point_amount_unit": "absolute",
      "product_code": "商品Aの商品コード",
      "required_count": 3
    },
    {
      "point_amount": 100,
      "point_amount_unit": "absolute",
      "product_code": "商品Bの商品コード",
      "required_count": 3
    }
  ]
}
```

例2: 商品A, B, Cのうち2商品以上が同時購入されたときに総額の10%ポイントが付与
```javascript
{
  minimum_number_for_combination_purchase: 2,
  product_based_point_rules: [
    {
      "point_amount": 10,
      "point_amount_unit": "percent",
      "product_code": "商品Aの商品コード",
      "is_multiply_by_count": true,
    },
    {
      "point_amount": 10,
      "point_amount_unit": "percent",
      "product_code": "商品Bの商品コード",
      "is_multiply_by_count": true,
    },
    {
      "point_amount": 10,
      "point_amount_unit": "percent",
      "product_code": "商品Cの商品コード",
      "is_multiply_by_count": true,
    }
  ]
}
```

---
`dest_private_money_id`  
```json
{
  "type": "string",
  "format": "uuid"
}
```
キャンペーンを駆動するイベントのマネーとは「別のマネー」に対してポイントを付けたいときに、そのマネーIDを指定します。

ポイント付与先のマネーはキャンペーンを駆動するイベントのマネーと同一発行体が発行しているものに限ります。その他のマネーIDが指定された場合は private_money_not_found (422) が返ります。
エンドユーザー、店舗、ポイント負担先店舗はポイント付与先マネーのウォレットを持っている必要があります。持っていない場合はポイントは付きません。
元のイベントのマネーと異なる複数のマネーに対して同時にポイントを付与することはできません。重複可能に設定されている複数のキャンペーンで別々のポイント付与先マネーを指定した場合は最も優先度の高いものが処理され、残りは無視されます。
キャンペーンのポイント付与先マネーは後から更新することはできません。
デフォルトではポイント付与先はキャンペーンを駆動するイベントのマネー(private_money_idで指定したマネー)になります。

別マネーに対するポイント付与は別のtransactionとなります。 RefundTransaction で元のイベントをキャンセルしたときはポイント付与のtransactionもキャンセルされ、逆にポイント付与のtransactionをキャンセルしたときは連動して元のイベントがキャンセルされます。

---
成功したときは[Campaign](#campaign)オブジェクトを返します
<a name="list-campaigns"></a>
#### キャンペーン一覧を取得する
マネーIDを指定してキャンペーンを取得します。
発行体の組織マネージャ権限で、自組織が発行するマネーのキャンペーンについてのみ閲覧可能です。
閲覧権限がない場合は unpermitted_admin_user エラー(422)が返ります。
```csharp
Request.ListCampaigns request = new Request.ListCampaigns(
    "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx" // マネーID
) {
    IsOngoing = false,  // 現在適用可能なキャンペーンかどうか
    Page = 1,  // ページ番号
    PerPage = 50,  // 1ページ分の取得数
};
Response.PaginatedCampaigns response = await request.Send(client);
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

フィルターとして使われ、指定したマネーでのキャンペーンのみ一覧に表示されます。

---
`is_ongoing`  
```json
{ "type": "boolean" }
```
有効化されており、現在キャンペーン期間内にあるキャンペーンをフィルターするために使われます。
真であれば適用可能なもののみを抽出し、偽であれば適用不可なもののみを抽出します。
デフォルトでは未指定(フィルターなし)です。

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
1ページ分の取得数です。デフォルトでは 20 になっています。

---
成功したときは[PaginatedCampaigns](#paginated-campaigns)オブジェクトを返します
<a name="get-campaign"></a>
#### キャンペーンを取得する
IDを指定してキャンペーンを取得します。
発行体の組織マネージャ権限で、自組織が発行するマネーのキャンペーンについてのみ閲覧可能です。
閲覧権限がない場合は unpermitted_admin_user エラー(422)が返ります。
```csharp
Request.GetCampaign request = new Request.GetCampaign(
    "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx" // キャンペーンID
);
Response.Campaign response = await request.Send(client);
```

---
`campaign_id`  
```json
{
  "type": "string",
  "format": "uuid"
}
```
キャンペーンIDです。

指定したIDのキャンペーンを取得します。存在しないIDを指定した場合は404エラー(NotFound)が返ります。

---
成功したときは[Campaign](#campaign)オブジェクトを返します
<a name="update-campaign"></a>
#### ポイント付与キャンペーンを更新する
ポイント付与キャンペーンを更新します。

```csharp
Request.UpdateCampaign request = new Request.UpdateCampaign(
    "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx" // キャンペーンID
) {
    Name = "rucmF8n8VnjFoEs5f64mvXKC0yIYDrOmfZvcfCdES8",  // キャンペーン名
    StartsAt = "2024-09-08T07:20:09.000000+09:00",  // キャンペーン開始日時
    EndsAt = "2023-12-27T18:14:31.000000+09:00",  // キャンペーン終了日時
    Priority = 9546,  // キャンペーンの適用優先度
    Event = "payment",  // イベント種別
    Description = "f50TC5y2HNrP34hD1uxIbudPgKcAH4LqtvnYdJrsgVxWy0PirB5ccKSjPsnaJy0xSUaUZ3KYipGveNp11WiSr08uCzB0JSt7h",  // キャンペーンの説明文
    Status = "disabled",  // キャンペーン作成時の状態
    PointExpiresAt = "2024-11-12T03:49:54.000000+09:00",  // ポイント有効期限(絶対日時指定)
    PointExpiresInDays = 7854,  // ポイント有効期限(相対日数指定)
    IsExclusive = true,  // キャンペーンの重複設定
    Subject = "money",  // ポイント付与の対象金額の種別
    AmountBasedPointRules = new object[]{new Dictionary<string, object>(){{"point_amount",5}, {"point_amount_unit","percent"}, {"subject_more_than_or_equal",1000}, {"subject_less_than",5000}}, new Dictionary<string, object>(){{"point_amount",5}, {"point_amount_unit","percent"}, {"subject_more_than_or_equal",1000}, {"subject_less_than",5000}}, new Dictionary<string, object>(){{"point_amount",5}, {"point_amount_unit","percent"}, {"subject_more_than_or_equal",1000}, {"subject_less_than",5000}}},  // 取引金額ベースのポイント付与ルール
    ProductBasedPointRules = new object[]{new Dictionary<string, object>(){{"point_amount",5}, {"point_amount_unit","percent"}, {"product_code","4912345678904"}, {"is_multiply_by_count",true}, {"required_count",2}}, new Dictionary<string, object>(){{"point_amount",5}, {"point_amount_unit","percent"}, {"product_code","4912345678904"}, {"is_multiply_by_count",true}, {"required_count",2}}, new Dictionary<string, object>(){{"point_amount",5}, {"point_amount_unit","percent"}, {"product_code","4912345678904"}, {"is_multiply_by_count",true}, {"required_count",2}}},  // 商品情報ベースのポイント付与ルール
    ApplicableDaysOfWeek = new int[]{2, 1},  // キャンペーンを適用する曜日 (複数指定)
    ApplicableTimeRanges = new object[]{new Dictionary<string, object>(){{"from","12:00"}, {"to","23:59"}}, new Dictionary<string, object>(){{"from","12:00"}, {"to","23:59"}}, new Dictionary<string, object>(){{"from","12:00"}, {"to","23:59"}}},  // キャンペーンを適用する時間帯 (複数指定)
    ApplicableShopIds = new string[]{"xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx", "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx", "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx"},  // キャンペーン適用対象となる店舗IDのリスト
    MinimumNumberForCombinationPurchase = 7273,  // 複数種類の商品を同時購入するときの商品種別数の下限
};
Response.Campaign response = await request.Send(client);
```

---
`campaign_id`  
```json
{
  "type": "string",
  "format": "uuid"
}
```
キャンペーンIDです。

指定したIDのキャンペーンを更新します。存在しないIDを指定した場合は404エラー(NotFound)が返ります。

---
`name`  
```json
{
  "type": "string",
  "maxLength": 256
}
```
キャンペーン名です。

ポイント付与によってできるチャージ取引の説明文に転記されます。取引説明文はエンドユーザーからも確認できます。

---
`starts_at`  
```json
{
  "type": "string",
  "format": "date-time"
}
```
キャンペーン開始日時です。
キャンペーン期間中のみポイントが付与されます。
開始日時よりも終了日時が前のときはcampaign_invalid_periodエラー(422)になります。

---
`ends_at`  
```json
{
  "type": "string",
  "format": "date-time"
}
```
キャンペーン終了日時です。
キャンペーン期間中のみポイントが付与されます。
開始日時よりも終了日時が前のときはcampaign_invalid_periodエラー(422)になります。

---
`priority`  
```json
{ "type": "integer" }
```
キャンペーンの適用優先度です。

優先度が大きいものから順に適用判定されていきます。
キャンペーン期間が重なっている同一の優先度のキャンペーンが存在するとcampaign_period_overlapsエラー(422)になります。

---
`event`  
```json
{
  "type": "string",
  "enum": [ "topup", "payment", "external-transaction" ]
}
```
キャンペーンのトリガーとなるイベントの種類を指定します。

以下のいずれかを指定できます。

1. topup
   店舗からエンドユーザーへの送金取引(チャージ)
2. payment
   エンドユーザーから店舗への送金取引(支払い)
3. external-transaction
   ポケペイ外の取引(現金決済など)

---
`description`  
```json
{
  "type": "string",
  "maxLength": 200
}
```
キャンペーンの内容を記載します。管理画面などでキャンペーンを管理するための説明文になります。

---
`status`  
```json
{
  "type": "string",
  "enum": { "enabled": "disabled" }
}
```
キャンペーン作成時の状態を指定します。デフォルトではenabledです。

以下のいずれかを指定できます。

1. enabled
   有効
2. disabled
   無効

---
`point_expires_at`  
```json
{
  "type": "string",
  "format": "date-time"
}
```
キャンペーンによって付与されるポイントの有効期限を絶対日時で指定します。
省略した場合はマネーに設定された有効期限と同じものがポイントの有効期限となります。

---
`point_expires_in_days`  
```json
{
  "type": "integer",
  "minimum": 1
}
```
キャンペーンによって付与されるポイントの有効期限を相対日数で指定します。
省略した場合はマネーに設定された有効期限と同じものがポイントの有効期限となります。

---
`is_exclusive`  
```json
{ "type": "boolean" }
```
キャンペーンの重ね掛けを行うかどうかのフラグです。

これにtrueを指定すると他のキャンペーンと同時適用されません。デフォルト値はtrueです。
falseを指定すると次の優先度の重ね掛け可能なキャンペーンの適用判定に進みます。

---
`subject`  
```json
{
  "type": "string",
  "enum": { "money": "all" }
}
```
ポイント付与額を計算する対象となる金額の種類を指定します。デフォルト値はallです。
eventとしてexternal-transactionを指定した場合はポイントとマネーの区別がないためsubjectの指定に関わらず常にallとなります。

以下のいずれかを指定できます。

1. money
moneyを指定すると決済額の中で「マネー」を使って支払った額を対象にします

2. all
all を指定すると決済額全体を対象にします (「ポイント」での取引額を含む)
注意: event を topup にしたときはポイントの付与に対しても適用されます

---
`amount_based_point_rules`  
```json
{
  "type": "array",
  "items": { "type": "object" }
}
```
金額をベースとしてポイント付与を行うルールを指定します。
amount_based_point_rules と product_based_point_rules はどちらか一方しか指定できません。
各ルールは一つのみ適用され、条件に重複があった場合は先に記載されたものが優先されます。

例:
```javascript
[
  // 1000円以上、5000円未満の決済には 5％
  {
    "point_amount": 5,
    "point_amount_unit": "percent",
    "subject_more_than_or_equal": 1000,
    "subject_less_than": 5000
  },
  // 5000円以上の決済には 10%
  {
    "point_amount": 10,
    "point_amount_unit": "percent",
    "subject_more_than_or_equal": 5000
  },
]
```

---
`product_based_point_rules`  
```json
{
  "type": "array",
  "items": { "type": "object" }
}
```
商品情報をベースとしてポイント付与を行うルールを指定します。
ルールは商品ごとに設定可能で、ルールの配列として指定します。
amount_based_point_rules と product_based_point_rules はどちらか一方しか指定できません。
event が payment か external-transaction の時のみ有効です。
各ルールの順序は問わず、適用可能なものは全て適用されます。
一つの決済の中で複数の商品がキャンペーン適用可能な場合はそれぞれの商品についてのルールが適用され、ポイント付与額はその合算になります。

例:
```javascript
[
  // 対象商品の購入額から5%ポイント付与。複数購入時は単価の5%が付与される。
  {
    "point_amount": 5,
    "point_amount_unit": "percent",
    "product_code": "4912345678904",
  },
  // 対象商品の購入額から5%ポイント付与。複数購入時は購入総額の5%が付与される。
  {
    "point_amount": 5,
    "point_amount_unit": "percent",
    "product_code": "4912345678904",
    "is_multiply_by_count": true,
  },
  // 対象商品を2つ以上購入したら500ポイント付与(固定額付与)
  {
    "point_amount": 500,
    "point_amount_unit": absolute",
    "product_code": "4912345678904",
    "required_count": 2
  },
  // 書籍は10%ポイント付与
  // ※ISBNの形式はレジがポケペイに送信する形式に準じます
  {
    "point_amount": 10,
    "point_amount_unit": "percent",
    "product_code": "978-%",
  },
  // 一部の出版社の書籍は10%ポイント付与
  {
    "point_amount": 10,
    "point_amount_unit": "percent",
    "product_code": "978-4-01-%", // 旺文社
  }
]
```

---
`minimum_number_for_combination_purchase`  
```json
{
  "type": "integer",
  "minimum": 1
}
```
複数種別の商品を同時購入したとき、同時購入キャンペーンの対象となる商品種別数の下限です。

このパラメータを指定するときは product_based_point_rules で商品毎のルールが指定されている必要があります。
例えば、A商品とB商品とC商品のうち、キャンペーンの発火のために2商品以上が同時購入される必要があるときは 2 を指定します。

例1: 商品A, Bが同時購入されたときに固定ポイント額(200ポイント)付与
```javascript
{
  minimum_number_for_combination_purchase: 2,
  product_based_point_rules: [
    {
      "point_amount": 100,
      "point_amount_unit": "absolute",
      "product_code": "商品Aの商品コード"
    },
    {
      "point_amount": 100,
      "point_amount_unit": "absolute",
      "product_code": "商品Bの商品コード"
    }
  ]
}
```

例2: 商品A, Bが3個ずつ以上同時購入されたときに固定ポイント額(200ポイント)付与
```javascript
{
  minimum_number_for_combination_purchase: 2,
  product_based_point_rules: [
    {
      "point_amount": 100,
      "point_amount_unit": "absolute",
      "product_code": "商品Aの商品コード",
      "required_count": 3
    },
    {
      "point_amount": 100,
      "point_amount_unit": "absolute",
      "product_code": "商品Bの商品コード",
      "required_count": 3
    }
  ]
}
```

例2: 商品A, B, Cのうち2商品以上が同時購入されたときに総額の10%ポイントが付与
```javascript
{
  minimum_number_for_combination_purchase: 2,
  product_based_point_rules: [
    {
      "point_amount": 10,
      "point_amount_unit": "percent",
      "product_code": "商品Aの商品コード",
      "is_multiply_by_count": true,
    },
    {
      "point_amount": 10,
      "point_amount_unit": "percent",
      "product_code": "商品Bの商品コード",
      "is_multiply_by_count": true,
    },
    {
      "point_amount": 10,
      "point_amount_unit": "percent",
      "product_code": "商品Cの商品コード",
      "is_multiply_by_count": true,
    }
  ]
}
```

---
成功したときは[Campaign](#campaign)オブジェクトを返します
## Responses


<a name="account-with-user"></a>
## AccountWithUser
* `Id (string)`: 
* `Name (string)`: 
* `IsSuspended (bool)`: 
* `Status (string)`: 
* `PrivateMoney (PrivateMoney)`: 
* `User (User)`: 

`private_money`は [PrivateMoney](#private-money) オブジェクトを返します。

`user`は [User](#user) オブジェクトを返します。

<a name="account-detail"></a>
## AccountDetail
* `Id (string)`: 
* `Name (string)`: 
* `IsSuspended (bool)`: 
* `Status (string)`: 
* `Balance (double)`: 
* `MoneyBalance (double)`: 
* `PointBalance (double)`: 
* `PrivateMoney (PrivateMoney)`: 
* `User (User)`: 
* `ExternalId (string)`: 

`private_money`は [PrivateMoney](#private-money) オブジェクトを返します。

`user`は [User](#user) オブジェクトを返します。

<a name="account-deleted"></a>
## AccountDeleted

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

<a name="cpm-token"></a>
## CpmToken
* `CpmToken (string)`: 
* `Account (AccountDetail)`: 
* `Transaction (Transaction)`: 
* `Event (ExternalTransaction)`: 
* `Scopes (string[])`: 許可された取引種別
* `ExpiresAt (string)`: CPMトークンの失効日時
* `Metadata (string)`: エンドユーザー側メタデータ

`account`は [AccountDetail](#account-detail) オブジェクトを返します。

`transaction`は [Transaction](#transaction) オブジェクトを返します。

`event`は [ExternalTransaction](#external-transaction) オブジェクトを返します。

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

<a name="transaction-detail"></a>
## TransactionDetail
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
* `Transfers (Transfer[])`: 

`receiver`と`sender`は [User](#user) オブジェクトを返します。

`receiver_account`と`sender_account`は [Account](#account) オブジェクトを返します。

`transfers`は [Transfer](#transfer) オブジェクトの配列を返します。

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

<a name="external-transaction"></a>
## ExternalTransaction
* `Id (string)`: ポケペイ外部取引ID
* `IsModified (bool)`: 返金された取引かどうか
* `Sender (User)`: 送金者情報
* `SenderAccount (Account)`: 送金ウォレット情報
* `Receiver (User)`: 受取者情報
* `ReceiverAccount (Account)`: 受取ウォレット情報
* `Amount (double)`: 決済額
* `DoneAt (string)`: 取引日時
* `Description (string)`: 取引説明文

`receiver`と`sender`は [User](#user) オブジェクトを返します。

`receiver_account`と`sender_account`は [Account](#account) オブジェクトを返します。

<a name="paginated-private-money-organization-summaries"></a>
## PaginatedPrivateMoneyOrganizationSummaries
* `Rows (PrivateMoneyOrganizationSummary[])`: 
* `Count (int)`: 
* `Pagination (Pagination)`: 

`rows`は [PrivateMoneyOrganizationSummary](#private-money-organization-summary) オブジェクトの配列を返します。

`pagination`は [Pagination](#pagination) オブジェクトを返します。

<a name="private-money-summary"></a>
## PrivateMoneySummary
* `TopupAmount (double)`: 
* `RefundedTopupAmount (double)`: 
* `PaymentAmount (double)`: 
* `RefundedPaymentAmount (double)`: 
* `AddedPointAmount (double)`: 
* `RefundedAddedPointAmount (double)`: 
* `ExchangeInflowAmount (double)`: 
* `ExchangeOutflowAmount (double)`: 
* `TransactionCount (int)`: 

<a name="paginated-transaction"></a>
## PaginatedTransaction
* `Rows (Transaction[])`: 
* `Count (int)`: 
* `Pagination (Pagination)`: 

`rows`は [Transaction](#transaction) オブジェクトの配列を返します。

`pagination`は [Pagination](#pagination) オブジェクトを返します。

<a name="paginated-transaction-v2"></a>
## PaginatedTransactionV2
* `Rows (Transaction[])`: 
* `PerPage (int)`: 
* `Count (int)`: 
* `NextPageCursorId (string)`: 
* `PrevPageCursorId (string)`: 

`rows`は [Transaction](#transaction) オブジェクトの配列を返します。

<a name="paginated-transfers"></a>
## PaginatedTransfers
* `Rows (Transfer[])`: 
* `Count (int)`: 
* `Pagination (Pagination)`: 

`rows`は [Transfer](#transfer) オブジェクトの配列を返します。

`pagination`は [Pagination](#pagination) オブジェクトを返します。

<a name="paginated-account-with-users"></a>
## PaginatedAccountWithUsers
* `Rows (AccountWithUser[])`: 
* `Count (int)`: 
* `Pagination (Pagination)`: 

`rows`は [AccountWithUser](#account-with-user) オブジェクトの配列を返します。

`pagination`は [Pagination](#pagination) オブジェクトを返します。

<a name="paginated-account-details"></a>
## PaginatedAccountDetails
* `Rows (AccountDetail[])`: 
* `Count (int)`: 
* `Pagination (Pagination)`: 

`rows`は [AccountDetail](#account-detail) オブジェクトの配列を返します。

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

<a name="campaign"></a>
## Campaign
* `Id (string)`: キャンペーンID
* `Name (string)`: キャペーン名
* `ApplicableShops (User[])`: キャンペーン適用対象の店舗リスト
* `IsExclusive (bool)`: キャンペーンの重複を許すかどうかのフラグ
* `StartsAt (string)`: キャンペーン開始日時
* `EndsAt (string)`: キャンペーン終了日時
* `PointExpiresAt (string)`: キャンペーンによって付与されるポイントの失効日時
* `PointExpiresInDays (int)`: キャンペーンによって付与されるポイントの有効期限(相対指定、単位は日)
* `Priority (int)`: キャンペーンの優先順位
* `Description (string)`: キャンペーン説明文
* `BearPointShop (User)`: ポイントを負担する店舗
* `PrivateMoney (PrivateMoney)`: キャンペーンを適用するマネー
* `DestPrivateMoney (PrivateMoney)`: ポイントを付与するマネー
* `PointCalculationRule (string)`: ポイント計算ルール (banklisp表記)
* `PointCalculationRuleObject (string)`: ポイント計算ルール (JSON文字列による表記)
* `Status (string)`: キャンペーンの現在の状態

`applicable-shops`は [User](#user) オブジェクトの配列を返します。

`bear_point_shop`は [User](#user) オブジェクトを返します。

`dest_private_money`と`private_money`は [PrivateMoney](#private-money) オブジェクトを返します。

<a name="paginated-campaigns"></a>
## PaginatedCampaigns
* `Rows (Campaign[])`: 
* `Count (int)`: 
* `Pagination (Pagination)`: 

`rows`は [Campaign](#campaign) オブジェクトの配列を返します。

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
* `DisplayMoneyAndPoint (string)`: 

`organization`は [Organization](#organization) オブジェクトを返します。

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
* `Status (string)`: 
* `PrivateMoney (PrivateMoney)`: 設定マネー情報

`private_money`は [PrivateMoney](#private-money) オブジェクトを返します。

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

<a name="account-without-private-money-detail"></a>
## AccountWithoutPrivateMoneyDetail
* `Id (string)`: 
* `Name (string)`: 
* `IsSuspended (bool)`: 
* `Status (string)`: 
* `PrivateMoneyId (string)`: 
* `User (User)`: 

`user`は [User](#user) オブジェクトを返します。

<a name="organization-summary"></a>
## OrganizationSummary
* `Count (int)`: 
* `MoneyAmount (double)`: 
* `MoneyCount (int)`: 
* `PointAmount (double)`: 
* `PointCount (int)`: 
