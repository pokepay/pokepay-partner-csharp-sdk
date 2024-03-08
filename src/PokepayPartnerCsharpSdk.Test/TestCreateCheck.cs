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
    public class TestCreateCheck
    {
        private Client client;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            client = new Client("~/.pokepay/test-config.ini");
        }

        [Test]
        public async Task CreateCheck0()
        {
            try {
                Request.CreateCheck request = new Request.CreateCheck(
                    "daf2d002-f16e-4d5c-81f5-532f11a3f3f2"
                ) {
                    MoneyAmount = 8380.0,
                };
                Response.Check response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task CreateCheck1()
        {
            try {
                Request.CreateCheck request = new Request.CreateCheck(
                    "daf2d002-f16e-4d5c-81f5-532f11a3f3f2"
                ) {
                    MoneyAmount = 6406.0,
                    Description = "36TYPgxIzfeirgwWnuJKugM3OQh2JHBnxbiEM0oFGnnvKX9mW4mLerHweV6yDqMFurm2HyY5rxBRsFTyEvnewbYd4rNZJsCq7m7arw2NKYH12xHXaAOFqIwxrvxkxwVYBDQiRCyVT",
                };
                Response.Check response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task CreateCheck2()
        {
            try {
                Request.CreateCheck request = new Request.CreateCheck(
                    "daf2d002-f16e-4d5c-81f5-532f11a3f3f2"
                ) {
                    MoneyAmount = 8734.0,
                    IsOnetime = true,
                    Description = "3czNdwQ9LziqjK5MdQ1lZMyARXVB9A32ESqVUKE1GN9JqLEvyRdA5j20ws4Z1",
                };
                Response.Check response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task CreateCheck3()
        {
            try {
                Request.CreateCheck request = new Request.CreateCheck(
                    "daf2d002-f16e-4d5c-81f5-532f11a3f3f2"
                ) {
                    MoneyAmount = 7574.0,
                    UsageLimit = 138,
                    IsOnetime = true,
                    Description = "jZ8xWKeN3WKGyHXCKDfS0S9olxtCG8sS34enFyHhIbteE1tQOMttUhD0OiwEvovxL7L6kZ3KaNub1zwaCdHgj8ik3dmsSURUNaSg6OcHEmOeQFO",
                };
                Response.Check response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task CreateCheck4()
        {
            try {
                Request.CreateCheck request = new Request.CreateCheck(
                    "daf2d002-f16e-4d5c-81f5-532f11a3f3f2"
                ) {
                    MoneyAmount = 7859.0,
                    ExpiresAt = "2023-05-07T23:01:35.000000Z",
                    UsageLimit = 3057,
                    IsOnetime = true,
                    Description = "SQ0YVNC6SfrLsEgbwDrafzykU4qQWwEl9RBh7JkqQ2DDr8e6Qf8fK7SBxethCuCr4dBSWzD3agMTAvZtCmtviHLHOBHoLHZ5Hyso5u9Osjia9h3ovwp1QqOYhJf",
                };
                Response.Check response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task CreateCheck5()
        {
            try {
                Request.CreateCheck request = new Request.CreateCheck(
                    "daf2d002-f16e-4d5c-81f5-532f11a3f3f2"
                ) {
                    MoneyAmount = 7124.0,
                    PointExpiresAt = "2023-05-07T19:04:42.000000Z",
                    ExpiresAt = "2021-04-03T08:49:41.000000Z",
                    UsageLimit = 5919,
                    IsOnetime = true,
                    Description = "v94bnDyHKg7jf7TRBDusrb62imeaN035TYhQYVT6897JBIT98Ea3vOiHnJbC3RzxMsGYTRQVbbDGQ3KFvfr7wcTIqfZGa8VmM7LxaafZsEiZ4h1kUtLESZUqCMHUv6WI9WlLqAjFFVtovIA3w7if4YoZJ6xmZ8",
                };
                Response.Check response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task CreateCheck6()
        {
            try {
                Request.CreateCheck request = new Request.CreateCheck(
                    "daf2d002-f16e-4d5c-81f5-532f11a3f3f2"
                ) {
                    MoneyAmount = 5070.0,
                    PointExpiresInDays = 6716,
                    PointExpiresAt = "2023-03-31T08:24:20.000000Z",
                    ExpiresAt = "2020-11-28T02:54:40.000000Z",
                    UsageLimit = 2977,
                    IsOnetime = false,
                    Description = "ZaugRp11iMcrfILoN8ZP7287JaoYb8spv1FcaYx8c7c37K2BoQEomxqdvzxKVxdoit0nsRdkY0a6T9IRy95uKnYj6aDVb3qDkr4zFWttvA7t4NS9wkdOXwioDpfXuzoNbRpuKefj9znX2XonFzQcO5QEOmdgUm73I2kFchNQksZB6By",
                };
                Response.Check response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task CreateCheck7()
        {
            try {
                Request.CreateCheck request = new Request.CreateCheck(
                    "daf2d002-f16e-4d5c-81f5-532f11a3f3f2"
                ) {
                    MoneyAmount = 2132.0,
                    BearPointAccount = "564f0633-c088-426c-bfdf-b12916570056",
                    PointExpiresInDays = 4947,
                    PointExpiresAt = "2024-03-06T17:39:29.000000Z",
                    ExpiresAt = "2024-01-16T03:09:56.000000Z",
                    UsageLimit = 8911,
                    IsOnetime = true,
                    Description = "23WFeXCsADfveWv5SetJLuZcB6tdcwibyPvTHbjOWbqqVGNOP2f7Fmc6X",
                };
                Response.Check response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task CreateCheck8()
        {
            try {
                Request.CreateCheck request = new Request.CreateCheck(
                    "daf2d002-f16e-4d5c-81f5-532f11a3f3f2"
                ) {
                    MoneyAmount = 2943.0,
                    PointAmount = 6616.0,
                };
                Response.Check response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task CreateCheck9()
        {
            try {
                Request.CreateCheck request = new Request.CreateCheck(
                    "daf2d002-f16e-4d5c-81f5-532f11a3f3f2"
                ) {
                    MoneyAmount = 4440.0,
                    PointAmount = 2094.0,
                    Description = "3Y5XPxnjFhfkfYgvABxRhjV7rXm6F6onhtgkbe1I3fnSrAjiMpnuQgQNZWqLAFAWqZBqyjs43AAjNC",
                };
                Response.Check response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task CreateCheck10()
        {
            try {
                Request.CreateCheck request = new Request.CreateCheck(
                    "daf2d002-f16e-4d5c-81f5-532f11a3f3f2"
                ) {
                    MoneyAmount = 1341.0,
                    PointAmount = 3944.0,
                    IsOnetime = false,
                    Description = "ERBnJER6lOBQBwAgsTow2Z3Uka1wds9TY9Bp5VDJiBPB1XeTNJcIKtWyeNc1zzlxW2hgOK8NI225RAsUHuuLFS4058hKDGnyjbxrF6zxkmTZedVWeLbSdWlORFkWxf1fgII7vrhxHZrOE",
                };
                Response.Check response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task CreateCheck11()
        {
            try {
                Request.CreateCheck request = new Request.CreateCheck(
                    "daf2d002-f16e-4d5c-81f5-532f11a3f3f2"
                ) {
                    MoneyAmount = 1020.0,
                    PointAmount = 7368.0,
                    UsageLimit = 6710,
                    IsOnetime = false,
                    Description = "NdDlfIrfFFwUdXhpSi4j72IcAxs47XeIzYlwiQaQGyn4Age91Y1cWNDBnv9RrzZK5kL8kuH9QZjAoA9Wjz3xWF4fJVtnG3Avmta20vIgud6F1UgGMHbk2IRflsvwuZxk0nQmXMvg0FcWUrBHOSV7LC2s46hfsRF0YKxTClCMK7WZ9OzN",
                };
                Response.Check response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task CreateCheck12()
        {
            try {
                Request.CreateCheck request = new Request.CreateCheck(
                    "daf2d002-f16e-4d5c-81f5-532f11a3f3f2"
                ) {
                    MoneyAmount = 5196.0,
                    PointAmount = 8782.0,
                    ExpiresAt = "2023-04-24T17:55:07.000000Z",
                    UsageLimit = 3819,
                    IsOnetime = true,
                    Description = "oAuPSksHUuefNAm0yTlB8Y7jnhE6v0ICVfZpB32LWZFMYYNQ77hNnDgeQkP6BrHNLW2TjgwJkClYsxYjLV6mNckmXWb6cDTOBEvT1fZ",
                };
                Response.Check response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task CreateCheck13()
        {
            try {
                Request.CreateCheck request = new Request.CreateCheck(
                    "daf2d002-f16e-4d5c-81f5-532f11a3f3f2"
                ) {
                    MoneyAmount = 5465.0,
                    PointAmount = 9473.0,
                    PointExpiresAt = "2023-01-06T00:46:39.000000Z",
                    ExpiresAt = "2023-12-11T07:46:43.000000Z",
                    UsageLimit = 1602,
                    IsOnetime = true,
                    Description = "tgwRL",
                };
                Response.Check response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task CreateCheck14()
        {
            try {
                Request.CreateCheck request = new Request.CreateCheck(
                    "daf2d002-f16e-4d5c-81f5-532f11a3f3f2"
                ) {
                    MoneyAmount = 778.0,
                    PointAmount = 5777.0,
                    PointExpiresInDays = 5743,
                    PointExpiresAt = "2020-09-11T08:09:37.000000Z",
                    ExpiresAt = "2020-06-24T07:15:37.000000Z",
                    UsageLimit = 6025,
                    IsOnetime = true,
                    Description = "1",
                };
                Response.Check response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task CreateCheck15()
        {
            try {
                Request.CreateCheck request = new Request.CreateCheck(
                    "daf2d002-f16e-4d5c-81f5-532f11a3f3f2"
                ) {
                    MoneyAmount = 3271.0,
                    PointAmount = 1239.0,
                    BearPointAccount = "d98f9df1-5a7b-4001-a67e-7d325bfa80fc",
                    PointExpiresInDays = 1933,
                    PointExpiresAt = "2022-10-06T14:18:40.000000Z",
                    ExpiresAt = "2021-10-09T18:26:18.000000Z",
                    UsageLimit = 2848,
                    IsOnetime = true,
                    Description = "amqpbbuSj1PURjYRasH9ARntTDK9f1O2csoG3F55uy56fVMl4ovKtbbNMLWzz4xf72tklHyikvXSu1xVqKMzKtPMLBX6YLvmDqPAbWtHJHRtQBqCHs",
                };
                Response.Check response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task CreateCheck16()
        {
            try {
                Request.CreateCheck request = new Request.CreateCheck(
                    "daf2d002-f16e-4d5c-81f5-532f11a3f3f2"
                ) {
                    PointAmount = 4728.0,
                };
                Response.Check response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task CreateCheck17()
        {
            try {
                Request.CreateCheck request = new Request.CreateCheck(
                    "daf2d002-f16e-4d5c-81f5-532f11a3f3f2"
                ) {
                    PointAmount = 4232.0,
                    Description = "1kIOiSHcZ37iojnk7j2j33qMA4N2evwLBNS7QyCEhtgNDuAnxydB9u3o7ZMeTosoRh4S0mExQI1uCwHXvSS9xqXNJMeqv2rRxx8SeYgA5RTAZIE0d3whSKLF4xWXCgQOdSsQVPrApoltrzZbMjGbqCaDUv1CsWTy6z2FdXbfXavW2HwaVVWGcOvR",
                };
                Response.Check response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task CreateCheck18()
        {
            try {
                Request.CreateCheck request = new Request.CreateCheck(
                    "daf2d002-f16e-4d5c-81f5-532f11a3f3f2"
                ) {
                    PointAmount = 5863.0,
                    IsOnetime = true,
                    Description = "fjTir1eeHpnGAvFN5uVHKI7mM3plgJR5",
                };
                Response.Check response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task CreateCheck19()
        {
            try {
                Request.CreateCheck request = new Request.CreateCheck(
                    "daf2d002-f16e-4d5c-81f5-532f11a3f3f2"
                ) {
                    PointAmount = 8844.0,
                    UsageLimit = 6043,
                    IsOnetime = false,
                    Description = "wzKIFQcpGZZVlRU03Fa2F6PUopGrOCijX4VQZjHwhb9lV9sTjbq8Wo22UU1er3T1gBtfr20CiDsCwyLdW5AzEeQbE5VhNxjrtNh84WLuHKWoYQpDLtJyiWbDVy6Ss7attO0",
                };
                Response.Check response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task CreateCheck20()
        {
            try {
                Request.CreateCheck request = new Request.CreateCheck(
                    "daf2d002-f16e-4d5c-81f5-532f11a3f3f2"
                ) {
                    PointAmount = 5779.0,
                    ExpiresAt = "2021-08-19T06:24:40.000000Z",
                    UsageLimit = 6812,
                    IsOnetime = false,
                    Description = "KDvZ2PuoFKU33PYYZTEIyRn",
                };
                Response.Check response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task CreateCheck21()
        {
            try {
                Request.CreateCheck request = new Request.CreateCheck(
                    "daf2d002-f16e-4d5c-81f5-532f11a3f3f2"
                ) {
                    PointAmount = 7103.0,
                    PointExpiresAt = "2022-04-14T03:54:12.000000Z",
                    ExpiresAt = "2023-11-18T08:53:29.000000Z",
                    UsageLimit = 8965,
                    IsOnetime = false,
                    Description = "mm72c26Cd6B3OB7swghUIdkqUOY2HAI87h7tC8vMnTzjNmFWDzLZEPN7HQXwymFrbXYvN3cal4RO9jT63dRDxKNVoewLoaJggIMA5wXB3CTdPu3I6Gb57N6Bfk723xgVJhWc2FLm",
                };
                Response.Check response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task CreateCheck22()
        {
            try {
                Request.CreateCheck request = new Request.CreateCheck(
                    "daf2d002-f16e-4d5c-81f5-532f11a3f3f2"
                ) {
                    PointAmount = 9717.0,
                    PointExpiresInDays = 8378,
                    PointExpiresAt = "2022-01-29T08:19:17.000000Z",
                    ExpiresAt = "2020-01-09T22:54:37.000000Z",
                    UsageLimit = 2484,
                    IsOnetime = false,
                    Description = "TQ1eFfFoOmA6KgKFTgUMIqeaKPydQtxKkPEiJ9F7s09s2D07ZJtROtnJyz65lsPnpU0js5rsIZ4cWpER3UtPkG2eq1I6SZr9Xo8DUROCVDxPSk72x92MmliF75MFhbZKuKGU7dTPisUgKnCVzFujd5tp1lylHobnm6HycWppeOG5c4bSqVBGp3Ank6BTTvg",
                };
                Response.Check response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task CreateCheck23()
        {
            try {
                Request.CreateCheck request = new Request.CreateCheck(
                    "daf2d002-f16e-4d5c-81f5-532f11a3f3f2"
                ) {
                    PointAmount = 5112.0,
                    BearPointAccount = "3b5cf612-fb24-4648-ba09-81a28c59f07a",
                    PointExpiresInDays = 2879,
                    PointExpiresAt = "2020-05-16T22:29:02.000000Z",
                    ExpiresAt = "2020-03-08T04:01:31.000000Z",
                    UsageLimit = 8140,
                    IsOnetime = false,
                    Description = "gPMdYrCUsTg7mFBD5JyTl3OSbQF6o9LFFmkiVCdqahnf",
                };
                Response.Check response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

    }
}
