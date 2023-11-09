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
                    "ed94d818-c5a5-4f4b-8c55-822be4d94d26",
                    "fa0f8eb7-8469-4778-a4b6-53f65a2c3199",
                    "1727e844-c3bc-4933-825c-8d04c682d454",
                    3823.0
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
                    "ed94d818-c5a5-4f4b-8c55-822be4d94d26",
                    "fa0f8eb7-8469-4778-a4b6-53f65a2c3199",
                    "1727e844-c3bc-4933-825c-8d04c682d454",
                    3823.0
                ) {
                    RequestId = "a473aa82-a41f-4314-a9a6-9a4e22c761e3",
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
                    "ed94d818-c5a5-4f4b-8c55-822be4d94d26",
                    "fa0f8eb7-8469-4778-a4b6-53f65a2c3199",
                    "1727e844-c3bc-4933-825c-8d04c682d454",
                    3823.0
                ) {
                    Description = "Iv4Cy2qiGNeSDJueWNAF2iLhkB08mWoSEw4Yfnz5e3bjXKldANGzSZe49qKV1rholLnfHAgpNJKDDEjuzSmETPUL6TDRxNmjKW",
                    RequestId = "e16c5914-c5d0-4c11-84bc-cec52b1041fa",
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
