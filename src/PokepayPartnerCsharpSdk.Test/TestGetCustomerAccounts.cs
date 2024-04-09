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
                    "8fd6266d-a71c-4830-9cd3-391d4cc8aba3"
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
                    "8fd6266d-a71c-4830-9cd3-391d4cc8aba3"
                ) {
                    Email = "p2RluFOAxJ@TKKl.com",
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
                    "8fd6266d-a71c-4830-9cd3-391d4cc8aba3"
                ) {
                    Tel = "00555265714",
                    Email = "cJlnsa7zuy@1tus.com",
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
                    "8fd6266d-a71c-4830-9cd3-391d4cc8aba3"
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
                    "8fd6266d-a71c-4830-9cd3-391d4cc8aba3"
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
                    "8fd6266d-a71c-4830-9cd3-391d4cc8aba3"
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
                    "8fd6266d-a71c-4830-9cd3-391d4cc8aba3"
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
                    "8fd6266d-a71c-4830-9cd3-391d4cc8aba3"
                ) {
                    CreatedAtFrom = "2021-03-24T19:42:09.000000+09:00",
                    CreatedAtTo = "2020-09-24T18:38:11.000000+09:00",
                    IsSuspended = true,
                    Status = "active",
                    ExternalId = "PASw8jPQ0hMJ4nPgNJOUuVI3xkUSOX0vTgyFK1F",
                    Tel = "002-97-992",
                    Email = "exAarzlUll@rgsQ.com",
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
                    "8fd6266d-a71c-4830-9cd3-391d4cc8aba3"
                ) {
                    PerPage = 6435,
                    CreatedAtFrom = "2022-12-18T13:21:30.000000+09:00",
                    CreatedAtTo = "2022-10-28T02:45:21.000000+09:00",
                    IsSuspended = true,
                    Status = "active",
                    ExternalId = "YeKIbZQuPYAKNLvTyMcIYl",
                    Tel = "079352848",
                    Email = "Pv9LO3MtPy@t1wT.com",
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
                    "8fd6266d-a71c-4830-9cd3-391d4cc8aba3"
                ) {
                    Page = 8687,
                    PerPage = 8494,
                    CreatedAtFrom = "2024-02-11T20:15:48.000000+09:00",
                    CreatedAtTo = "2023-10-06T20:45:00.000000+09:00",
                    IsSuspended = true,
                    Status = "active",
                    ExternalId = "Yk",
                    Tel = "004073-175",
                    Email = "ncONv8Kje2@pUTW.com",
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
