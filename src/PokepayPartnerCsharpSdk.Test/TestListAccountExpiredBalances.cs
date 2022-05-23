// DO NOT EDIT: File is generated by code generator.
using System;
using System.Net;
using System.Net.Http;
using NUnit.Framework;
using System.Threading.Tasks;

using PokepayPartnerCsharpSdk;

namespace PokepayPartnerCsharpSdk.Test
{
    public class TestListAccountExpiredBalances
    {
        private Client client;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            client = new Client("~/.pokepay/test-config.ini");
        }

        [Test]
        public async Task ListAccountExpiredBalances0()
        {
            try {
                Request.ListAccountExpiredBalances request = new Request.ListAccountExpiredBalances(
                    "35d0430c-e892-4509-8ebf-e20868a29af9"
                );
                Response.PaginatedAccountBalance response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListAccountExpiredBalances1()
        {
            try {
                Request.ListAccountExpiredBalances request = new Request.ListAccountExpiredBalances(
                    "35d0430c-e892-4509-8ebf-e20868a29af9"
                ) {
                    Direction = "desc",
                };
                Response.PaginatedAccountBalance response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListAccountExpiredBalances2()
        {
            try {
                Request.ListAccountExpiredBalances request = new Request.ListAccountExpiredBalances(
                    "35d0430c-e892-4509-8ebf-e20868a29af9"
                ) {
                    ExpiresAtTo = "2023-06-26T07:13:08.000000+09:00",
                    Direction = "desc",
                };
                Response.PaginatedAccountBalance response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListAccountExpiredBalances3()
        {
            try {
                Request.ListAccountExpiredBalances request = new Request.ListAccountExpiredBalances(
                    "35d0430c-e892-4509-8ebf-e20868a29af9"
                ) {
                    ExpiresAtFrom = "2023-08-06T06:07:03.000000+09:00",
                    ExpiresAtTo = "2017-09-19T20:56:50.000000+09:00",
                    Direction = "asc",
                };
                Response.PaginatedAccountBalance response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListAccountExpiredBalances4()
        {
            try {
                Request.ListAccountExpiredBalances request = new Request.ListAccountExpiredBalances(
                    "35d0430c-e892-4509-8ebf-e20868a29af9"
                ) {
                    PerPage = 6769,
                    ExpiresAtFrom = "2017-02-25T01:34:39.000000+09:00",
                    ExpiresAtTo = "2021-01-28T21:13:31.000000+09:00",
                    Direction = "asc",
                };
                Response.PaginatedAccountBalance response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListAccountExpiredBalances5()
        {
            try {
                Request.ListAccountExpiredBalances request = new Request.ListAccountExpiredBalances(
                    "35d0430c-e892-4509-8ebf-e20868a29af9"
                ) {
                    Page = 8209,
                    PerPage = 8646,
                    ExpiresAtFrom = "2023-03-21T01:13:31.000000+09:00",
                    ExpiresAtTo = "2017-06-09T20:27:30.000000+09:00",
                    Direction = "asc",
                };
                Response.PaginatedAccountBalance response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

    }
}
