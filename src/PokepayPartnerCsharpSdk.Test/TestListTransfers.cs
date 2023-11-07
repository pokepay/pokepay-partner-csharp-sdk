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
                    Description = "T8gUT0xhlhBKpW6d1YDflV5WRDxao8ypyckifraRkxk4fIPpUpvADXVFMrVUKAhD0WHYpXfg",
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
                    TransferTypes = new string[]{"coupon", "campaign", "exchange", "expire", "cashback"},
                    Description = "ZRrkTD5ax2bfGFITij9oMkkxsMsZJCkVeyULIbRDC5HI1T7",
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
                    TransactionTypes = new string[]{"payment", "expire", "topup", "transfer"},
                    TransferTypes = new string[]{"exchange", "coupon", "cashback", "topup", "expire", "transfer"},
                    Description = "le6CSUmpGq4wmfafZSVhTrNL08SkteC6i8PzV1bw2qsqh1Js4g2FlZFtNYwdi70hJKQCVwcvHayT047DDZNLgp4f76CgRvsTxERLzEgCaSiP1QwVSbziJ",
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
                    TransactionTypes = new string[]{"exchange", "cashback", "transfer", "payment", "expire"},
                    TransferTypes = new string[]{},
                    Description = "YrSuDwhHzqMXCcpdTEIp6lZO1xQG6DSuGHaKcrYWjYhhANnK4rsvjvJgBKy1oWbtmQ4Y17p4479rzeNaIyG13GSoA9mFKnrUWIuk56AL",
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
                    PrivateMoneyId = "e5d6291c-eea7-409a-973b-b8feef9e1bbb",
                    IsModified = false,
                    TransactionTypes = new string[]{"expire", "topup", "exchange", "transfer", "cashback"},
                    TransferTypes = new string[]{},
                    Description = "ExnNWvtSl6AeOE3aw46ZtOA7CEcnGML9Ty2kP8kWj5CEbxEZJ56gOvpnekQxfRigQ9CNJpset54c5ixnG",
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
                    TransactionId = "dd0eccbf-27d5-4115-b180-d140eff138b2",
                    PrivateMoneyId = "7746c369-92f9-4048-8533-a8acb7fddcd7",
                    IsModified = false,
                    TransactionTypes = new string[]{"expire", "payment", "topup"},
                    TransferTypes = new string[]{"campaign", "payment", "coupon"},
                    Description = "yhr3oVwWBmrkCvTwdUnJlqaB5MbMoTIwutlWHBoOIeDSxzcpOoOJW9zXPJ0MYGHJSsw",
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
                    CustomerName = "KfTg1iVmZUHtOXVfSs9nEbKYoBvTibmu8ddq4kMComkFD0lk0HcxWoSB99BDT6bYKxqlRQpkMUxRUpBYCjy6znOHzeeaQRZbcE3l8c4OtYbY4Kua1skNFdagh1OkNjNcDRug2nRCxqCKVJhVg9RsBqm5KyVPq0fU1OUJxvzgYR",
                    TransactionId = "9dcbbbc8-2030-40be-8d08-7b57418b56d9",
                    PrivateMoneyId = "558a8911-3c0c-4c36-8701-dcc1140bd115",
                    IsModified = false,
                    TransactionTypes = new string[]{},
                    TransferTypes = new string[]{"coupon", "payment", "exchange", "cashback", "transfer"},
                    Description = "XZkkaNM9CUYOhjQJEqH9n6XoAJWbLeyL6YmA24katAXtBCYc5V0MXRS9m6",
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
                    CustomerId = "3ae8a6df-d454-4d9a-be62-be40830bb351",
                    CustomerName = "FX9qKs4vj3KzZmLW6JhwaMufXFZLutaB8",
                    TransactionId = "ceaf05cd-9427-4779-b11b-45c8370f3818",
                    PrivateMoneyId = "347ecc69-0fd0-44ba-833d-4991b7697815",
                    IsModified = true,
                    TransactionTypes = new string[]{"expire", "topup", "cashback"},
                    TransferTypes = new string[]{"transfer", "campaign", "coupon", "exchange", "topup", "payment", "expire", "cashback"},
                    Description = "3qjZHvmUIrcQSa9u",
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
                    ShopName = "EYGwWEOQKZM6a3eUrfrNu2B2UNBn0ytnSLixSVyKkgxd8THBdU5ZcdNLVxFJZJl7TXWfh4cVYdsHlP3QwzHH13dAMnwWm6QXQA7g27VdnEWeBXkpFJl2VIGVxv2Fs1f6dVigLxS7eK8C0RPoMk6JdFgNSing2NrzMFZJPV9aFgKFVA6ExmwN5PCRYUQZaWBgl9YYXB1rZWBjfiCtK0VPnqYrsKSCLz9KlfAhfnGplt9SfnhZF4raBHJsCW",
                    CustomerId = "ad4bb492-7a64-40f9-aad8-ddbd19fa1360",
                    CustomerName = "rZuip3c4Iunw0LV4QwehPvVQOTvXSpeBZcS2dYKRrqhjHUqZcHcEY7MAUUqRJPifDYYB4RqeBalrH1svmN0DMcSzfEo2PqqgiXTr6csOpmFx5n90Dc3cElDonB355y3ltjAP5fw2CqAK8WVAIbNmi6CftEuKP6HvUyfI4ntteTL1TbyXMEs5VNaegTME57VWIcsFbBwEmA",
                    TransactionId = "38601ce4-24b1-4d58-bb79-f137e0a0875f",
                    PrivateMoneyId = "b3016d9a-513d-4196-9cb8-7e17e4e59952",
                    IsModified = true,
                    TransactionTypes = new string[]{"exchange", "cashback", "transfer", "payment", "topup", "expire"},
                    TransferTypes = new string[]{"expire", "cashback", "transfer", "coupon", "payment"},
                    Description = "AJGreMGRGn20XQzfBPfSxWIYhgInvpQ3BNpzCY7Rdx9jF5NaQ0NuC1KY44kWOdFWxfzR9VCBbWQ1riVcHnBavTLzE4zSnvsvkduu4NskX9I0PeEDGGNnH1eEgmu56wz8h0nyCYGScMKc4tkRIVcSKezwDzOCLAw8yHmgg459Fk8gMpyDMgiTt",
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
                    ShopId = "78f44657-a04d-455b-9ac7-31badf26c998",
                    ShopName = "UVd4l5Iz0oDGxyGjSPTYjby4uKORKrIqFVOmZlUjrByTx2spBiLyMVkhp",
                    CustomerId = "5c0dc648-9b35-4a2b-890a-0ccd346d3957",
                    CustomerName = "0b5zYrw2VA3obzjBcg57jMyJwu7TNF7zRWuYz8Q5nzCS4OuHV976u7mjmXJpk4bxLti9ZUufK",
                    TransactionId = "62a43574-4efd-4d23-94f3-e8e46efb4b04",
                    PrivateMoneyId = "62b73a90-157e-4b77-8dac-f3f92564543c",
                    IsModified = false,
                    TransactionTypes = new string[]{},
                    TransferTypes = new string[]{"campaign", "topup", "transfer", "expire", "exchange", "coupon", "cashback", "payment"},
                    Description = "2Cbr2NRJodlXGD1wnNeHuRK5mGd79bEOOGLJ1rmCz2dDc4rsl4NyLvtGKY5qLfFZcREz8bRj2LUEPcAKnD3dtYFkC7Ai8tpxKM1uH3",
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
                    PerPage = 2596,
                    ShopId = "ca961aa9-fdec-4961-8075-a029eadb68f3",
                    ShopName = "NwIzqYmYvrnkFcy1byg8E6",
                    CustomerId = "954a4d19-c028-4be9-9162-0569e0b81c48",
                    CustomerName = "49MLdsSU2vt6WY5THUsLDF9BK8UaIP5difywjSv",
                    TransactionId = "8fbd851f-c2a7-4fa7-8802-08d0da08247e",
                    PrivateMoneyId = "914fe109-29fe-4b49-b00b-b254fb8e5e68",
                    IsModified = false,
                    TransactionTypes = new string[]{"cashback", "expire", "exchange", "topup"},
                    TransferTypes = new string[]{"coupon", "exchange", "transfer", "cashback", "expire", "topup", "campaign", "payment"},
                    Description = "eNVzScbrEq",
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
                    Page = 8995,
                    PerPage = 8654,
                    ShopId = "9ffef72d-bd90-49eb-818d-61d4fca07b3f",
                    ShopName = "f9gShd3HS37NvvaQTMK90aAeyK78fRnYWX5eGJJTddHFIU01IouYAinrJ9sqNxu2x7MUfW4ez3igLN6TgDvZcxwFkjhNwOcev4MzbejmxVwNFdhb6VCr6XCUU4LsZJcpDPP8f8CI",
                    CustomerId = "9d5c7c8c-590f-45f0-aedf-011f78962f8d",
                    CustomerName = "3PFF1cCb1Cg4JY6fdx3EMnNslzmZtnOgHFcMv8Jpt0RDIwZ5iVqSwAw9MZfQCQTDyQtCabnKu3MlyhZksd9NE3a6eVWYTgzRI6AT3",
                    TransactionId = "bfb35084-eb98-4b4d-9055-310cb91d57ce",
                    PrivateMoneyId = "860b1b22-fbcd-4bb7-b13f-4bf04fe768b9",
                    IsModified = true,
                    TransactionTypes = new string[]{"exchange"},
                    TransferTypes = new string[]{"campaign", "topup", "coupon", "expire"},
                    Description = "pBDhU1o",
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
                    To = "2019-06-12T15:31:24.000000+09:00",
                    Page = 5308,
                    PerPage = 7181,
                    ShopId = "c4f8c2e0-82a7-4bb6-a90f-9c81b44670d6",
                    ShopName = "TFwBsErhsi30tSA5jAw6YzUBx84UEqUNyLrOCxX8R2dpwot48WExr2cOa47VJ5D528",
                    CustomerId = "01a41f56-64d1-43a3-a6c7-0bbd9d6d743a",
                    CustomerName = "VHZPXy9C907wF",
                    TransactionId = "501a3f30-31a0-4796-bef3-71273803df6b",
                    PrivateMoneyId = "d2d392af-5a37-4117-8a25-30b88a6deff3",
                    IsModified = true,
                    TransactionTypes = new string[]{"topup", "exchange", "payment", "cashback"},
                    TransferTypes = new string[]{"expire"},
                    Description = "dsCjHD3F2QbZrAHqgRJ5TF9X2iDswHBe5Y9Ni8IpfYeK0V5H68IVbsgB7wkhZ04CSVJ1vteeIlYC7mCba8OP69Qu6LeaTSKvLQmWH2iDhfljvW1eNAaCwm0RAa2KoASvzCIUz7v3nteI14oGABUrl39qUHtQJPBCYkT0sTmMLo7nUaKFAzYMD5jjQS1IFlzdi",
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
                    From = "2019-03-22T23:58:31.000000+09:00",
                    To = "2020-04-25T19:59:17.000000+09:00",
                    Page = 4265,
                    PerPage = 2997,
                    ShopId = "0e226fc7-2d12-4e2e-bef4-81812826fdfd",
                    ShopName = "ToK4pd3jVYYHK6Sr87KyeqJlFxIGsd1Vod7DE3WfcS7JoV31sIn7k0Qel3SyMrnUqqDDkxzf03ogEkWei6kLys0xxLkN7veWhnS",
                    CustomerId = "40225948-3c2d-44e9-9823-7bf8d87866d0",
                    CustomerName = "oXhcHgv7Zz6kBvlznmUCuSi2EX1IeLseHga4h3P7ZX1zxJPrzVcVmOH6Lo2lwYfT9AMiYxIATWDdLWlrSpZPyl3lT2VH03Thc7AleKTqttUiHnOoUU6z8tjUjaUwtKe8HKmKY7DpKow223XiK0TEZvyVUrLQONETpIPv74iUQ7NsHIAORcIxg99tyYVS2B3BbTh3nt7AB0qNL99iTwvD52XUEGP5P1Peaxe",
                    TransactionId = "2b6dd0ad-7456-4522-bf53-056895f3794d",
                    PrivateMoneyId = "0b624a04-2406-4242-a248-62328434763e",
                    IsModified = false,
                    TransactionTypes = new string[]{"topup", "exchange", "expire", "transfer", "cashback"},
                    TransferTypes = new string[]{"exchange", "payment", "topup"},
                    Description = "QpYaovQQxFZdG1I83DP4paSzd55ByamZCTji8jEsEQPk7X5LCQDD9jsvi",
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
