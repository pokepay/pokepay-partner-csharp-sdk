# Coupon
割引クーポンを表すデータです。
クーポンをユーザが明示的に利用することによって支払い決済時の割引(固定金額 or 割引率)が適用されます。
クーポンは支払い時に指定し、支払い処理の前にクーポンに指定の方法で値引き処理を行います。
クーポン原資を負担する発行店舗を設定したり、配布先を指定することも可能です。
また、特定店舗で利用できるものや利用可能期間、配信条件などを設定できます。


<a name="list-coupons"></a>
## ListCoupons: クーポン一覧の取得
指定したマネーのクーポン一覧を取得します

```csharp
Request.ListCoupons request = new Request.ListCoupons(
    "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx" // 対象クーポンのマネーID
) {
    CouponId = "5rFal",  // クーポンID
    CouponName = "07TQSGuwj6",  // クーポン名
    IssuedShopName = "ad9K1XBWV",  // 発行店舗名
    AvailableShopName = "xIt1hLKB6G",  // 利用可能店舗名
    AvailableFrom = "2025-12-07T12:03:19.000000Z",  // 利用可能期間 (開始日時)
    AvailableTo = "2020-12-15T16:03:30.000000Z",  // 利用可能期間 (終了日時)
    Page = 1,  // ページ番号
    PerPage = 50,  // 1ページ分の取得数
};
Response.PaginatedCoupons response = await request.Send(client);
```



### Parameters
#### `private_money_id`
対象クーポンのマネーIDです(必須項目)。
存在しないマネーIDを指定した場合はprivate_money_not_foundエラー(422)が返ります。

<details>
<summary>スキーマ</summary>

```json
{
  "type": "string",
  "format": "uuid"
}
```

</details>

#### `coupon_id`
指定されたクーポンIDで結果をフィルターします。
部分一致(前方一致)します。

<details>
<summary>スキーマ</summary>

```json
{
  "type": "string"
}
```

</details>

#### `coupon_name`
指定されたクーポン名で結果をフィルターします。

<details>
<summary>スキーマ</summary>

```json
{
  "type": "string"
}
```

</details>

#### `issued_shop_name`
指定された発行店舗で結果をフィルターします。

<details>
<summary>スキーマ</summary>

```json
{
  "type": "string"
}
```

</details>

#### `available_shop_name`
指定された利用可能店舗で結果をフィルターします。

<details>
<summary>スキーマ</summary>

```json
{
  "type": "string"
}
```

</details>

#### `available_from`
利用可能期間でフィルターします。フィルターの開始日時をISO8601形式で指定します。

<details>
<summary>スキーマ</summary>

```json
{
  "type": "string",
  "format": "date-time"
}
```

</details>

#### `available_to`
利用可能期間でフィルターします。フィルターの終了日時をISO8601形式で指定します。

<details>
<summary>スキーマ</summary>

```json
{
  "type": "string",
  "format": "date-time"
}
```

</details>

#### `page`
取得したいページ番号です。

<details>
<summary>スキーマ</summary>

```json
{
  "type": "integer",
  "minimum": 1
}
```

</details>

#### `per_page`
1ページ分の取得数です。デフォルトでは 50 になっています。

<details>
<summary>スキーマ</summary>

```json
{
  "type": "integer",
  "minimum": 1
}
```

