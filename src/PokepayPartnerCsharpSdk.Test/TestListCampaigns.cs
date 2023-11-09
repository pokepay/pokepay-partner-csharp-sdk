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
                    "b479f22e-e033-4172-9f2a-8c1a8451ee51"
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
                    "b479f22e-e033-4172-9f2a-8c1a8451ee51"
                ) {
                    PerPage = 26,
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
                    "b479f22e-e033-4172-9f2a-8c1a8451ee51"
                ) {
                    Page = 7539,
                    PerPage = 38,
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
                    "b479f22e-e033-4172-9f2a-8c1a8451ee51"
                ) {
                    AvailableTo = "2019-08-22T02:18:51.000000+09:00",
                    Page = 8646,
                    PerPage = 19,
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
                    "b479f22e-e033-4172-9f2a-8c1a8451ee51"
                ) {
                    AvailableFrom = "2024-05-19T04:30:54.000000+09:00",
                    AvailableTo = "2023-07-07T04:49:56.000000+09:00",
                    Page = 8268,
                    PerPage = 28,
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
                    "b479f22e-e033-4172-9f2a-8c1a8451ee51"
                ) {
                    IsOngoing = false,
                    AvailableFrom = "2023-11-10T16:23:03.000000+09:00",
                    AvailableTo = "2015-12-11T07:32:44.000000+09:00",
                    Page = 5046,
                    PerPage = 19,
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
