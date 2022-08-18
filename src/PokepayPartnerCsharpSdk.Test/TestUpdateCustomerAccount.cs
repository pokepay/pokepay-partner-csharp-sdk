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
    public class TestUpdateCustomerAccount
    {
        private Client client;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            client = new Client("~/.pokepay/test-config.ini");
        }

        [Test]
        public async Task UpdateCustomerAccount0()
        {
            try {
                Request.UpdateCustomerAccount request = new Request.UpdateCustomerAccount(
                    "f39e0dc7-ebbf-4161-a34e-e312bce444b9"
                );
                Response.AccountWithUser response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task UpdateCustomerAccount1()
        {
            try {
                Request.UpdateCustomerAccount request = new Request.UpdateCustomerAccount(
                    "f39e0dc7-ebbf-4161-a34e-e312bce444b9"
                ) {
                    ExternalId = "eZjSIQORsTn19Lt83IRfp6apsZzw",
                };
                Response.AccountWithUser response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task UpdateCustomerAccount2()
        {
            try {
                Request.UpdateCustomerAccount request = new Request.UpdateCustomerAccount(
                    "f39e0dc7-ebbf-4161-a34e-e312bce444b9"
                ) {
                    AccountName = "Ugb2qqrLtRpMZnFJMuPuuYDxHZdnikAchiJbVP3ZTnJxIJTqpbj9hQa29LtqbzIUCtrgI5GH6",
                    ExternalId = "i2f3OojTDEk0fitYgK",
                };
                Response.AccountWithUser response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task UpdateCustomerAccount3()
        {
            try {
                Request.UpdateCustomerAccount request = new Request.UpdateCustomerAccount(
                    "f39e0dc7-ebbf-4161-a34e-e312bce444b9"
                ) {
                    Status = "suspended",
                    AccountName = "zfXu0N7ZPQ6Ey6Tu3B",
                    ExternalId = "U56A0DovC2AWlgsj8AO1bqHH9NHpqZwH1tkpyND",
                };
                Response.AccountWithUser response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

    }
}
