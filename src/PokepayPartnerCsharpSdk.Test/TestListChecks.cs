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
    public class TestListChecks
    {
        private Client client;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            client = new Client("~/.pokepay/test-config.ini");
        }

        [Test]
        public async Task ListChecks0()
        {
            try {
                Request.ListChecks request = new Request.ListChecks();
                Response.PaginatedChecks response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListChecks1()
        {
            try {
                Request.ListChecks request = new Request.ListChecks() {
                    IsDisabled = true,
                };
                Response.PaginatedChecks response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListChecks2()
        {
            try {
                Request.ListChecks request = new Request.ListChecks() {
                    IsOnetime = false,
                    IsDisabled = true,
                };
                Response.PaginatedChecks response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListChecks3()
        {
            try {
                Request.ListChecks request = new Request.ListChecks() {
                    Description = "iWbDVy6Ss7",
                    IsOnetime = false,
                    IsDisabled = true,
                };
                Response.PaginatedChecks response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListChecks4()
        {
            try {
                Request.ListChecks request = new Request.ListChecks() {
                    IssuerShopId = "9f5f4bbe-5cf4-472f-8f91-d6191d999789",
                    Description = "0",
                    IsOnetime = false,
                    IsDisabled = true,
                };
                Response.PaginatedChecks response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListChecks5()
        {
            try {
                Request.ListChecks request = new Request.ListChecks() {
                    CreatedTo = "2022-06-30T02:58:13.000000+09:00",
                    IssuerShopId = "309aca4b-8a21-4644-b682-37da98bf59b2",
                    Description = "u",
                    IsOnetime = false,
                    IsDisabled = false,
                };
                Response.PaginatedChecks response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListChecks6()
        {
            try {
                Request.ListChecks request = new Request.ListChecks() {
                    CreatedFrom = "2016-09-08T01:38:59.000000+09:00",
                    CreatedTo = "2016-05-13T15:33:03.000000+09:00",
                    IssuerShopId = "860771a0-4f59-415a-a905-5384db180fd4",
                    Description = "IyRndm",
                    IsOnetime = true,
                    IsDisabled = false,
                };
                Response.PaginatedChecks response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListChecks7()
        {
            try {
                Request.ListChecks request = new Request.ListChecks() {
                    ExpiresTo = "2016-03-08T23:23:57.000000+09:00",
                    CreatedFrom = "2021-06-17T07:09:58.000000+09:00",
                    CreatedTo = "2021-03-25T19:45:47.000000+09:00",
                    IssuerShopId = "6357ef3e-e436-429b-852d-6ca6149f14c3",
                    Description = "6B3OB",
                    IsOnetime = false,
                    IsDisabled = false,
                };
                Response.PaginatedChecks response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListChecks8()
        {
            try {
                Request.ListChecks request = new Request.ListChecks() {
                    ExpiresFrom = "2021-04-10T18:50:35.000000+09:00",
                    ExpiresTo = "2016-06-04T18:30:01.000000+09:00",
                    CreatedFrom = "2023-07-18T12:39:11.000000+09:00",
                    CreatedTo = "2016-08-12T01:41:07.000000+09:00",
                    IssuerShopId = "740db4c9-e510-4ee4-abf1-7d55706c69cf",
                    Description = "2HAI87h7tC",
                    IsOnetime = false,
                    IsDisabled = true,
                };
                Response.PaginatedChecks response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListChecks9()
        {
            try {
                Request.ListChecks request = new Request.ListChecks() {
                    OrganizationCode = "vMnTzjNmFWDzLZEPN",
                    ExpiresFrom = "2016-11-19T05:24:08.000000+09:00",
                    ExpiresTo = "2021-04-14T14:37:51.000000+09:00",
                    CreatedFrom = "2022-02-12T21:55:37.000000+09:00",
                    CreatedTo = "2017-12-26T14:47:45.000000+09:00",
                    IssuerShopId = "86b3ca81-11a8-403c-866d-f346c7e6f48c",
                    Description = "bXY",
                    IsOnetime = false,
                    IsDisabled = true,
                };
                Response.PaginatedChecks response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListChecks10()
        {
            try {
                Request.ListChecks request = new Request.ListChecks() {
                    PrivateMoneyId = "c2b07718-2826-4e8b-be11-1a2baecca24e",
                    OrganizationCode = "3cal4",
                    ExpiresFrom = "2024-01-27T09:24:17.000000+09:00",
                    ExpiresTo = "2018-12-13T01:07:23.000000+09:00",
                    CreatedFrom = "2016-06-18T19:19:16.000000+09:00",
                    CreatedTo = "2024-01-19T20:38:00.000000+09:00",
                    IssuerShopId = "d628d433-7664-40d2-847d-9ea2d22fc522",
                    Description = "KNVoewLoa",
                    IsOnetime = true,
                    IsDisabled = true,
                };
                Response.PaginatedChecks response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListChecks11()
        {
            try {
                Request.ListChecks request = new Request.ListChecks() {
                    PerPage = 1896,
                    PrivateMoneyId = "70586dc9-8ccd-4ffe-afad-922751cedb89",
                    OrganizationCode = "A5wXB3CTdPu3I6Gb57N6Bfk723",
                    ExpiresFrom = "2022-01-30T04:00:04.000000+09:00",
                    ExpiresTo = "2021-07-02T04:39:11.000000+09:00",
                    CreatedFrom = "2025-01-30T23:54:19.000000+09:00",
                    CreatedTo = "2021-09-17T21:03:49.000000+09:00",
                    IssuerShopId = "ce38e757-58e3-40b2-abad-be87b3e25a46",
                    Description = "mu9RV4",
                    IsOnetime = false,
                    IsDisabled = true,
                };
                Response.PaginatedChecks response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListChecks12()
        {
            try {
                Request.ListChecks request = new Request.ListChecks() {
                    Page = 1365,
                    PerPage = 7378,
                    PrivateMoneyId = "7d8dd8a6-d892-4331-a590-0f46fa6ce3e6",
                    OrganizationCode = "oOmA6Kg",
                    ExpiresFrom = "2022-12-08T18:30:43.000000+09:00",
                    ExpiresTo = "2020-03-05T20:29:54.000000+09:00",
                    CreatedFrom = "2018-01-09T22:51:54.000000+09:00",
                    CreatedTo = "2019-03-22T16:00:51.000000+09:00",
                    IssuerShopId = "90884e22-eecd-4e3d-890c-4b9650555294",
                    Description = "qeaKPydQ",
                    IsOnetime = false,
                    IsDisabled = false,
                };
                Response.PaginatedChecks response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

    }
}
