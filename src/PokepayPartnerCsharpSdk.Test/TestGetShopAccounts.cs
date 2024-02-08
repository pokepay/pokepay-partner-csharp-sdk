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
    public class TestGetShopAccounts
    {
        private Client client;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            client = new Client("~/.pokepay/test-config.ini");
        }

        [Test]
        public async Task GetShopAccounts0()
        {
            try {
                Request.GetShopAccounts request = new Request.GetShopAccounts(
                    "ca2616e9-5ed4-477c-bcc2-cc53b62f225a"
                );
                Response.PaginatedAccountWithUsers response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task GetShopAccounts1()
        {
            try {
                Request.GetShopAccounts request = new Request.GetShopAccounts(
                    "ca2616e9-5ed4-477c-bcc2-cc53b62f225a"
                ) {
                    IsSuspended = false,
                };
                Response.PaginatedAccountWithUsers response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task GetShopAccounts2()
        {
            try {
                Request.GetShopAccounts request = new Request.GetShopAccounts(
                    "ca2616e9-5ed4-477c-bcc2-cc53b62f225a"
                ) {
                    CreatedAtTo = "2023-10-10T07:01:36.000000Z",
                    IsSuspended = false,
                };
                Response.PaginatedAccountWithUsers response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task GetShopAccounts3()
        {
            try {
                Request.GetShopAccounts request = new Request.GetShopAccounts(
                    "ca2616e9-5ed4-477c-bcc2-cc53b62f225a"
                ) {
                    CreatedAtFrom = "2022-03-15T18:57:12.000000Z",
                    CreatedAtTo = "2022-11-02T09:39:16.000000Z",
                    IsSuspended = false,
                };
                Response.PaginatedAccountWithUsers response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task GetShopAccounts4()
        {
            try {
                Request.GetShopAccounts request = new Request.GetShopAccounts(
                    "ca2616e9-5ed4-477c-bcc2-cc53b62f225a"
                ) {
                    PerPage = 2047,
                    CreatedAtFrom = "2020-10-29T13:03:08.000000Z",
                    CreatedAtTo = "2022-09-06T09:13:55.000000Z",
                    IsSuspended = false,
                };
                Response.PaginatedAccountWithUsers response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task GetShopAccounts5()
        {
            try {
                Request.GetShopAccounts request = new Request.GetShopAccounts(
                    "ca2616e9-5ed4-477c-bcc2-cc53b62f225a"
                ) {
                    Page = 9914,
                    PerPage = 9044,
                    CreatedAtFrom = "2023-03-04T08:24:04.000000Z",
                    CreatedAtTo = "2021-01-14T14:41:40.000000Z",
                    IsSuspended = false,
                };
                Response.PaginatedAccountWithUsers response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

    }
}
