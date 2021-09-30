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
    public class TestListTransactions
    {
        private Client? client;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            client = new Client("~/.pokepay/test-config.ini");
        }

        [Test]
        public async Task ListTransactions0()
        {
            try {
                Request.ListTransactions request = new Request.ListTransactions();
                Response.PaginatedTransaction response = await request.Send(client!);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.StatusCode!, (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.StatusCode >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListTransactions1()
        {
            try {
                Request.ListTransactions request = new Request.ListTransactions() {
                    Description = "TAZIE0d3whSKLF4xWXCg",
                };
                Response.PaginatedTransaction response = await request.Send(client!);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.StatusCode!, (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.StatusCode >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListTransactions2()
        {
            try {
                Request.ListTransactions request = new Request.ListTransactions() {
                    Types = new string[]{"exchange_inflow", "exchange_outflow", "topup", "payment"},
                    Description = "SsQVPrApoltrzZbMjGbqCaDUv1CsWTy6z2FdXbfXavW2HwaVVWGcOvRgfjTir1eeHpnGAvFN5uVHKI7mM3plgJR5fwzKIFQc",
                };
                Response.PaginatedTransaction response = await request.Send(client!);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.StatusCode!, (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.StatusCode >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListTransactions3()
        {
            try {
                Request.ListTransactions request = new Request.ListTransactions() {
                    IsModified = false,
                    Types = new string[]{"exchange_inflow", "payment"},
                    Description = "ZVlRU03Fa2F6PUopGrOCijX4VQZjHwhb9lV9sTjbq8Wo22UU1er3T1gBtfr20CiDsCwyLdW5AzEeQbE5VhNxjrtNh84WLuHKWoYQpDLtJyiWbDVy6Ss7attO0KDvZ2PuoFKU33PYYZTEIyRndmm72c26Cd6B3OB7swghUIdkqUOY",
                };
                Response.PaginatedTransaction response = await request.Send(client!);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.StatusCode!, (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.StatusCode >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListTransactions4()
        {
            try {
                Request.ListTransactions request = new Request.ListTransactions() {
                    PrivateMoneyId = "3cc695ac-cab2-4b5f-8841-abc913a198b8",
                    IsModified = false,
                    Types = new string[]{"exchange_inflow", "payment", "topup", "exchange_outflow"},
                    Description = "8vMnTzjNmFWDzLZEPN7HQXwymFrbXYvN3cal4RO9jT63dRDxKNVoewLoaJggIMA5wXB3CTdPu3I6Gb57N6Bfk723xgVJhWc2FLmu9RV4wTQ1eFfFoOmA6KgKFTgUMIqeaKPydQtxKkPEiJ9F7s09s2D07ZJtROtnJyz65lsPnpU0js5rsIZ4cWpER3UtPkG2eq1I",
                };
                Response.PaginatedTransaction response = await request.Send(client!);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.StatusCode!, (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.StatusCode >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListTransactions5()
        {
            try {
                Request.ListTransactions request = new Request.ListTransactions() {
                    OrganizationCode = "X--l-4dU57GxN0f8c2-v-hF--PuqM-5-",
                    PrivateMoneyId = "84feeb67-644b-45ee-a73b-1c4380e18a3d",
                    IsModified = false,
                    Types = new string[]{"exchange_outflow", "topup"},
                    Description = "ujd",
                };
                Response.PaginatedTransaction response = await request.Send(client!);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.StatusCode!, (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.StatusCode >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListTransactions6()
        {
            try {
                Request.ListTransactions request = new Request.ListTransactions() {
                    TransactionId = "c1e93c1c-b8b5-46a5-baf4-54ad692797f0",
                    OrganizationCode = "-H---5-f-31W2--Qx-tE",
                    PrivateMoneyId = "c2286d41-9fee-459b-abdc-b07ee4c953b6",
                    IsModified = true,
                    Types = new string[]{"topup", "payment", "exchange_outflow"},
                    Description = "HzzgdLIxgPMdYrCUsTg",
                };
                Response.PaginatedTransaction response = await request.Send(client!);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.StatusCode!, (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.StatusCode >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListTransactions7()
        {
            try {
                Request.ListTransactions request = new Request.ListTransactions() {
                    TerminalId = "e355910a-a6e0-4bb7-84ed-1c4638b12142",
                    TransactionId = "7350b687-e326-421b-965f-7fc4de5ccd35",
                    OrganizationCode = "L-l",
                    PrivateMoneyId = "a37a9d19-dd40-413b-a956-7a43f9e5a421",
                    IsModified = false,
                    Types = new string[]{"exchange_outflow", "exchange_inflow", "topup"},
                    Description = "qahnfY1HR9DfMzD3LCASqee9bY3sHOGNF3Mai4m7no77RN8AasCH56gnyuHFpFsNPJmzuH1GHYOOmiUvKwyiQYSSoPK3N5ZGrmU0unMptspEioBBqGcJLaXcepDTPRHElLNQrvWUnk17KWAi",
                };
                Response.PaginatedTransaction response = await request.Send(client!);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.StatusCode!, (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.StatusCode >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListTransactions8()
        {
            try {
                Request.ListTransactions request = new Request.ListTransactions() {
                    CustomerName = "iFIGH7shpxz5S2r82nr4Char2DsC6IOlQ3ZCa8lZmMT5mAFAIeN7EOzXnRCcbLOsMiN4tjoxBAROpiRc0j39oPNkDTFwGmGihFz2z0gAPfWDnSv3",
                    TerminalId = "c9f88909-ba17-47f0-a5cd-60f31eb35071",
                    TransactionId = "9a631a8a-9c55-491c-af1d-03f44f151408",
                    OrganizationCode = "v0j-",
                    PrivateMoneyId = "b926cb22-01d5-402b-a8a0-e8b1d22a7e5e",
                    IsModified = false,
                    Types = new string[]{},
                    Description = "yHwM52367FRSK6ZN3d",
                };
                Response.PaginatedTransaction response = await request.Send(client!);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.StatusCode!, (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.StatusCode >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListTransactions9()
        {
            try {
                Request.ListTransactions request = new Request.ListTransactions() {
                    CustomerId = "0b07f190-d3d0-4715-8718-a6ca99762a96",
                    CustomerName = "hssMJ1c81K9V4uwaN6FqKGuMQEbIhSKLSxcJDAAH0jwIPbMhYlMMXruKsOetb8P3w3wpAlq46MRFhBa1KSFCImukjAtQPb0UOTifX7KrzTtAdseC51TTzGU05VTqLiAQDTT40IDYkIvu0sCcHMaDTHEOIiZjdOoQxmayWcgZvBQUAudiHvhALf0xr0YedjAtAhk4Q5ZEYWHc6DIDKem3xaXPio",
                    TerminalId = "b47e7035-dc3b-47fd-aeef-b4b00b4f1889",
                    TransactionId = "08141bf1-29b9-4178-b0e9-675585186008",
                    OrganizationCode = "6pqi124eJ23IQZ2-G-4-2-LzD--",
                    PrivateMoneyId = "24a7f392-2f7b-4452-8d3f-b8d06a33d356",
                    IsModified = false,
                    Types = new string[]{"topup", "payment", "exchange_outflow", "exchange_inflow"},
                    Description = "cOO1w2GShMQxP1XNaA4tMwkt9CEIs7P52Qn8Ps6rGg4gx",
                };
                Response.PaginatedTransaction response = await request.Send(client!);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.StatusCode!, (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.StatusCode >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListTransactions10()
        {
            try {
                Request.ListTransactions request = new Request.ListTransactions() {
                    ShopId = "36b4aa28-4aa0-4768-9145-dd50539ace40",
                    CustomerId = "d46dfe82-1d48-4f26-9dec-3b445ff9d6cd",
                    CustomerName = "zo7RyqyjDQCvIVLohtP7YX7LIJvkHIDHAM5JdvPW8u4K9jehE0FIX2d1fsIJRaq4cseT3Jr8x9EZ1qV4Ufa8eDKBhpNX1jWPk8Z43B0y0B9mfs2NjGqIbT9OwqnkaPpwID0eLyZpFNZ79bus52pNLLPoSL84SGwACEhVooVmB4cFvbTIGcXWAqG4BSfipEZMFGhk16I7iXigWOnUAkBWGfv1h3SdKWf7Mk6qxlTg",
                    TerminalId = "2cd7ae3d-2d08-408e-a12c-26e0290b4c1b",
                    TransactionId = "a821411e-8d83-473d-b313-2202285c59fc",
                    OrganizationCode = "",
                    PrivateMoneyId = "660013e0-20f1-44cc-94f1-ae7e11ec2cc7",
                    IsModified = true,
                    Types = new string[]{"payment", "exchange_inflow"},
                    Description = "QDuaFv4VsaDUMga8HPHLfj8VAxLQCn6D",
                };
                Response.PaginatedTransaction response = await request.Send(client!);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.StatusCode!, (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.StatusCode >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListTransactions11()
        {
            try {
                Request.ListTransactions request = new Request.ListTransactions() {
                    PerPage = 625,
                    ShopId = "a7c2ad92-5f70-47d0-9927-db37a6bef875",
                    CustomerId = "e79be95a-4aa5-464b-b3b5-eef7b55d8e4d",
                    CustomerName = "f3MBYDCuFCMBOgtd28MFakoJp4sttlPyu0hLTf3LV1FvqM27O2bqybT3XFSWXNEvBDebROkI568yn3vAdg2WzE6cQfJbdKVhYmdIeaGtyZiVBFtaHsVEu5jHLt1IIKsQ450xUM6O5hfI4vi32RsgmtpDzruBR2bpCJbWCsF1XO",
                    TerminalId = "0f8e3606-b2cd-42f7-9ecf-74cda3652ae6",
                    TransactionId = "1863241f-f862-4c97-8f04-0a93ace66243",
                    OrganizationCode = "--z-m-F4T-9Hu-9WU4",
                    PrivateMoneyId = "efd61b1a-2ca8-451a-9c5f-45c798e54544",
                    IsModified = true,
                    Types = new string[]{"exchange_inflow", "exchange_outflow", "topup"},
                    Description = "4Vk2VUx2tI5N4bIOpNtWwRJ7taFGOOZNR9womkOYYXss1h0acoAUmABE9DWtAN",
                };
                Response.PaginatedTransaction response = await request.Send(client!);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.StatusCode!, (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.StatusCode >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListTransactions12()
        {
            try {
                Request.ListTransactions request = new Request.ListTransactions() {
                    Page = 9249,
                    PerPage = 9545,
                    ShopId = "e8965db4-16fe-43dc-8325-9a1e96d7e1b5",
                    CustomerId = "6373d8f3-bf66-4878-b8d3-a3e7e9c6fc60",
                    CustomerName = "9q1O62IQSAJ63xgskw6yfFQPcXHRn98CcSXK5Zlq5PBZ9vRV0xbdBDEvdzHS5KI84n4B4JwtxMbsrynFzleqVzZvPQrwaZ",
                    TerminalId = "5a4e8a35-0af8-44e6-ba75-b8dd67698107",
                    TransactionId = "27cbf36d-2ba8-427a-b0b5-e544079dd5af",
                    OrganizationCode = "L",
                    PrivateMoneyId = "0aa64158-3474-4f1b-b294-87a885961d52",
                    IsModified = true,
                    Types = new string[]{},
                    Description = "xOmHZB8Yd9TYL0bkCAVqSRIdac4BtBwC2bbOKrqEvtHSmLf6gZqSXb2Lr55RtyiRtGJ1HUxolj1KPz6vAaVd6Sg4zOt2LPb0nLBvCfu5QWsdUnRrH9KHVuXFGKt4lw9lRVMCAhIxweHf4mhVFw56RKDemCYdfHKy6",
                };
                Response.PaginatedTransaction response = await request.Send(client!);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.StatusCode!, (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.StatusCode >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListTransactions13()
        {
            try {
                Request.ListTransactions request = new Request.ListTransactions() {
                    To = "2021-05-11T18:48:19.000000+09:00",
                    Page = 3650,
                    PerPage = 8667,
                    ShopId = "005704a8-ed28-4fc2-bd90-f6b09038a965",
                    CustomerId = "19f248b7-440f-42fc-a7dc-9e538594ee6f",
                    CustomerName = "Ck5GjWL9QXL9sfwRokQiO2gJLOs7NWiVmOaSDg31Umvi1k0xZepHVlU5",
                    TerminalId = "f8afd8d5-2bc3-44e0-8295-3e88addaeaeb",
                    TransactionId = "0e19adfb-e831-4eed-833c-ea32dc071eb6",
                    OrganizationCode = "4A-8B-7-9r6-0pOHL",
                    PrivateMoneyId = "4aab6e89-ddc7-4754-aa28-9588c64cf6a1",
                    IsModified = true,
                    Types = new string[]{"topup", "payment", "exchange_outflow", "exchange_inflow"},
                    Description = "pAIG2G",
                };
                Response.PaginatedTransaction response = await request.Send(client!);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.StatusCode!, (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.StatusCode >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListTransactions14()
        {
            try {
                Request.ListTransactions request = new Request.ListTransactions() {
                    From = "2020-08-09T06:06:25.000000+09:00",
                    To = "2025-02-19T13:53:54.000000+09:00",
                    Page = 717,
                    PerPage = 9156,
                    ShopId = "ef1fc346-6d8b-4637-9811-1327bd1d7a0a",
                    CustomerId = "f7c1fb53-8b32-4236-b970-6fd4f801a37a",
                    CustomerName = "Exe5LQXN3tfMMeaiTEdRlgPRLO6iu4xB9p9hHVjuFskSUixLpvflY8MFYZJvlfPZ9XRs2DjUex8FZc",
                    TerminalId = "5fa63023-67a6-4af2-b534-fda1a5252336",
                    TransactionId = "9b1905b8-6806-47f5-a51a-8a2cffb62ee9",
                    OrganizationCode = "-fIx--4-5EX-Sp0U-K-v-y24-b--F1-M",
                    PrivateMoneyId = "040857d6-130f-4ea3-af48-a8fa6e8ad7b2",
                    IsModified = false,
                    Types = new string[]{"exchange_inflow"},
                    Description = "x9gOffBCzdPD5lY5ruzs73QnlHzwGB",
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
