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
    public class TestGetPrivateMoneyOrganizationSummaries
    {
        private Client client;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            client = new Client("~/.pokepay/test-config.ini");
        }

        [Test]
        public async Task GetPrivateMoneyOrganizationSummaries0()
        {
            try {
                Request.GetPrivateMoneyOrganizationSummaries request = new Request.GetPrivateMoneyOrganizationSummaries(
                    "6c69519c-629e-42bf-a323-61b53531887b"
                );
                Response.PaginatedPrivateMoneyOrganizationSummaries response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task GetPrivateMoneyOrganizationSummaries1()
        {
            try {
                Request.GetPrivateMoneyOrganizationSummaries request = new Request.GetPrivateMoneyOrganizationSummaries(
                    "6c69519c-629e-42bf-a323-61b53531887b"
                ) {
                    Page = 9718,
                };
                Response.PaginatedPrivateMoneyOrganizationSummaries response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task GetPrivateMoneyOrganizationSummaries2()
        {
            try {
                Request.GetPrivateMoneyOrganizationSummaries request = new Request.GetPrivateMoneyOrganizationSummaries(
                    "6c69519c-629e-42bf-a323-61b53531887b"
                ) {
                    PerPage = 5526,
                    Page = 9523,
                };
                Response.PaginatedPrivateMoneyOrganizationSummaries response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task GetPrivateMoneyOrganizationSummaries3()
        {
            try {
                Request.GetPrivateMoneyOrganizationSummaries request = new Request.GetPrivateMoneyOrganizationSummaries(
                    "6c69519c-629e-42bf-a323-61b53531887b"
                ) {
                    From = "2021-05-16T22:08:37.000000Z",
                    To = "2022-03-18T14:41:36.000000Z",
                };
                Response.PaginatedPrivateMoneyOrganizationSummaries response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task GetPrivateMoneyOrganizationSummaries4()
        {
            try {
                Request.GetPrivateMoneyOrganizationSummaries request = new Request.GetPrivateMoneyOrganizationSummaries(
                    "6c69519c-629e-42bf-a323-61b53531887b"
                ) {
                    From = "2023-12-25T08:58:49.000000Z",
                    To = "2022-02-05T06:15:53.000000Z",
                    Page = 3359,
                };
                Response.PaginatedPrivateMoneyOrganizationSummaries response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task GetPrivateMoneyOrganizationSummaries5()
        {
            try {
                Request.GetPrivateMoneyOrganizationSummaries request = new Request.GetPrivateMoneyOrganizationSummaries(
                    "6c69519c-629e-42bf-a323-61b53531887b"
                ) {
                    From = "2021-06-11T14:08:29.000000Z",
                    To = "2022-12-27T10:10:34.000000Z",
                    PerPage = 9682,
                    Page = 4040,
                };
                Response.PaginatedPrivateMoneyOrganizationSummaries response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

    }
}
