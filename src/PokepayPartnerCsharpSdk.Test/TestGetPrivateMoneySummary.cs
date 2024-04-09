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
    public class TestGetPrivateMoneySummary
    {
        private Client client;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            client = new Client("~/.pokepay/test-config.ini");
        }

        [Test]
        public async Task GetPrivateMoneySummary0()
        {
            try {
                Request.GetPrivateMoneySummary request = new Request.GetPrivateMoneySummary(
                    "dbd3f582-dc6f-4a85-9f52-b6e55af92926"
                );
                Response.PrivateMoneySummary response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task GetPrivateMoneySummary1()
        {
            try {
                Request.GetPrivateMoneySummary request = new Request.GetPrivateMoneySummary(
                    "dbd3f582-dc6f-4a85-9f52-b6e55af92926"
                ) {
                    To = "2020-03-24T13:03:12.000000Z",
                };
                Response.PrivateMoneySummary response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task GetPrivateMoneySummary2()
        {
            try {
                Request.GetPrivateMoneySummary request = new Request.GetPrivateMoneySummary(
                    "dbd3f582-dc6f-4a85-9f52-b6e55af92926"
                ) {
                    From = "2020-12-25T12:28:03.000000Z",
                    To = "2021-06-11T03:44:43.000000Z",
                };
                Response.PrivateMoneySummary response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

    }
}
