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
                    "1ed99f9c-85f2-4383-a32d-8b4b05bce6aa",
                    "c66f3660-e78b-4caf-a30b-bb9025ebf13a"
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
                    "1ed99f9c-85f2-4383-a32d-8b4b05bce6aa",
                    "c66f3660-e78b-4caf-a30b-bb9025ebf13a"
                ) {
                    Description = "lFd3Ur1MCMIUROIYftW7QMsIbzCAj1GsSvfXjxUW5PMdDuBsMe04PTf8vSsZQwwHu7ykbtkzG",
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
                    "1ed99f9c-85f2-4383-a32d-8b4b05bce6aa",
                    "c66f3660-e78b-4caf-a30b-bb9025ebf13a"
                ) {
                    Amount = 4384.0,
                    Description = "ROeLpMaUZfjz7mGpF3omDB92rueqlmfnAfu7erS3gFr3FTdQ8rwckpkfwdxwxZ95sfTG55oAI4VCG4sTwcYeFwcP7ZmLygXYRtjxN2aIco6xNkWo0aYr1y1KHCm",
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
