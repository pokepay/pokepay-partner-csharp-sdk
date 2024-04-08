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
                    "438f86c4-85d0-4bd9-8a9d-3941867967ad",
                    "2212ed03-8825-40d6-ba56-a08028c272b6",
                    "vyI6ywfpyKilj5zg8pn57kF0DYbPLXjuwrpeD0A9IDYP4sAiFNwaac9r9GBqh0SVIl9M1spjv4mKXU1rVLf6U0K44BovHKqYzk7GBG1DZKj2tBRFerhSuL22gGga7pF0nmLMfnIYTQdqHJZ8WnDHEVfpIBtEOM",
                    "P2U7IkYygmkkDxd3MzpkzvPsPo2v"
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
                    "438f86c4-85d0-4bd9-8a9d-3941867967ad",
                    "2212ed03-8825-40d6-ba56-a08028c272b6",
                    "vyI6ywfpyKilj5zg8pn57kF0DYbPLXjuwrpeD0A9IDYP4sAiFNwaac9r9GBqh0SVIl9M1spjv4mKXU1rVLf6U0K44BovHKqYzk7GBG1DZKj2tBRFerhSuL22gGga7pF0nmLMfnIYTQdqHJZ8WnDHEVfpIBtEOM",
                    "P2U7IkYygmkkDxd3MzpkzvPsPo2v"
                ) {
                    Birthdate = "cZvK",
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
                    "438f86c4-85d0-4bd9-8a9d-3941867967ad",
                    "2212ed03-8825-40d6-ba56-a08028c272b6",
                    "vyI6ywfpyKilj5zg8pn57kF0DYbPLXjuwrpeD0A9IDYP4sAiFNwaac9r9GBqh0SVIl9M1spjv4mKXU1rVLf6U0K44BovHKqYzk7GBG1DZKj2tBRFerhSuL22gGga7pF0nmLMfnIYTQdqHJZ8WnDHEVfpIBtEOM",
                    "P2U7IkYygmkkDxd3MzpkzvPsPo2v"
                ) {
                    Email = "af470Dw5YI@6SeA.com",
                    Birthdate = "OBDBgRA",
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
