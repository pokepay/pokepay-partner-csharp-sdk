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
    public class TestCreateExternalTransaction
    {
        private Client client;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            client = new Client("~/.pokepay/test-config.ini");
        }

        [Test]
        public async Task CreateExternalTransaction0()
        {
            try {
                Request.CreateExternalTransaction request = new Request.CreateExternalTransaction(
                    "4701f4e4-3bec-475d-9f70-bb67dd3af7fe",
                    "88d565f6-b4fc-4ff3-97b3-8a43235de4ae",
                    "e828decd-6db8-412b-b43e-e24758c4b6e7",
                    3316
                );
                Response.ExternalTransaction response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task CreateExternalTransaction1()
        {
            try {
                Request.CreateExternalTransaction request = new Request.CreateExternalTransaction(
                    "4701f4e4-3bec-475d-9f70-bb67dd3af7fe",
                    "88d565f6-b4fc-4ff3-97b3-8a43235de4ae",
                    "e828decd-6db8-412b-b43e-e24758c4b6e7",
                    3316
                ) {
                    RequestId = "4f6628c4-0795-44a2-9413-d79c30635cf4",
                };
                Response.ExternalTransaction response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task CreateExternalTransaction2()
        {
            try {
                Request.CreateExternalTransaction request = new Request.CreateExternalTransaction(
                    "4701f4e4-3bec-475d-9f70-bb67dd3af7fe",
                    "88d565f6-b4fc-4ff3-97b3-8a43235de4ae",
                    "e828decd-6db8-412b-b43e-e24758c4b6e7",
                    3316
                ) {
                    Products = new object[]{new Dictionary<string, object>(){{"jan_code","abc"}, {"name","name1"}, {"unit_price",100}, {"price",100}, {"is_discounted",false}, {"other","{}"}}, new Dictionary<string, object>(){{"jan_code","abc"}, {"name","name1"}, {"unit_price",100}, {"price",100}, {"is_discounted",false}, {"other","{}"}}, new Dictionary<string, object>(){{"jan_code","abc"}, {"name","name1"}, {"unit_price",100}, {"price",100}, {"is_discounted",false}, {"other","{}"}}},
                    RequestId = "33b81316-5a7b-4c67-bd1f-99e789b5126c",
                };
                Response.ExternalTransaction response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task CreateExternalTransaction3()
        {
            try {
                Request.CreateExternalTransaction request = new Request.CreateExternalTransaction(
                    "4701f4e4-3bec-475d-9f70-bb67dd3af7fe",
                    "88d565f6-b4fc-4ff3-97b3-8a43235de4ae",
                    "e828decd-6db8-412b-b43e-e24758c4b6e7",
                    3316
                ) {
                    Metadata = "{\"key\":\"value\"}",
                    Products = new object[]{new Dictionary<string, object>(){{"jan_code","abc"}, {"name","name1"}, {"unit_price",100}, {"price",100}, {"is_discounted",false}, {"other","{}"}}, new Dictionary<string, object>(){{"jan_code","abc"}, {"name","name1"}, {"unit_price",100}, {"price",100}, {"is_discounted",false}, {"other","{}"}}, new Dictionary<string, object>(){{"jan_code","abc"}, {"name","name1"}, {"unit_price",100}, {"price",100}, {"is_discounted",false}, {"other","{}"}}, new Dictionary<string, object>(){{"jan_code","abc"}, {"name","name1"}, {"unit_price",100}, {"price",100}, {"is_discounted",false}, {"other","{}"}}, new Dictionary<string, object>(){{"jan_code","abc"}, {"name","name1"}, {"unit_price",100}, {"price",100}, {"is_discounted",false}, {"other","{}"}}},
                    RequestId = "6896b746-23f9-4975-b988-1ad04128667c",
                };
                Response.ExternalTransaction response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task CreateExternalTransaction4()
        {
            try {
                Request.CreateExternalTransaction request = new Request.CreateExternalTransaction(
                    "4701f4e4-3bec-475d-9f70-bb67dd3af7fe",
                    "88d565f6-b4fc-4ff3-97b3-8a43235de4ae",
                    "e828decd-6db8-412b-b43e-e24758c4b6e7",
                    3316
                ) {
                    Description = "F565USVRWyJH3sM1xaRaZOcphX35DSeis0t8z9SynL5uvVJYAmIIViSvfUQ1E9K8Ku7Dg2tSYScpHRRoE2oZ4K1hmoW6IAu3R8tbXkOR1EGGsTCkst3eLNMPJAskoGXK3Bbr81yZa3WvPcZQc",
                    Metadata = "{\"key\":\"value\"}",
                    Products = new object[]{new Dictionary<string, object>(){{"jan_code","abc"}, {"name","name1"}, {"unit_price",100}, {"price",100}, {"is_discounted",false}, {"other","{}"}}, new Dictionary<string, object>(){{"jan_code","abc"}, {"name","name1"}, {"unit_price",100}, {"price",100}, {"is_discounted",false}, {"other","{}"}}, new Dictionary<string, object>(){{"jan_code","abc"}, {"name","name1"}, {"unit_price",100}, {"price",100}, {"is_discounted",false}, {"other","{}"}}, new Dictionary<string, object>(){{"jan_code","abc"}, {"name","name1"}, {"unit_price",100}, {"price",100}, {"is_discounted",false}, {"other","{}"}}, new Dictionary<string, object>(){{"jan_code","abc"}, {"name","name1"}, {"unit_price",100}, {"price",100}, {"is_discounted",false}, {"other","{}"}}, new Dictionary<string, object>(){{"jan_code","abc"}, {"name","name1"}, {"unit_price",100}, {"price",100}, {"is_discounted",false}, {"other","{}"}}, new Dictionary<string, object>(){{"jan_code","abc"}, {"name","name1"}, {"unit_price",100}, {"price",100}, {"is_discounted",false}, {"other","{}"}}, new Dictionary<string, object>(){{"jan_code","abc"}, {"name","name1"}, {"unit_price",100}, {"price",100}, {"is_discounted",false}, {"other","{}"}}, new Dictionary<string, object>(){{"jan_code","abc"}, {"name","name1"}, {"unit_price",100}, {"price",100}, {"is_discounted",false}, {"other","{}"}}},
                    RequestId = "09c875fd-c0f8-4a97-af21-e148a446b4bc",
                };
                Response.ExternalTransaction response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

    }
}
