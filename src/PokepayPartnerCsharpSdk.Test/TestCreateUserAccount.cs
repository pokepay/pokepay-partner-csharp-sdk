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
    public class TestCreateUserAccount
    {
        private Client client;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            client = new Client("~/.pokepay/test-config.ini");
        }

        [Test]
        public async Task CreateUserAccount0()
        {
            try {
                Request.CreateUserAccount request = new Request.CreateUserAccount(
                    "1cca797a-a4ae-4807-a9ad-4bab80f00988",
                    "a7de9f4c-0cba-468f-80c5-ac4cef1a2e6d"
                );
                Response.AccountDetail response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task CreateUserAccount1()
        {
            try {
                Request.CreateUserAccount request = new Request.CreateUserAccount(
                    "1cca797a-a4ae-4807-a9ad-4bab80f00988",
                    "a7de9f4c-0cba-468f-80c5-ac4cef1a2e6d"
                ) {
                    Metadata = "{\"key1\":\"foo\",\"key2\":\"bar\"}",
                };
                Response.AccountDetail response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task CreateUserAccount2()
        {
            try {
                Request.CreateUserAccount request = new Request.CreateUserAccount(
                    "1cca797a-a4ae-4807-a9ad-4bab80f00988",
                    "a7de9f4c-0cba-468f-80c5-ac4cef1a2e6d"
                ) {
                    ExternalId = "FBMnn24Y00BddIYIaGsnHTfyj3vGhpYs6lE3PVx",
                    Metadata = "{\"key1\":\"foo\",\"key2\":\"bar\"}",
                };
                Response.AccountDetail response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task CreateUserAccount3()
        {
            try {
                Request.CreateUserAccount request = new Request.CreateUserAccount(
                    "1cca797a-a4ae-4807-a9ad-4bab80f00988",
                    "a7de9f4c-0cba-468f-80c5-ac4cef1a2e6d"
                ) {
                    Name = "hCRcEAVa4JmfjoJZ9ajsO39BqxPDSP5BpfA0dYcuMmHpa4aDHWm32hBFhI0DxRhz83lKq4Wp1hKlNvpHM0s7Dd9Uu6qWqC0qUtLag9adxARTcCtKjz1M2kusM3cVDMOGMtpxWNvKR6Gcp6PWCiNymBaUIu6lQIyVNDYRttS46oTXBYnbHbMuAdnXANiixumuncg7egxc7L05i8jkZ1Waa",
                    ExternalId = "h6AAgB9jXehhbgs",
                    Metadata = "{\"key1\":\"foo\",\"key2\":\"bar\"}",
                };
                Response.AccountDetail response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

    }
}
