# Coupon
Couponは支払い時に指定し、支払い処理の前にCouponに指定の方法で値引き処理を行います。
Couponは特定店舗で利用できるものや利用可能期間、配信条件などを設定できます。


<a name="list-coupons"></a>
## ListCoupons: クーポン一覧の取得
指定したマネーのクーポン一覧を取得します

```csharp
Request.ListCoupons request = new Request.ListCoupons(
    "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx" // 対象クーポンのマネーID
) {
    CouponId = "W1kAzyAHjk",  // クーポンID
    CouponName = "W0eFslSf",  // クーポン名
    IssuedShopName = "8NaBT",  // 発行店舗名
    AvailableShopName = "yV6",  // 利用可能店舗名
    AvailableFrom = "2023-09-25T19:13:11.000000Z",  // 利用可能期間 (開始日時)
    AvailableTo = "2022-09-08T11:40:05.000000Z",  // 利用可能期間 (終了日時)
    Page = 1,  // ページ番号
    PerPage = 50,  // 1ページ分の取得数
};
Response.PaginatedCoupons response = await request.Send(client);
```



### Parameters
**`private_money_id`** 
  

対象クーポンのマネーIDです(必須項目)。
存在しないマネーIDを指定した場合はprivate_money_not_foundエラー(422)が返ります。


```json
{
  "type": "string",
  "format": "uuid"
}
```

**`coupon_id`** 
  

指定されたクーポンIDで結果をフィルターします。
部分一致(前方一致)します。


```json
{
  "type": "string"
}
```

**`coupon_name`** 
  

指定されたクーポン名で結果をフィルターします。


```json
{
  "type": "string"
}
```

**`issued_shop_name`** 
  

指定された発行店舗で結果をフィルターします。


```json
{
  "type": "string"
}
```

**`available_shop_name`** 
  

指定された利用可能店舗で結果をフィルターします。


```json
{
  "type": "string"
}
```

**`available_from`** 
  

利用可能期間でフィルターします。フィルターの開始日時をISO8601形式で指定します。


```json
{
  "type": "string",
  "format": "date-time"
}
```

**`available_to`** 
  

利用可能期間でフィルターします。フィルターの終了日時をISO8601形式で指定します。


```json
{
  "type": "string",
  "format": "date-time"
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
  

1ページ分の取得数です。デフォルトでは 50 になっています。

```json
{
  "type": "integer",
  "minimum": 1
}
```



成功したときは
[PaginatedCoupons](./responses.md#paginated-coupons)
を返します

### Error Responses
|status|type|ja|en|
|---|---|---|---|
|403|unpermitted_admin_user|この管理ユーザには権限がありません|Admin does not have permission|
|422|shop_user_not_found|店舗が見つかりません|The shop user is not found|
|422|private_money_not_found|マネーが見つかりません|Private money not found|



---


<a name="create-coupon"></a>
## CreateCoupon: クーポンの登録
新しいクーポンを登録します

```csharp
Request.CreateCoupon request = new Request.CreateCoupon(
    "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx",
    "T8tDHI0zWcr0sMpkdiHOOwl5xIQi",
    "2022-09-20T21:42:21.000000Z",
    "2020-11-14T09:59:36.000000Z",
    "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx" // 発行元の店舗ID
) {
    Description = "P4UplfuFUQK5yc0JqyEbk4xV1ElwOVpwOgCs3REJLXlOpH9qH3TntlxmPSv0sqeMHV",
    DiscountAmount = 1318,
    DiscountPercentage = 2149.0,
    DiscountUpperLimit = 3966,
    DisplayStartsAt = "2020-04-02T12:24:32.000000Z",  // クーポンの掲載期間(開始日時)
    DisplayEndsAt = "2021-09-05T12:11:50.000000Z",  // クーポンの掲載期間(終了日時)
    IsDisabled = true,  // 無効化フラグ
    IsHidden = false,  // クーポン一覧に掲載されるかどうか
    IsPublic = true,  // アプリ配信なしで受け取れるかどうか
    Code = "nQaE",  // クーポン受け取りコード
    UsageLimit = 1501,  // ユーザごとの利用可能回数(NULLの場合は無制限)
    MinAmount = 3692,  // クーポン適用可能な最小取引額
    IsShopSpecified = false,  // 特定店舗限定のクーポンかどうか
    AvailableShopIds = new string[]{"xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx", "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx"},  // 利用可能店舗リスト
    StorageId = "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx",  // ストレージID
};
Response.CouponDetail response = await request.Send(client);
```

`is_shop_specified`と`available_shop_ids`は同時に指定する必要があります。


### Parameters
**`private_money_id`** 
  


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
  "maxLength": 128
}
```

