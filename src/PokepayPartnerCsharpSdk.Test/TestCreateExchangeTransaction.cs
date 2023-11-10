// DO NOT EDIT: File is generated by code generator.
using System;
using System.Net;
using System.Net.Http;
using NUnit.Framework;
using System.Threading.Tasks;
using System.Collections.Generic;

using PokepayPartnerCsharpSdk;

namespace PokepayPartnerCsharpSdk.Test
{
    public class TestCreateExchangeTransaction
    {
        private Client client;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            client = new Client("~/.pokepay/test-config.ini");
        }

        [Test]
        public async Task CreateExchangeTransaction0()
        {
            try {
                Request.CreateExchangeTransaction request = new Request.CreateExchangeTransaction(
                    "89d70bcc-5348-40f5-b878-314224a0f868",
                    "cf203849-4adb-4632-b4d3-d9e5ca8c76d6",
                    "6909e035-9476-412e-a5bc-91f69cd9f7f3",
                    7078.0
                );
                Response.TransactionDetail response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task CreateExchangeTransaction1()
        {
            try {
                Request.CreateExchangeTransaction request = new Request.CreateExchangeTransaction(
                    "89d70bcc-5348-40f5-b878-314224a0f868",
                    "cf203849-4adb-4632-b4d3-d9e5ca8c76d6",
                    "6909e035-9476-412e-a5bc-91f69cd9f7f3",
                    7078.0
                ) {
                    RequestId = "cb29c7c8-88fb-4c37-b85e-5faf7323daa3",
                };
                Response.TransactionDetail response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task CreateExchangeTransaction2()
        {
            try {
                Request.CreateExchangeTransaction request = new Request.CreateExchangeTransaction(
                    "89d70bcc-5348-40f5-b878-314224a0f868",
                    "cf203849-4adb-4632-b4d3-d9e5ca8c76d6",
                    "6909e035-9476-412e-a5bc-91f69cd9f7f3",
                    7078.0
                ) {
                    Description = "jGpWmUFjwKlKruaLRuFt4LogflE21rvfGp5KRbpkrSoN0fNjgkoETmxsX5WJ1mnzkXFtRA7xYBRNcPnOX2UOJaoJf7DhoUomKM1bYhl9CkUdKSn2GiN3BSWwUstM39H1aN5",
                    RequestId = "6cf5584e-0372-472e-b4d6-8858d550ba0d",
                };
                Response.TransactionDetail response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

    }
}
