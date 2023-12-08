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
    public class TestUpdateCashtray
    {
        private Client client;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            client = new Client("~/.pokepay/test-config.ini");
        }

        [Test]
        public async Task UpdateCashtray0()
        {
            try {
                Request.UpdateCashtray request = new Request.UpdateCashtray(
                    "c0d8a9a6-97df-4a41-aa40-a917e9db4704"
                );
                Response.Cashtray response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task UpdateCashtray1()
        {
            try {
                Request.UpdateCashtray request = new Request.UpdateCashtray(
                    "c0d8a9a6-97df-4a41-aa40-a917e9db4704"
                ) {
                    ExpiresIn = 2674,
                };
                Response.Cashtray response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task UpdateCashtray2()
        {
            try {
                Request.UpdateCashtray request = new Request.UpdateCashtray(
                    "c0d8a9a6-97df-4a41-aa40-a917e9db4704"
                ) {
                    Description = "016ZjJCH7wtIwkByOxgZ1CmhlD7BVFzYE678HYgrDW8XfB04cuHe8uQqeJWnp68s54oON3JT7TlfvcjHRgsbjroXcf1fxLB1yf5dH6gwvhweVkrWRctnJ2TSLmfSkWFb6oLKvNkr7xERwVYEzuAqPS2Yq5Zx",
                    ExpiresIn = 819,
                };
                Response.Cashtray response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task UpdateCashtray3()
        {
            try {
                Request.UpdateCashtray request = new Request.UpdateCashtray(
                    "c0d8a9a6-97df-4a41-aa40-a917e9db4704"
                ) {
                    Amount = 5688.0,
                    Description = "wb6djbQEnxEVuuBukUKWopaaFtoO5CUO2HA5dwLtiNF6M5qahAMFoXb9rmaZQXIsaxB2CgIcPvFHqcQFB1Jdew",
                    ExpiresIn = 8998,
                };
                Response.Cashtray response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

    }
}
