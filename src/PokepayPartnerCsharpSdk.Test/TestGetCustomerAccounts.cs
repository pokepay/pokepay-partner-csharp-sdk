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
    public class TestGetCustomerAccounts
    {
        private Client client;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            client = new Client("~/.pokepay/test-config.ini");
        }

        [Test]
        public async Task GetCustomerAccounts0()
        {
            try {
                Request.GetCustomerAccounts request = new Request.GetCustomerAccounts(
                    "55543535-882b-44f5-9f30-80a440a9c1d9"
                );
                Response.PaginatedAccountWithUsers response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task GetCustomerAccounts1()
        {
            try {
                Request.GetCustomerAccounts request = new Request.GetCustomerAccounts(
                    "55543535-882b-44f5-9f30-80a440a9c1d9"
                ) {
                    Email = "Icm0Sp2Rlu@FOAx.com",
                };
                Response.PaginatedAccountWithUsers response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task GetCustomerAccounts2()
        {
            try {
                Request.GetCustomerAccounts request = new Request.GetCustomerAccounts(
                    "55543535-882b-44f5-9f30-80a440a9c1d9"
                ) {
                    Tel = "047-0551-2657",
                    Email = "TcJlnsa7zu@y1tu.com",
                };
                Response.PaginatedAccountWithUsers response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task GetCustomerAccounts3()
        {
            try {
                Request.GetCustomerAccounts request = new Request.GetCustomerAccounts(
                    "55543535-882b-44f5-9f30-80a440a9c1d9"
                ) {
                    ExternalId = "dw",
                    Tel = "071-69745487",
                    Email = "fKkMLwrBpO@RQ9L.com",
                };
                Response.PaginatedAccountWithUsers response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task GetCustomerAccounts4()
        {
            try {
                Request.GetCustomerAccounts request = new Request.GetCustomerAccounts(
                    "55543535-882b-44f5-9f30-80a440a9c1d9"
                ) {
                    Status = "suspended",
                    ExternalId = "lnKRmCd4n",
                    Tel = "045-981479",
                    Email = "qpn3W7S36l@34SS.com",
                };
                Response.PaginatedAccountWithUsers response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task GetCustomerAccounts5()
        {
            try {
                Request.GetCustomerAccounts request = new Request.GetCustomerAccounts(
                    "55543535-882b-44f5-9f30-80a440a9c1d9"
                ) {
                    IsSuspended = false,
                    Status = "active",
                    ExternalId = "W72gqSjd8QPzbjt0rt7UmerReZGbvGgvA",
                    Tel = "09215911045",
                    Email = "P1AnQALadF@sAzg.com",
                };
                Response.PaginatedAccountWithUsers response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task GetCustomerAccounts6()
        {
            try {
                Request.GetCustomerAccounts request = new Request.GetCustomerAccounts(
                    "55543535-882b-44f5-9f30-80a440a9c1d9"
                ) {
                    CreatedAtTo = "2022-07-27T22:59:50.000000+09:00",
                    IsSuspended = true,
                    Status = "pre-closed",
                    ExternalId = "tuXgZDedIJqTHGgnOhGiwZBj5AvHdO2Atfc",
                    Tel = "0129-664-818",
                    Email = "3sP8V6IT9V@FC5b.com",
                };
                Response.PaginatedAccountWithUsers response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task GetCustomerAccounts7()
        {
            try {
                Request.GetCustomerAccounts request = new Request.GetCustomerAccounts(
                    "55543535-882b-44f5-9f30-80a440a9c1d9"
                ) {
                    CreatedAtFrom = "2021-03-24T19:42:09.000000+09:00",
                    CreatedAtTo = "2023-05-02T07:02:07.000000+09:00",
                    IsSuspended = true,
                    Status = "pre-closed",
                    ExternalId = "XfPASw8jPQ0h",
                    Tel = "062-07305693",
                    Email = "xkUSOX0vTg@yFK1.com",
                };
                Response.PaginatedAccountWithUsers response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task GetCustomerAccounts8()
        {
            try {
                Request.GetCustomerAccounts request = new Request.GetCustomerAccounts(
                    "55543535-882b-44f5-9f30-80a440a9c1d9"
                ) {
                    PerPage = 6034,
                    CreatedAtFrom = "2022-02-08T11:59:01.000000+09:00",
                    CreatedAtTo = "2021-10-26T00:50:23.000000+09:00",
                    IsSuspended = true,
                    Status = "pre-closed",
                    ExternalId = "7pl9MWii2exAarzlUllr",
                    Tel = "01-1105-7098",
                    Email = "bZQuPYAKNL@vTyM.com",
                };
                Response.PaginatedAccountWithUsers response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task GetCustomerAccounts9()
        {
            try {
                Request.GetCustomerAccounts request = new Request.GetCustomerAccounts(
                    "55543535-882b-44f5-9f30-80a440a9c1d9"
                ) {
                    Page = 7048,
                    PerPage = 7330,
                    CreatedAtFrom = "2022-02-14T10:49:45.000000+09:00",
                    CreatedAtTo = "2023-05-04T06:41:23.000000+09:00",
                    IsSuspended = false,
                    Status = "suspended",
                    ExternalId = "LoYSz5jRHNPv9LO3MtPyt1wTnktL8AYkBvD7caRgncONv",
                    Tel = "085-5471-045",
                    Email = "87oiAkJDB6@ZsUU.com",
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