**`description`** 
  


```json
{
  "type": "string",
  "maxLength": 256
}
```

**`discount_amount`** 
  


```json
{
  "type": "integer",
  "minimum": 0
}
```

**`discount_percentage`** 
  


```json
{
  "type": "number",
  "minimum": 0
}
```

**`discount_upper_limit`** 
  


```json
{
  "type": "integer",
  "minimum": 0
}
```

**`starts_at`** 
  


```json
{
  "type": "string",
  "format": "date-time"
}
```

**`ends_at`** 
  


```json
{
  "type": "string",
  "format": "date-time"
}
```

**`display_starts_at`** 
  


```json
{
  "type": "string",
  "format": "date-time"
}
```

**`display_ends_at`** 
  


```json
{
  "type": "string",
  "format": "date-time"
}
```

**`is_disabled`** 
  


```json
{
  "type": "boolean"
}
```

**`is_hidden`** 
  

アプリに表示されるクーポン一覧に掲載されるかどうか。
主に一時的に掲載から外したいときに用いられる。そのためis_publicの設定よりも優先される。


```json
{
  "type": "boolean"
}
```

**`is_public`** 
  


```json
{
  "type": "boolean"
}
```

**`code`** 
  


```json
{
  "type": "string"
}
```

**`usage_limit`** 
  


```json
{
  "type": "integer"
}
```

**`min_amount`** 
  


```json
{
  "type": "integer"
}
```

**`issued_shop_id`** 
  


```json
{
  "type": "string",
  "format": "uuid"
}
```

**`is_shop_specified`** 
  


```json
{
  "type": "boolean"
}
```

**`available_shop_ids`** 
  


```json
{
  "type": "array",
  "items": {
    "type": "string",
    "format": "uuid"
  }
}
```

**`storage_id`** 
  

Storage APIでアップロードしたクーポン画像のStorage IDを指定します

```json
{
  "type": "string",
  "format": "uuid"
}
```



