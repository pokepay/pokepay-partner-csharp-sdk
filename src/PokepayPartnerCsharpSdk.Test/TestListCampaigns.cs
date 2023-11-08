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
                    "b88ced06-143e-4765-a432-208c3430ec38"
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
                    "b88ced06-143e-4765-a432-208c3430ec38"
                ) {
                    PerPage = 18,
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
                    "b88ced06-143e-4765-a432-208c3430ec38"
                ) {
                    Page = 3079,
                    PerPage = 34,
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
                    "b88ced06-143e-4765-a432-208c3430ec38"
                ) {
                    AvailableTo = "2025-01-10T21:02:27.000000+09:00",
                    Page = 8049,
                    PerPage = 14,
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
                    "b88ced06-143e-4765-a432-208c3430ec38"
                ) {
                    AvailableFrom = "2023-03-04T13:01:52.000000+09:00",
                    AvailableTo = "2021-11-19T06:51:25.000000+09:00",
                    Page = 8254,
                    PerPage = 40,
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
                    "b88ced06-143e-4765-a432-208c3430ec38"
                ) {
                    IsOngoing = true,
                    AvailableFrom = "2022-05-01T03:26:09.000000+09:00",
                    AvailableTo = "2018-08-22T00:09:50.000000+09:00",
                    Page = 4362,
                    PerPage = 30,
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
