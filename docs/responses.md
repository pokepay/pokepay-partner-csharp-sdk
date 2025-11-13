# Responses
<a name="account-with-user"></a>
## AccountWithUser
* `Id (string)`: 
* `Name (string)`: 
* `IsSuspended (bool)`: 
* `Status (string)`: 
* `PrivateMoney (PrivateMoney)`: 
* `User (User)`: 

`private_money`は [PrivateMoney](#private-money) オブジェクトを返します。

`user`は [User](#user) オブジェクトを返します。

<a name="account-detail"></a>
## AccountDetail
* `Id (string)`: 
* `Name (string)`: 
* `IsSuspended (bool)`: 
* `Status (string)`: 
* `Balance (double)`: 
* `MoneyBalance (double)`: 
* `PointBalance (double)`: 
* `PointDebt (double)`: 
* `PrivateMoney (PrivateMoney)`: 
* `User (User)`: 
* `ExternalId (string)`: 

`private_money`は [PrivateMoney](#private-money) オブジェクトを返します。

`user`は [User](#user) オブジェクトを返します。

<a name="account-deleted"></a>
## AccountDeleted

<a name="bill"></a>
## Bill
* `Id (string)`: 支払いQRコードのID
* `Amount (double)`: 支払い額
* `MaxAmount (double)`: 支払い額を範囲指定した場合の上限
* `MinAmount (double)`: 支払い額を範囲指定した場合の下限
* `Description (string)`: 支払いQRコードの説明文(アプリ上で取引の説明文として表示される)
* `Account (AccountWithUser)`: 支払いQRコード発行ウォレット
* `IsDisabled (bool)`: 無効化されているかどうか
* `Token (string)`: 支払いQRコードを解析したときに出てくるURL
* `CreatedAt (string)`: 支払いQRコードの作成日時

`account`は [AccountWithUser](#account-with-user) オブジェクトを返します。

<a name="check"></a>
## Check
* `Id (string)`: チャージQRコードのID
* `CreatedAt (string)`: チャージQRコードの作成日時
* `Amount (double)`: チャージマネー額 (deprecated)
* `MoneyAmount (double)`: チャージマネー額
* `PointAmount (double)`: チャージポイント額
* `Description (string)`: チャージQRコードの説明文(アプリ上で取引の説明文として表示される)
* `User (User)`: 送金元ユーザ情報
* `IsOnetime (bool)`: 使用回数が一回限りかどうか
* `IsDisabled (bool)`: 無効化されているかどうか
* `ExpiresAt (string)`: チャージQRコード自体の失効日時
* `LastUsedAt (string)`: 
* `PrivateMoney (PrivateMoney)`: 対象マネー情報
* `UsageLimit (int)`: 一回限りでない場合の最大読み取り回数
* `UsageCount (double)`: 一回限りでない場合の現在までに読み取られた回数
* `PointExpiresAt (string)`: ポイント有効期限(絶対日数指定)
* `PointExpiresInDays (int)`: ポイント有効期限(相対日数指定)
* `Token (string)`: チャージQRコードを解析したときに出てくるURL

`user`は [User](#user) オブジェクトを返します。

`private_money`は [PrivateMoney](#private-money) オブジェクトを返します。

<a name="paginated-checks"></a>
## PaginatedChecks
* `Rows (Check[])`: 
* `Count (int)`: 
* `Pagination (Pagination)`: 

`rows`は [Check](#check) オブジェクトの配列を返します。

`pagination`は [Pagination](#pagination) オブジェクトを返します。

<a name="cpm-token"></a>
## CpmToken
* `CpmToken (string)`: 
* `Account (AccountDetail)`: 
* `Transaction (Transaction)`: 
* `Event (ExternalTransaction)`: 
* `Scopes (string[])`: 許可された取引種別
* `ExpiresAt (string)`: CPMトークンの失効日時
* `Metadata (string)`: エンドユーザー側メタデータ

`account`は [AccountDetail](#account-detail) オブジェクトを返します。

`transaction`は [Transaction](#transaction) オブジェクトを返します。

`event`は [ExternalTransaction](#external-transaction) オブジェクトを返します。

<a name="cashtray"></a>
## Cashtray
* `Id (string)`: Cashtray自体のIDです。
* `Amount (double)`: 取引金額
* `Description (string)`: Cashtrayの説明文
* `Account (AccountWithUser)`: 発行店舗のウォレット
* `ExpiresAt (string)`: Cashtrayの失効日時
* `CanceledAt (string)`: Cashtrayの無効化日時。NULLの場合は無効化されていません
* `Token (string)`: CashtrayのQRコードを解析したときに出てくるURL

`account`は [AccountWithUser](#account-with-user) オブジェクトを返します。

<a name="cashtray-with-result"></a>
## CashtrayWithResult
* `Id (string)`: CashtrayのID
* `Amount (double)`: 取引金額
* `Description (string)`: Cashtrayの説明文(アプリ上で取引の説明文として表示される)
* `Account (AccountWithUser)`: 発行店舗のウォレット
* `ExpiresAt (string)`: Cashtrayの失効日時
* `CanceledAt (string)`: Cashtrayの無効化日時。NULLの場合は無効化されていません
* `Token (string)`: CashtrayのQRコードを解析したときに出てくるURL
* `Attempt (CashtrayAttempt)`: Cashtray読み取り結果
* `Transaction (Transaction)`: 取引結果

`account`は [AccountWithUser](#account-with-user) オブジェクトを返します。

`attempt`は [CashtrayAttempt](#cashtray-attempt) オブジェクトを返します。

`transaction`は [Transaction](#transaction) オブジェクトを返します。

<a name="user"></a>
## User
* `Id (string)`: ユーザー (または店舗) ID
* `Name (string)`: ユーザー (または店舗) 名
* `IsMerchant (bool)`: 店舗ユーザーかどうか

<a name="organization"></a>
## Organization
* `Code (string)`: 組織コード
* `Name (string)`: 組織名

<a name="transaction-detail"></a>
## TransactionDetail
* `Id (string)`: 取引ID
* `Type (string)`: 取引種別
* `IsModified (bool)`: 返金された取引かどうか
* `Sender (User)`: 送金者情報
* `SenderAccount (Account)`: 送金ウォレット情報
* `Receiver (User)`: 受取者情報
* `ReceiverAccount (Account)`: 受取ウォレット情報
* `Amount (double)`: 取引総額 (マネー額 + ポイント額)
* `MoneyAmount (double)`: 取引マネー額
* `PointAmount (double)`: 取引ポイント額(キャンペーン付与ポイント合算)
* `RawPointAmount (double)`: 取引ポイント額
* `CampaignPointAmount (double)`: キャンペーンによるポイント付与額
* `DoneAt (string)`: 取引日時
* `Description (string)`: 取引説明文
* `Transfers (Transfer[])`: 

`receiver`と`sender`は [User](#user) オブジェクトを返します。

`receiver_account`と`sender_account`は [Account](#account) オブジェクトを返します。

`transfers`は [Transfer](#transfer) オブジェクトの配列を返します。

<a name="shop-with-accounts"></a>
## ShopWithAccounts
* `Id (string)`: 店舗ID
* `Name (string)`: 店舗名
* `OrganizationCode (string)`: 組織コード
* `Status (string)`: 店舗の状態
* `PostalCode (string)`: 店舗の郵便番号
* `Address (string)`: 店舗の住所
* `Tel (string)`: 店舗の電話番号
* `Email (string)`: 店舗のメールアドレス
* `ExternalId (string)`: 店舗の外部ID
* `Accounts (ShopAccount[])`: 

`accounts`は [ShopAccount](#shop-account) オブジェクトの配列を返します。

<a name="bulk-transaction"></a>
## BulkTransaction
* `Id (string)`: 
* `RequestId (string)`: リクエストID
* `Name (string)`: バルク取引管理用の名前
* `Description (string)`: バルク取引管理用の説明文
* `Status (string)`: バルク取引の状態
* `Error (string)`: バルク取引のエラー種別
* `ErrorLineno (int)`: バルク取引のエラーが発生した行番号
* `SubmittedAt (string)`: バルク取引が登録された日時
* `UpdatedAt (string)`: バルク取引が更新された日時

<a name="paginated-bulk-transaction-job"></a>
## PaginatedBulkTransactionJob
* `Rows (BulkTransactionJob[])`: 
* `Count (int)`: 
* `Pagination (Pagination)`: 

`rows`は [BulkTransactionJob](#bulk-transaction-job) オブジェクトの配列を返します。

`pagination`は [Pagination](#pagination) オブジェクトを返します。

<a name="external-transaction-detail"></a>
## ExternalTransactionDetail
* `Id (string)`: ポケペイ外部取引ID
* `IsModified (bool)`: 返金された取引かどうか
* `Sender (User)`: 送金者情報
* `SenderAccount (Account)`: 送金ウォレット情報
* `Receiver (User)`: 受取者情報
* `ReceiverAccount (Account)`: 受取ウォレット情報
* `Amount (double)`: 決済額
* `DoneAt (string)`: 取引日時
* `Description (string)`: 取引説明文
* `Transaction (TransactionDetail)`: 関連ポケペイ取引詳細

`receiver`と`sender`は [User](#user) オブジェクトを返します。

`receiver_account`と`sender_account`は [Account](#account) オブジェクトを返します。

`transaction`は [TransactionDetail](#transaction-detail) オブジェクトを返します。

<a name="paginated-private-money-organization-summaries"></a>
## PaginatedPrivateMoneyOrganizationSummaries
* `Rows (PrivateMoneyOrganizationSummary[])`: 
* `Count (int)`: 
* `Pagination (Pagination)`: 

`rows`は [PrivateMoneyOrganizationSummary](#private-money-organization-summary) オブジェクトの配列を返します。

`pagination`は [Pagination](#pagination) オブジェクトを返します。

<a name="private-money-summary"></a>
## PrivateMoneySummary
* `TopupAmount (double)`: 
* `RefundedTopupAmount (double)`: 
* `PaymentAmount (double)`: 
* `RefundedPaymentAmount (double)`: 
* `AddedPointAmount (double)`: 
* `TopupPointAmount (double)`: 
* `CampaignPointAmount (double)`: 
* `RefundedAddedPointAmount (double)`: 
* `ExchangeInflowAmount (double)`: 
* `ExchangeOutflowAmount (double)`: 
* `TransactionCount (int)`: 

<a name="user-stats-operation"></a>
## UserStatsOperation
* `Id (string)`: 集計処理ID
* `From (string)`: 集計期間の開始時刻
* `To (string)`: 集計期間の終了時刻
* `Status (string)`: 集計処理の実行ステータス
* `ErrorReason (string)`: エラーとなった理由
* `DoneAt (string)`: 集計処理の完了時刻
* `FileUrl (string)`: 集計結果のCSVのダウンロードURL
* `RequestedAt (string)`: 集計リクエストを行った時刻

<a name="user-device"></a>
## UserDevice
* `Id (string)`: デバイスID
* `User (User)`: デバイスを使用するユーザ
* `IsActive (bool)`: デバイスが有効か
* `Metadata (string)`: デバイスのメタデータ

`user`は [User](#user) オブジェクトを返します。

<a name="bank-registering-info"></a>
## BankRegisteringInfo
* `RedirectUrl (string)`: 
* `PaytreeCustomerNumber (string)`: 

<a name="banks"></a>
## Banks
* `Rows (Bank[])`: 
* `Count (int)`: 

`rows`は [Bank](#bank) オブジェクトの配列を返します。

<a name="bank-deleted"></a>
## BankDeleted

<a name="paginated-transaction"></a>
## PaginatedTransaction
* `Rows (Transaction[])`: 
* `Count (int)`: 
* `Pagination (Pagination)`: 

`rows`は [Transaction](#transaction) オブジェクトの配列を返します。

`pagination`は [Pagination](#pagination) オブジェクトを返します。

<a name="paginated-transaction-v2"></a>
## PaginatedTransactionV2
* `Rows (Transaction[])`: 
* `PerPage (int)`: 
* `Count (int)`: 
* `NextPageCursorId (string)`: 
* `PrevPageCursorId (string)`: 

`rows`は [Transaction](#transaction) オブジェクトの配列を返します。

<a name="paginated-bill-transaction"></a>
## PaginatedBillTransaction
* `Rows (BillTransaction[])`: 
* `PerPage (int)`: 
* `Count (int)`: 
* `NextPageCursorId (string)`: 
* `PrevPageCursorId (string)`: 

`rows`は [BillTransaction](#bill-transaction) オブジェクトの配列を返します。

<a name="paginated-transfers"></a>
## PaginatedTransfers
* `Rows (Transfer[])`: 
* `Count (int)`: 
* `Pagination (Pagination)`: 

`rows`は [Transfer](#transfer) オブジェクトの配列を返します。

`pagination`は [Pagination](#pagination) オブジェクトを返します。

<a name="paginated-transfers-v2"></a>
## PaginatedTransfersV2
* `Rows (Transfer[])`: 
* `PerPage (int)`: 
* `Count (int)`: 
* `NextPageCursorId (string)`: 
* `PrevPageCursorId (string)`: 

`rows`は [Transfer](#transfer) オブジェクトの配列を返します。

<a name="paginated-account-with-users"></a>
## PaginatedAccountWithUsers
* `Rows (AccountWithUser[])`: 
* `Count (int)`: 
* `Pagination (Pagination)`: 

`rows`は [AccountWithUser](#account-with-user) オブジェクトの配列を返します。

`pagination`は [Pagination](#pagination) オブジェクトを返します。

<a name="paginated-account-details"></a>
## PaginatedAccountDetails
* `Rows (AccountDetail[])`: 
* `Count (int)`: 
* `Pagination (Pagination)`: 

`rows`は [AccountDetail](#account-detail) オブジェクトの配列を返します。

`pagination`は [Pagination](#pagination) オブジェクトを返します。

<a name="paginated-account-balance"></a>
## PaginatedAccountBalance
* `Rows (AccountBalance[])`: 
* `Count (int)`: 
* `Pagination (Pagination)`: 

`rows`は [AccountBalance](#account-balance) オブジェクトの配列を返します。

`pagination`は [Pagination](#pagination) オブジェクトを返します。

<a name="paginated-shops"></a>
## PaginatedShops
* `Rows (ShopWithMetadata[])`: 
* `Count (int)`: 
* `Pagination (Pagination)`: 

`rows`は [ShopWithMetadata](#shop-with-metadata) オブジェクトの配列を返します。

`pagination`は [Pagination](#pagination) オブジェクトを返します。

<a name="paginated-bills"></a>
## PaginatedBills
* `Rows (Bill[])`: 
* `Count (int)`: 
* `Pagination (Pagination)`: 

`rows`は [Bill](#bill) オブジェクトの配列を返します。

`pagination`は [Pagination](#pagination) オブジェクトを返します。

<a name="paginated-private-moneys"></a>
## PaginatedPrivateMoneys
* `Rows (PrivateMoney[])`: 
* `Count (int)`: 
* `Pagination (Pagination)`: 

`rows`は [PrivateMoney](#private-money) オブジェクトの配列を返します。

`pagination`は [Pagination](#pagination) オブジェクトを返します。

<a name="campaign"></a>
## Campaign
* `Id (string)`: キャンペーンID
* `Name (string)`: キャペーン名
* `ApplicableShops (User[])`: キャンペーン適用対象の店舗リスト
* `IsExclusive (bool)`: キャンペーンの重複を許すかどうかのフラグ
* `StartsAt (string)`: キャンペーン開始日時
* `EndsAt (string)`: キャンペーン終了日時
* `PointExpiresAt (string)`: キャンペーンによって付与されるポイントの失効日時
* `PointExpiresInDays (int)`: キャンペーンによって付与されるポイントの有効期限(相対指定、単位は日)
* `Priority (int)`: キャンペーンの優先順位
* `Description (string)`: キャンペーン説明文
* `BearPointShop (User)`: ポイントを負担する店舗
* `PrivateMoney (PrivateMoney)`: キャンペーンを適用するマネー
* `DestPrivateMoney (PrivateMoney)`: ポイントを付与するマネー
* `MaxTotalPointAmount (int)`: 一人当たりの累計ポイント上限
* `PointCalculationRule (string)`: ポイント計算ルール (banklisp表記)
* `PointCalculationRuleObject (string)`: ポイント計算ルール (JSON文字列による表記)
* `Status (string)`: キャンペーンの現在の状態
* `BudgetCapsAmount (int)`: キャンペーンの予算上限額
* `BudgetCurrentAmount (int)`: キャンペーンの付与合計額
* `BudgetCurrentTime (string)`: キャンペーンの付与集計日時

`applicable-shops`は [User](#user) オブジェクトの配列を返します。

`bear_point_shop`は [User](#user) オブジェクトを返します。

`dest_private_money`と`private_money`は [PrivateMoney](#private-money) オブジェクトを返します。

<a name="paginated-campaigns"></a>
## PaginatedCampaigns
* `Rows (Campaign[])`: 
* `Count (int)`: 
* `Pagination (Pagination)`: 

`rows`は [Campaign](#campaign) オブジェクトの配列を返します。

`pagination`は [Pagination](#pagination) オブジェクトを返します。

<a name="account-transfer-summary"></a>
## AccountTransferSummary
* `Summaries (AccountTransferSummaryElement[])`: 

`summaries`は [AccountTransferSummaryElement](#account-transfer-summary-element) オブジェクトの配列を返します。

<a name="organization-worker-task-webhook"></a>
## OrganizationWorkerTaskWebhook
* `Id (string)`: 
* `OrganizationCode (string)`: 
* `Task (string)`: 
* `Url (string)`: 
* `ContentType (string)`: 
* `IsActive (bool)`: 

<a name="paginated-organization-worker-task-webhook"></a>
## PaginatedOrganizationWorkerTaskWebhook
* `Rows (OrganizationWorkerTaskWebhook[])`: 
* `Count (int)`: 
* `Pagination (Pagination)`: 

`rows`は [OrganizationWorkerTaskWebhook](#organization-worker-task-webhook) オブジェクトの配列を返します。

`pagination`は [Pagination](#pagination) オブジェクトを返します。

<a name="coupon-detail"></a>
## CouponDetail
* `Id (string)`: クーポンID
* `Name (string)`: クーポン名
* `IssuedShop (User)`: クーポン発行店舗
* `Description (string)`: クーポンの説明文
* `DiscountAmount (int)`: クーポンによる値引き額(絶対値指定)
* `DiscountPercentage (double)`: クーポンによる値引き率
* `DiscountUpperLimit (int)`: クーポンによる値引き上限(値引き率が指定された場合の値引き上限額)
* `StartsAt (string)`: クーポンの利用可能期間(開始日時)
* `EndsAt (string)`: クーポンの利用可能期間(終了日時)
* `DisplayStartsAt (string)`: クーポンの掲載期間(開始日時)
* `DisplayEndsAt (string)`: クーポンの掲載期間(終了日時)
* `UsageLimit (int)`: ユーザごとの利用可能回数(NULLの場合は無制限)
* `MinAmount (int)`: クーポン適用可能な最小取引額
* `IsShopSpecified (bool)`: 特定店舗限定のクーポンかどうか
* `IsHidden (bool)`: クーポン一覧に掲載されるかどうか
* `IsPublic (bool)`: アプリ配信なしで受け取れるかどうか
* `Code (string)`: クーポン受け取りコード
* `IsDisabled (bool)`: 無効化フラグ
* `Token (string)`: クーポンを特定するためのトークン
* `CouponImage (string)`: クーポン画像のURL
* `AvailableShops (User[])`: 利用可能店舗リスト
* `PrivateMoney (PrivateMoney)`: クーポンのマネー
* `NumRecipientsCap (int)`: クーポンを受け取ることができるユーザ数上限
* `NumRecipients (int)`: クーポンを受け取ったユーザ数

`issued_shop`は [User](#user) オブジェクトを返します。

`available-shops`は [User](#user) オブジェクトの配列を返します。

`private_money`は [PrivateMoney](#private-money) オブジェクトを返します。

<a name="paginated-coupons"></a>
## PaginatedCoupons
* `Rows (Coupon[])`: 
* `Count (int)`: 
* `Pagination (Pagination)`: 

`rows`は [Coupon](#coupon) オブジェクトの配列を返します。

`pagination`は [Pagination](#pagination) オブジェクトを返します。

<a name="paginated-organizations"></a>
## PaginatedOrganizations
* `Rows (Organization[])`: 
* `Count (int)`: 
* `Pagination (Pagination)`: 

`rows`は [Organization](#organization) オブジェクトの配列を返します。

`pagination`は [Pagination](#pagination) オブジェクトを返します。

<a name="seven-bank-atm-session"></a>
## SevenBankATMSession
* `QrInfo (string)`: 
* `Account (AccountDetail)`: 
* `Amount (int)`: 
* `Transaction (Transaction)`: 
* `SevenBankCustomerNumber (string)`: 
* `AtmId (string)`: 
* `AudiId (string)`: 
* `IssuerCode (string)`: 
* `IssuerName (string)`: 
* `MoneyName (string)`: 

`account`は [AccountDetail](#account-detail) オブジェクトを返します。

`transaction`は [Transaction](#transaction) オブジェクトを返します。

<a name="private-money"></a>
## PrivateMoney
* `Id (string)`: マネーID
* `Name (string)`: マネー名
* `Unit (string)`: マネー単位 (例: 円)
* `IsExclusive (bool)`: 会員制のマネーかどうか
* `Description (string)`: マネー説明文
* `OnelineMessage (string)`: マネーの要約
* `Organization (Organization)`: マネーを発行した組織
* `MaxBalance (double)`: ウォレットの上限金額
* `TransferLimit (double)`: マネーの取引上限額
* `MoneyTopupTransferLimit (double)`: マネーチャージ取引上限額
* `Type (string)`: マネー種別 (自家型=own, 第三者型=third-party)
* `ExpirationType (string)`: 有効期限種別 (チャージ日起算=static, 最終利用日起算=last-update, 最終チャージ日起算=last-topup-update)
* `EnableTopupByMember (bool)`:  (deprecated)
* `DisplayMoneyAndPoint (string)`: 

`organization`は [Organization](#organization) オブジェクトを返します。

<a name="pagination"></a>
## Pagination
* `Current (int)`: 
* `PerPage (int)`: 
* `MaxPage (int)`: 
* `HasPrev (bool)`: 
* `HasNext (bool)`: 

<a name="transaction"></a>
## Transaction
* `Id (string)`: 取引ID
* `Type (string)`: 取引種別
* `IsModified (bool)`: 返金された取引かどうか
* `Sender (User)`: 送金者情報
* `SenderAccount (Account)`: 送金ウォレット情報
* `Receiver (User)`: 受取者情報
* `ReceiverAccount (Account)`: 受取ウォレット情報
* `Amount (double)`: 取引総額 (マネー額 + ポイント額)
* `MoneyAmount (double)`: 取引マネー額
* `PointAmount (double)`: 取引ポイント額(キャンペーン付与ポイント合算)
* `RawPointAmount (double)`: 取引ポイント額
* `CampaignPointAmount (double)`: キャンペーンによるポイント付与額
* `DoneAt (string)`: 取引日時
* `Description (string)`: 取引説明文

`receiver`と`sender`は [User](#user) オブジェクトを返します。

`receiver_account`と`sender_account`は [Account](#account) オブジェクトを返します。

<a name="external-transaction"></a>
## ExternalTransaction
* `Id (string)`: ポケペイ外部取引ID
* `IsModified (bool)`: 返金された取引かどうか
* `Sender (User)`: 送金者情報
* `SenderAccount (Account)`: 送金ウォレット情報
* `Receiver (User)`: 受取者情報
* `ReceiverAccount (Account)`: 受取ウォレット情報
* `Amount (double)`: 決済額
* `DoneAt (string)`: 取引日時
* `Description (string)`: 取引説明文

`receiver`と`sender`は [User](#user) オブジェクトを返します。

`receiver_account`と`sender_account`は [Account](#account) オブジェクトを返します。

<a name="cashtray-attempt"></a>
## CashtrayAttempt
* `Account (AccountWithUser)`: エンドユーザーのウォレット
* `StatusCode (double)`: ステータスコード
* `ErrorType (string)`: エラー型
* `ErrorMessage (string)`: エラーメッセージ
* `CreatedAt (string)`: Cashtray読み取り記録の作成日時

`account`は [AccountWithUser](#account-with-user) オブジェクトを返します。

<a name="account"></a>
## Account
* `Id (string)`: ウォレットID
* `Name (string)`: ウォレット名
* `IsSuspended (bool)`: ウォレットが凍結されているかどうか
* `Status (string)`: 
* `PrivateMoney (PrivateMoney)`: 設定マネー情報

`private_money`は [PrivateMoney](#private-money) オブジェクトを返します。

<a name="transfer"></a>
## Transfer
* `Id (string)`: 
* `SenderAccount (AccountWithoutPrivateMoneyDetail)`: 
* `ReceiverAccount (AccountWithoutPrivateMoneyDetail)`: 
* `Amount (double)`: 
* `MoneyAmount (double)`: 
* `PointAmount (double)`: 
* `DoneAt (string)`: 
* `Type (string)`: 
* `Description (string)`: 
* `TransactionId (string)`: 

`receiver_account`と`sender_account`は [AccountWithoutPrivateMoneyDetail](#account-without-private-money-detail) オブジェクトを返します。

<a name="shop-account"></a>
## ShopAccount
* `Id (string)`: ウォレットID
* `Name (string)`: ウォレット名
* `IsSuspended (bool)`: ウォレットが凍結されているかどうか
* `CanTransferTopup (bool)`: チャージ可能かどうか
* `PrivateMoney (PrivateMoney)`: 設定マネー情報

`private_money`は [PrivateMoney](#private-money) オブジェクトを返します。

<a name="bulk-transaction-job"></a>
## BulkTransactionJob
* `Id (int)`: 
* `BulkTransaction (BulkTransaction)`: 
* `Type (string)`: 取引種別
* `SenderAccountId (string)`: 
* `ReceiverAccountId (string)`: 
* `MoneyAmount (double)`: 
* `PointAmount (double)`: 
* `Description (string)`: バルク取引ジョブ管理用の説明文
* `BearPointAccountId (string)`: 
* `PointExpiresAt (string)`: ポイント有効期限
* `Status (string)`: バルク取引ジョブの状態
* `Error (string)`: バルク取引のエラー種別
* `Lineno (int)`: バルク取引のエラーが発生した行番号
* `TransactionId (string)`: 
* `CreatedAt (string)`: バルク取引ジョブが登録された日時
* `UpdatedAt (string)`: バルク取引ジョブが更新された日時

`bulk_transaction`は [BulkTransaction](#bulk-transaction) オブジェクトを返します。

<a name="private-money-organization-summary"></a>
## PrivateMoneyOrganizationSummary
* `OrganizationCode (string)`: 
* `Topup (OrganizationSummary)`: 
* `Payment (OrganizationSummary)`: 

`payment`と`topup`は [OrganizationSummary](#organization-summary) オブジェクトを返します。

<a name="bank"></a>
## Bank
* `Id (string)`: 
* `PrivateMoney (PrivateMoney)`: 
* `BankName (string)`: 
* `BankCode (string)`: 
* `BranchNumber (string)`: 
* `BranchName (string)`: 
* `DepositType (string)`: 
* `MaskedAccountNumber (string)`: 
* `AccountName (string)`: 

`private_money`は [PrivateMoney](#private-money) オブジェクトを返します。

<a name="bill-transaction"></a>
## BillTransaction
* `Transaction (Transaction)`: 
* `Bill (Bill)`: 

`transaction`は [Transaction](#transaction) オブジェクトを返します。

`bill`は [Bill](#bill) オブジェクトを返します。

<a name="account-balance"></a>
## AccountBalance
* `ExpiresAt (string)`: 
* `MoneyAmount (double)`: 
* `PointAmount (double)`: 

<a name="shop-with-metadata"></a>
## ShopWithMetadata
* `Id (string)`: 店舗ID
* `Name (string)`: 店舗名
* `OrganizationCode (string)`: 組織コード
* `Status (string)`: 店舗の状態
* `PostalCode (string)`: 店舗の郵便番号
* `Address (string)`: 店舗の住所
* `Tel (string)`: 店舗の電話番号
* `Email (string)`: 店舗のメールアドレス
* `ExternalId (string)`: 店舗の外部ID

<a name="account-transfer-summary-element"></a>
## AccountTransferSummaryElement
* `TransferType (string)`: 
* `MoneyAmount (double)`: 
* `PointAmount (double)`: 
* `Count (double)`: 

<a name="coupon"></a>
## Coupon
* `Id (string)`: クーポンID
* `Name (string)`: クーポン名
* `IssuedShop (User)`: クーポン発行店舗
* `Description (string)`: クーポンの説明文
* `DiscountAmount (int)`: クーポンによる値引き額(絶対値指定)
* `DiscountPercentage (double)`: クーポンによる値引き率
* `DiscountUpperLimit (int)`: クーポンによる値引き上限(値引き率が指定された場合の値引き上限額)
* `StartsAt (string)`: クーポンの利用可能期間(開始日時)
* `EndsAt (string)`: クーポンの利用可能期間(終了日時)
* `DisplayStartsAt (string)`: クーポンの掲載期間(開始日時)
* `DisplayEndsAt (string)`: クーポンの掲載期間(終了日時)
* `UsageLimit (int)`: ユーザごとの利用可能回数(NULLの場合は無制限)
* `MinAmount (int)`: クーポン適用可能な最小取引額
* `IsShopSpecified (bool)`: 特定店舗限定のクーポンかどうか
* `IsHidden (bool)`: クーポン一覧に掲載されるかどうか
* `IsPublic (bool)`: アプリ配信なしで受け取れるかどうか
* `Code (string)`: クーポン受け取りコード
* `IsDisabled (bool)`: 無効化フラグ
* `Token (string)`: クーポンを特定するためのトークン
* `NumRecipientsCap (int)`: クーポンを受け取ることができるユーザ数上限
* `NumRecipients (int)`: クーポンを受け取ったユーザ数

`issued_shop`は [User](#user) オブジェクトを返します。

<a name="account-without-private-money-detail"></a>
## AccountWithoutPrivateMoneyDetail
* `Id (string)`: 
* `Name (string)`: 
* `IsSuspended (bool)`: 
* `Status (string)`: 
* `PrivateMoneyId (string)`: 
* `User (User)`: 

`user`は [User](#user) オブジェクトを返します。

<a name="organization-summary"></a>
## OrganizationSummary
* `Count (int)`: 
* `MoneyAmount (double)`: 
* `MoneyCount (int)`: 
* `PointAmount (double)`: 
* `RawPointAmount (double)`: 
* `CampaignPointAmount (double)`: 
* `PointCount (int)`: 
