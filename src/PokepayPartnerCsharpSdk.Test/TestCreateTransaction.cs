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
    public class TestCreateTransaction
    {
        private Client client;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            client = new Client("~/.pokepay/test-config.ini");
        }

        [Test]
        public async Task CreateTransaction0()
        {
            try {
                Request.CreateTransaction request = new Request.CreateTransaction(
                    "4c465e88-d17e-4002-a4e2-477788aff273",
                    "1c28c6a2-9817-43a9-956a-238e90da7f9f",
                    "962b71c0-75c6-401f-a872-db3acf509f2d"
                );
                Response.TransactionDetail response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task CreateTransaction1()
        {
            try {
                Request.CreateTransaction request = new Request.CreateTransaction(
                    "4c465e88-d17e-4002-a4e2-477788aff273",
                    "1c28c6a2-9817-43a9-956a-238e90da7f9f",
                    "962b71c0-75c6-401f-a872-db3acf509f2d"
                ) {
                    Description = "NwoEyag2SfuJiolnAr0O5BazmKqHUlvI3TLRDU2wR06BrqE4xR4G",
                };
                Response.TransactionDetail response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task CreateTransaction2()
        {
            try {
                Request.CreateTransaction request = new Request.CreateTransaction(
                    "4c465e88-d17e-4002-a4e2-477788aff273",
                    "1c28c6a2-9817-43a9-956a-238e90da7f9f",
                    "962b71c0-75c6-401f-a872-db3acf509f2d"
                ) {
                    PointExpiresAt = "2023-08-29T17:28:41.000000+09:00",
                    Description = "B6QEvmEtQTqfIDfhF08aWAgYKgMRg4eijui0x4AzukqXii06wz9NdLnaFp0",
                };
                Response.TransactionDetail response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task CreateTransaction3()
        {
            try {
                Request.CreateTransaction request = new Request.CreateTransaction(
                    "4c465e88-d17e-4002-a4e2-477788aff273",
                    "1c28c6a2-9817-43a9-956a-238e90da7f9f",
                    "962b71c0-75c6-401f-a872-db3acf509f2d"
                ) {
                    PointAmount = 3812,
                    PointExpiresAt = "2021-03-01T15:33:42.000000+09:00",
                    Description = "ZXWwwPUfmYGEVrOM4dkj0diMGxwkBMFBNKhTrrGkGVnz7dW1L5JRcqWGZoB7J2SLBuVTFPFKYeglUQAESlFenRvUgW2C0Pk55puUaBmR66mDvQf3SzEAz6sFhOXUyleHUBygYLLJFfbbjn",
                };
                Response.TransactionDetail response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task CreateTransaction4()
        {
            try {
                Request.CreateTransaction request = new Request.CreateTransaction(
                    "4c465e88-d17e-4002-a4e2-477788aff273",
                    "1c28c6a2-9817-43a9-956a-238e90da7f9f",
                    "962b71c0-75c6-401f-a872-db3acf509f2d"
                ) {
                    MoneyAmount = 2767,
                    PointAmount = 7938,
                    PointExpiresAt = "2019-12-07T07:28:16.000000+09:00",
                    Description = "1Ii4QyBabDj1sJ7k6dP6L13ja9VovumOjMgFfs83kBzSot4H9G2QRAYPymeRfFOHsPVjb9UCbPcYx5YXiYOW0oa5SUOR88F7Ubd6EIlmfbIWBjq",
                };
                Response.TransactionDetail response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

    }
}
