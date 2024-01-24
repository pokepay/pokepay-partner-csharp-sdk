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
    public class TestCreateTopupTransaction
    {
        private Client client;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            client = new Client("~/.pokepay/test-config.ini");
        }

        [Test]
        public async Task CreateTopupTransaction0()
        {
            try {
                Request.CreateTopupTransaction request = new Request.CreateTopupTransaction(
                    "c0234ed8-64f8-41ef-950c-ff47b85a5a54",
                    "3871a35c-a13b-4070-a407-9a76b6b93253",
                    "bffb238f-03af-4eba-bf47-2788e5a61629"
                );
                Response.TransactionDetail response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task CreateTopupTransaction1()
        {
            try {
                Request.CreateTopupTransaction request = new Request.CreateTopupTransaction(
                    "c0234ed8-64f8-41ef-950c-ff47b85a5a54",
                    "3871a35c-a13b-4070-a407-9a76b6b93253",
                    "bffb238f-03af-4eba-bf47-2788e5a61629"
                ) {
                    RequestId = "46b0b860-3f84-4829-ae37-b92c737de2eb",
                };
                Response.TransactionDetail response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task CreateTopupTransaction2()
        {
            try {
                Request.CreateTopupTransaction request = new Request.CreateTopupTransaction(
                    "c0234ed8-64f8-41ef-950c-ff47b85a5a54",
                    "3871a35c-a13b-4070-a407-9a76b6b93253",
                    "bffb238f-03af-4eba-bf47-2788e5a61629"
                ) {
                    Metadata = "{\"key\":\"value\"}",
                    RequestId = "68f59d5e-d6fe-45be-9130-be750ed838ca",
                };
                Response.TransactionDetail response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task CreateTopupTransaction3()
        {
            try {
                Request.CreateTopupTransaction request = new Request.CreateTopupTransaction(
                    "c0234ed8-64f8-41ef-950c-ff47b85a5a54",
                    "3871a35c-a13b-4070-a407-9a76b6b93253",
                    "bffb238f-03af-4eba-bf47-2788e5a61629"
                ) {
                    Description = "2tBF8DMJHPo2JrEFT6od5qcp0i4vcS7ZxvN2Z7Wi0ChpurM3FN5zQLn9sLFMY",
                    Metadata = "{\"key\":\"value\"}",
                    RequestId = "5fd71edc-d04a-477c-b56d-59ea7105f277",
                };
                Response.TransactionDetail response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task CreateTopupTransaction4()
        {
            try {
                Request.CreateTopupTransaction request = new Request.CreateTopupTransaction(
                    "c0234ed8-64f8-41ef-950c-ff47b85a5a54",
                    "3871a35c-a13b-4070-a407-9a76b6b93253",
                    "bffb238f-03af-4eba-bf47-2788e5a61629"
                ) {
                    PointExpiresAt = "2022-10-14T05:45:53.000000+09:00",
                    Description = "SUIFss9LrGlxVylfnPLJ2vF2z1aJOmCXgHJRHL9qU0PKOhiEtiTPaivcjocaAFQcmJDEAan1Rrgfzx7U2V5wi9kTMneD2hr1Omn7KkDOpKq4vSm9CzUHMYYKFNutBzlt3ZF65T7Thx3sTrFoUkVu6ncH8ejYiqgcDtK8DKUdm4nQHtEes5",
                    Metadata = "{\"key\":\"value\"}",
                    RequestId = "99cac1f7-cb43-49d2-ae82-e03b67befd2f",
                };
                Response.TransactionDetail response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task CreateTopupTransaction5()
        {
            try {
                Request.CreateTopupTransaction request = new Request.CreateTopupTransaction(
                    "c0234ed8-64f8-41ef-950c-ff47b85a5a54",
                    "3871a35c-a13b-4070-a407-9a76b6b93253",
                    "bffb238f-03af-4eba-bf47-2788e5a61629"
                ) {
                    PointAmount = 9228,
                    PointExpiresAt = "2023-05-04T08:22:55.000000+09:00",
                    Description = "zrD5imjEquGzhnz9gdZ7nz2C9RHCkePoHs",
                    Metadata = "{\"key\":\"value\"}",
                    RequestId = "0ab46856-5bd8-4c89-aaea-16cc03637bd4",
                };
                Response.TransactionDetail response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task CreateTopupTransaction6()
        {
            try {
                Request.CreateTopupTransaction request = new Request.CreateTopupTransaction(
                    "c0234ed8-64f8-41ef-950c-ff47b85a5a54",
                    "3871a35c-a13b-4070-a407-9a76b6b93253",
                    "bffb238f-03af-4eba-bf47-2788e5a61629"
                ) {
                    MoneyAmount = 2280,
                    PointAmount = 2832,
                    PointExpiresAt = "2020-09-09T13:26:29.000000+09:00",
                    Description = "0gt9XFUWCBhi2BTMUmHin8e0SOMMDxXuGGstFsnW5I5hNddQMnO6G3PGN3Zi5DISgC8XgEHRp8GAhPvKOtIBqoGsONvmdVT9LuIbmy2WFRP0owBVblebdCzjOGRvP",
                    Metadata = "{\"key\":\"value\"}",
                    RequestId = "c6df5115-c075-44ae-bab2-fadcdc43a798",
                };
                Response.TransactionDetail response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task CreateTopupTransaction7()
        {
            try {
                Request.CreateTopupTransaction request = new Request.CreateTopupTransaction(
                    "c0234ed8-64f8-41ef-950c-ff47b85a5a54",
                    "3871a35c-a13b-4070-a407-9a76b6b93253",
                    "bffb238f-03af-4eba-bf47-2788e5a61629"
                ) {
                    BearPointShopId = "e33c030b-e579-4c9b-8572-111db935557f",
                    MoneyAmount = 8744,
                    PointAmount = 7588,
                    PointExpiresAt = "2023-06-24T11:00:55.000000+09:00",
                    Description = "fwT93p3vJBM90sY1UMMkfZiwk0QShY9uXjmZQQts6GlupwQT14F5RhoXPNozVW16RzBNqyLRGRmWY8uJWuNrPN6zzcUeraLOWnL6slU6jQ8NRM",
                    Metadata = "{\"key\":\"value\"}",
                    RequestId = "b2867629-62ae-45c1-b040-8116410e0f90",
                };
                Response.TransactionDetail response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

    }
}
