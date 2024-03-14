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
    public class TestCreateTopupTransaction
    {
        private Client client;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            client = new Client("~/.pokepay/test-config.ini");
        }

        [Test]
        public async Task CreateTopupTransaction0()
        {
            try {
                Request.CreateTopupTransaction request = new Request.CreateTopupTransaction(
                    "6da01c20-d03e-4221-b4eb-e4af22dc13dc",
                    "1cdfa084-85b1-4f99-9c06-09e99f062caf",
                    "a093a4dc-da6e-4260-ab2c-24d17011f9aa"
                );
                Response.TransactionDetail response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task CreateTopupTransaction1()
        {
            try {
                Request.CreateTopupTransaction request = new Request.CreateTopupTransaction(
                    "6da01c20-d03e-4221-b4eb-e4af22dc13dc",
                    "1cdfa084-85b1-4f99-9c06-09e99f062caf",
                    "a093a4dc-da6e-4260-ab2c-24d17011f9aa"
                ) {
                    RequestId = "419e8a17-63f2-447b-9769-b7ebe2579d40",
                };
                Response.TransactionDetail response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task CreateTopupTransaction2()
        {
            try {
                Request.CreateTopupTransaction request = new Request.CreateTopupTransaction(
                    "6da01c20-d03e-4221-b4eb-e4af22dc13dc",
                    "1cdfa084-85b1-4f99-9c06-09e99f062caf",
                    "a093a4dc-da6e-4260-ab2c-24d17011f9aa"
                ) {
                    Metadata = "{\"key\":\"value\"}",
                    RequestId = "01bf3c74-e24d-4284-9d93-789f49eab28b",
                };
                Response.TransactionDetail response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task CreateTopupTransaction3()
        {
            try {
                Request.CreateTopupTransaction request = new Request.CreateTopupTransaction(
                    "6da01c20-d03e-4221-b4eb-e4af22dc13dc",
                    "1cdfa084-85b1-4f99-9c06-09e99f062caf",
                    "a093a4dc-da6e-4260-ab2c-24d17011f9aa"
                ) {
                    Description = "K0FHLyLnvzTdFf0Y1JODoBhEEJFs7RURiJHf6mnglgKA3t551AWYy2EKxgIvudVQKM3ivlyVYA6fe68jtm2G7nC3SW8MPeFKTYT7eEYLwvHQFKDImV0W8uMWRziTXMumFeaEHdh8PePo",
                    Metadata = "{\"key\":\"value\"}",
                    RequestId = "10083b2b-1dcd-4421-9c7d-1991ae9a8080",
                };
                Response.TransactionDetail response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task CreateTopupTransaction4()
        {
            try {
                Request.CreateTopupTransaction request = new Request.CreateTopupTransaction(
                    "6da01c20-d03e-4221-b4eb-e4af22dc13dc",
                    "1cdfa084-85b1-4f99-9c06-09e99f062caf",
                    "a093a4dc-da6e-4260-ab2c-24d17011f9aa"
                ) {
                    PointExpiresAt = "2022-09-07T05:49:14.000000+09:00",
                    Description = "nAEmuUL6pb761IWS7zT3jmF3XMzgKDKO5o6UqQsbMF41dYUnemzRdROKbGph7rDrumGN6tQ3vZwFKRF7w7plclcWB9bNRwQ0LABzLS5AginlSJbgCOpN21Ez",
                    Metadata = "{\"key\":\"value\"}",
                    RequestId = "821be759-2cfd-4c1a-b685-959795b54598",
                };
                Response.TransactionDetail response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task CreateTopupTransaction5()
        {
            try {
                Request.CreateTopupTransaction request = new Request.CreateTopupTransaction(
                    "6da01c20-d03e-4221-b4eb-e4af22dc13dc",
                    "1cdfa084-85b1-4f99-9c06-09e99f062caf",
                    "a093a4dc-da6e-4260-ab2c-24d17011f9aa"
                ) {
                    PointAmount = 5685,
                    PointExpiresAt = "2023-07-16T11:54:58.000000+09:00",
                    Description = "3e8C68gL6nh3hboA1Va",
                    Metadata = "{\"key\":\"value\"}",
                    RequestId = "c81a23d8-e551-4171-9e23-7dd933acd091",
                };
                Response.TransactionDetail response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task CreateTopupTransaction6()
        {
            try {
                Request.CreateTopupTransaction request = new Request.CreateTopupTransaction(
                    "6da01c20-d03e-4221-b4eb-e4af22dc13dc",
                    "1cdfa084-85b1-4f99-9c06-09e99f062caf",
                    "a093a4dc-da6e-4260-ab2c-24d17011f9aa"
                ) {
                    MoneyAmount = 4732,
                    PointAmount = 890,
                    PointExpiresAt = "2022-04-19T07:28:35.000000+09:00",
                    Description = "7H8v5OYX2Bb7kgjpYtpWxkJ26TN1VktFjJy7P4SbKkoz4u4vqNtkYjPXUyJ1V0r5CHRNT2ecfLdc33OSn94wpSCBGnb27KI1Ko9Ro9P2UOPHKcZd7kJ0a09BOfpTrIxahzBDxgf0eAPjokEVHRFLghiMn2sJjV2bGnLruRc9c27Gpu7iWb08U",
                    Metadata = "{\"key\":\"value\"}",
                    RequestId = "2d043ee2-928f-4549-9858-ede60f677d61",
                };
                Response.TransactionDetail response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task CreateTopupTransaction7()
        {
            try {
                Request.CreateTopupTransaction request = new Request.CreateTopupTransaction(
                    "6da01c20-d03e-4221-b4eb-e4af22dc13dc",
                    "1cdfa084-85b1-4f99-9c06-09e99f062caf",
                    "a093a4dc-da6e-4260-ab2c-24d17011f9aa"
                ) {
                    BearPointShopId = "61542cfa-2ec9-4589-9a57-176fa045c3e7",
                    MoneyAmount = 4700,
                    PointAmount = 7780,
                    PointExpiresAt = "2023-04-19T22:43:44.000000+09:00",
                    Description = "xJNEfM7ZphEzx62f8FNzaDel7ro4JT6XY3",
                    Metadata = "{\"key\":\"value\"}",
                    RequestId = "5374f43e-5b14-4059-9db3-c8959f351484",
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