</details>



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
    "ESgi9KMGwAvzt2XDFLhsltsxjHevXAeaqJQdiPE4BeJCcIbjYCJA60910zNdhVnyX38KqA1fvkyrtqcl",
    "2021-02-06T15:41:58.000000Z",
    "2024-04-23T19:37:51.000000Z",
    "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx" // 発行元の店舗ID
) {
    Description = "9jljopVrQrbVbWUr1E2HhlclCQRWx8FEGzWXdbWzamEGXFO5PHpjsIS4SoPDOBVrOHFo8xzE1tgCZyMtCfVQXKeHEaCm6v4bOQPdSecOojChLhuEaRbGgSXO57u6cTOWbPpHzT8SBHVxA4uTsQXNQLVTsa7Enw9cnxOrtkyrYkFM2fsUIFcBc3xUhfvCQABU9yhdPlghv2VJu1lljCVVYS",
    DiscountAmount = 6563,
    DiscountPercentage = 3804.0,
    DiscountUpperLimit = 5243,
    DisplayStartsAt = "2025-11-09T11:12:19.000000Z",  // クーポンの掲載期間(開始日時)
    DisplayEndsAt = "2020-08-29T02:32:46.000000Z",  // クーポンの掲載期間(終了日時)
    IsDisabled = true,  // 無効化フラグ
    IsHidden = false,  // クーポン一覧に掲載されるかどうか
    IsPublic = true,  // アプリ配信なしで受け取れるかどうか
    Code = "lSztThgX6",  // クーポン受け取りコード
    UsageLimit = 4279,  // ユーザごとの利用可能回数(NULLの場合は無制限)
    MinAmount = 5692,  // クーポン適用可能な最小取引額
    IsShopSpecified = true,  // 特定店舗限定のクーポンかどうか
    AvailableShopIds = new string[]{"xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx", "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx", "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx"},  // 利用可能店舗リスト
    StorageId = "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx",  // ストレージID
    NumRecipientsCap = 81,  // クーポンを受け取ることができるユーザ数上限
};
Response.CouponDetail response = await request.Send(client);
```

`is_shop_specified`と`available_shop_ids`は同時に指定する必要があります。


### Parameters
#### `private_money_id`

<details>
<summary>スキーマ</summary>

```json
{
  "type": "string",
  "format": "uuid"
}
```

</details>

#### `name`

<details>
<summary>スキーマ</summary>

```json
{
  "type": "string",
  "maxLength": 128
}
```

</details>

#### `description`

<details>
<summary>スキーマ</summary>

```json
{
  "type": "string",
  "maxLength": 256
}
```

</details>

#### `discount_amount`

<details>
<summary>スキーマ</summary>

```json
{
  "type": "integer",
  "minimum": 0
}
```

</details>

#### `discount_percentage`

<details>
<summary>スキーマ</summary>

```json
{
  "type": "number",
  "minimum": 0
}
```

</details>

#### `discount_upper_limit`

<details>
<summary>スキーマ</summary>

```json
{
  "type": "integer",
  "minimum": 0
}
```

</details>

#### `starts_at`

<details>
<summary>スキーマ</summary>

```json
{
  "type": "string",
  "format": "date-time"
}
```

</details>

#### `ends_at`

<details>
<summary>スキーマ</summary>

```json
{
  "type": "string",
  "format": "date-time"
}
```

</details>

#### `display_starts_at`

<details>
<summary>スキーマ</summary>

```json
{
  "type": "string",
  "format": "date-time"
}
```

</details>

#### `display_ends_at`

<details>
<summary>スキーマ</summary>

```json
{
  "type": "string",
  "format": "date-time"
}
```

</details>

#### `is_disabled`

<details>
<summary>スキーマ</summary>

```json
{
  "type": "boolean"
}
```

</details>

#### `is_hidden`
アプリに表示されるクーポン一覧に掲載されるかどうか。
主に一時的に掲載から外したいときに用いられる。そのためis_publicの設定よりも優先される。

<details>
<summary>スキーマ</summary>

```json
{
  "type": "boolean"
}
```

</details>

#### `is_public`

<details>
<summary>スキーマ</summary>

```json
{
  "type": "boolean"
}
```

</details>

#### `code`

<details>
<summary>スキーマ</summary>

```json
{
  "type": "string"
}
```

</details>

#### `usage_limit`

<details>
<summary>スキーマ</summary>

```json
{
  "type": "integer"
}
```

</details>

#### `min_amount`

<details>
<summary>スキーマ</summary>

```json
{
  "type": "integer"
}
```

</details>

#### `issued_shop_id`

<details>
<summary>スキーマ</summary>

```json
{
  "type": "string",
  "format": "uuid"
}
```

</details>

#### `is_shop_specified`

<details>
<summary>スキーマ</summary>

```json
{
  "type": "boolean"
}
```

</details>

#### `available_shop_ids`

<details>
<summary>スキーマ</summary>

```json
{
  "type": "array",
  "items": {
    "type": "string",
    "format": "uuid"
  }
}
```

</details>

#### `storage_id`
Storage APIでアップロードしたクーポン画像のStorage IDを指定します

<details>
<summary>スキーマ</summary>

```json
{
  "type": "string",
  "format": "uuid"
}
```

</details>

#### `num_recipients_cap`

<details>
<summary>スキーマ</summary>

```json
{
  "type": "integer",
  "minimum": 1
}
```

</details>



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
#### `coupon_id`
取得するクーポンのIDです。
UUIDv4フォーマットである必要があり、フォーマットが異なる場合は InvalidParametersエラー(400)が返ります。
指定したIDのクーポンが存在しない場合はCouponNotFoundエラー(422)が返ります。

<details>
<summary>スキーマ</summary>

```json
{
  "type": "string",
  "format": "uuid"
}
```

</details>



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
    Name = "bzVLVHAuqNRKSFbkQwzExi4cSpvsggIAlYenv9bZPRWKzkKRFsQ10G0TlaGn12vl36ewyKaB6SHyKZZn5jR7G8GZiBnTaUgy7N3mTLem",
    Description = "MZeIt74bhbcXSO6mPwoW10WefOcGtzUdCSHPXTvr",
    DiscountAmount = 3885,
    DiscountPercentage = 3370.0,
    DiscountUpperLimit = 7391,
    StartsAt = "2025-04-07T01:25:38.000000Z",
    EndsAt = "2020-11-05T12:33:22.000000Z",
    DisplayStartsAt = "2021-12-29T07:40:45.000000Z",  // クーポンの掲載期間(開始日時)
    DisplayEndsAt = "2026-02-20T09:33:30.000000Z",  // クーポンの掲載期間(終了日時)
    IsDisabled = false,  // 無効化フラグ
    IsHidden = true,  // クーポン一覧に掲載されるかどうか
    IsPublic = false,  // アプリ配信なしで受け取れるかどうか
    Code = "BOkNuR",  // クーポン受け取りコード
    UsageLimit = 6951,  // ユーザごとの利用可能回数(NULLの場合は無制限)
    MinAmount = 908,  // クーポン適用可能な最小取引額
    IsShopSpecified = true,  // 特定店舗限定のクーポンかどうか
    AvailableShopIds = new string[]{"xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx", "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx"},  // 利用可能店舗リスト
    StorageId = "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx",  // ストレージID
    NumRecipientsCap = 6349,  // クーポンを受け取ることができるユーザ数上限
};
Response.CouponDetail response = await request.Send(client);
```


