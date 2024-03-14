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
                    "c38e1368-27f8-4e40-ad73-ba121ece97f2",
                    "e3a6d8da-6fca-4319-9026-889774578a1c",
                    "6049173e-a862-4eb5-bc42-de03ac7928b1",
                    7243
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
                    "c38e1368-27f8-4e40-ad73-ba121ece97f2",
                    "e3a6d8da-6fca-4319-9026-889774578a1c",
                    "6049173e-a862-4eb5-bc42-de03ac7928b1",
                    7243
                ) {
                    RequestId = "0aca1db9-f05a-4ccc-82ca-d9fe71e4fbea",
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
                    "c38e1368-27f8-4e40-ad73-ba121ece97f2",
                    "e3a6d8da-6fca-4319-9026-889774578a1c",
                    "6049173e-a862-4eb5-bc42-de03ac7928b1",
                    7243
                ) {
                    Products = new object[]{new Dictionary<string, object>(){{"jan_code","abc"}, {"name","name1"}, {"unit_price",100}, {"price",100}, {"is_discounted",false}, {"other","{}"}}, new Dictionary<string, object>(){{"jan_code","abc"}, {"name","name1"}, {"unit_price",100}, {"price",100}, {"is_discounted",false}, {"other","{}"}}, new Dictionary<string, object>(){{"jan_code","abc"}, {"name","name1"}, {"unit_price",100}, {"price",100}, {"is_discounted",false}, {"other","{}"}}, new Dictionary<string, object>(){{"jan_code","abc"}, {"name","name1"}, {"unit_price",100}, {"price",100}, {"is_discounted",false}, {"other","{}"}}, new Dictionary<string, object>(){{"jan_code","abc"}, {"name","name1"}, {"unit_price",100}, {"price",100}, {"is_discounted",false}, {"other","{}"}}, new Dictionary<string, object>(){{"jan_code","abc"}, {"name","name1"}, {"unit_price",100}, {"price",100}, {"is_discounted",false}, {"other","{}"}}},
                    RequestId = "38478551-9cfa-4872-a3c7-4e342be56ae3",
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
                    "c38e1368-27f8-4e40-ad73-ba121ece97f2",
                    "e3a6d8da-6fca-4319-9026-889774578a1c",
                    "6049173e-a862-4eb5-bc42-de03ac7928b1",
                    7243
                ) {
                    Metadata = "{\"key\":\"value\"}",
                    Products = new object[]{new Dictionary<string, object>(){{"jan_code","abc"}, {"name","name1"}, {"unit_price",100}, {"price",100}, {"is_discounted",false}, {"other","{}"}}, new Dictionary<string, object>(){{"jan_code","abc"}, {"name","name1"}, {"unit_price",100}, {"price",100}, {"is_discounted",false}, {"other","{}"}}, new Dictionary<string, object>(){{"jan_code","abc"}, {"name","name1"}, {"unit_price",100}, {"price",100}, {"is_discounted",false}, {"other","{}"}}, new Dictionary<string, object>(){{"jan_code","abc"}, {"name","name1"}, {"unit_price",100}, {"price",100}, {"is_discounted",false}, {"other","{}"}}, new Dictionary<string, object>(){{"jan_code","abc"}, {"name","name1"}, {"unit_price",100}, {"price",100}, {"is_discounted",false}, {"other","{}"}}, new Dictionary<string, object>(){{"jan_code","abc"}, {"name","name1"}, {"unit_price",100}, {"price",100}, {"is_discounted",false}, {"other","{}"}}, new Dictionary<string, object>(){{"jan_code","abc"}, {"name","name1"}, {"unit_price",100}, {"price",100}, {"is_discounted",false}, {"other","{}"}}},
                    RequestId = "024f6100-745f-4378-8d39-9739e6d0b630",
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
                    "c38e1368-27f8-4e40-ad73-ba121ece97f2",
                    "e3a6d8da-6fca-4319-9026-889774578a1c",
                    "6049173e-a862-4eb5-bc42-de03ac7928b1",
                    7243
                ) {
                    Description = "5go4dBLdUCSZVd4cTqnNfSRiXLw6IXxof4N3bX72yEerLNEKMYsRf9vriYiP8HndtLKgF",
                    Metadata = "{\"key\":\"value\"}",
                    Products = new object[]{new Dictionary<string, object>(){{"jan_code","abc"}, {"name","name1"}, {"unit_price",100}, {"price",100}, {"is_discounted",false}, {"other","{}"}}, new Dictionary<string, object>(){{"jan_code","abc"}, {"name","name1"}, {"unit_price",100}, {"price",100}, {"is_discounted",false}, {"other","{}"}}, new Dictionary<string, object>(){{"jan_code","abc"}, {"name","name1"}, {"unit_price",100}, {"price",100}, {"is_discounted",false}, {"other","{}"}}, new Dictionary<string, object>(){{"jan_code","abc"}, {"name","name1"}, {"unit_price",100}, {"price",100}, {"is_discounted",false}, {"other","{}"}}, new Dictionary<string, object>(){{"jan_code","abc"}, {"name","name1"}, {"unit_price",100}, {"price",100}, {"is_discounted",false}, {"other","{}"}}, new Dictionary<string, object>(){{"jan_code","abc"}, {"name","name1"}, {"unit_price",100}, {"price",100}, {"is_discounted",false}, {"other","{}"}}, new Dictionary<string, object>(){{"jan_code","abc"}, {"name","name1"}, {"unit_price",100}, {"price",100}, {"is_discounted",false}, {"other","{}"}}},
                    RequestId = "75025857-893b-4ec9-9be5-f22b203f8a8d",
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
