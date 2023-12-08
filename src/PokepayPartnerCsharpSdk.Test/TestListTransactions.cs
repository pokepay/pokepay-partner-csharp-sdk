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
    public class TestListTransactions
    {
        private Client client;

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
                Response.PaginatedTransaction response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListTransactions1()
        {
            try {
                Request.ListTransactions request = new Request.ListTransactions() {
                    Description = "tu08AkjC0WPKbQvYow9",
                };
                Response.PaginatedTransaction response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListTransactions2()
        {
            try {
                Request.ListTransactions request = new Request.ListTransactions() {
                    Types = new string[]{"cashback", "exchange_outflow", "expire", "payment", "topup", "exchange_inflow"},
                    Description = "zD7SQmRuyNCMpGLgUAKK4AYXStTHGYGCT6FSvry2ciGzpWdg5yn158N5eaT1YQUtPEMBFK5RCvbOFISTKPBIbnB4IlVfzKQeAZtwqv4AGYkQ5YWzuO0mrMzlLTVYxU13omHKmdh2ng7xlmB0D7qlClsr3peE1RPsdDZEoaT5osfv5Au45ikm",
                };
                Response.PaginatedTransaction response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListTransactions3()
        {
            try {
                Request.ListTransactions request = new Request.ListTransactions() {
                    IsModified = false,
                    Types = new string[]{"exchange_outflow", "exchange_inflow", "topup", "payment"},
                    Description = "rL5tEVsPccciqGzpCuGxgjotbAnDFm6nBFTBcp5MgKi6djde9q9Gx06zspIhW3gmaN6JcrvmX5",
                };
                Response.PaginatedTransaction response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListTransactions4()
        {
            try {
                Request.ListTransactions request = new Request.ListTransactions() {
                    PrivateMoneyId = "0cdcfa47-a319-4d37-a3e0-9f996e79988f",
                    IsModified = true,
                    Types = new string[]{"cashback", "exchange_outflow", "payment", "topup", "exchange_inflow", "expire"},
                    Description = "URH3hLLIVR7YcRrTeQOsLdvK2PUyIdpshyxjFJxJ7Fcj7Ywb40WRFS5iP8DHnWS95dKYCDWjMDqXUFGoRA4Xv",
                };
                Response.PaginatedTransaction response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListTransactions5()
        {
            try {
                Request.ListTransactions request = new Request.ListTransactions() {
                    OrganizationCode = "amu1Qb",
                    PrivateMoneyId = "10cdcd72-743b-4c21-b523-f6636c69665f",
                    IsModified = true,
                    Types = new string[]{"expire", "cashback", "payment"},
                    Description = "6HP3Edv56q9t5VGuIJJqB3hC6IgJljp1y8KOJgfu4WFT3sPLKGiMRgfz5jiMdvRW63Z9043h9SU3fTD5o4Kn6TQ5PsH9Yt",
                };
                Response.PaginatedTransaction response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListTransactions6()
        {
            try {
                Request.ListTransactions request = new Request.ListTransactions() {
                    TransactionId = "nNi",
                    OrganizationCode = "-Y-d-4ozKC-meZh",
                    PrivateMoneyId = "312b45e7-0344-465f-808e-b9eefdd31bdc",
                    IsModified = false,
                    Types = new string[]{"payment", "expire", "exchange_inflow"},
                    Description = "eIh1PycrJFKeRKa",
                };
                Response.PaginatedTransaction response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListTransactions7()
        {
            try {
                Request.ListTransactions request = new Request.ListTransactions() {
                    TerminalId = "e526330b-4f10-4611-8415-21107623cb2b",
                    TransactionId = "6OogwkyZ",
                    OrganizationCode = "-8-gzwp54Cp61-z---0z-m-8-",
                    PrivateMoneyId = "51051155-841b-4179-9618-41eadd75c975",
                    IsModified = true,
                    Types = new string[]{"payment", "exchange_outflow", "topup", "expire", "cashback"},
                    Description = "aiUShsjoKemD9IJVji3EhQ10nakJ4Xx7BosawhL51XW0ltZ8tyBqdUl09HCPEoMCgQwCdLCVxkfS7LC09h1a33P4feIw8rNkq1IJcIVXzbXoLITUciADNRcm8cr7h7uvpVmJgh2hs",
                };
                Response.PaginatedTransaction response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListTransactions8()
        {
            try {
                Request.ListTransactions request = new Request.ListTransactions() {
                    CustomerName = "BOtxaFVpQwu69vaYb020lVhpK1ujAV4SIGQkIPmfa5YJsZSIV5H0hKFZRjFJsBJwxE5ymHkkfvwj75uGxXyxLiKvyAHQ0Cmh0GR2iNpQgbrTS2HEf",
                    TerminalId = "89e41d66-51d0-47de-b78c-4a30a57e7a88",
                    TransactionId = "HCUoh",
                    OrganizationCode = "Mc8-b69es4rdU1V85719",
                    PrivateMoneyId = "aa77fa8d-811f-4d68-a643-531199e66e63",
                    IsModified = true,
                    Types = new string[]{"expire", "exchange_outflow", "topup", "payment"},
                    Description = "KBpAMRk3KT9aHDvn680BNVo61whu52VEWHzeXnCqnnjKe2ZokcQxt9okwN5c4Mkgq5YYKEEntoCEiLAHJ2sW9Fit",
                };
                Response.PaginatedTransaction response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListTransactions9()
        {
            try {
                Request.ListTransactions request = new Request.ListTransactions() {
                    CustomerId = "132e1b6a-2886-4075-b495-bf5542cede4a",
                    CustomerName = "sIkCXGENUTkzcX2ykkKJlN107OaiUpqdHMS0BnQNQ8yntRPdiO7nDWAmmXsETvex6EwUtMqxtCS",
                    TerminalId = "bc4e0fcd-6322-4d5d-8598-8023fcf8b05a",
                    TransactionId = "WLR3IYMZq",
                    OrganizationCode = "I-0p--c-ke-",
                    PrivateMoneyId = "51b1acc2-3c61-4e54-aa36-52c36869090a",
                    IsModified = false,
                    Types = new string[]{"exchange_outflow", "expire", "exchange_inflow"},
                    Description = "MrDSrYQmTFD8MK4LhwIRladKEnUCUBMTsHjSLXQWZdqZHXOS9NchMx",
                };
                Response.PaginatedTransaction response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListTransactions10()
        {
            try {
                Request.ListTransactions request = new Request.ListTransactions() {
                    ShopId = "1625350c-099f-4275-8da5-f2766daeb39d",
                    CustomerId = "67ba2e4d-cb4f-45d6-bf24-6caa8fd747dc",
                    CustomerName = "5pE0ThIcNVnpd1n04FvafoOT5XflXygJfyBJl1nws6Ne3S7kdpHli9FCf9vj51iwXi5vVkai7fMidPllBkchJ2ELHNBkuEPtWGn6U1tknXv7iBjpuz8kXfTQVtq7nYSMGg6A5q48d0VvhbqvZRxaI0AVDH5phIrM988xOpACBuWehCLI5Ithzpo1sbw0fi8Tfl4MiezYuuDN5NO2HkiJUlQ4dKgR3uo3pyHQKCLEzAV2HW0T6wtgFowhjkpuax7i",
                    TerminalId = "fa3db2ee-5d54-47c3-9304-c49ec529804b",
                    TransactionId = "JlAlkDX0z9",
                    OrganizationCode = "skmZmz-6-t2-zOM7Nh6geRQq",
                    PrivateMoneyId = "386e97bb-3cfc-4b82-aed4-0ad1ad9fb213",
                    IsModified = false,
                    Types = new string[]{"cashback", "payment", "exchange_inflow", "exchange_outflow"},
                    Description = "piIl88uXhFr9tzNaCFLhrW7Qg63LOoyDRk2frbKYDtHXRSpeSviFk4W1qsOLMcNwe8KEeqmGGreSt4nt1ybC0Ywm3a7y1jkUDzYlQVbUnnRBBQRDsGnvgO2bodBPeKpRFsQIEwGMkEBFs4OKbpkXgOJ3P1nM9riBWugVW8sRaEhx8aJkSJHuUfzU3cx",
                };
                Response.PaginatedTransaction response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListTransactions11()
        {
            try {
                Request.ListTransactions request = new Request.ListTransactions() {
                    PerPage = 114,
                    ShopId = "85574ecc-2ca0-4753-8738-f7938b7bbea6",
                    CustomerId = "39a50153-c8df-4134-aa16-f42145881782",
                    CustomerName = "P0CNMNfb6VowWUVfzovzP7VL5ebcijLtVhmlM6kBu7DCNg4aU7BlWsNECFWA4hHlvtcjGtIPadSKiVX8t6IuP7AfSh1iSdnomW",
                    TerminalId = "941f5da3-f206-4782-87bd-8c0f56ec376c",
                    TransactionId = "A8y2vwAsT",
                    OrganizationCode = "YHl-S1Os-uSHO6-js2-7lM-e-yj---",
                    PrivateMoneyId = "de011e95-9a90-4745-a9f8-0f0bba2bf206",
                    IsModified = true,
                    Types = new string[]{"exchange_inflow", "topup", "payment", "exchange_outflow"},
                    Description = "FOu5KxrV4xhz7DzBywKIciMlN0S7L0N0uBHj0xIlmI7crwjgiJmBq8x2BMoiejWmPY8qwKCFWRUhTWJtrSHM5KvGCx3jvLeQXqJ7fOtRApW564YK0LvLN69VHlYJhXH6cUQL7XLfiXA0zUZ8WIiKSeWU9z6lAbD3wpFlmsWusC8RGaBKUJdHLf9kwaxRbmzAo5vz",
                };
                Response.PaginatedTransaction response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListTransactions12()
        {
            try {
                Request.ListTransactions request = new Request.ListTransactions() {
                    Page = 8179,
                    PerPage = 7438,
                    ShopId = "3753612a-ea71-4643-80b4-413315717728",
                    CustomerId = "69f02507-246b-42f6-9235-32d62d4b787a",
                    CustomerName = "4JSx7Qk5qYm8EJV1By6vGk0FuWZ3ptkSyNBcc9paWacdvlF8sKq6M8TMch0t9MLsXgvG8EYKbsPpBkO0z5h9",
                    TerminalId = "a2dcac56-b2c4-4de0-84fe-eb58ff4ef53c",
                    TransactionId = "3NEhs",
                    OrganizationCode = "vo8p3E-9D4-0L-0",
                    PrivateMoneyId = "cc969fb4-db01-4b0d-aba8-c61d56943552",
                    IsModified = false,
                    Types = new string[]{},
                    Description = "zLLX07kGwmRZR89QJDyeQCnprhi7qh3KP4T37Wi9g9nZZhOiq9TM1kLnMOaPoayQ1SL4LwXctk2uyuazqzFpngLk90ZBFe71DIECbUavopC",
                };
                Response.PaginatedTransaction response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListTransactions13()
        {
            try {
                Request.ListTransactions request = new Request.ListTransactions() {
                    To = "2019-11-15T11:08:19.000000+09:00",
                    Page = 8051,
                    PerPage = 4509,
                    ShopId = "f044ec1e-0e36-4061-add5-79aeb7a5c6f1",
                    CustomerId = "b75f285b-c057-49e9-8d69-767ff8b935b2",
                    CustomerName = "uDVrmTki6pqO0f8cnptMkBRjmpnnbeCg4xumOoxK0oT4F795unttA065Yr03Qzj1SYSblk7QSMdkkKPrtzfsCSKaR3OFn1WKJz5hhBZBCZgSERTDaoK9IqITw9RXh5VLaB",
                    TerminalId = "11d539fb-32ae-4c58-93d3-60b34b1173c5",
                    TransactionId = "srMpj",
                    OrganizationCode = "j4V0-7rLZw--m-s-11y--S4k",
                    PrivateMoneyId = "29fb7fb0-5794-4c04-bfd6-cfc1f4122396",
                    IsModified = false,
                    Types = new string[]{},
                    Description = "L",
                };
                Response.PaginatedTransaction response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListTransactions14()
        {
            try {
                Request.ListTransactions request = new Request.ListTransactions() {
                    From = "2015-10-20T14:29:57.000000+09:00",
                    To = "2023-11-11T04:41:23.000000+09:00",
                    Page = 5786,
                    PerPage = 1681,
                    ShopId = "020a413f-94d8-4484-8d42-d9a49776a7fe",
                    CustomerId = "ea46d57d-f0d6-47d8-9e8b-ba9a72e971d6",
                    CustomerName = "IePzMvb8rIAKhBAUImOpB9NJd0FGb0jOdIa2VbV1E7pIBf60ZOpXb0u",
                    TerminalId = "6e908ed5-8685-45d4-bc6a-3f4524e6bb27",
                    TransactionId = "W5F",
                    OrganizationCode = "V4t8s",
                    PrivateMoneyId = "3cc48352-cbb5-4de2-965e-7637792ce134",
                    IsModified = true,
                    Types = new string[]{"exchange_inflow", "payment"},
                    Description = "MclFLskpVJhF8OvhWGp3gTZC60RTw4fZ8zWBqSC3vDIMcnooU2vsEkhFzbMP7H4x70jy8CyXSjsNQfhm4JdiSR8LU0sAxVpKo9Pr8tnCR4b3VVcnR7ySaTJSLXaRbjFaO",
                };
                Response.PaginatedTransaction response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

    }
}
