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
                    "030ed8b1-32b8-4416-806a-9c9cbfb08585"
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
                    "030ed8b1-32b8-4416-806a-9c9cbfb08585"
                ) {
                    Email = "wtDqKqINz3@T5lX.com",
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
                    "030ed8b1-32b8-4416-806a-9c9cbfb08585"
                ) {
                    Tel = "04-857041",
                    Email = "05vdPzjIxO@uLiW.com",
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
                    "030ed8b1-32b8-4416-806a-9c9cbfb08585"
                ) {
                    ExternalId = "zKF",
                    Tel = "06515-650",
                    Email = "qQTplXiUwb@j843.com",
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
                    "030ed8b1-32b8-4416-806a-9c9cbfb08585"
                ) {
                    Status = "active",
                    ExternalId = "OOh8GsD9CsAZvJkdwkRXnUI5q7H1D",
                    Tel = "0825-40225643",
                    Email = "j42kY81am0@KTTt.com",
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
                    "030ed8b1-32b8-4416-806a-9c9cbfb08585"
                ) {
                    IsSuspended = true,
                    Status = "suspended",
                    ExternalId = "M8TOiEciN3kA6YHNhvh",
                    Tel = "0125-5529-5757",
                    Email = "PlZbno5tek@JGyE.com",
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
                    "030ed8b1-32b8-4416-806a-9c9cbfb08585"
                ) {
                    CreatedAtTo = "2017-10-23T03:23:20.000000+09:00",
                    IsSuspended = true,
                    Status = "pre-closed",
                    ExternalId = "8ceUbWmMzgN9LXXlV4gE0cfvunWEZQ1HP6jg9sbDsJJo3x4BOA",
                    Tel = "0039-01-7238",
                    Email = "70y4HLdLyu@xfIB.com",
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
                    "030ed8b1-32b8-4416-806a-9c9cbfb08585"
                ) {
                    CreatedAtFrom = "2017-06-13T02:49:25.000000+09:00",
                    CreatedAtTo = "2016-11-11T01:46:22.000000+09:00",
                    IsSuspended = true,
                    Status = "suspended",
                    ExternalId = "cZB7fivPIvektd1huoqKUMR4SyAreCV0PZlrKjUHfredCfp1ym",
                    Tel = "04655170",
                    Email = "RTzzVUeUa2@esNX.com",
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
                    "030ed8b1-32b8-4416-806a-9c9cbfb08585"
                ) {
                    PerPage = 6135,
                    CreatedAtFrom = "2021-12-18T05:07:53.000000+09:00",
                    CreatedAtTo = "2025-08-05T02:02:23.000000+09:00",
                    IsSuspended = true,
                    Status = "suspended",
                    ExternalId = "218PU5ZOfoRa5sx6ciWr0asEkokzk6FnLPgDhNI9T",
                    Tel = "098455-064",
                    Email = "tzl2Xku6Mf@hTIV.com",
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
                    "030ed8b1-32b8-4416-806a-9c9cbfb08585"
                ) {
                    Page = 4225,
                    PerPage = 629,
                    CreatedAtFrom = "2018-02-17T13:21:43.000000+09:00",
                    CreatedAtTo = "2022-05-13T18:10:56.000000+09:00",
                    IsSuspended = false,
                    Status = "pre-closed",
                    ExternalId = "RzmZVBUbaq864mF9",
                    Tel = "009695-5236",
                    Email = "OvnPKHxdvb@2DbC.com",
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
