# BankPay
BankPayを用いた銀行からのチャージ取引などのAPIを提供しています。


<a name="list-banks"></a>
## ListBanks: 登録した銀行の一覧
登録した銀行を一覧します

```csharp
Request.ListBanks request = new Request.ListBanks(
    "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx" // デバイスID
) {
    PrivateMoneyId = "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx",
};
Response.Banks response = await request.Send(client);
```



### Parameters
**`user_device_id`** 
  


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



成功したときは
[Banks](./responses.md#banks)
を返します



---


<a name="create-bank"></a>
## CreateBank: 銀行口座の登録
銀行口座の登録を始めるAPIです。レスポンスに含まれるredirect_urlをユーザーの端末で開き銀行を登録します。

ユーザーが銀行口座の登録に成功すると、callback_urlにリクエストが行われます。
アプリの場合はDeep Linkを使うことを想定しています。


```csharp
Request.CreateBank request = new Request.CreateBank(
    "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx", // デバイスID
    "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx", // マネーID
    "<Deep Link>", // コールバックURL
    "ポケペイタロウ" // ユーザーの氏名 (片仮名で指定)
) {
    Email = "EeKe2EnvF9@kW30.com",  // ユーザーのメールアドレス
    Birthdate = "19901142",  // 生年月日
};
Response.BankRegisteringInfo response = await request.Send(client);
```



### Parameters
**`user_device_id`** 
  


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

**`callback_url`** 
  


```json
{
  "type": "string",
  "maxLength": 256
}
```

**`kana`** 
  


```json
{
  "type": "string",
  "maxLength": 30
}
```

**`email`** 
  


```json
{
  "type": "string",
  "format": "email",
  "maxLength": 300
}
```

**`birthdate`** 
  


```json
{
  "type": "string",
  "maxLength": 8
}
```



成功したときは
[BankRegisteringInfo](./responses.md#bank-registering-info)
を返します



---


<a name="create-bank-topup-transaction"></a>
## CreateBankTopupTransaction: 銀行からのチャージ
指定のマネーのアカウントにbank_idの口座を用いてチャージを行います。

```csharp
Request.CreateBankTopupTransaction request = new Request.CreateBankTopupTransaction(
    "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx", // デバイスID
    "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx", // マネーID
    2810, // チャージ金額
    "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx", // 銀行ID
    "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx" // リクエストID
);
Response.TransactionDetail response = await request.Send(client);
```



### Parameters
**`user_device_id`** 
  


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

**`amount`** 
  


```json
{
  "type": "integer",
  "minimum": 1
}
```

**`bank_id`** 
  


```json
{
  "type": "string",
  "format": "uuid"
}
```

**`request_id`** 
  


```json
{
  "type": "string",
  "format": "uuid"
}
```



成功したときは
[TransactionDetail](./responses.md#transaction-detail)
を返します



---



