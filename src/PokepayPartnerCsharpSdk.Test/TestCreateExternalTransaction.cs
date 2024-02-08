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
                    "82bbdb9d-8356-4e38-9c97-731155d767e4",
                    "c161298b-00af-49d2-88d9-03531d9fc0c6",
                    "4d772685-d144-4ae9-a7e7-6873865779e1",
                    7886
                );
                Response.ExternalTransactionDetail response = await request.Send(client);
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
                    "82bbdb9d-8356-4e38-9c97-731155d767e4",
                    "c161298b-00af-49d2-88d9-03531d9fc0c6",
                    "4d772685-d144-4ae9-a7e7-6873865779e1",
                    7886
                ) {
                    RequestId = "7cbf90a1-a822-4b22-adc0-bc343a43ad50",
                };
                Response.ExternalTransactionDetail response = await request.Send(client);
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
                    "82bbdb9d-8356-4e38-9c97-731155d767e4",
                    "c161298b-00af-49d2-88d9-03531d9fc0c6",
                    "4d772685-d144-4ae9-a7e7-6873865779e1",
                    7886
                ) {
                    Products = new object[]{new Dictionary<string, object>(){{"jan_code","abc"}, {"name","name1"}, {"unit_price",100}, {"price",100}, {"is_discounted",false}, {"other","{}"}}, new Dictionary<string, object>(){{"jan_code","abc"}, {"name","name1"}, {"unit_price",100}, {"price",100}, {"is_discounted",false}, {"other","{}"}}, new Dictionary<string, object>(){{"jan_code","abc"}, {"name","name1"}, {"unit_price",100}, {"price",100}, {"is_discounted",false}, {"other","{}"}}},
                    RequestId = "ce67ec62-5417-4af1-9aee-5c30fdbb3e95",
                };
                Response.ExternalTransactionDetail response = await request.Send(client);
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
                    "82bbdb9d-8356-4e38-9c97-731155d767e4",
                    "c161298b-00af-49d2-88d9-03531d9fc0c6",
                    "4d772685-d144-4ae9-a7e7-6873865779e1",
                    7886
                ) {
                    Metadata = "{\"key\":\"value\"}",
                    Products = new object[]{new Dictionary<string, object>(){{"jan_code","abc"}, {"name","name1"}, {"unit_price",100}, {"price",100}, {"is_discounted",false}, {"other","{}"}}, new Dictionary<string, object>(){{"jan_code","abc"}, {"name","name1"}, {"unit_price",100}, {"price",100}, {"is_discounted",false}, {"other","{}"}}, new Dictionary<string, object>(){{"jan_code","abc"}, {"name","name1"}, {"unit_price",100}, {"price",100}, {"is_discounted",false}, {"other","{}"}}, new Dictionary<string, object>(){{"jan_code","abc"}, {"name","name1"}, {"unit_price",100}, {"price",100}, {"is_discounted",false}, {"other","{}"}}, new Dictionary<string, object>(){{"jan_code","abc"}, {"name","name1"}, {"unit_price",100}, {"price",100}, {"is_discounted",false}, {"other","{}"}}, new Dictionary<string, object>(){{"jan_code","abc"}, {"name","name1"}, {"unit_price",100}, {"price",100}, {"is_discounted",false}, {"other","{}"}}, new Dictionary<string, object>(){{"jan_code","abc"}, {"name","name1"}, {"unit_price",100}, {"price",100}, {"is_discounted",false}, {"other","{}"}}, new Dictionary<string, object>(){{"jan_code","abc"}, {"name","name1"}, {"unit_price",100}, {"price",100}, {"is_discounted",false}, {"other","{}"}}, new Dictionary<string, object>(){{"jan_code","abc"}, {"name","name1"}, {"unit_price",100}, {"price",100}, {"is_discounted",false}, {"other","{}"}}, new Dictionary<string, object>(){{"jan_code","abc"}, {"name","name1"}, {"unit_price",100}, {"price",100}, {"is_discounted",false}, {"other","{}"}}},
                    RequestId = "e8a6fd63-0375-4a18-818a-9fc9e853672a",
                };
                Response.ExternalTransactionDetail response = await request.Send(client);
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
                    "82bbdb9d-8356-4e38-9c97-731155d767e4",
                    "c161298b-00af-49d2-88d9-03531d9fc0c6",
                    "4d772685-d144-4ae9-a7e7-6873865779e1",
                    7886
                ) {
                    Description = "8Tc91YrDumA0BEPaxu5hz8quH88gYqQC45YQseyms9QyHVorEq6zLZyg3cEPs9bN7e1DJRmWCvXV5f7NFxRTTWOKh4cp2t8rtdj0F82hhuu2d72PSRBNNGTP71wcJLJ",
                    Metadata = "{\"key\":\"value\"}",
                    Products = new object[]{new Dictionary<string, object>(){{"jan_code","abc"}, {"name","name1"}, {"unit_price",100}, {"price",100}, {"is_discounted",false}, {"other","{}"}}, new Dictionary<string, object>(){{"jan_code","abc"}, {"name","name1"}, {"unit_price",100}, {"price",100}, {"is_discounted",false}, {"other","{}"}}, new Dictionary<string, object>(){{"jan_code","abc"}, {"name","name1"}, {"unit_price",100}, {"price",100}, {"is_discounted",false}, {"other","{}"}}, new Dictionary<string, object>(){{"jan_code","abc"}, {"name","name1"}, {"unit_price",100}, {"price",100}, {"is_discounted",false}, {"other","{}"}}, new Dictionary<string, object>(){{"jan_code","abc"}, {"name","name1"}, {"unit_price",100}, {"price",100}, {"is_discounted",false}, {"other","{}"}}, new Dictionary<string, object>(){{"jan_code","abc"}, {"name","name1"}, {"unit_price",100}, {"price",100}, {"is_discounted",false}, {"other","{}"}}, new Dictionary<string, object>(){{"jan_code","abc"}, {"name","name1"}, {"unit_price",100}, {"price",100}, {"is_discounted",false}, {"other","{}"}}, new Dictionary<string, object>(){{"jan_code","abc"}, {"name","name1"}, {"unit_price",100}, {"price",100}, {"is_discounted",false}, {"other","{}"}}},
                    RequestId = "750722eb-dd49-47f6-949b-24da4059d2ee",
                };
                Response.ExternalTransactionDetail response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

    }
}
