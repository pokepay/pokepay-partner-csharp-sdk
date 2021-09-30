// DO NOT EDIT: File is generated by code generator.
#nullable enable
using System;
using System.Net;
using System.Net.Http;
using NUnit.Framework;
using System.Threading.Tasks;

using PokepayPartnerCsharpSdk;

namespace PokepayPartnerCsharpSdk.Test
{
    public class TestListCustomerTransactions
    {
        private Client? client;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            client = new Client("~/.pokepay/test-config.ini");
        }

        [Test]
        public async Task ListCustomerTransactions0()
        {
            try {
                Request.ListCustomerTransactions request = new Request.ListCustomerTransactions(
                    "ecabccc2-216e-4f0a-8c56-22f77a805705"
                );
                Response.PaginatedTransaction response = await request.Send(client!);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.StatusCode!, (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.StatusCode >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListCustomerTransactions1()
        {
            try {
                Request.ListCustomerTransactions request = new Request.ListCustomerTransactions(
                    "ecabccc2-216e-4f0a-8c56-22f77a805705"
                ) {
                    PerPage = 3407
                };
                Response.PaginatedTransaction response = await request.Send(client!);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.StatusCode!, (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.StatusCode >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListCustomerTransactions2()
        {
            try {
                Request.ListCustomerTransactions request = new Request.ListCustomerTransactions(
                    "ecabccc2-216e-4f0a-8c56-22f77a805705"
                ) {
                    Page = 9887,
                    PerPage = 8313
                };
                Response.PaginatedTransaction response = await request.Send(client!);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.StatusCode!, (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.StatusCode >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListCustomerTransactions3()
        {
            try {
                Request.ListCustomerTransactions request = new Request.ListCustomerTransactions(
                    "ecabccc2-216e-4f0a-8c56-22f77a805705"
                ) {
                    To = "2024-10-04T10:29:29.000000+09:00",
                    Page = 4809,
                    PerPage = 7889
                };
                Response.PaginatedTransaction response = await request.Send(client!);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.StatusCode!, (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.StatusCode >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListCustomerTransactions4()
        {
            try {
                Request.ListCustomerTransactions request = new Request.ListCustomerTransactions(
                    "ecabccc2-216e-4f0a-8c56-22f77a805705"
                ) {
                    From = "2018-09-04T01:24:54.000000+09:00",
                    To = "2021-03-09T05:14:51.000000+09:00",
                    Page = 9747,
                    PerPage = 8650
                };
                Response.PaginatedTransaction response = await request.Send(client!);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.StatusCode!, (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.StatusCode >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListCustomerTransactions5()
        {
            try {
                Request.ListCustomerTransactions request = new Request.ListCustomerTransactions(
                    "ecabccc2-216e-4f0a-8c56-22f77a805705"
                ) {
                    IsModified = false,
                    From = "2024-02-13T23:55:13.000000+09:00",
                    To = "2022-04-30T22:46:21.000000+09:00",
                    Page = 8859,
                    PerPage = 1138
                };
                Response.PaginatedTransaction response = await request.Send(client!);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.StatusCode!, (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.StatusCode >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListCustomerTransactions6()
        {
            try {
                Request.ListCustomerTransactions request = new Request.ListCustomerTransactions(
                    "ecabccc2-216e-4f0a-8c56-22f77a805705"
                ) {
                    Type = "p6Bl",
                    IsModified = false,
                    From = "2023-03-16T14:23:51.000000+09:00",
                    To = "2022-10-08T04:41:33.000000+09:00",
                    Page = 9260,
                    PerPage = 7375
                };
                Response.PaginatedTransaction response = await request.Send(client!);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.StatusCode!, (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.StatusCode >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListCustomerTransactions7()
        {
            try {
                Request.ListCustomerTransactions request = new Request.ListCustomerTransactions(
                    "ecabccc2-216e-4f0a-8c56-22f77a805705"
                ) {
                    ReceiverCustomerId = "c2ebb8ed-4299-474a-93a9-3fc9818d2ff5",
                    Type = "KWvjUjC",
                    IsModified = true,
                    From = "2017-05-12T20:28:09.000000+09:00",
                    To = "2021-09-07T15:02:59.000000+09:00",
                    Page = 4199,
                    PerPage = 4531
                };
                Response.PaginatedTransaction response = await request.Send(client!);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.StatusCode!, (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.StatusCode >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListCustomerTransactions8()
        {
            try {
                Request.ListCustomerTransactions request = new Request.ListCustomerTransactions(
                    "ecabccc2-216e-4f0a-8c56-22f77a805705"
                ) {
                    SenderCustomerId = "61154127-fe01-47cc-bdef-933913db0fce",
                    ReceiverCustomerId = "c898b0f1-236c-48d6-b6ae-0575cf9ae458",
                    Type = "M4yE9kd",
                    IsModified = false,
                    From = "2024-05-08T06:55:33.000000+09:00",
                    To = "2025-07-22T08:58:39.000000+09:00",
                    Page = 3543,
                    PerPage = 1335
                };
                Response.PaginatedTransaction response = await request.Send(client!);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.StatusCode!, (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.StatusCode >= 300, "Should be larger than 300");
            }
        }

    }
}
