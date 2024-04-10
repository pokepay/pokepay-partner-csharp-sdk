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
    public class TestCreateOrganization
    {
        private Client client;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            client = new Client("~/.pokepay/test-config.ini");
        }

        [Test]
        public async Task CreateOrganization0()
        {
            try {
                Request.CreateOrganization request = new Request.CreateOrganization(
                    "xrA24",
                    "28zEWnFZLX87qtedPzV8NdiYCurc",
                    new string[]{"c735f73c-6310-4b19-8ecf-94836f5376d0", "8cfd37da-350f-499c-8026-a6fa315ae997", "20b778f7-ba4d-4bd7-8867-94510f672fbc", "6dcc57b0-2800-4f56-8553-2b94e65e6508", "1a812366-c0bd-47f3-8689-a37037441857", "17cfd7fc-1eb9-4f62-8795-c25b9b9fe4b9", "8aad33ce-e6c2-4ae4-868c-3de3d9ed35fa"},
                    "TSynCfTiWL@EN2p.com",
                    "Ebq7ZeB8PV@JkE9.com"
                );
                Response.Organization response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task CreateOrganization1()
        {
            try {
                Request.CreateOrganization request = new Request.CreateOrganization(
                    "xrA24",
                    "28zEWnFZLX87qtedPzV8NdiYCurc",
                    new string[]{"c735f73c-6310-4b19-8ecf-94836f5376d0", "8cfd37da-350f-499c-8026-a6fa315ae997", "20b778f7-ba4d-4bd7-8867-94510f672fbc", "6dcc57b0-2800-4f56-8553-2b94e65e6508", "1a812366-c0bd-47f3-8689-a37037441857", "17cfd7fc-1eb9-4f62-8795-c25b9b9fe4b9", "8aad33ce-e6c2-4ae4-868c-3de3d9ed35fa"},
                    "TSynCfTiWL@EN2p.com",
                    "Ebq7ZeB8PV@JkE9.com"
                ) {
                    ContactName = "zaeTptZ5kX9rLpagdWQnEnTlLyubwibc5uG9Y4cn6ApRZ5NX6gFb5nuODlmm9rpn022H3wQmNFzbLFm",
                };
                Response.Organization response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task CreateOrganization2()
        {
            try {
                Request.CreateOrganization request = new Request.CreateOrganization(
                    "xrA24",
                    "28zEWnFZLX87qtedPzV8NdiYCurc",
                    new string[]{"c735f73c-6310-4b19-8ecf-94836f5376d0", "8cfd37da-350f-499c-8026-a6fa315ae997", "20b778f7-ba4d-4bd7-8867-94510f672fbc", "6dcc57b0-2800-4f56-8553-2b94e65e6508", "1a812366-c0bd-47f3-8689-a37037441857", "17cfd7fc-1eb9-4f62-8795-c25b9b9fe4b9", "8aad33ce-e6c2-4ae4-868c-3de3d9ed35fa"},
                    "TSynCfTiWL@EN2p.com",
                    "Ebq7ZeB8PV@JkE9.com"
                ) {
                    BankAccountHolderName = ",",
                    ContactName = "FSz1uperYHhU5vbLxW8Yq15XpRuu89q3NykiRPYO2oQiAYMcKkXBWEu4RSjxgCW3jFlgob7yobgqdqFleVhpCebdmmx3jJLFYo72YjP5pod5QaLCZTmFLxumOnvrupx1",
                };
                Response.Organization response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task CreateOrganization3()
        {
            try {
                Request.CreateOrganization request = new Request.CreateOrganization(
                    "xrA24",
                    "28zEWnFZLX87qtedPzV8NdiYCurc",
                    new string[]{"c735f73c-6310-4b19-8ecf-94836f5376d0", "8cfd37da-350f-499c-8026-a6fa315ae997", "20b778f7-ba4d-4bd7-8867-94510f672fbc", "6dcc57b0-2800-4f56-8553-2b94e65e6508", "1a812366-c0bd-47f3-8689-a37037441857", "17cfd7fc-1eb9-4f62-8795-c25b9b9fe4b9", "8aad33ce-e6c2-4ae4-868c-3de3d9ed35fa"},
                    "TSynCfTiWL@EN2p.com",
                    "Ebq7ZeB8PV@JkE9.com"
                ) {
                    BankAccount = "834",
                    BankAccountHolderName = "(",
                    ContactName = "PfCabjEtMliIf7wKoPmNQWU6zl3h0ZGoCe5IIfEbaRlpdhTTQpQoSRT6b0IY83jSy9CLjq8yjjxInoBnLVw5NxHP7CI9Yb5tOQ2qp6BlopujNmJIuVKWvjUjC0u3f2Lo9NqlV6uXM4yE9kd7lV6QKkz6REzoI7cZYW4c0GyNh6EpQVqX4KE4B5KRDxSSppVORQLy6PO73cHGKqjz0v27dHE8reh9b3v7zqeYS2n0EGsPPbvQvYkAPBJ7wm",
                };
                Response.Organization response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task CreateOrganization4()
        {
            try {
                Request.CreateOrganization request = new Request.CreateOrganization(
                    "xrA24",
                    "28zEWnFZLX87qtedPzV8NdiYCurc",
                    new string[]{"c735f73c-6310-4b19-8ecf-94836f5376d0", "8cfd37da-350f-499c-8026-a6fa315ae997", "20b778f7-ba4d-4bd7-8867-94510f672fbc", "6dcc57b0-2800-4f56-8553-2b94e65e6508", "1a812366-c0bd-47f3-8689-a37037441857", "17cfd7fc-1eb9-4f62-8795-c25b9b9fe4b9", "8aad33ce-e6c2-4ae4-868c-3de3d9ed35fa"},
                    "TSynCfTiWL@EN2p.com",
                    "Ebq7ZeB8PV@JkE9.com"
                ) {
                    BankAccountType = "saving",
                    BankAccount = "710",
                    BankAccountHolderName = "ﾖ",
                    ContactName = "xAKZBD2FhNoFZKIbAgSoRCKxxDEWQZO9yz4Mc4BWxPS7UaVHpVi4pZYZOGKLSewvJuaN97ObUNQZ0A0Rwk2Z2omGatDjCcJfOMaGd4kHySUJYrKI48UyLazcdaqg9M9b56VUQzIG7Yr7fsBnFuG56tOVY8vi9Z9lrbTGfh4QbdPS2DfLew9jsvLcXjFRqAsdyU0EjzFGdoCEVoN09yrlyTlHcxkp2hdiJWs83eoAqvgg01z",
                };
                Response.Organization response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task CreateOrganization5()
        {
            try {
                Request.CreateOrganization request = new Request.CreateOrganization(
                    "xrA24",
                    "28zEWnFZLX87qtedPzV8NdiYCurc",
                    new string[]{"c735f73c-6310-4b19-8ecf-94836f5376d0", "8cfd37da-350f-499c-8026-a6fa315ae997", "20b778f7-ba4d-4bd7-8867-94510f672fbc", "6dcc57b0-2800-4f56-8553-2b94e65e6508", "1a812366-c0bd-47f3-8689-a37037441857", "17cfd7fc-1eb9-4f62-8795-c25b9b9fe4b9", "8aad33ce-e6c2-4ae4-868c-3de3d9ed35fa"},
                    "TSynCfTiWL@EN2p.com",
                    "Ebq7ZeB8PV@JkE9.com"
                ) {
                    BankBranchCode = "",
                    BankAccountType = "current",
                    BankAccount = "1728474",
                    BankAccountHolderName = "ｦ",
                    ContactName = "RsB1baR1aePdc9fGHLcwyelAg5Jr7zEeO7nUDqxXj74j643AIOVakyq8QHWKNric3MBQYWsKtvnxoQJLloM94TQVFchkaVLnKXq1JcpZfZUH2UsKCxnRcuSoLNAly4QR5kzfucn7LZFZwhy5RIJGwbFSZ2qU",
                };
                Response.Organization response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task CreateOrganization6()
        {
            try {
                Request.CreateOrganization request = new Request.CreateOrganization(
                    "xrA24",
                    "28zEWnFZLX87qtedPzV8NdiYCurc",
                    new string[]{"c735f73c-6310-4b19-8ecf-94836f5376d0", "8cfd37da-350f-499c-8026-a6fa315ae997", "20b778f7-ba4d-4bd7-8867-94510f672fbc", "6dcc57b0-2800-4f56-8553-2b94e65e6508", "1a812366-c0bd-47f3-8689-a37037441857", "17cfd7fc-1eb9-4f62-8795-c25b9b9fe4b9", "8aad33ce-e6c2-4ae4-868c-3de3d9ed35fa"},
                    "TSynCfTiWL@EN2p.com",
                    "Ebq7ZeB8PV@JkE9.com"
                ) {
                    BankBranchName = "L9frpqlrETgz3O9wlyQ0TWfR4Gx21zM7WIQGDsPsJyAShBlCJPjt",
                    BankBranchCode = "",
                    BankAccountType = "other",
                    BankAccount = "287228",
                    BankAccountHolderName = "/",
                    ContactName = "hryHKQAP2bBeZkmIh2UeN7Z047tEp9MnaMKkPTTOh4KlFXKgtixsqVTYrrSHZ1a0tz4EzkuhUCHWp85qyAYWUJWst1yIlHOt0Xi",
                };
                Response.Organization response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task CreateOrganization7()
        {
            try {
                Request.CreateOrganization request = new Request.CreateOrganization(
                    "xrA24",
                    "28zEWnFZLX87qtedPzV8NdiYCurc",
                    new string[]{"c735f73c-6310-4b19-8ecf-94836f5376d0", "8cfd37da-350f-499c-8026-a6fa315ae997", "20b778f7-ba4d-4bd7-8867-94510f672fbc", "6dcc57b0-2800-4f56-8553-2b94e65e6508", "1a812366-c0bd-47f3-8689-a37037441857", "17cfd7fc-1eb9-4f62-8795-c25b9b9fe4b9", "8aad33ce-e6c2-4ae4-868c-3de3d9ed35fa"},
                    "TSynCfTiWL@EN2p.com",
                    "Ebq7ZeB8PV@JkE9.com"
                ) {
                    BankCode = "",
                    BankBranchName = "6Qkur8SbZd3wcu",
                    BankBranchCode = "753",
                    BankAccountType = "other",
                    BankAccount = "",
                    BankAccountHolderName = "\\",
                    ContactName = "UlIAlQvL5t780R8L5VrLxzRQlVu0ZdkmHWdPUiVDqeHPcQVtlOjSB31Mxq8SXpxSHJRZi52y7KvoeklIR5ig74Fkbtbb0SlK2KbT8BQ8WxGHxi6f0cuW1ZhxLtCHCm7yUfJm7Fg98YgjSKRGLQpNx8ciNrKweGJtnGqdSp90ci6D0iGddOVzLT6tirwJLurByrAGwszVwlQAuTXTWtKg2YB5YxVquVYsbDyysR",
                };
                Response.Organization response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task CreateOrganization8()
        {
            try {
                Request.CreateOrganization request = new Request.CreateOrganization(
                    "xrA24",
                    "28zEWnFZLX87qtedPzV8NdiYCurc",
                    new string[]{"c735f73c-6310-4b19-8ecf-94836f5376d0", "8cfd37da-350f-499c-8026-a6fa315ae997", "20b778f7-ba4d-4bd7-8867-94510f672fbc", "6dcc57b0-2800-4f56-8553-2b94e65e6508", "1a812366-c0bd-47f3-8689-a37037441857", "17cfd7fc-1eb9-4f62-8795-c25b9b9fe4b9", "8aad33ce-e6c2-4ae4-868c-3de3d9ed35fa"},
                    "TSynCfTiWL@EN2p.com",
                    "Ebq7ZeB8PV@JkE9.com"
                ) {
                    BankName = "sRQ9ectqoj4yKOsEPCrpQPvSjUDltH57ysDpO4lTbJ",
                    BankCode = "0481",
                    BankBranchName = "wKn5NSHIJ7mbc5qbOnYCYxA4AjI47p6qtIsaCpt80GzH1FRWe6zLcwMHaeJGF",
                    BankBranchCode = "810",
                    BankAccountType = "other",
                    BankAccount = "344456",
                    BankAccountHolderName = "E",
                    ContactName = "SAh41fZii84vybd1Jsf0jR3rzbwtxyn2FAh1zUedGEpNztrZH4AytTH",
                };
                Response.Organization response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

    }
}
