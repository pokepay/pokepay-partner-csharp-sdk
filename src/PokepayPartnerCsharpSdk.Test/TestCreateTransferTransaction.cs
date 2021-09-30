// DO NOT EDIT: File is generated by code generator.
#nullable enable
using System;
using System.Net;
using System.Net.Http;
using NUnit.Framework;
using System.Threading.Tasks;

using PokepayPartnerCsharpSdk;

namespace PokepayPartnerCsharpSdk.Test
{
    public class TestCreateTransferTransaction
    {
        private Client? client;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            client = new Client("~/.pokepay/test-config.ini");
        }

        [Test]
        public async Task CreateTransferTransaction0()
        {
            try {
                Request.CreateTransferTransaction request = new Request.CreateTransferTransaction(
                    "c6facea8-e164-48fc-87c9-a84019ec9c26",
                    "6dd80cf8-ca43-4a84-a641-f956391b6c5e",
                    "efceb8d8-8775-4c90-b877-00bb8cb8e650",
                    4891
                );
                Response.Transaction response = await request.Send(client!);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.StatusCode!, (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.StatusCode >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task CreateTransferTransaction1()
        {
            try {
                Request.CreateTransferTransaction request = new Request.CreateTransferTransaction(
                    "c6facea8-e164-48fc-87c9-a84019ec9c26",
                    "6dd80cf8-ca43-4a84-a641-f956391b6c5e",
                    "efceb8d8-8775-4c90-b877-00bb8cb8e650",
                    4891
                ) {
                    RequestId = "8d75fd46-dee4-48cd-892b-67a22942bdb0"
                };
                Response.Transaction response = await request.Send(client!);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.StatusCode!, (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.StatusCode >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task CreateTransferTransaction2()
        {
            try {
                Request.CreateTransferTransaction request = new Request.CreateTransferTransaction(
                    "c6facea8-e164-48fc-87c9-a84019ec9c26",
                    "6dd80cf8-ca43-4a84-a641-f956391b6c5e",
                    "efceb8d8-8775-4c90-b877-00bb8cb8e650",
                    4891
                ) {
                    Description = "8RX9GwTm1EaeDH0runisLVA8D7RtvLwRN8QmXijHIyMGxrgTxrmP2c2b7AqdqrRaU4tsNqOUthYSxSa5qYfKcdpEzIZoGgQ8JT7nM2XS",
                    RequestId = "df9a62fb-4791-4cd2-bc10-4aaa2b1f3189"
                };
                Response.Transaction response = await request.Send(client!);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.StatusCode!, (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.StatusCode >= 300, "Should be larger than 300");
            }
        }

    }
}
