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
    public class TestRefundExternalTransaction
    {
        private Client client;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            client = new Client("~/.pokepay/test-config.ini");
        }

        [Test]
        public async Task RefundExternalTransaction0()
        {
            try {
                Request.RefundExternalTransaction request = new Request.RefundExternalTransaction(
                    "10291337-f3f0-49f2-b464-2005f27706b2"
                );
                Response.ExternalTransactionDetail response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task RefundExternalTransaction1()
        {
            try {
                Request.RefundExternalTransaction request = new Request.RefundExternalTransaction(
                    "10291337-f3f0-49f2-b464-2005f27706b2"
                ) {
                    Description = "jpaf36YY6mrG9Y2ztoKUUUx5B1bSO8xEgnoe60dnWTCVmm3x115QsBZT6dCGgqZsePkl6iY0bdXM6Nza2rTctUJQmh0gNd3qkWY4lVW5zCUF3zWzIdrHm6OsiyHBxsWBtx4G7cLV",
                };
                Response.ExternalTransactionDetail response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

    }
}
