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
                    "0be2928e-c4d1-4475-870b-6b3ce73cf57f",
                    "29a2963b-d109-4587-9494-d531b4d31dae",
                    "0af0e039-05b8-490e-af0b-3c3ec707c134",
                    4324
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
                    "0be2928e-c4d1-4475-870b-6b3ce73cf57f",
                    "29a2963b-d109-4587-9494-d531b4d31dae",
                    "0af0e039-05b8-490e-af0b-3c3ec707c134",
                    4324
                ) {
                    RequestId = "5b8c1045-7438-4e79-a58e-622e5cfa8838",
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
                    "0be2928e-c4d1-4475-870b-6b3ce73cf57f",
                    "29a2963b-d109-4587-9494-d531b4d31dae",
                    "0af0e039-05b8-490e-af0b-3c3ec707c134",
                    4324
                ) {
                    Description = "xiCptr",
                    RequestId = "a3a15640-677e-4e99-b82b-e8a868cdd958",
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
