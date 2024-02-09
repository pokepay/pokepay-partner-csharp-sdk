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
    public class TestCreateCpmTransaction
    {
        private Client client;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            client = new Client("~/.pokepay/test-config.ini");
        }

        [Test]
        public async Task CreateCpmTransaction0()
        {
            try {
                Request.CreateCpmTransaction request = new Request.CreateCpmTransaction(
                    "jMgk8QSZwJ1udEIb7zDJ6K",
                    "18bed4da-27d4-4c23-91db-b3c5b1944e6b",
                    4884.0
                );
                Response.TransactionDetail response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task CreateCpmTransaction1()
        {
            try {
                Request.CreateCpmTransaction request = new Request.CreateCpmTransaction(
                    "jMgk8QSZwJ1udEIb7zDJ6K",
                    "18bed4da-27d4-4c23-91db-b3c5b1944e6b",
                    4884.0
                ) {
                    RequestId = "fb9e0f30-8d3a-4e08-ad27-35c422d3be7f",
                };
                Response.TransactionDetail response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task CreateCpmTransaction2()
        {
            try {
                Request.CreateCpmTransaction request = new Request.CreateCpmTransaction(
                    "jMgk8QSZwJ1udEIb7zDJ6K",
                    "18bed4da-27d4-4c23-91db-b3c5b1944e6b",
                    4884.0
                ) {
                    Products = new object[]{new Dictionary<string, object>(){{"jan_code","abc"}, {"name","name1"}, {"unit_price",100}, {"price",100}, {"is_discounted",false}, {"other","{}"}}, new Dictionary<string, object>(){{"jan_code","abc"}, {"name","name1"}, {"unit_price",100}, {"price",100}, {"is_discounted",false}, {"other","{}"}}, new Dictionary<string, object>(){{"jan_code","abc"}, {"name","name1"}, {"unit_price",100}, {"price",100}, {"is_discounted",false}, {"other","{}"}}},
                    RequestId = "23667b47-a8f1-46bf-a438-206a38759b97",
                };
                Response.TransactionDetail response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task CreateCpmTransaction3()
        {
            try {
                Request.CreateCpmTransaction request = new Request.CreateCpmTransaction(
                    "jMgk8QSZwJ1udEIb7zDJ6K",
                    "18bed4da-27d4-4c23-91db-b3c5b1944e6b",
                    4884.0
                ) {
                    Metadata = "{\"key\":\"value\"}",
                    Products = new object[]{new Dictionary<string, object>(){{"jan_code","abc"}, {"name","name1"}, {"unit_price",100}, {"price",100}, {"is_discounted",false}, {"other","{}"}}},
                    RequestId = "d06e9347-04e9-4b68-8632-23298ca3f192",
                };
                Response.TransactionDetail response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task CreateCpmTransaction4()
        {
            try {
                Request.CreateCpmTransaction request = new Request.CreateCpmTransaction(
                    "jMgk8QSZwJ1udEIb7zDJ6K",
                    "18bed4da-27d4-4c23-91db-b3c5b1944e6b",
                    4884.0
                ) {
                    Description = "zo2GN3QYDG6CZS1PVe5LZzi2NmWBluHrzflOytNd3ROmH9nMfAHnX3LOs6P3dxLhDjrt4CFESWJnPCLUxGLtrgoghS3pP",
                    Metadata = "{\"key\":\"value\"}",
                    Products = new object[]{new Dictionary<string, object>(){{"jan_code","abc"}, {"name","name1"}, {"unit_price",100}, {"price",100}, {"is_discounted",false}, {"other","{}"}}, new Dictionary<string, object>(){{"jan_code","abc"}, {"name","name1"}, {"unit_price",100}, {"price",100}, {"is_discounted",false}, {"other","{}"}}, new Dictionary<string, object>(){{"jan_code","abc"}, {"name","name1"}, {"unit_price",100}, {"price",100}, {"is_discounted",false}, {"other","{}"}}, new Dictionary<string, object>(){{"jan_code","abc"}, {"name","name1"}, {"unit_price",100}, {"price",100}, {"is_discounted",false}, {"other","{}"}}},
                    RequestId = "338ac73d-0ec8-4345-b5b7-80b49109483c",
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