`discount_amount`と`discount_percentage`の少なくとも一方は指定する必要があります。



### Parameters
#### `coupon_id`

<details>
<summary>スキーマ</summary>

```json
{
  "type": "string",
  "format": "uuid"
}
```

</details>

#### `name`

<details>
<summary>スキーマ</summary>

```json
{
  "type": "string",
  "maxLength": 128
}
```

</details>

#### `description`

<details>
<summary>スキーマ</summary>

```json
{
  "type": "string",
  "maxLength": 256
}
```

</details>

#### `discount_amount`

<details>
<summary>スキーマ</summary>

```json
{
  "type": "integer",
  "minimum": 0
}
```

</details>

#### `discount_percentage`

<details>
<summary>スキーマ</summary>

```json
{
  "type": "number",
  "minimum": 0
}
```

</details>

#### `discount_upper_limit`

<details>
<summary>スキーマ</summary>

```json
{
  "type": "integer",
  "minimum": 0
}
```

</details>

#### `starts_at`

<details>
<summary>スキーマ</summary>

```json
{
  "type": "string",
  "format": "date-time"
}
```

</details>

#### `ends_at`

<details>
<summary>スキーマ</summary>

```json
{
  "type": "string",
  "format": "date-time"
}
```

</details>

#### `display_starts_at`

<details>
<summary>スキーマ</summary>

```json
{
  "type": "string",
  "format": "date-time"
}
```

</details>

#### `display_ends_at`

<details>
<summary>スキーマ</summary>

```json
{
  "type": "string",
  "format": "date-time"
}
```

</details>

#### `is_disabled`

<details>
<summary>スキーマ</summary>

```json
{
  "type": "boolean"
}
```

</details>

#### `is_hidden`
アプリに表示されるクーポン一覧に掲載されるかどうか。
主に一時的に掲載から外したいときに用いられる。そのためis_publicの設定よりも優先される。

<details>
<summary>スキーマ</summary>

```json
{
  "type": "boolean"
}
```

</details>

#### `is_public`

<details>
<summary>スキーマ</summary>

```json
{
  "type": "boolean"
}
```

</details>

#### `code`

<details>
<summary>スキーマ</summary>

```json
{
  "type": "string"
}
```

</details>

#### `usage_limit`

<details>
<summary>スキーマ</summary>

```json
{
  "type": "integer"
}
```

</details>

#### `min_amount`

<details>
<summary>スキーマ</summary>

```json
{
  "type": "integer"
}
```

</details>

#### `is_shop_specified`

<details>
<summary>スキーマ</summary>

```json
{
  "type": "boolean"
}
```

</details>

#### `available_shop_ids`

<details>
<summary>スキーマ</summary>

```json
{
  "type": "array",
  "items": {
    "type": "string",
    "format": "uuid"
  }
}
```

</details>

#### `storage_id`
Storage APIでアップロードしたクーポン画像のStorage IDを指定します

<details>
<summary>スキーマ</summary>

```json
{
  "type": "string",
  "format": "uuid"
}
```

</details>

#### `num_recipients_cap`

<details>
<summary>スキーマ</summary>

```json
{
  "type": "integer",
  "minimum": 1
}
```

</details>



成功したときは
[CouponDetail](./responses.md#coupon-detail)
を返します



---



