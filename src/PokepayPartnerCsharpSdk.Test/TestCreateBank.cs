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
    public class TestCreateBank
    {
        private Client client;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            client = new Client("~/.pokepay/test-config.ini");
        }

        [Test]
        public async Task CreateBank0()
        {
            try {
                Request.CreateBank request = new Request.CreateBank(
                    "58384260-026d-49a5-9c9e-589871daca4b",
                    "9d0ffa8f-c1d4-46c5-895b-2a4118410389",
                    "MAf2HgecIl74FyRST7ScfdaiXI0aphnQpmaEH46JpxMwBWB66twUXazpjqxEREjqmyqJkEdfkYviMgBpZAYBbcvRZzaI37qk5Qpl5Gz36NQavWZXSE0IrKdpz0FXntwLwsP6PlvtKfS7zk6Hoi0oeAT0NWEwBSET0oVnBy6crZKnvytNg9",
                    "oYMrwaGFqX3wegLSKGRp"
                );
                Response.BankRegisteringInfo response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task CreateBank1()
        {
            try {
                Request.CreateBank request = new Request.CreateBank(
                    "58384260-026d-49a5-9c9e-589871daca4b",
                    "9d0ffa8f-c1d4-46c5-895b-2a4118410389",
                    "MAf2HgecIl74FyRST7ScfdaiXI0aphnQpmaEH46JpxMwBWB66twUXazpjqxEREjqmyqJkEdfkYviMgBpZAYBbcvRZzaI37qk5Qpl5Gz36NQavWZXSE0IrKdpz0FXntwLwsP6PlvtKfS7zk6Hoi0oeAT0NWEwBSET0oVnBy6crZKnvytNg9",
                    "oYMrwaGFqX3wegLSKGRp"
                ) {
                    Birthdate = "qSEu",
                };
                Response.BankRegisteringInfo response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task CreateBank2()
        {
            try {
                Request.CreateBank request = new Request.CreateBank(
                    "58384260-026d-49a5-9c9e-589871daca4b",
                    "9d0ffa8f-c1d4-46c5-895b-2a4118410389",
                    "MAf2HgecIl74FyRST7ScfdaiXI0aphnQpmaEH46JpxMwBWB66twUXazpjqxEREjqmyqJkEdfkYviMgBpZAYBbcvRZzaI37qk5Qpl5Gz36NQavWZXSE0IrKdpz0FXntwLwsP6PlvtKfS7zk6Hoi0oeAT0NWEwBSET0oVnBy6crZKnvytNg9",
                    "oYMrwaGFqX3wegLSKGRp"
                ) {
                    Email = "wLWT9k07B0@88FF.com",
                    Birthdate = "f",
                };
                Response.BankRegisteringInfo response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

    }
}
