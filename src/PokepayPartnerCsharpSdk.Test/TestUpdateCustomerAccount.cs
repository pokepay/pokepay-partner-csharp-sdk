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
                    "cff74c61-cb3c-4826-9c2c-6c6704051386"
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
                    "cff74c61-cb3c-4826-9c2c-6c6704051386"
                ) {
                    Metadata = "{\"key1\":\"foo\",\"key2\":\"bar\"}",
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
                    "cff74c61-cb3c-4826-9c2c-6c6704051386"
                ) {
                    ExternalId = "PUC9GnoaK0P12PCDldng31MZvzzwLFYmf",
                    Metadata = "{\"key1\":\"foo\",\"key2\":\"bar\"}",
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
                    "cff74c61-cb3c-4826-9c2c-6c6704051386"
                ) {
                    AccountName = "cuJt9kI9U6j99OPTS7XOPCTUoXu6TYapqfaLYsHJH9PP8lhxgkdW9iNwgpn2ml07SNBd3bnAwunfW8U9IUxtv6XDldGcCT4v0IQ3eyiAyDmWUOoMeCCcl9CMeLuXTW76GTTHMDfhWMCUnoKmLLnX4IAensLWc1mdjK",
                    ExternalId = "Q4UThHs4AbkLvyT0rWpGxshVy3aHkrD7qLLei3Y8CNBhDe",
                    Metadata = "{\"key1\":\"foo\",\"key2\":\"bar\"}",
                };
                Response.AccountWithUser response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task UpdateCustomerAccount4()
        {
            try {
                Request.UpdateCustomerAccount request = new Request.UpdateCustomerAccount(
                    "cff74c61-cb3c-4826-9c2c-6c6704051386"
                ) {
                    Status = "pre-closed",
                    AccountName = "BxORn9QZyq1l4qoy9Af7AaCborFPfpzF",
                    ExternalId = "Z5",
                    Metadata = "{\"key1\":\"foo\",\"key2\":\"bar\"}",
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
