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
    CouponId = "QGKVJoUCSY",  // クーポンID
    CouponName = "35cdkgvsb",  // クーポン名
    IssuedShopName = "AYCbaEHjTH",  // 発行店舗名
    AvailableShopName = "mx8bpM",  // 利用可能店舗名
    AvailableFrom = "2021-12-06T11:40:45.000000Z",  // 利用可能期間 (開始日時)
    AvailableTo = "2020-06-30T10:03:36.000000Z",  // 利用可能期間 (終了日時)
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
    "ByLz0xsJRhRVsB9HjzBAZfWzO75yHWR5FLMa9CO3GmqQepv7doxpRjgZI2VSDvLJkkZMMdEANfWVavAje3PJg4zkA5",
    "2023-12-19T00:11:20.000000Z",
    "2020-04-12T12:52:30.000000Z",
    "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx" // 発行元の店舗ID
) {
    Description = "RQrAEDCEBzCTk0pNAGkxkj3y6QjLE9oTv9S3Zg4O5dK9OBTn3gY0HIwJr5Xn6R9PIw5eC52tvIBnMyMg4CnT2dj7ORUTt4jEgn4792da7QYy7V605lzcBixerwgOsZo2yFQXiifPwyEPkMTjwK5UmBamQcUvvHD25XYGaGoRmlkWpVKSQYACWhdJgT5oXIAxp1c5Q2vG7By91KC2xkwbMvROWfUAhh6XnZz0yJYgRGAM6oTzljbZYS9b",
    DiscountAmount = 7445,
    DiscountPercentage = 6681.0,
    DiscountUpperLimit = 1334,
    DisplayStartsAt = "2024-01-10T16:44:33.000000Z",  // クーポンの掲載期間(開始日時)
    DisplayEndsAt = "2024-07-21T22:47:46.000000Z",  // クーポンの掲載期間(終了日時)
    IsDisabled = false,  // 無効化フラグ
    IsHidden = false,  // クーポン一覧に掲載されるかどうか
    IsPublic = true,  // アプリ配信なしで受け取れるかどうか
    Code = "FaDi",  // クーポン受け取りコード
    UsageLimit = 5654,  // ユーザごとの利用可能回数(NULLの場合は無制限)
    MinAmount = 7691,  // クーポン適用可能な最小取引額
    IsShopSpecified = true,  // 特定店舗限定のクーポンかどうか
    AvailableShopIds = new string[]{"xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx"},  // 利用可能店舗リスト
    StorageId = "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx",  // ストレージID
    NumRecipientsCap = 4567,  // クーポンを受け取ることができるユーザ数上限
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

**`num_recipients_cap`** 
  


```json
{
  "type": "integer",
  "minimum": 1
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
    Name = "xdn1z0TuA7dLQ8GnuuGnm3um0ZKYlqHYAPfacx4ba4px",
    Description = "iFCicQd3QQrdtpp5IlW8KnTaroT8w3801ZxeZpTa0FFkkUFLVCDKp9TvCsVFg3Dy6t9FVfvRBKOl2QQeBI5NM6J7EhkzGk22yYle2ZOPXJOiEYcNwwBKhoxCdqw8SDS6L7O6ohLm8HBuYz7E9ZuYBAHz0vH45u4SHdXpfYeqMtcfd8wxcygIW1kAzyAHjkW0eFslSf8NaBTyV6GBT8tDHI0zW",
    DiscountAmount = 1681,
    DiscountPercentage = 3214.0,
    DiscountUpperLimit = 4704,
    StartsAt = "2025-01-31T13:36:35.000000Z",
    EndsAt = "2020-09-21T03:39:30.000000Z",
    DisplayStartsAt = "2021-08-29T11:14:37.000000Z",  // クーポンの掲載期間(開始日時)
    DisplayEndsAt = "2020-11-07T03:49:04.000000Z",  // クーポンの掲載期間(終了日時)
    IsDisabled = false,  // 無効化フラグ
    IsHidden = false,  // クーポン一覧に掲載されるかどうか
    IsPublic = true,  // アプリ配信なしで受け取れるかどうか
    Code = "diHOOw",  // クーポン受け取りコード
    UsageLimit = 8853,  // ユーザごとの利用可能回数(NULLの場合は無制限)
    MinAmount = 1932,  // クーポン適用可能な最小取引額
    IsShopSpecified = true,  // 特定店舗限定のクーポンかどうか
    AvailableShopIds = new string[]{"xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx"},  // 利用可能店舗リスト
    StorageId = "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx",  // ストレージID
    NumRecipientsCap = 5053,  // クーポンを受け取ることができるユーザ数上限
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

**`num_recipients_cap`** 
  


```json
{
  "type": "integer",
  "minimum": 1
}
```



成功したときは
[CouponDetail](./responses.md#coupon-detail)
を返します



---



