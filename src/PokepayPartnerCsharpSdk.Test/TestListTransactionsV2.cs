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
    public class TestListTransactionsV2
    {
        private Client client;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            client = new Client("~/.pokepay/test-config.ini");
        }

        [Test]
        public async Task ListTransactionsV20()
        {
            try {
                Request.ListTransactionsV2 request = new Request.ListTransactionsV2();
                Response.PaginatedTransactionV2 response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListTransactionsV21()
        {
            try {
                Request.ListTransactionsV2 request = new Request.ListTransactionsV2() {
                    PerPage = 294,
                };
                Response.PaginatedTransactionV2 response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListTransactionsV22()
        {
            try {
                Request.ListTransactionsV2 request = new Request.ListTransactionsV2() {
                    PrevPageCursorId = "00b6230f-7394-4d9f-9f97-f934db87e929",
                    PerPage = 747,
                };
                Response.PaginatedTransactionV2 response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListTransactionsV23()
        {
            try {
                Request.ListTransactionsV2 request = new Request.ListTransactionsV2() {
                    NextPageCursorId = "36acf857-afc0-464f-89bf-092583a351bd",
                    PrevPageCursorId = "43a0a02a-0728-4ca4-81eb-4290dcf8bf6a",
                    PerPage = 549,
                };
                Response.PaginatedTransactionV2 response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListTransactionsV24()
        {
            try {
                Request.ListTransactionsV2 request = new Request.ListTransactionsV2() {
                    To = "2022-08-06T14:52:06.000000+09:00",
                    NextPageCursorId = "ce7dc1a4-e89f-4d14-b848-4b8162fc0d10",
                    PrevPageCursorId = "fefa5b22-d91a-4b2a-91db-d298e19816dd",
                    PerPage = 891,
                };
                Response.PaginatedTransactionV2 response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListTransactionsV25()
        {
            try {
                Request.ListTransactionsV2 request = new Request.ListTransactionsV2() {
                    From = "2022-03-30T00:29:50.000000+09:00",
                    To = "2022-08-12T10:58:41.000000+09:00",
                    NextPageCursorId = "e5004f54-0348-40ef-9d2b-4df6c2ebf145",
                    PrevPageCursorId = "539d424c-d768-4788-8f55-8906bfadf8e4",
                    PerPage = 219,
                };
                Response.PaginatedTransactionV2 response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListTransactionsV26()
        {
            try {
                Request.ListTransactionsV2 request = new Request.ListTransactionsV2() {
                    Types = new string[]{"expire", "payment", "topup"},
                    From = "2022-12-01T11:56:22.000000+09:00",
                    To = "2020-03-30T21:25:52.000000+09:00",
                    NextPageCursorId = "77ac4d12-a2e8-444b-b87f-0f1b65ed6bb1",
                    PrevPageCursorId = "c545aff9-360f-4c57-b6de-2d0b0a739aec",
                    PerPage = 818,
                };
                Response.PaginatedTransactionV2 response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListTransactionsV27()
        {
            try {
                Request.ListTransactionsV2 request = new Request.ListTransactionsV2() {
                    IsModified = false,
                    Types = new string[]{"payment", "cashback", "exchange_inflow", "expire"},
                    From = "2020-02-04T22:13:45.000000+09:00",
                    To = "2020-09-02T12:44:13.000000+09:00",
                    NextPageCursorId = "3ee4101a-cbe8-4a2a-9e9d-b100b7a2fb3f",
                    PrevPageCursorId = "94aafab1-ab76-4000-9b51-2312d7ee272b",
                    PerPage = 717,
                };
                Response.PaginatedTransactionV2 response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListTransactionsV28()
        {
            try {
                Request.ListTransactionsV2 request = new Request.ListTransactionsV2() {
                    TransactionId = "HS",
                    IsModified = true,
                    Types = new string[]{"cashback"},
                    From = "2021-03-08T01:05:27.000000+09:00",
                    To = "2023-11-22T10:27:17.000000+09:00",
                    NextPageCursorId = "2f6fdb27-8d52-46d9-b3b4-cef39ec681d4",
                    PrevPageCursorId = "7552bcea-9010-48fa-b87a-efa3c08bc08a",
                    PerPage = 211,
                };
                Response.PaginatedTransactionV2 response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListTransactionsV29()
        {
            try {
                Request.ListTransactionsV2 request = new Request.ListTransactionsV2() {
                    Description = "Iqpu0yVVxuS1Dh90vsOxD0zKZzWp8fRhyJ5OV4gRYGGQ8Iyys9ufJZUvEqQhkOdp54foZKBIEPmExitdxeotBAgWCps7ld",
                    TransactionId = "b7eYwfjtZb",
                    IsModified = false,
                    Types = new string[]{"exchange_inflow", "exchange_outflow"},
                    From = "2023-06-06T09:21:45.000000+09:00",
                    To = "2021-03-30T08:29:35.000000+09:00",
                    NextPageCursorId = "7bdeb7e5-fd2c-46b3-a1bb-2c62002812f9",
                    PrevPageCursorId = "bc3e661b-64da-478f-bf78-8523e09c55f5",
                    PerPage = 500,
                };
                Response.PaginatedTransactionV2 response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListTransactionsV210()
        {
            try {
                Request.ListTransactionsV2 request = new Request.ListTransactionsV2() {
                    CustomerName = "sjTgKLh",
                    Description = "EAPBXyuWlI0lkkrPRUDc3xubGgzgpTyJdTG6wNd0703bQTgVQcArLsERBrd91jKkzxDXM3Q0vFNIMTWsMfH38UB3UUcxmTnXYAMOhDvyvzfDJjWxhcB48rqIfCVR3xWlq8GJlWtI4wZCZqMTJd7cZg91UZKIpBcX3IXpkKC3J47HsLGkA1YnJ1p",
                    TransactionId = "jpoBAfQ6SD",
                    IsModified = false,
                    Types = new string[]{"payment", "cashback", "expire", "topup", "exchange_outflow", "exchange_inflow"},
                    From = "2022-11-07T03:08:20.000000+09:00",
                    To = "2022-03-17T08:02:46.000000+09:00",
                    NextPageCursorId = "9bedf601-7f54-406f-adb7-9f3b4685fc52",
                    PrevPageCursorId = "f5483546-c650-4e07-9f29-dc5fd95cd975",
                    PerPage = 419,
                };
                Response.PaginatedTransactionV2 response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListTransactionsV211()
        {
            try {
                Request.ListTransactionsV2 request = new Request.ListTransactionsV2() {
                    CustomerId = "47d5308c-47a8-440e-b594-622241fcd925",
                    CustomerName = "V8SWZlKSGuuigpr7RKqATTTQLFv7f4bN8d9wke5kOSUcUeXy7ubZHIH3bw0aUDsOtDY3cUwZilUbnaLuDJP01wgDImyjusxzjEC4DmS73Zkp1UrHk2VS1j8huzyTT4c4Dw7NrFbgC3l2IDpEsyV56L14I5n",
                    Description = "glGwEaExLzR8lCdnjcaARhsHuIm0XtkuN1NvnCAZ3JzfVOyNbiqJ4s5EIAJkplwu3oQ3X45FMo6IhxQ2UbfMZm6TK2Qjdu40cgJ9CG6EUyA",
                    TransactionId = "VwA",
                    IsModified = false,
                    Types = new string[]{"expire", "topup", "exchange_inflow", "cashback", "exchange_outflow", "payment"},
                    From = "2021-09-19T03:00:20.000000+09:00",
                    To = "2023-12-01T19:44:13.000000+09:00",
                    NextPageCursorId = "df4e865e-4982-4166-aaf7-9f64ff7c6f44",
                    PrevPageCursorId = "37c836d6-fe31-4ef9-97b2-6dc01bf2c7d1",
                    PerPage = 641,
                };
                Response.PaginatedTransactionV2 response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListTransactionsV212()
        {
            try {
                Request.ListTransactionsV2 request = new Request.ListTransactionsV2() {
                    TerminalId = "1f6a5a2c-4ef6-4b87-b99e-96d4a44e46ca",
                    CustomerId = "d8d324d8-795f-43a9-8519-e1f6df78c56c",
                    CustomerName = "djPT1zB4pwGaFtgnhduf7dkd0TM9mreGVEu7AO9OghGITUGhGyHxTwklNOQ3U8ArOftruBdWErLAltBC46FQDIAdBldls2AlG3QY9ov8mE2yTLddQXiHMpktl08Aiyp",
                    Description = "Ba4IwbhcxipxSXDjFJZfyXOqeMoPdvT0aQ0mjCrH67pQez1nn3j3ELUSLyUyECMtvCbmdUlDIIP4sbc4lu2TkthN1p0AbuBHUOGne3XIDdi3kBzCH",
                    TransactionId = "N6wFxV8",
                    IsModified = false,
                    Types = new string[]{"expire", "topup", "exchange_inflow"},
                    From = "2020-07-06T04:50:07.000000+09:00",
                    To = "2020-09-22T06:18:12.000000+09:00",
                    NextPageCursorId = "81fca5c9-c0a0-4987-91de-b572c19f0331",
                    PrevPageCursorId = "db8fb77f-9487-460e-bc41-7c84f5dcbd45",
                    PerPage = 670,
                };
                Response.PaginatedTransactionV2 response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListTransactionsV213()
        {
            try {
                Request.ListTransactionsV2 request = new Request.ListTransactionsV2() {
                    ShopId = "a3ddb1e7-6d88-43b3-b342-f7f22f8e7b31",
                    TerminalId = "c4c5d64c-27d1-41ea-b44f-a278b7ae5a51",
                    CustomerId = "b9ae4046-1eda-4d76-9e7f-e349ea89262e",
                    CustomerName = "YraIrFnS7fkeUvDFSsCKlOJvW3e0EUwNWyhdSIZPzUGyQ1GT6LESRpZMpQ3Ge7FAJ8CJrccjaNlxQUbPoZtukWc2F3EKdk7KXnDL258kQrg9zrIVkmuxwU6RdBU1vPduG7idpGvBZ6eganAawZgJutu3wKsJOxlv7qRH9k3txp0yLq78R9s2J2OE6TJWtcl5uPijJyvKGGbRWTfiGMaGS8iDSuZwmlYXLHW5Ep5IqiZzvUTr5hCH",
                    Description = "HJS9NyxC7Secj4QfFExg91qa0cD3GrXQx0CltdyqYIxNa4AUlGZyHi5Pd9PvpNgoB5xnCj4tzE1NTptMRowD8YiyEoRDbDZFrdhg7riXytN8Qh",
                    TransactionId = "gjgtmiAq",
                    IsModified = false,
                    Types = new string[]{"exchange_inflow"},
                    From = "2022-10-12T17:55:32.000000+09:00",
                    To = "2024-01-12T14:46:01.000000+09:00",
                    NextPageCursorId = "a25ab4ff-15e9-46df-bc80-db63fd4da0bc",
                    PrevPageCursorId = "b4b22129-c845-425a-bca9-771047353e47",
                    PerPage = 309,
                };
                Response.PaginatedTransactionV2 response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListTransactionsV214()
        {
            try {
                Request.ListTransactionsV2 request = new Request.ListTransactionsV2() {
                    OrganizationCode = "K-V-",
                    ShopId = "89147889-6e63-40a8-a78e-76dd7d085bcb",
                    TerminalId = "c9294a8f-4382-4308-90f7-a5110f8a28f2",
                    CustomerId = "95b83ba2-cb17-4e8e-9b4e-b095eeccad33",
                    CustomerName = "iL2MQtXUMdhull0eFv9dHC6wZgxoktHBKgRwADTA81nR9wAA0vulOqZ0nt53toyWjtVRSo5UqnU1TrV3jlNUiqbF2TFn9PJm",
                    Description = "tnRzJZx3KIted9roXPzGZOvymjswnoj4YpXRLonrISUWRgCiM4gZRsW6hDMCBTclcQCgjy3ZKGBmy5dqh9t7mq8d",
                    TransactionId = "eZNEaEVA",
                    IsModified = true,
                    Types = new string[]{"topup", "cashback", "expire", "exchange_inflow", "payment", "exchange_outflow"},
                    From = "2020-04-29T23:50:54.000000+09:00",
                    To = "2020-12-03T19:01:09.000000+09:00",
                    NextPageCursorId = "c5439784-952e-4612-b875-851ca028fd13",
                    PrevPageCursorId = "d4139ef6-1509-4d14-8a50-1247dcb50b2d",
                    PerPage = 890,
                };
                Response.PaginatedTransactionV2 response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListTransactionsV215()
        {
            try {
                Request.ListTransactionsV2 request = new Request.ListTransactionsV2() {
                    PrivateMoneyId = "fb8f3e63-a95c-4e72-9a70-8618ae9b1907",
                    OrganizationCode = "iT-0-fZ0---ONxmKK0yeJ61O-Zes",
                    ShopId = "b82d92b0-e5bc-4006-9dcd-8841e41cbac6",
                    TerminalId = "6476657f-9203-4d39-b2c3-ab6673427116",
                    CustomerId = "1f993de2-11b8-4d4a-8a1c-92dcf65369a7",
                    CustomerName = "wAyXBZZVCcl5dxM4AYyX9oGi2HETVDhiCB0kA1SErqAqPZsWjyStR1yXu0ldTKl9iascgg5p9xJSeWtEcLR1H2BZOUWaYQp0p721oh6ozoDIuOiNtdIjK7OXgK1uirvs28",
                    Description = "0aHr3hbSFeNHPFra8Rcl0Tn8lkbvWjxix70XgGlbw7Qy0zuqU5BqA1F5Mebirv",
                    TransactionId = "Ixq7S",
                    IsModified = false,
                    Types = new string[]{"topup", "cashback", "exchange_inflow", "payment", "expire"},
                    From = "2022-04-13T06:22:42.000000+09:00",
                    To = "2020-04-04T01:47:26.000000+09:00",
                    NextPageCursorId = "b31cc634-da0d-45a9-8029-fb1499212ab9",
                    PrevPageCursorId = "13624950-3384-4052-88e2-75559410a310",
                    PerPage = 411,
                };
                Response.PaginatedTransactionV2 response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

    }
}