成功したときは
[CouponDetail](./responses.md#coupon-detail)
を返します

### Error Responses
|status|type|ja|en|
|---|---|---|---|
|400|invalid_parameters|項目が無効です|Invalid parameters|
|403|unpermitted_admin_user|この管理ユーザには権限がありません|Admin does not have permission|
|404|partner_storage_not_found|指定したIDのデータは保存されていません|Not found by storage_id|
|422|shop_user_not_found|店舗が見つかりません|The shop user is not found|
|422|private_money_not_found|マネーが見つかりません|Private money not found|
|422|coupon_image_storage_conflict|クーポン画像のストレージIDは既に存在します|The coupon image storage_id is already exists|



---


<a name="get-coupon"></a>
## GetCoupon: クーポンの取得
指定したIDを持つクーポンを取得します

```csharp
Request.GetCoupon request = new Request.GetCoupon(
    "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx" // クーポンID
);
Response.CouponDetail response = await request.Send(client);
```



### Parameters
**`coupon_id`** 
  

取得するクーポンのIDです。
UUIDv4フォーマットである必要があり、フォーマットが異なる場合は InvalidParametersエラー(400)が返ります。
指定したIDのクーポンが存在しない場合はCouponNotFoundエラー(422)が返ります。

```json
{
  "type": "string",
  "format": "uuid"
}
```



成功したときは
[CouponDetail](./responses.md#coupon-detail)
を返します



---


<a name="update-coupon"></a>
## UpdateCoupon: クーポンの更新
指定したクーポンを更新します

```csharp
Request.UpdateCoupon request = new Request.UpdateCoupon(
    "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx" // クーポンID
) {
    Name = "3S7TMyfZKpPybiZ1Lwce18e7Eq5OqWuTabdRaaHOyfGqVUncXzhjskeGyZxmbEy050Zlv3tzVr8aTPDqMKbxS0Vs3OlIrdnx7rU9Fte9Z959oBy13",
    Description = "mtel3d8TfJ3Ol39ScasZnA58jo0hnztlMdM7BVfn4iFYyJJXfrDUn2Z5dTBMhYMOaLFSQqsldJHk3l4cpZ7fJl29A3O6y0fQnXOgwkIth5yMWiTVYzb9YasuIp7v4EzACicWq4Ul0bBBFnJwjrPufrwL5Z4qM5cyeftMbZhJuNs",
    DiscountAmount = 8945,
    DiscountPercentage = 8795.0,
    DiscountUpperLimit = 5157,
    StartsAt = "2022-10-17T22:23:23.000000Z",
    EndsAt = "2020-08-08T19:18:46.000000Z",
    DisplayStartsAt = "2023-12-30T17:09:42.000000Z",  // クーポンの掲載期間(開始日時)
    DisplayEndsAt = "2020-01-16T22:52:49.000000Z",  // クーポンの掲載期間(終了日時)
    IsDisabled = false,  // 無効化フラグ
    IsHidden = true,  // クーポン一覧に掲載されるかどうか
    IsPublic = false,  // アプリ配信なしで受け取れるかどうか
    Code = "KQ",  // クーポン受け取りコード
    UsageLimit = 4056,  // ユーザごとの利用可能回数(NULLの場合は無制限)
    MinAmount = 3101,  // クーポン適用可能な最小取引額
    IsShopSpecified = true,  // 特定店舗限定のクーポンかどうか
    AvailableShopIds = new string[]{"xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx"},  // 利用可能店舗リスト
    StorageId = "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx",  // ストレージID
};
Response.CouponDetail response = await request.Send(client);
```


`discount_amount`と`discount_percentage`の少なくとも一方は指定する必要があります。



### Parameters
**`coupon_id`** 
  


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
  "maxLength": 128
}
```

**`description`** 
  


```json
{
  "type": "string",
  "maxLength": 256
}
```

**`discount_amount`** 
  


```json
{
  "type": "integer",
  "minimum": 0
}
```

**`discount_percentage`** 
  


```json
{
  "type": "number",
  "minimum": 0
}
```

**`discount_upper_limit`** 
  


```json
{
  "type": "integer",
  "minimum": 0
}
```

**`starts_at`** 
  


```json
{
  "type": "string",
  "format": "date-time"
}
```

**`ends_at`** 
  


```json
{
  "type": "string",
  "format": "date-time"
}
```

**`display_starts_at`** 
  


```json
{
  "type": "string",
  "format": "date-time"
}
```

**`display_ends_at`** 
  


```json
{
  "type": "string",
  "format": "date-time"
}
```

**`is_disabled`** 
  


```json
{
  "type": "boolean"
}
```

**`is_hidden`** 
  

アプリに表示されるクーポン一覧に掲載されるかどうか。
主に一時的に掲載から外したいときに用いられる。そのためis_publicの設定よりも優先される。


```json
{
  "type": "boolean"
}
```

**`is_public`** 
  


```json
{
  "type": "boolean"
}
```

**`code`** 
  


```json
{
  "type": "string"
}
```

**`usage_limit`** 
  


```json
{
  "type": "integer"
}
```

**`min_amount`** 
  


```json
{
  "type": "integer"
}
```

**`is_shop_specified`** 
  


```json
{
  "type": "boolean"
}
```

**`available_shop_ids`** 
  


```json
{
  "type": "array",
  "items": {
    "type": "string",
    "format": "uuid"
  }
}
```

**`storage_id`** 
  

Storage APIでアップロードしたクーポン画像のStorage IDを指定します

```json
{
  "type": "string",
  "format": "uuid"
}
```



成功したときは
[CouponDetail](./responses.md#coupon-detail)
を返します



---



