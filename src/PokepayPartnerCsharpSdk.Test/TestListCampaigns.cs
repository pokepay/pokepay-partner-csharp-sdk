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
                    "18bcc7a6-42df-4471-8c96-80325b2c3b3c"
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
                    "18bcc7a6-42df-4471-8c96-80325b2c3b3c"
                ) {
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
        public async Task ListCampaigns2()
        {
            try {
                Request.ListCampaigns request = new Request.ListCampaigns(
                    "18bcc7a6-42df-4471-8c96-80325b2c3b3c"
                ) {
                    Page = 9966,
                    PerPage = 43,
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
                    "18bcc7a6-42df-4471-8c96-80325b2c3b3c"
                ) {
                    AvailableTo = "2023-05-16T03:50:44.000000+09:00",
                    Page = 74,
                    PerPage = 35,
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
                    "18bcc7a6-42df-4471-8c96-80325b2c3b3c"
                ) {
                    AvailableFrom = "2021-07-28T11:34:13.000000+09:00",
                    AvailableTo = "2024-03-02T00:05:43.000000+09:00",
                    Page = 8762,
                    PerPage = 37,
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
                    "18bcc7a6-42df-4471-8c96-80325b2c3b3c"
                ) {
                    IsOngoing = false,
                    AvailableFrom = "2022-09-25T09:37:37.000000+09:00",
                    AvailableTo = "2023-05-26T13:38:27.000000+09:00",
                    Page = 2512,
                    PerPage = 9,
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
