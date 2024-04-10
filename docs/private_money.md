# Private Money

<a name="get-private-moneys"></a>
## GetPrivateMoneys: マネー一覧を取得する
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



### Parameters
**`organization_code`** 
  

パートナーキーの管理者が発行体組織に属している場合、発行マネーのうち、この組織コードで指定した決済加盟店組織が加盟しているマネーの一覧を返します。決済加盟店組織の管理者は自組織以外を指定することはできません。

```json
{
  "type": "string",
  "maxLength": 32,
  "pattern": "^[a-zA-Z0-9-]*$"
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



成功したときは
[PaginatedPrivateMoneys](./responses.md#paginated-private-moneys)
を返します

### Error Responses
|status|type|ja|en|
|---|---|---|---|
|403|unpermitted_admin_user|この管理ユーザには権限がありません|Admin does not have permission|
|422|organization_not_found||Organization not found|



---


<a name="get-private-money-organization-summaries"></a>
## GetPrivateMoneyOrganizationSummaries: 決済加盟店の取引サマリを取得する

```csharp
Request.GetPrivateMoneyOrganizationSummaries request = new Request.GetPrivateMoneyOrganizationSummaries(
    "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx" // マネーID
) {
    From = "2020-09-01T07:38:37.000000Z",  // 開始日時(toと同時に指定する必要有)
    To = "2024-03-21T02:25:01.000000Z",  // 終了日時(fromと同時に指定する必要有)
    Page = 1,  // ページ番号
    PerPage = 50,  // 1ページ分の取引数
};
Response.PaginatedPrivateMoneyOrganizationSummaries response = await request.Send(client);
```

`from`と`to`は同時に指定する必要があります。


### Parameters
**`private_money_id`** 
  


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



成功したときは
[PaginatedPrivateMoneyOrganizationSummaries](./responses.md#paginated-private-money-organization-summaries)
を返します



---


<a name="get-private-money-summary"></a>
## GetPrivateMoneySummary: 取引サマリを取得する

```csharp
Request.GetPrivateMoneySummary request = new Request.GetPrivateMoneySummary(
    "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx" // マネーID
) {
    From = "2023-10-27T19:24:09.000000Z",  // 開始日時
    To = "2020-01-28T06:46:15.000000Z",  // 終了日時
};
Response.PrivateMoneySummary response = await request.Send(client);
```



### Parameters
**`private_money_id`** 
  


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



成功したときは
[PrivateMoneySummary](./responses.md#private-money-summary)
を返します



---



