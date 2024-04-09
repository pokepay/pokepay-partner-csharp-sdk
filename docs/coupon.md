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
    CouponId = "x2jnlKrw0",  // クーポンID
    CouponName = "dNS4VtkXCD",  // クーポン名
    IssuedShopName = "t0L",  // 発行店舗名
    AvailableShopName = "OE3Qg",  // 利用可能店舗名
    AvailableFrom = "2021-02-12T04:03:43.000000Z",  // 利用可能期間 (開始日時)
    AvailableTo = "2023-06-04T13:12:02.000000Z",  // 利用可能期間 (終了日時)
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
|422|private_money_not_found||Private money not found|



---


<a name="create-coupon"></a>
## CreateCoupon: クーポンの登録
新しいクーポンを登録します

```csharp
Request.CreateCoupon request = new Request.CreateCoupon(
    "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx",
    "cszhfH09Y5OthVwPmvHXBFS5mnHJDaN7ByqCBViT8YJSc5gafw5E7JxTvjUc1aT5EbGp",
    "2022-01-15T18:09:07.000000Z",
    "2022-08-26T01:51:15.000000Z",
    "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx" // 発行元の店舗ID
) {
    Description = "Qn8B7l65BYM",
    DiscountAmount = 4227,
    DiscountPercentage = 806.0,
    DiscountUpperLimit = 1270,
    DisplayStartsAt = "2020-02-09T15:09:11.000000Z",  // クーポンの掲載期間(開始日時)
    DisplayEndsAt = "2023-11-04T13:46:54.000000Z",  // クーポンの掲載期間(終了日時)
    IsDisabled = true,  // 無効化フラグ
    IsHidden = false,  // クーポン一覧に掲載されるかどうか
    IsPublic = false,  // アプリ配信なしで受け取れるかどうか
    Code = "EwbRq7C0z",  // クーポン受け取りコード
    UsageLimit = 1053,  // ユーザごとの利用可能回数(NULLの場合は無制限)
    MinAmount = 7786,  // クーポン適用可能な最小取引額
    IsShopSpecified = true,  // 特定店舗限定のクーポンかどうか
    AvailableShopIds = new string[]{"xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx", "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx", "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx"},  // 利用可能店舗リスト
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
|422|private_money_not_found||Private money not found|
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
    Name = "5JoEScisdzkhxnXFFT7CXS50vaovkRO",
    Description = "QbPFa2Q0QZFPxPWcwwu3uh9fDL3S3N",
    DiscountAmount = 2550,
    DiscountPercentage = 8586.0,
    DiscountUpperLimit = 2093,
    StartsAt = "2021-01-29T13:48:50.000000Z",
    EndsAt = "2022-04-03T12:59:15.000000Z",
    DisplayStartsAt = "2021-06-14T03:00:40.000000Z",  // クーポンの掲載期間(開始日時)
    DisplayEndsAt = "2022-07-07T12:43:02.000000Z",  // クーポンの掲載期間(終了日時)
    IsDisabled = false,  // 無効化フラグ
    IsHidden = false,  // クーポン一覧に掲載されるかどうか
    IsPublic = true,  // アプリ配信なしで受け取れるかどうか
    Code = "VO",  // クーポン受け取りコード
    UsageLimit = 5609,  // ユーザごとの利用可能回数(NULLの場合は無制限)
    MinAmount = 6829,  // クーポン適用可能な最小取引額
    IsShopSpecified = false,  // 特定店舗限定のクーポンかどうか
    AvailableShopIds = new string[]{"xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx", "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx"},  // 利用可能店舗リスト
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



