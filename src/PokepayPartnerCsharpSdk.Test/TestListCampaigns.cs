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
    public class TestListCampaigns
    {
        private Client client;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            client = new Client("~/.pokepay/test-config.ini");
        }

        [Test]
        public async Task ListCampaigns0()
        {
            try {
                Request.ListCampaigns request = new Request.ListCampaigns(
                    "0b04c1b9-00b1-4cf2-90e0-5cd6ca36e237"
                );
                Response.PaginatedCampaigns response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListCampaigns1()
        {
            try {
                Request.ListCampaigns request = new Request.ListCampaigns(
                    "0b04c1b9-00b1-4cf2-90e0-5cd6ca36e237"
                ) {
                    PerPage = 7,
                };
                Response.PaginatedCampaigns response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListCampaigns2()
        {
            try {
                Request.ListCampaigns request = new Request.ListCampaigns(
                    "0b04c1b9-00b1-4cf2-90e0-5cd6ca36e237"
                ) {
                    Page = 1599,
                    PerPage = 36,
                };
                Response.PaginatedCampaigns response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListCampaigns3()
        {
            try {
                Request.ListCampaigns request = new Request.ListCampaigns(
                    "0b04c1b9-00b1-4cf2-90e0-5cd6ca36e237"
                ) {
                    AvailableTo = "2021-08-17T14:02:12.000000Z",
                    Page = 6946,
                    PerPage = 9,
                };
                Response.PaginatedCampaigns response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListCampaigns4()
        {
            try {
                Request.ListCampaigns request = new Request.ListCampaigns(
                    "0b04c1b9-00b1-4cf2-90e0-5cd6ca36e237"
                ) {
                    AvailableFrom = "2021-08-16T08:25:54.000000Z",
                    AvailableTo = "2021-12-26T17:11:55.000000Z",
                    Page = 7875,
                    PerPage = 50,
                };
                Response.PaginatedCampaigns response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListCampaigns5()
        {
            try {
                Request.ListCampaigns request = new Request.ListCampaigns(
                    "0b04c1b9-00b1-4cf2-90e0-5cd6ca36e237"
                ) {
                    IsOngoing = true,
                    AvailableFrom = "2024-10-19T06:32:03.000000Z",
                    AvailableTo = "2024-11-09T16:05:14.000000Z",
                    Page = 8229,
                    PerPage = 35,
                };
                Response.PaginatedCampaigns response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

    }
}
