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

### Transaction
- [GetCpmToken](./transaction.md#get-cpm-token): CPMトークンの状態取得
- [ListTransactions](./transaction.md#list-transactions): 【廃止】取引履歴を取得する
- [CreateTransaction](./transaction.md#create-transaction): 【廃止】チャージする
- [ListTransactionsV2](./transaction.md#list-transactions-v2): 取引履歴を取得する
- [CreateTopupTransaction](./transaction.md#create-topup-transaction): チャージする
- [CreatePaymentTransaction](./transaction.md#create-payment-transaction): 支払いする
- [CreateCpmTransaction](./transaction.md#create-cpm-transaction): CPMトークンによる取引作成
- [CreateTransferTransaction](./transaction.md#create-transfer-transaction): 個人間送金
- [CreateExchangeTransaction](./transaction.md#create-exchange-transaction): 
- [GetTransaction](./transaction.md#get-transaction): 取引情報を取得する
- [RefundTransaction](./transaction.md#refund-transaction): 取引をキャンセルする
- [GetTransactionByRequestId](./transaction.md#get-transaction-by-request-id): リクエストIDから取引情報を取得する
- [GetBulkTransaction](./transaction.md#get-bulk-transaction): バルク取引ジョブの実行状況を取得する
- [ListBulkTransactionJobs](./transaction.md#list-bulk-transaction-jobs): バルク取引ジョブの詳細情報一覧を取得する
- [RequestUserStats](./transaction.md#request-user-stats): 指定期間内の顧客が行った取引の統計情報をCSVでダウンロードする

### Transfer
- [GetAccountTransferSummary](./transfer.md#get-account-transfer-summary): 
- [ListTransfers](./transfer.md#list-transfers): 
- [ListTransfersV2](./transfer.md#list-transfers-v2): 

### Check
- [CreateCheck](./check.md#create-check): チャージQRコードの発行
- [ListChecks](./check.md#list-checks): チャージQRコード一覧の取得
- [GetCheck](./check.md#get-check): チャージQRコードの表示
- [UpdateCheck](./check.md#update-check): チャージQRコードの更新
- [CreateTopupTransactionWithCheck](./check.md#create-topup-transaction-with-check): チャージQRコードを読み取ることでチャージする

### Bill
- [ListBills](./bill.md#list-bills): 支払いQRコード一覧を表示する
- [CreateBill](./bill.md#create-bill): 支払いQRコードの発行
- [UpdateBill](./bill.md#update-bill): 支払いQRコードの更新

### Cashtray
- [CreateCashtray](./cashtray.md#create-cashtray): Cashtrayを作る
- [GetCashtray](./cashtray.md#get-cashtray): Cashtrayの情報を取得する
- [CancelCashtray](./cashtray.md#cancel-cashtray): Cashtrayを無効化する
- [UpdateCashtray](./cashtray.md#update-cashtray): Cashtrayの情報を更新する

### Customer
- [GetAccount](./customer.md#get-account): ウォレット情報を表示する
- [UpdateAccount](./customer.md#update-account): ウォレット情報を更新する
- [DeleteAccount](./customer.md#delete-account): ウォレットを退会する
- [ListAccountBalances](./customer.md#list-account-balances): エンドユーザーの残高内訳を表示する
- [ListAccountExpiredBalances](./customer.md#list-account-expired-balances): エンドユーザーの失効済みの残高内訳を表示する
- [UpdateCustomerAccount](./customer.md#update-customer-account): エンドユーザーのウォレット情報を更新する
- [GetCustomerAccounts](./customer.md#get-customer-accounts): エンドユーザーのウォレット一覧を表示する
- [CreateCustomerAccount](./customer.md#create-customer-account): 新規エンドユーザーをウォレットと共に追加する
- [GetShopAccounts](./customer.md#get-shop-accounts): 店舗ユーザーのウォレット一覧を表示する
- [ListCustomerTransactions](./customer.md#list-customer-transactions): 取引履歴を取得する

### Organization
- [ListOrganizations](./organization.md#list-organizations): 加盟店組織の一覧を取得する
- [CreateOrganization](./organization.md#create-organization): 新規加盟店組織を追加する

### Shop
- [ListShops](./shop.md#list-shops): 店舗一覧を取得する
- [CreateShop](./shop.md#create-shop): 【廃止】新規店舗を追加する
- [CreateShopV2](./shop.md#create-shop-v2): 新規店舗を追加する
- [GetShop](./shop.md#get-shop): 店舗情報を表示する
- [UpdateShop](./shop.md#update-shop): 店舗情報を更新する

### User
- [GetUser](./user.md#get-user): 

### Account
- [ListUserAccounts](./account.md#list-user-accounts): エンドユーザー、店舗ユーザーのウォレット一覧を表示する
- [CreateUserAccount](./account.md#create-user-account): エンドユーザーのウォレットを作成する

### Private Money
- [GetPrivateMoneys](./private_money.md#get-private-moneys): マネー一覧を取得する
- [GetPrivateMoneyOrganizationSummaries](./private_money.md#get-private-money-organization-summaries): 決済加盟店の取引サマリを取得する
- [GetPrivateMoneySummary](./private_money.md#get-private-money-summary): 取引サマリを取得する

### Bulk
- [BulkCreateTransaction](./bulk.md#bulk-create-transaction): CSVファイル一括取引

### Event
- [CreateExternalTransaction](./event.md#create-external-transaction): ポケペイ外部取引を作成する
- [RefundExternalTransaction](./event.md#refund-external-transaction): ポケペイ外部取引をキャンセルする

### Campaign
- [CreateCampaign](./campaign.md#create-campaign): ポイント付与キャンペーンを作る
- [ListCampaigns](./campaign.md#list-campaigns): キャンペーン一覧を取得する
- [GetCampaign](./campaign.md#get-campaign): キャンペーンを取得する
- [UpdateCampaign](./campaign.md#update-campaign): ポイント付与キャンペーンを更新する

### Webhook
- [CreateWebhook](./webhook.md#create-webhook): webhookの作成
- [ListWebhooks](./webhook.md#list-webhooks): 作成したWebhookの一覧を返す
- [UpdateWebhook](./webhook.md#update-webhook): Webhookの更新
- [DeleteWebhook](./webhook.md#delete-webhook): Webhookの削除

### Coupon
- [ListCoupons](./coupon.md#list-coupons): クーポン一覧の取得
- [CreateCoupon](./coupon.md#create-coupon): クーポンの登録
- [GetCoupon](./coupon.md#get-coupon): クーポンの取得
- [UpdateCoupon](./coupon.md#update-coupon): クーポンの更新

### UserDevice
- [CreateUserDevice](./user_device.md#create-user-device): ユーザーのデバイス登録
- [GetUserDevice](./user_device.md#get-user-device): ユーザーのデバイスを取得
- [ActivateUserDevice](./user_device.md#activate-user-device): デバイスの有効化

### BankPay
- [CreateBank](./bank_pay.md#create-bank): 銀行口座の登録
- [ListBanks](./bank_pay.md#list-banks): 登録した銀行の一覧
- [CreateBankTopupTransaction](./bank_pay.md#create-bank-topup-transaction): 銀行からのチャージ

