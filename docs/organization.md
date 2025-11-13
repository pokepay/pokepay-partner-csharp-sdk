# Organization

<a name="list-organizations"></a>
## ListOrganizations: 加盟店組織の一覧を取得する

```csharp
Request.ListOrganizations request = new Request.ListOrganizations(
    "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx" // マネーID
) {
    Page = 1,  // ページ番号
    PerPage = 50,  // 1ページ分の取引数
    Name = "z0ZAYuH",  // 組織名
    Code = "rS89ga",  // 組織コード
};
Response.PaginatedOrganizations response = await request.Send(client);
```



### Parameters
**`private_money_id`** 
  

マネーIDです。
このマネーに加盟している加盟組織がフィルターされます。

```json
{
  "type": "string",
  "format": "uuid"
}
```

**`page`** 
  

取得したいページ番号です。

```json
{
  "type": "integer",
  "minimum": 1
}
```

**`per_page`** 
  

1ページ分の取引数です。

```json
{
  "type": "integer",
  "minimum": 1
}
```

**`name`** 
  


```json
{
  "type": "string"
}
```

**`code`** 
  


```json
{
  "type": "string"
}
```



成功したときは
[PaginatedOrganizations](./responses.md#paginated-organizations)
を返します

### Error Responses
|status|type|ja|en|
|---|---|---|---|
|400|invalid_parameters|項目が無効です|Invalid parameters|
|403|unpermitted_admin_user|この管理ユーザには権限がありません|Admin does not have permission|
|422|private_money_not_found|マネーが見つかりません|Private money not found|



---


<a name="create-organization"></a>
## CreateOrganization: 新規加盟店組織を追加する

```csharp
Request.CreateOrganization request = new Request.CreateOrganization(
    "ox-supermarket", // 新規組織コード
    "oxスーパー", // 新規組織名
    new string[]{"xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx", "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx", "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx"}, // 加盟店組織で有効にするマネーIDの配列
    "8rAwXpAiqw@Txt1.com", // 発行体担当者メールアドレス
    "HL4wWzmkMD@A4SV.com" // 新規組織担当者メールアドレス
) {
    BankName = "XYZ銀行",  // 銀行名
    BankCode = "1234",  // 銀行金融機関コード
    BankBranchName = "ABC支店",  // 銀行支店名
    BankBranchCode = "123",  // 銀行支店コード
    BankAccountType = "saving",  // 銀行口座種別 (普通=saving, 当座=current, その他=other)
    BankAccount = "1234567",  // 銀行口座番号
    BankAccountHolderName = "ﾌｸｻﾞﾜﾕｷﾁ",  // 口座名義人名
    ContactName = "佐藤清",  // 担当者名
};
Response.Organization response = await request.Send(client);
```



### Parameters
**`code`** 
  


```json
{
  "type": "string",
  "maxLength": 32
}
```

**`name`** 
  


```json
{
  "type": "string",
  "maxLength": 256
}
```

**`private_money_ids`** 
  


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

**`issuer_admin_user_email`** 
  


```json
{
  "type": "string",
  "format": "email"
}
```

**`member_admin_user_email`** 
  


```json
{
  "type": "string",
  "format": "email"
}
```

**`bank_name`** 
  


```json
{
  "type": "string",
  "maxLength": 64
}
```

**`bank_code`** 
  


```json
{
  "type": "string",
  "pattern": "^$|^[0-9]{4}$"
}
```

**`bank_branch_name`** 
  


```json
{
  "type": "string",
  "maxLength": 64
}
```

**`bank_branch_code`** 
  


```json
{
  "type": "string",
  "pattern": "^(|[0-9]{3})$"
}
```

**`bank_account_type`** 
  


```json
{
  "type": "string",
  "enum": [
    "saving",
    "current",
    "other"
  ]
}
```

**`bank_account`** 
  


```json
{
  "type": "string",
  "maxLength": 7,
  "pattern": "[0-9]{0,7}"
}
```

**`bank_account_holder_name`** 
  


```json
{
  "type": "string",
  "maxLength": 30,
  "pattern": "^[0-9A-Zｦｱ-ﾟ (-),-/\\\\｢-｣]$"
}
```

**`contact_name`** 
  


```json
{
  "type": "string",
  "maxLength": 256
}
```



成功したときは
[Organization](./responses.md#organization)
を返します

### Error Responses
|status|type|ja|en|
|---|---|---|---|
|403|NULL|NULL|NULL|
|409|organization_conflict||The organization code is already used|
|409|shop_name_conflict||The shop name is already used|
|422|organization_private_money_not_found||Issuer organization does not have private-money|
|422|unavailable_private_money||Given private money(s) is/are not available|
|503|failed_to_send_email||Failed to send an E-mail.|



---



