# Transfer

<a name="get-account-transfer-summary"></a>
## GetAccountTransferSummary: 
ウォレットを指定して取引明細種別毎の集計を返す

```csharp
Request.GetAccountTransferSummary request = new Request.GetAccountTransferSummary(
    "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx" // ウォレットID
) {
    From = "2020-11-04T16:34:17.000000Z",  // 集計期間の開始時刻
    To = "2021-03-23T02:43:19.000000Z",  // 集計期間の終了時刻
    TransferTypes = new string[]{"topup", "payment"},  // 取引明細種別 (複数指定可)
};
Response.AccountTransferSummary response = await request.Send(client);
```



### Parameters
**`account_id`** 
  

ウォレットIDです。

ここで指定したウォレットIDの取引明細レベルでの集計を取得します。

```json
{
  "type": "string",
  "format": "uuid"
}
```

**`from`** 
  


```json
{
  "type": "string",
  "format": "date-time"
}
```

**`to`** 
  


```json
{
  "type": "string",
  "format": "date-time"
}
```

**`transfer_types`** 
  

取引明細の種別でフィルターします。
以下の種別を指定できます。

- payment
  エンドユーザーから店舗への送金取引(支払い取引)
- topup
  店舗からエンドユーザーへの送金取引(チャージ取引)
- campaign-topup
  キャンペーンによるエンドユーザーへのポイント付与取引(ポイントチャージ)
- use-coupon
  支払い時のクーポン使用による値引き取引
- refund-payment
  支払い取引に対するキャンセル取引
- refund-topup
  チャージ取引に対するキャンセル取引
- refund-campaign
  キャンペーンによるポイント付与取引に対するキャンセル取引
- refund-coupon
  クーポン使用による値引き取引に対するキャンセル取引
- exchange-inflow
  交換による他マネーからの流入取引
- exchange-outflow
  交換による他マネーへの流出取引
- refund-exchange-inflow
  交換による他マネーからの流入取引に対するキャンセル取引
- refund-exchange-outflow
  交換による他マネーへの流出取引に対するキャンセル取引

```json
{
  "type": "array",
  "items": {
    "type": "string",
    "enum": [
      "payment",
      "topup",
      "campaign-topup",
      "use-coupon",
      "refund-payment",
      "refund-topup",
      "refund-campaign",
      "refund-coupon",
      "exchange-inflow",
      "exchange-outflow",
      "refund-exchange-inflow",
      "refund-exchange-outflow"
    ]
  }
}
```



