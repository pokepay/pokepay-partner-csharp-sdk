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
    public class TestCreateBill
    {
        private Client client;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            client = new Client("~/.pokepay/test-config.ini");
        }

        [Test]
        public async Task CreateBill0()
        {
            try {
                Request.CreateBill request = new Request.CreateBill(
                    "9a5387ae-5073-455d-b2b6-f5c50f9210c4",
                    "f41d19fb-7d26-4d80-abfa-9dc49d937f4c"
                );
                Response.Bill response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task CreateBill1()
        {
            try {
                Request.CreateBill request = new Request.CreateBill(
                    "9a5387ae-5073-455d-b2b6-f5c50f9210c4",
                    "f41d19fb-7d26-4d80-abfa-9dc49d937f4c"
                ) {
                    Description = "nAr7NHvMDZLOk3Kn6N9IKA2DQ0UDl0RkGXqQRpkGArTGUPugetKJLdESdgB4DMlPhuAgx6J23S5a4KJH2dJnXOeAy8xYgmSSWd6nFdHza9f0TF30iljDxgSpyfoekUtY",
                };
                Response.Bill response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task CreateBill2()
        {
            try {
                Request.CreateBill request = new Request.CreateBill(
                    "9a5387ae-5073-455d-b2b6-f5c50f9210c4",
                    "f41d19fb-7d26-4d80-abfa-9dc49d937f4c"
                ) {
                    Amount = 1581.0,
                    Description = "6dyRqDXbojqilSXXfgL13rI1kMYSkzLYWcqyBEPqq6jXoMPoI5dYhtAEAC8MN1MIRbysguh0xXqdkQK8VG",
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
