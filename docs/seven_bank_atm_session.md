# SevenBankATMSession
セブンATMチャージの取引内容を照会するAPIを提供しています。


<a name="get-seven-bank-atm-session"></a>
## GetSevenBankATMSession: セブン銀行ATMセッションの取得
セブン銀行ATMセッションを取得します

```csharp
Request.GetSevenBankAtmSession request = new Request.GetSevenBankAtmSession(
    "RuNHWw3" // QRコードの情報
);
Response.SevenBankATMSession response = await request.Send(client);
```



### Parameters
**`qr_info`** 
  

取得するセブン銀行ATMチャージのQRコードの情報です。

```json
{
  "type": "string"
}
```



成功したときは
[SevenBankATMSession](./responses.md#seven-bank-atm-session)
を返します



---



