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
    public class TestCreateCustomerAccount
    {
        private Client? client;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            client = new Client("~/.pokepay/test-config.ini");
        }

        [Test]
        public async Task CreateCustomerAccount0()
        {
            try {
                Request.CreateCustomerAccount request = new Request.CreateCustomerAccount(
                    "13fc31f4-ab13-4552-8970-52a788378b0f"
                );
                Response.AccountWithUser response = await request.Send(client!);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.StatusCode!, (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.StatusCode >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task CreateCustomerAccount1()
        {
            try {
                Request.CreateCustomerAccount request = new Request.CreateCustomerAccount(
                    "13fc31f4-ab13-4552-8970-52a788378b0f"
                ) {
                    ExternalId = "MZnFJMuPuuYDxHZdnik",
                };
                Response.AccountWithUser response = await request.Send(client!);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.StatusCode!, (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.StatusCode >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task CreateCustomerAccount2()
        {
            try {
                Request.CreateCustomerAccount request = new Request.CreateCustomerAccount(
                    "13fc31f4-ab13-4552-8970-52a788378b0f"
                ) {
                    AccountName = "AchiJbVP3ZTnJxIJTqpbj9hQa29LtqbzIUCtr",
                    ExternalId = "I5GH6wQi2f3OojTDEk0fitYgKzfXu0N7ZPQ6Ey6T",
                };
                Response.AccountWithUser response = await request.Send(client!);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.StatusCode!, (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.StatusCode >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task CreateCustomerAccount3()
        {
            try {
                Request.CreateCustomerAccount request = new Request.CreateCustomerAccount(
                    "13fc31f4-ab13-4552-8970-52a788378b0f"
                ) {
                    UserName = "u3BU56A0DovC2AWlgsj8",
                    AccountName = "O1bqHH9NHpqZwH1tkpyNDcuWxfr4xKRRC5UPfddKJfLPJmxAhDpkltxfpGBgKzLBWM",
                    ExternalId = "YifX",
                };
                Response.AccountWithUser response = await request.Send(client!);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.StatusCode!, (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.StatusCode >= 300, "Should be larger than 300");
            }
        }

    }
}
