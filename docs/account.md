# Account

<a name="list-user-accounts"></a>
## ListUserAccounts: エンドユーザー、店舗ユーザーのウォレット一覧を表示する
ユーザーIDを指定してそのユーザーのウォレット一覧を取得します。

```csharp
Request.ListUserAccounts request = new Request.ListUserAccounts(
    "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx" // ユーザーID
) {
    Page = 1301,  // ページ番号
    PerPage = 5987,  // 1ページ分の取引数
};
Response.PaginatedAccountDetails response = await request.Send(client);
```



### Parameters
**`user_id`** 
  

ユーザーIDです。

指定したユーザーIDのウォレット一覧を取得します。パートナーキーと紐づく組織が発行しているマネーのウォレットのみが表示されます。

```json
{
  "type": "string",
  "format": "uuid"
}
```

**`page`** 
  

取得したいページ番号です。デフォルト値は1です。

```json
{
  "type": "integer",
  "minimum": 1
}
```

**`per_page`** 
  

1ページ当たりのウォレット数です。デフォルト値は50です。

```json
{
  "type": "integer",
  "minimum": 1
}
```



成功したときは
[PaginatedAccountDetails](./responses.md#paginated-account-details)
を返します



---


<a name="create-user-account"></a>
## CreateUserAccount: エンドユーザーのウォレットを作成する
既存のエンドユーザーに対して、指定したマネーのウォレットを新規作成します

```csharp
Request.CreateUserAccount request = new Request.CreateUserAccount(
    "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx", // ユーザーID
    "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx" // マネーID
) {
    Name = "MxYByLz0xsJRhRVsB9HjzBAZfWzO75yHWR5FLMa9CO3GmqQepv7doxpRjgZI2VSDvLJkkZMMdEANfWVavAje3PJg4zkA5dwRQrAEDCEBzCTk0pNAGkxkj3y6QjLE9oTv9S3Zg4O5dK9OBTn3gY0HIwJr5Xn6R9PIw5eC52tvIBnMyMg4CnT2dj7ORUTt4jEgn4792da7QYy7V605lzcBixerwgOsZo2yFQXiifPwyEPkMTjwK",  // ウォレット名
    ExternalId = "UmBamQcUvvHD25XYGaGoRmlkWpVKSQYACWhdJgT5oXIA",  // 外部ID
    Metadata = "{\"key1\":\"foo\",\"key2\":\"bar\"}",  // ウォレットに付加するメタデータ
};
Response.AccountDetail response = await request.Send(client);
```



### Parameters
**`user_id`** 
  

ユーザーIDです。

```json
{
  "type": "string",
  "format": "uuid"
}
```

**`private_money_id`** 
  

マネーIDです。

作成するウォレットのマネーを指定します。このパラメータは必須です。

```json
{
  "type": "string",
  "format": "uuid"
}
```

**`name`** 
  


```json
{
  "type": "string",
  "maxLength": 256
}
```

**`external_id`** 
  


```json
{
  "type": "string",
  "maxLength": 50
}
```

**`metadata`** 
  

ウォレットに付加するメタデータをJSON文字列で指定します。
指定できるJSON文字列には以下のような制約があります。
- フラットな構造のJSONを文字列化したものであること。
- keyは最大32文字の文字列(同じkeyを複数指定することはできません)
- valueには128文字以下の文字列が指定できます

```json
{
  "type": "string",
  "format": "json"
}
```



成功したときは
[AccountDetail](./responses.md#account-detail)
を返します



---



