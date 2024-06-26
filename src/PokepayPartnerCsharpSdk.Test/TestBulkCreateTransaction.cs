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
    public class TestBulkCreateTransaction
    {
        private Client client;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            client = new Client("~/.pokepay/test-config.ini");
        }

        [Test]
        public async Task BulkCreateTransaction0()
        {
            try {
                Request.BulkCreateTransaction request = new Request.BulkCreateTransaction(
                    "SJ9o4hVc0u6tzaZ3sbYKC",
                    "bmAlkaNJiO",
                    "vuRswwQSmiJco3KwhjqpMqyENnnotJKNM2Dv"
                );
                Response.BulkTransaction response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task BulkCreateTransaction1()
        {
            try {
                Request.BulkCreateTransaction request = new Request.BulkCreateTransaction(
                    "SJ9o4hVc0u6tzaZ3sbYKC",
                    "bmAlkaNJiO",
                    "vuRswwQSmiJco3KwhjqpMqyENnnotJKNM2Dv"
                ) {
                    PrivateMoneyId = "703c377c-3ed1-428b-a827-9c18a076be05",
                };
                Response.BulkTransaction response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task BulkCreateTransaction2()
        {
            try {
                Request.BulkCreateTransaction request = new Request.BulkCreateTransaction(
                    "SJ9o4hVc0u6tzaZ3sbYKC",
                    "bmAlkaNJiO",
                    "vuRswwQSmiJco3KwhjqpMqyENnnotJKNM2Dv"
                ) {
                    Description = "u06FE8juzeNINZktFZU0JpHpSrpNbF8O3WzYFSGY9bWV5jbNBEz14f9BIpTXI2luGWaGy1CoCYoYmaLr1BLY",
                    PrivateMoneyId = "db01c22d-6011-4ce4-a38d-62e775c56e73",
                };
                Response.BulkTransaction response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

    }
}
