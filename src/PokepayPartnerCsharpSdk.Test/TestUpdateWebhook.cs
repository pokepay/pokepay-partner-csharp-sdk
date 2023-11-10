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
    public class TestUpdateWebhook
    {
        private Client client;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            client = new Client("~/.pokepay/test-config.ini");
        }

        [Test]
        public async Task UpdateWebhook0()
        {
            try {
                Request.UpdateWebhook request = new Request.UpdateWebhook(
                    "104f5f27-c420-4652-a69d-1c4b80fbe607"
                );
                Response.OrganizationWorkerTaskWebhook response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task UpdateWebhook1()
        {
            try {
                Request.UpdateWebhook request = new Request.UpdateWebhook(
                    "104f5f27-c420-4652-a69d-1c4b80fbe607"
                ) {
                    Task = "bulk_shops",
                };
                Response.OrganizationWorkerTaskWebhook response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task UpdateWebhook2()
        {
            try {
                Request.UpdateWebhook request = new Request.UpdateWebhook(
                    "104f5f27-c420-4652-a69d-1c4b80fbe607"
                ) {
                    IsActive = true,
                    Task = "process_user_stats_operation",
                };
                Response.OrganizationWorkerTaskWebhook response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task UpdateWebhook3()
        {
            try {
                Request.UpdateWebhook request = new Request.UpdateWebhook(
                    "104f5f27-c420-4652-a69d-1c4b80fbe607"
                ) {
                    Url = "XjTLwIIt8",
                    IsActive = true,
                    Task = "process_user_stats_operation",
                };
                Response.OrganizationWorkerTaskWebhook response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

    }
}