成功したときは
[AccountTransferSummary](./responses.md#account-transfer-summary)
を返します



---


<a name="list-transfers"></a>
## ListTransfers

```csharp
Request.ListTransfers request = new Request.ListTransfers() {
    From = "2024-03-12T16:53:53.000000Z",
    To = "2022-04-14T08:54:52.000000Z",
    Page = 6738,
    PerPage = 8532,
    ShopId = "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx",
    ShopName = "aMM6DcJjfAtdrmKAg3KBKDu0vlbYdVC6n9nVLo43cE33CQPF6kxIlI0uguDnziraNYM7VX",
    CustomerId = "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx",
    CustomerName = "YLnlD8HOOCDlP4GZ7jbmXMO5zVMwfk3fyCehTHNb57OPgysrQCIrNbKg5EGtS1CRG8HTOfVnvp3qGXZFBsOSpPHbliv7UIdhUMzObVJcG5btiH5rur7GsubMGTjIcOXKD9o8Kba3zToGBURahT5P9DvE8UV0j2YqC15yVJZpc8KVpHARBDgg1G",
    TransactionId = "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx",
    PrivateMoneyId = "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx",
    IsModified = true,
    TransactionTypes = new string[]{"exchange"},
    TransferTypes = new string[]{"expire", "topup"},  // 取引明細の種類でフィルターします。
    Description = "店頭QRコードによる支払い",  // 取引詳細説明文
};
Response.PaginatedTransfers response = await request.Send(client);
```



### Parameters
**`from`** 
  


```json
{
  "type": "string",
  "format": "date-time"
}
```

**`to`** 
  


```json
{
  "type": "string",
  "format": "date-time"
}
```

**`page`** 
  


```json
{
  "type": "integer",
  "minimum": 1
}
```

**`per_page`** 
  


```json
{
  "type": "integer",
  "minimum": 1
}
```

**`shop_id`** 
  


```json
{
  "type": "string",
  "format": "uuid"
}
```

**`shop_name`** 
  


```json
{
  "type": "string",
  "maxLength": 256
}
```

**`customer_id`** 
  


```json
{
  "type": "string",
  "format": "uuid"
}
```

**`customer_name`** 
  


```json
{
  "type": "string",
  "maxLength": 256
}
```

**`transaction_id`** 
  


```json
{
  "type": "string",
  "format": "uuid"
}
```

**`private_money_id`** 
  


```json
{
  "type": "string",
  "format": "uuid"
}
```

**`is_modified`** 
  


```json
{
  "type": "boolean"
}
```

**`transaction_types`** 
  


```json
{
  "type": "array",
  "items": {
    "type": "string",
    "enum": [
      "topup",
      "payment",
      "transfer",
      "exchange",
      "cashback",
      "expire"
    ]
  }
}
```

**`transfer_types`** 
  

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

```json
{
  "type": "array",
  "items": {
    "type": "string",
    "enum": [
      "topup",
      "payment",
      "exchange",
      "transfer",
      "coupon",
      "campaign",
      "cashback",
      "expire"
    ]
  }
}
```

**`description`** 
  

取引詳細を指定の取引詳細説明文でフィルターします。

取引詳細説明文が完全一致する取引のみ抽出されます。取引詳細説明文は最大200文字で記録されています。

```json
{
  "type": "string",
  "maxLength": 200
}
```



成功したときは
[PaginatedTransfers](./responses.md#paginated-transfers)
を返します

### Error Responses
|status|type|ja|en|
|---|---|---|---|
|403|NULL|NULL|NULL|



---


<a name="list-transfers-v2"></a>
## ListTransfersV2

```csharp
Request.ListTransfersV2 request = new Request.ListTransfersV2() {
    ShopId = "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx",  // 店舗ID
    ShopName = "vS6JUWIFuWHifSCeHqDX4OovF1kPsfFAfUD6hedBMnO5c5siBhPS0PdEUgltcrxJuLRpPyEyLzg5USUF0acnAYj9bCB7rUqwv3jfmweeo8gmjkrVbM4yoFbYRleO",  // 店舗名
    CustomerId = "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx",  // エンドユーザーID
    CustomerName = "9KOkq0RFzjJHwRArvOU8komJ1Atk5RVlui7mGRMrDuzhgMwi2QEwxvEfxvbfoaYN92mmS964bSnGq9n7PpIOomMWW66P3IlH0kXmsTM",  // エンドユーザー名
    TransactionId = "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx",  // 取引ID
    PrivateMoneyId = "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx",  // マネーID
    IsModified = true,  // キャンセルフラグ
    TransactionTypes = new string[]{"expire", "topup", "transfer", "exchange", "payment"},  // 取引種別 (複数指定可)、チャージ=topup、支払い=payment
    NextPageCursorId = "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx",  // 次ページへ遷移する際に起点となるtransferのID
    PrevPageCursorId = "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx",  // 前ページへ遷移する際に起点となるtransferのID
    PerPage = 50,  // 1ページ分の取引数
    TransferTypes = new string[]{"expire"},  // 取引明細種別 (複数指定可)
    Description = "店頭QRコードによる支払い",  // 取引詳細説明文
    From = "2023-04-20T11:19:57.000000Z",  // 開始日時
    To = "2023-07-26T09:32:54.000000Z",  // 終了日時
};
Response.PaginatedTransfersV2 response = await request.Send(client);
```



### Parameters
**`shop_id`** 
  

店舗IDです。

フィルターとして使われ、指定された店舗での取引のみ一覧に表示されます。

```json
{
  "type": "string",
  "format": "uuid"
}
```

**`shop_name`** 
  

店舗名です。

フィルターとして使われ、入力された名前に部分一致する店舗での取引のみ一覧に表示されます。

```json
{
  "type": "string",
  "maxLength": 256
}
```

**`customer_id`** 
  

エンドユーザーIDです。

フィルターとして使われ、指定されたエンドユーザーの取引のみ一覧に表示されます。

```json
{
  "type": "string",
  "format": "uuid"
}
```

**`customer_name`** 
  

エンドユーザー名です。

フィルターとして使われ、入力された名前に部分一致するエンドユーザーでの取引のみ一覧に表示されます。

```json
{
  "type": "string",
  "maxLength": 256
}
```

**`transaction_id`** 
  

取引IDです。

フィルターとして使われ、指定された取引IDに部分一致(前方一致)する取引のみが一覧に表示されます。

```json
{
  "type": "string",
  "format": "uuid"
}
```

**`private_money_id`** 
  

マネーIDです。

指定したマネーでの取引が一覧に表示されます。

```json
{
  "type": "string",
  "format": "uuid"
}
```

**`is_modified`** 
  

キャンセルフラグです。

これにtrueを指定するとキャンセルされた取引のみ一覧に表示されます。
デフォルト値はfalseで、キャンセルの有無にかかわらず一覧に表示されます。

```json
{
  "type": "boolean"
}
```

**`transaction_types`** 
  

取引の種類でフィルターします。

以下の種類を指定できます。

1. topup
   店舗からエンドユーザーへの送金取引(チャージ)

2. payment
   エンドユーザーから店舗への送金取引(支払い)

3. exchange-outflow
   他マネーへの流出
   private_money_idが指定されたとき、そのマネーから見て流出方向の交換取引が抽出されます。
   private_money_idを省略した場合は表示されません。

4. exchange-inflow
   他マネーからの流入
   private_money_idが指定されたとき、そのマネーから見て流入方向の交換取引が抽出されます。
   private_money_idを省略した場合は表示されません。

5. cashback
   退会時返金取引

6. expire
   退会時失効取引

```json
{
  "type": "array",
  "items": {
    "type": "string",
    "enum": [
      "topup",
      "payment",
      "transfer",
      "exchange",
      "cashback",
      "expire"
    ]
  }
}
```

**`next_page_cursor_id`** 
  

次ページへ遷移する際に起点となるtransferのID(前ページの末尾要素のID)です。
本APIのレスポンスにもnext_page_cursor_idが含まれており、これがnull値の場合は最後のページであることを意味します。
UUIDである場合は次のページが存在することを意味し、このnext_page_cursor_idをリクエストパラメータに含めることで次ページに遷移します。

next_page_cursor_idのtransfer自体は次のページには含まれません。

```json
{
  "type": "string",
  "format": "uuid"
}
```

**`prev_page_cursor_id`** 
  

前ページへ遷移する際に起点となるtransferのID(次ページの先頭要素のID)です。

本APIのレスポンスにもprev_page_cursor_idが含まれており、これがnull値の場合は先頭のページであることを意味します。
UUIDである場合は前のページが存在することを意味し、このprev_page_cursor_idをリクエストパラメータに含めることで前ページに遷移します。

prev_page_cursor_idのtransfer自体は前のページには含まれません。

```json
{
  "type": "string",
  "format": "uuid"
}
```

**`per_page`** 
  

1ページ分の取引数です。

デフォルト値は50です。

```json
{
  "type": "integer",
  "minimum": 1,
  "maximum": 1000
}
```

**`transfer_types`** 
  

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

```json
{
  "type": "array",
  "items": {
    "type": "string",
    "enum": [
      "topup",
      "payment",
      "exchange",
      "transfer",
      "coupon",
      "campaign",
      "cashback",
      "expire"
    ]
  }
}
```

**`description`** 
  

取引詳細を指定の取引詳細説明文でフィルターします。

取引詳細説明文が完全一致する取引のみ抽出されます。取引詳細説明文は最大200文字で記録されています。

```json
{
  "type": "string",
  "maxLength": 200
}
```

**`from`** 
  

抽出期間の開始日時です。

フィルターとして使われ、開始日時以降に発生した取引のみ一覧に表示されます。

```json
{
  "type": "string",
  "format": "date-time"
}
```

**`to`** 
  

抽出期間の終了日時です。

フィルターとして使われ、終了日時以前に発生した取引のみ一覧に表示されます。

```json
{
  "type": "string",
  "format": "date-time"
}
```



成功したときは
[PaginatedTransfersV2](./responses.md#paginated-transfers-v2)
を返します

### Error Responses
|status|type|ja|en|
|---|---|---|---|
|403|unpermitted_admin_user|この管理ユーザには権限がありません|Admin does not have permission|



---



