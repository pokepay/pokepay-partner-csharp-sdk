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
    public class TestCreatePaymentTransaction
    {
        private Client client;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            client = new Client("~/.pokepay/test-config.ini");
        }

        [Test]
        public async Task CreatePaymentTransaction0()
        {
            try {
                Request.CreatePaymentTransaction request = new Request.CreatePaymentTransaction(
                    "0023f1f8-40cc-4a68-84a1-e8eae07d7e8a",
                    "71ca7b90-1872-4df4-a134-a8af3d299b43",
                    "b371718c-f146-41bc-857c-75debe8b1e16",
                    9418
                );
                Response.TransactionDetail response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task CreatePaymentTransaction1()
        {
            try {
                Request.CreatePaymentTransaction request = new Request.CreatePaymentTransaction(
                    "0023f1f8-40cc-4a68-84a1-e8eae07d7e8a",
                    "71ca7b90-1872-4df4-a134-a8af3d299b43",
                    "b371718c-f146-41bc-857c-75debe8b1e16",
                    9418
                ) {
                    RequestId = "804fd502-9d1b-43bd-ae50-809558cde5bd",
                };
                Response.TransactionDetail response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task CreatePaymentTransaction2()
        {
            try {
                Request.CreatePaymentTransaction request = new Request.CreatePaymentTransaction(
                    "0023f1f8-40cc-4a68-84a1-e8eae07d7e8a",
                    "71ca7b90-1872-4df4-a134-a8af3d299b43",
                    "b371718c-f146-41bc-857c-75debe8b1e16",
                    9418
                ) {
                    Products = new object[]{new Dictionary<string, object>(){{"jan_code","abc"}, {"name","name1"}, {"unit_price",100}, {"price",100}, {"quantity",1}, {"is_discounted",false}, {"other","{}"}}, new Dictionary<string, object>(){{"jan_code","abc"}, {"name","name1"}, {"unit_price",100}, {"price",100}, {"quantity",1}, {"is_discounted",false}, {"other","{}"}}, new Dictionary<string, object>(){{"jan_code","abc"}, {"name","name1"}, {"unit_price",100}, {"price",100}, {"quantity",1}, {"is_discounted",false}, {"other","{}"}}, new Dictionary<string, object>(){{"jan_code","abc"}, {"name","name1"}, {"unit_price",100}, {"price",100}, {"quantity",1}, {"is_discounted",false}, {"other","{}"}}, new Dictionary<string, object>(){{"jan_code","abc"}, {"name","name1"}, {"unit_price",100}, {"price",100}, {"quantity",1}, {"is_discounted",false}, {"other","{}"}}, new Dictionary<string, object>(){{"jan_code","abc"}, {"name","name1"}, {"unit_price",100}, {"price",100}, {"quantity",1}, {"is_discounted",false}, {"other","{}"}}, new Dictionary<string, object>(){{"jan_code","abc"}, {"name","name1"}, {"unit_price",100}, {"price",100}, {"quantity",1}, {"is_discounted",false}, {"other","{}"}}},
                    RequestId = "03e7ea9d-e108-479a-834c-74555284398b",
                };
                Response.TransactionDetail response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task CreatePaymentTransaction3()
        {
            try {
                Request.CreatePaymentTransaction request = new Request.CreatePaymentTransaction(
                    "0023f1f8-40cc-4a68-84a1-e8eae07d7e8a",
                    "71ca7b90-1872-4df4-a134-a8af3d299b43",
                    "b371718c-f146-41bc-857c-75debe8b1e16",
                    9418
                ) {
                    Metadata = "{\"key\":\"value\"}",
                    Products = new object[]{new Dictionary<string, object>(){{"jan_code","abc"}, {"name","name1"}, {"unit_price",100}, {"price",100}, {"quantity",1}, {"is_discounted",false}, {"other","{}"}}, new Dictionary<string, object>(){{"jan_code","abc"}, {"name","name1"}, {"unit_price",100}, {"price",100}, {"quantity",1}, {"is_discounted",false}, {"other","{}"}}, new Dictionary<string, object>(){{"jan_code","abc"}, {"name","name1"}, {"unit_price",100}, {"price",100}, {"quantity",1}, {"is_discounted",false}, {"other","{}"}}, new Dictionary<string, object>(){{"jan_code","abc"}, {"name","name1"}, {"unit_price",100}, {"price",100}, {"quantity",1}, {"is_discounted",false}, {"other","{}"}}, new Dictionary<string, object>(){{"jan_code","abc"}, {"name","name1"}, {"unit_price",100}, {"price",100}, {"quantity",1}, {"is_discounted",false}, {"other","{}"}}, new Dictionary<string, object>(){{"jan_code","abc"}, {"name","name1"}, {"unit_price",100}, {"price",100}, {"quantity",1}, {"is_discounted",false}, {"other","{}"}}, new Dictionary<string, object>(){{"jan_code","abc"}, {"name","name1"}, {"unit_price",100}, {"price",100}, {"quantity",1}, {"is_discounted",false}, {"other","{}"}}, new Dictionary<string, object>(){{"jan_code","abc"}, {"name","name1"}, {"unit_price",100}, {"price",100}, {"quantity",1}, {"is_discounted",false}, {"other","{}"}}, new Dictionary<string, object>(){{"jan_code","abc"}, {"name","name1"}, {"unit_price",100}, {"price",100}, {"quantity",1}, {"is_discounted",false}, {"other","{}"}}},
                    RequestId = "c3f3b2c7-991f-42be-abbc-b6bb9035e04c",
                };
                Response.TransactionDetail response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task CreatePaymentTransaction4()
        {
            try {
                Request.CreatePaymentTransaction request = new Request.CreatePaymentTransaction(
                    "0023f1f8-40cc-4a68-84a1-e8eae07d7e8a",
                    "71ca7b90-1872-4df4-a134-a8af3d299b43",
                    "b371718c-f146-41bc-857c-75debe8b1e16",
                    9418
                ) {
                    Description = "rgoghS3pPHE574eeX1ksH4R2MgyW6z149JBRZmQUgzecqWdDVSstoEtPVoykbtA6l7WDayqQLAKXyhWYdlIHfSBBKI1KQ",
                    Metadata = "{\"key\":\"value\"}",
                    Products = new object[]{new Dictionary<string, object>(){{"jan_code","abc"}, {"name","name1"}, {"unit_price",100}, {"price",100}, {"quantity",1}, {"is_discounted",false}, {"other","{}"}}, new Dictionary<string, object>(){{"jan_code","abc"}, {"name","name1"}, {"unit_price",100}, {"price",100}, {"quantity",1}, {"is_discounted",false}, {"other","{}"}}, new Dictionary<string, object>(){{"jan_code","abc"}, {"name","name1"}, {"unit_price",100}, {"price",100}, {"quantity",1}, {"is_discounted",false}, {"other","{}"}}, new Dictionary<string, object>(){{"jan_code","abc"}, {"name","name1"}, {"unit_price",100}, {"price",100}, {"quantity",1}, {"is_discounted",false}, {"other","{}"}}, new Dictionary<string, object>(){{"jan_code","abc"}, {"name","name1"}, {"unit_price",100}, {"price",100}, {"quantity",1}, {"is_discounted",false}, {"other","{}"}}},
                    RequestId = "4328a863-d14b-49a9-9d36-b39927c16cc8",
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
