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
    public class WebhookTests
    {
        private Client client;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            client = new Client("~/.pokepay/test-config.ini");
        }

        [Test]
        public async Task test0()
        {
            Response.PaginatedOrganizationWorkerTaskWebhook list = await new Request.ListWebhooks().Send(client);
            foreach (Response.OrganizationWorkerTaskWebhook row in list.Rows)
            {
                await new Request.DeleteWebhook(
                    row.Id
                ).Send(client);
            }
            Response.OrganizationWorkerTaskWebhook webhook1 = await new Request.CreateWebhook(
                "bulk_shops",
                "http://localhost/bulk_shops"
            ).Send(client);
            Assert.AreEqual("coilinc", webhook1.OrganizationCode);
            Assert.AreEqual("bulk_shops", webhook1.Task);
            Assert.AreEqual("http://localhost/bulk_shops", webhook1.Url);
            Assert.AreEqual(true, webhook1.IsActive);
            Assert.AreEqual("application/json", webhook1.ContentType);
            Response.OrganizationWorkerTaskWebhook webhook2 = await new Request.CreateWebhook(
                "process_user_stats_operation",
                "http://localhost/process_user_stats_operation"
            ).Send(client);
            Assert.AreEqual("coilinc", webhook2.OrganizationCode);
            Assert.AreEqual("process_user_stats_operation", webhook2.Task);
            Assert.AreEqual("http://localhost/process_user_stats_operation", webhook2.Url);
            Assert.AreEqual(true, webhook2.IsActive);
            Assert.AreEqual("application/json", webhook2.ContentType);
            Response.PaginatedOrganizationWorkerTaskWebhook list2 = await new Request.ListWebhooks().Send(client);
            Assert.AreEqual(2, list2.Count);
            Assert.AreEqual(webhook2.Id, list2.Rows[0].Id);
            Assert.AreEqual(webhook1.Id, list2.Rows[1].Id);
            Response.OrganizationWorkerTaskWebhook update_response = await new Request.UpdateWebhook(
                webhook1.Id
            ) {

                IsActive = false,}
            .Send(client);
            Assert.AreEqual(webhook1.Id, update_response.Id);
            Assert.AreEqual(webhook1.OrganizationCode, update_response.OrganizationCode);
            Assert.AreEqual(webhook1.Task, update_response.Task);
            Assert.AreEqual(webhook1.Url, update_response.Url);
            Assert.AreEqual(webhook1.ContentType, update_response.ContentType);
            Assert.AreEqual(false, update_response.IsActive);
        }
    }
}
