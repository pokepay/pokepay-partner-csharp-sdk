# User

<a name="get-user"></a>
## GetUser

```csharp
Request.GetUser request = new Request.GetUser();
Response.AdminUserWithShopsAndPrivateMoneys response = await request.Send(client);
```






成功したときは
[AdminUserWithShopsAndPrivateMoneys](./responses.md#admin-user-with-shops-and-private-moneys)
を返します

### Error Responses
|status|type|ja|en|
|---|---|---|---|
|403|unpermitted_admin_user|この管理ユーザには権限がありません|Admin does not have permission|



---



