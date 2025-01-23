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
    public class TestListTransfers
    {
        private Client client;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            client = new Client("~/.pokepay/test-config.ini");
        }

        [Test]
        public async Task ListTransfers0()
        {
            try {
                Request.ListTransfers request = new Request.ListTransfers();
                Response.PaginatedTransfers response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListTransfers1()
        {
            try {
                Request.ListTransfers request = new Request.ListTransfers() {
                    Description = "Hg3HpQOkzK7LlGZ5l2cQL9XINJ3Yd9vs5R5vReMbbVX8HS4JwKvfQBXbwG5FfObbKUS2wO8JUS6TcMNwfudd0O",
                };
                Response.PaginatedTransfers response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListTransfers2()
        {
            try {
                Request.ListTransfers request = new Request.ListTransfers() {
                    TransferTypes = new string[]{"transfer", "campaign", "coupon", "payment", "expire", "cashback"},
                    Description = "6kEZNJtfvLzUTMMVxGv3INa5f54YI1Ph3OUBAsVaG6TxK3slQw2Vv1qEnKcaw1pz9vX015UD9qqTdXnkHVwtuWRPDBo28vDsYr2EOFyjAKpCpIzZXmsoGSwaJTi7OUK0vKQ13gfO1QSAIUcA7AjSS",
                };
                Response.PaginatedTransfers response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListTransfers3()
        {
            try {
                Request.ListTransfers request = new Request.ListTransfers() {
                    TransactionTypes = new string[]{"expire", "topup", "cashback", "payment", "exchange"},
                    TransferTypes = new string[]{"topup", "exchange"},
                    Description = "2Ra1BMEr62gevnEoyfp",
                };
                Response.PaginatedTransfers response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListTransfers4()
        {
            try {
                Request.ListTransfers request = new Request.ListTransfers() {
                    IsModified = false,
                    TransactionTypes = new string[]{"cashback"},
                    TransferTypes = new string[]{"exchange", "campaign", "payment", "cashback", "expire", "transfer", "topup"},
                    Description = "9aDgdNSfmE5De5bTvMyHpd2S0WD3FaqRKAgoYEGpNOGzwWmNqL0QHxylFWlu94S8FVSDMY5BU7ZXRTfnNFoNra90XKkUB3tuq1X9Hm0SHBKCUruJxi1ST1WXtfeKSzrq1Zc5Ju53UYOCwl5C8rEq5yNfh8NoRe5rX0rVCmpqdlL",
                };
                Response.PaginatedTransfers response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListTransfers5()
        {
            try {
                Request.ListTransfers request = new Request.ListTransfers() {
                    PrivateMoneyId = "3ee11c24-b1c8-4cce-a8a8-058d5b0676ce",
                    IsModified = false,
                    TransactionTypes = new string[]{"cashback", "transfer"},
                    TransferTypes = new string[]{"expire", "topup", "transfer", "payment"},
                    Description = "FRDSiyltrh",
                };
                Response.PaginatedTransfers response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListTransfers6()
        {
            try {
                Request.ListTransfers request = new Request.ListTransfers() {
                    TransactionId = "03027fd0-347a-49ce-a9b7-929296819488",
                    PrivateMoneyId = "af32746a-e6e5-45ac-9926-70ee7029216a",
                    IsModified = true,
                    TransactionTypes = new string[]{"topup", "transfer", "expire", "exchange"},
                    TransferTypes = new string[]{"payment", "coupon", "exchange", "cashback", "expire", "campaign", "transfer", "topup"},
                    Description = "Ol5XLEB6rdcoyFq3Dy2RXyPUAe3PgOIxNaz33MDlMm45c417ClVPZadCz21oTLg0Zh082rSUmgTJgltXU",
                };
                Response.PaginatedTransfers response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListTransfers7()
        {
            try {
                Request.ListTransfers request = new Request.ListTransfers() {
                    CustomerName = "opMAE6nKVgCC79b4Ei190OQ71CLczodkHUHlo8UiDVjyL8K2mxNxSNDBAB21jRDnDfUt4YgIyZaTsiHOmcCShoExxXDzwmu0NmtxroKVUk7sDu4lw8ZxL5ooBCUmbexHlOYPdRDRXfcFEKebPAHiatKRmL7K8IMJIBW1vB1RC8WQ75Zq2CPEph5LyiHrKKZHYeA6KMsRSBkbfNhFwjSSUkqouGV2ULftf3KLiOm0u6OdTYvY1WMa6BM",
                    TransactionId = "a3752b9a-7021-4e64-8517-444819062062",
                    PrivateMoneyId = "d331c96f-32f2-4ba0-b983-d142e4aca901",
                    IsModified = true,
                    TransactionTypes = new string[]{"cashback", "payment", "topup", "transfer"},
                    TransferTypes = new string[]{"exchange", "coupon", "transfer", "campaign", "cashback", "expire", "payment"},
                    Description = "jeAF8N8XvRYyNjj6LzPNoFY0NP",
                };
                Response.PaginatedTransfers response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListTransfers8()
        {
            try {
                Request.ListTransfers request = new Request.ListTransfers() {
                    CustomerId = "7ec6ff5b-191f-4b60-a1a9-fc63750546fe",
                    CustomerName = "gW3tdaerbfAUj6MGuDCQRgbbh69IfOOqdFvcvTYHWhMSc2JtDSCuxpXIBKjX0wbEINtuhWyJmxhctiEpL1KlL20SY28CEIpXvCz2lX0WFgkUTJYHHOr63hjnglJCcSZdRjCOwyap0lsb8d4Dc5yMU1TN0yX6wxY6IPoPyEr8klncfGkEwHBWOqOm",
                    TransactionId = "1ed84f6a-c0ab-4450-9485-e4d133301dea",
                    PrivateMoneyId = "447e5ac3-604a-42c9-aff1-eb64ead8c902",
                    IsModified = false,
                    TransactionTypes = new string[]{"topup", "transfer", "exchange"},
                    TransferTypes = new string[]{"cashback", "expire", "topup"},
                    Description = "MnqIdNLL8T5msTmgqj81RXJ34GFY2SrpQfm9Le0rSPWlrPa8fbLwdjVaS9JydpHqXjqW7D3uCGCdE3Z7gIcLSudPl4JIrQmLFWJxcGB9NLriuIsMTYyCUoOEa9YZaUNPTMagDSPeHLGCGYvgqbqCIdoPTyGfjAlvbOwBRftL3mTfJhTjDs9c8QNUGvnht1UycVdhwj",
                };
                Response.PaginatedTransfers response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListTransfers9()
        {
            try {
                Request.ListTransfers request = new Request.ListTransfers() {
                    ShopName = "qe7Rve16qe5BUa3mrtCxkktMbdZ0Ff5nebRZC0vDYNEWMfxXSVHRY4YZdsEswklf9tWgAr9KxjsUzeefEvU98BI4BdtnYVFOF5IXA6lNw66Yqs62ry4EX0H5SsjBGi2vt",
                    CustomerId = "222b6c33-7a49-4c0f-9520-d25668c91d0e",
                    CustomerName = "LujfoeXIyA6Ao821XE5",
                    TransactionId = "9148d535-970a-4283-8ae8-ace36f0e9732",
                    PrivateMoneyId = "3497bb39-7d8b-48fc-9d70-567fe01d1a27",
                    IsModified = true,
                    TransactionTypes = new string[]{"expire", "payment", "transfer"},
                    TransferTypes = new string[]{"exchange", "transfer", "expire", "campaign", "topup", "cashback", "coupon", "payment"},
                    Description = "A4Og2kdAYLVTxSOsaSsUmdY0CLcfoUMFSIdEJMG98zC6otpSw3LnpbrPkZnNjPWO55U7DSfY3LgW5M2IvR52CgIBy3eLTys12HHDFFeqLoUtYmfM0XLYceQxhubY3jVYhbh4RW4SjcPHu2g",
                };
                Response.PaginatedTransfers response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListTransfers10()
        {
            try {
                Request.ListTransfers request = new Request.ListTransfers() {
                    ShopId = "958fa3ab-2349-4470-b70f-4c481a57c890",
                    ShopName = "lCgxYlFZzBuHZ8tjsh68ScZg3aAMErPcV9o0TcGJkIJgRMahTjY4B83KCbssdnciBK2yKUyBpazsFHLyPhoCqWWrzikH0DrThI9ndCARX9iZhUIwUrsQ8Uijo55dyiBxXbKWY",
                    CustomerId = "defd9e0d-ea06-48fd-ba68-a6ac9dd2e2f1",
                    CustomerName = "QcADAJhWFwASll2hGkEzja1NmQHCUATGGz590dtBhucZ4e0BzAWy80f2MmxJUnd92RrjDmsbpR1t9xme9U0GR2pRvNpULEoTr6H5p2Y5YBaOZdS1seolNILNbVpFGvZ3N4x3uvaLnbw12Ii4C82SzJJG4lODNS2Ij7U5b72UTWbjXGfzCmZ2vkYmrCrWwA7IkDmk9acr8t",
                    TransactionId = "024620fd-b2d8-4103-b9fb-074a37c02b51",
                    PrivateMoneyId = "8476e614-82d3-4cc8-b969-f646ebb3a22b",
                    IsModified = true,
                    TransactionTypes = new string[]{"exchange", "expire", "payment", "cashback", "transfer", "topup"},
                    TransferTypes = new string[]{"topup", "cashback"},
                    Description = "K8GIOW0PGU45uzPdd0dJeNNvUC0bqs1hvmd5I8",
                };
                Response.PaginatedTransfers response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListTransfers11()
        {
            try {
                Request.ListTransfers request = new Request.ListTransfers() {
                    PerPage = 6374,
                    ShopId = "21964b76-489f-4693-8f62-0381baa72672",
                    ShopName = "QGpnYomE2cpD4cThkIOO2LW0e3G1sTmjjHcN57ZbAikJ2opGyr1ja3zumve771kQ7mwZnfGMQasC1yb1Dq2UL9Kx0jYk7sZRicOTg23f5GXrX6ozTzm0HG0TosxKz4jitwHtujKhwCFGwiyv4vlRBRxfHZeKBVf4jVtecQNubIdHetIBPUrvpeN86f46tWgyM4",
                    CustomerId = "534fcd33-a2a8-4289-818e-9b4a391a9528",
                    CustomerName = "0KTwWOYBSX4EzfsIiIDCSxoowqwobMRj4K8plKuk4zON6lsKCXAkk07Q9YuV27x2ZZwJNPJ0aXH1uRWCYsw6VRBfXAF7xeoT0y6lNlDnKEOyMV89HUL5OwvTmfkSpdcLQvsJQRiuvWpRkphzntqbTr2vHF1iF0Y7dBxe8hiTzwkLtzBfAa7kaQm6vULSy1FKdTtu83N0tnRGbdpbMjOs6NsjUai",
                    TransactionId = "bf038cab-5ac4-4b3a-9c1c-acf2f801baef",
                    PrivateMoneyId = "f453b2d9-cdb6-4fa4-9120-1cb3cd46e549",
                    IsModified = false,
                    TransactionTypes = new string[]{"payment", "topup", "expire", "transfer", "exchange"},
                    TransferTypes = new string[]{"payment"},
                    Description = "M3IJrwVbs9pMxfMCthiv1a2EEHFmQw4OmJsXraAGliEBPmHrH76ocsr7yZptwOIMGR",
                };
                Response.PaginatedTransfers response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListTransfers12()
        {
            try {
                Request.ListTransfers request = new Request.ListTransfers() {
                    Page = 3221,
                    PerPage = 8348,
                    ShopId = "2d67995a-f2cc-4c14-ab12-040bbbda35f4",
                    ShopName = "LdV7uiWarFr5GP0wp4l70ZsGyPlyZYRURgUMf",
                    CustomerId = "b61b3030-27d0-490a-81af-a4354316829b",
                    CustomerName = "ozHDn0iOeoW",
                    TransactionId = "8a110fc9-2152-45d2-8d84-849bd7ba0e1b",
                    PrivateMoneyId = "a660438a-97f9-48d2-aa30-8d6e4e31961c",
                    IsModified = false,
                    TransactionTypes = new string[]{"payment"},
                    TransferTypes = new string[]{"payment", "topup", "exchange"},
                    Description = "7eaFGoiOPKR0rUW9UTcnGDBsZuPfABdiNvfS9A",
                };
                Response.PaginatedTransfers response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListTransfers13()
        {
            try {
                Request.ListTransfers request = new Request.ListTransfers() {
                    To = "2023-07-24T21:00:30.000000Z",
                    Page = 6902,
                    PerPage = 5607,
                    ShopId = "d749657b-59a1-4de9-aaa1-b2b6c03e52d4",
                    ShopName = "HnocikBJOkD3FvwnaI0WeOGlWmmegc1KGhe3TxnuKac7CS1DK4Gnrr3oBLGMXHrz9mqfRhRmUp8pN9pjtBKEK15Dd3XxCT0Zmu6u7tOxquneNatGolCf6SjeF7Se",
                    CustomerId = "83f4900a-447e-4a2e-bada-6958250203f9",
                    CustomerName = "S6WkNJ2GvSwQUcruYP4H5cCw5ExNqh41OXXFwVmaHYw6oEFbK8qER1LlAIi5qYTqeIN9jftsBTkZDK",
                    TransactionId = "46499f43-946e-4fde-9169-b2dff8d43667",
                    PrivateMoneyId = "8da4c0c9-7bc2-4a63-a7f9-a065beef34c8",
                    IsModified = false,
                    TransactionTypes = new string[]{"exchange", "payment", "topup", "transfer", "cashback", "expire"},
                    TransferTypes = new string[]{"transfer", "topup", "coupon", "campaign", "payment", "expire", "exchange", "cashback"},
                    Description = "oYNaRDH3xa5ZXl3L94kmDiQZVmfdCV9wGJUROgp1VTNstKsbk2wvZcZmJCZwuee4w9Rkvag9C19xRl1IlJpGXqlhd",
                };
                Response.PaginatedTransfers response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListTransfers14()
        {
            try {
                Request.ListTransfers request = new Request.ListTransfers() {
                    From = "2022-12-02T08:09:19.000000Z",
                    To = "2023-06-04T18:20:53.000000Z",
                    Page = 6008,
                    PerPage = 5712,
                    ShopId = "c67cda06-5267-43b5-bd33-3f9f5dd89e1e",
                    ShopName = "j3Qic0iyKLnZxaZi9iCa2kj9IDD4",
                    CustomerId = "6ca6e0c6-0d1a-4d3c-8c5b-b95d262f4f55",
                    CustomerName = "53H4cTCafuN856J50SdiADG37eydGENMPuSUGC",
                    TransactionId = "98531b50-bebf-43ce-9f15-e45cd718d7c8",
                    PrivateMoneyId = "0ef2a7e9-665d-4a9d-8604-4170ac388c30",
                    IsModified = false,
                    TransactionTypes = new string[]{"transfer", "cashback", "expire"},
                    TransferTypes = new string[]{"expire"},
                    Description = "e1sIjLSVztCspdpKcDGU85LATApzQ2dQG1XtK0UfX1fzmKZw4jAX5TdVMZA3FsBWHTaR7q8iHovbTWoPNbCUX3WmvU0lnYW7MWulxJqejEoXiemEzy22TP2wtSY9IoDSrJUA2sSTBsOwjVmr0bTbO79f",
                };
                Response.PaginatedTransfers response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

    }
}
