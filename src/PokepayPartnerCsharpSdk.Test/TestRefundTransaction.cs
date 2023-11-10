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
    public class TestRefundTransaction
    {
        private Client client;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            client = new Client("~/.pokepay/test-config.ini");
        }

        [Test]
        public async Task RefundTransaction0()
        {
            try {
                Request.RefundTransaction request = new Request.RefundTransaction(
                    "f7cd9220-e7fc-4b2b-9e1c-c370596ec833"
                );
                Response.TransactionDetail response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task RefundTransaction1()
        {
            try {
                Request.RefundTransaction request = new Request.RefundTransaction(
                    "f7cd9220-e7fc-4b2b-9e1c-c370596ec833"
                ) {
                    ReturningPointExpiresAt = "2016-03-20T20:29:17.000000+09:00",
                };
                Response.TransactionDetail response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task RefundTransaction2()
        {
            try {
                Request.RefundTransaction request = new Request.RefundTransaction(
                    "f7cd9220-e7fc-4b2b-9e1c-c370596ec833"
                ) {
                    Description = "0EwmiwnDqaTm7Ttair2CeybDHw",
                    ReturningPointExpiresAt = "2021-01-02T00:35:56.000000+09:00",
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
