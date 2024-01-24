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
    public class TestUpdateBill
    {
        private Client client;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            client = new Client("~/.pokepay/test-config.ini");
        }

        [Test]
        public async Task UpdateBill0()
        {
            try {
                Request.UpdateBill request = new Request.UpdateBill(
                    "0bc708a6-4feb-41ca-9fd9-2e11585fc5c1"
                );
                Response.Bill response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task UpdateBill1()
        {
            try {
                Request.UpdateBill request = new Request.UpdateBill(
                    "0bc708a6-4feb-41ca-9fd9-2e11585fc5c1"
                ) {
                    IsDisabled = false,
                };
                Response.Bill response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task UpdateBill2()
        {
            try {
                Request.UpdateBill request = new Request.UpdateBill(
                    "0bc708a6-4feb-41ca-9fd9-2e11585fc5c1"
                ) {
                    Description = "nc5mZkG67JbdDc5LZvlYDAQhrfycL239VrUVhIvdlg",
                    IsDisabled = false,
                };
                Response.Bill response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task UpdateBill3()
        {
            try {
                Request.UpdateBill request = new Request.UpdateBill(
                    "0bc708a6-4feb-41ca-9fd9-2e11585fc5c1"
                ) {
                    Amount = 2494.0,
                    Description = "VhE9pK2iae8Rn0BLFLnu5Xee0pwg6DmNt3Yo99vcy0IpaEfLXFY8",
                    IsDisabled = true,
                };
                Response.Bill response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

    }
}
