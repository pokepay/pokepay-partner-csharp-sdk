// DO NOT EDIT: File is generated by code generator.
using System;
using System.Net;
using System.Net.Http;
using NUnit.Framework;
using System.Threading.Tasks;

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
                    "3dd77b65-409c-4af3-a730-1989bd49e260",
                    "a004110c-12ae-4f4c-b608-6f1269a53c52",
                    "e17e46f0-f424-4f7d-8914-1f5f40bb694f"
                );
                Response.Transaction response = await request.Send(client);
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
                    "3dd77b65-409c-4af3-a730-1989bd49e260",
                    "a004110c-12ae-4f4c-b608-6f1269a53c52",
                    "e17e46f0-f424-4f7d-8914-1f5f40bb694f"
                ) {
                    RequestId = "c5a5f2cb-234c-4167-a41d-a2c15cc41a16",
                };
                Response.Transaction response = await request.Send(client);
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
                    "3dd77b65-409c-4af3-a730-1989bd49e260",
                    "a004110c-12ae-4f4c-b608-6f1269a53c52",
                    "e17e46f0-f424-4f7d-8914-1f5f40bb694f"
                ) {
                    Description = "2m76DTKceEBbKe1QbzWrTYvHigdBYvKVDdotVdsHD1HarFGRZ0Q28LywVGUz2sIRxtNbAYMzHePlwRHJLPebYCA3qabphyjXP3",
                    RequestId = "e69edca0-be14-422e-b875-b413a294b6e8",
                };
                Response.Transaction response = await request.Send(client);
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
                    "3dd77b65-409c-4af3-a730-1989bd49e260",
                    "a004110c-12ae-4f4c-b608-6f1269a53c52",
                    "e17e46f0-f424-4f7d-8914-1f5f40bb694f"
                ) {
                    PointExpiresAt = "2020-09-06T14:18:08.000000+09:00",
                    Description = "uGRsNNOdzmZ5nbPQzPRirLmp7HiQajpl09d6QIiaL5c40GPi4ivBi3eJhDgAiQ5RhXwEfmyakwCi2K41MKrJ8u3JtJHw13BJLqURa9CDG8z1r52NxmvSo3IMgKOG9RqgqLtsxscDVj4qDxwlIsjYdDsgNzWfMVYN8tFORiCKaN1GSBkTmsnETZgON7",
                    RequestId = "2fe27f7b-b75d-4226-a877-cf5dcc4a773d",
                };
                Response.Transaction response = await request.Send(client);
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
                    "3dd77b65-409c-4af3-a730-1989bd49e260",
                    "a004110c-12ae-4f4c-b608-6f1269a53c52",
                    "e17e46f0-f424-4f7d-8914-1f5f40bb694f"
                ) {
                    PointAmount = 1594.0,
                    PointExpiresAt = "2016-07-18T23:48:15.000000+09:00",
                    Description = "25XD4LDGgtc1eHQx1a38fcy9G2ru7CIugZBUKc64A8KJDFHDE0sPhVLSmxr0FU3DnW6KqsDEeelMkJvsg1mQveiZolVhKjCQVZwzstz19XaUt7HUg2vBtQ3icUlEOMImvGy37aG3VpRlqKVbLVJ59qzi8HFxZtC5ypm8TU2Y6m10oaz",
                    RequestId = "edc2ff9c-ab4f-4860-a9ee-af5313107cc4",
                };
                Response.Transaction response = await request.Send(client);
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
                    "3dd77b65-409c-4af3-a730-1989bd49e260",
                    "a004110c-12ae-4f4c-b608-6f1269a53c52",
                    "e17e46f0-f424-4f7d-8914-1f5f40bb694f"
                ) {
                    MoneyAmount = 5597.0,
                    PointAmount = 1218.0,
                    PointExpiresAt = "2019-09-14T06:23:27.000000+09:00",
                    Description = "DkHpYoJtK8deELoxPb8vCqW8ZrqfNGAkbzmAIScfq8JbwsUjFhr3NwoEyag2SfuJiolnAr0O5BazmKqHUlvI3TLRDU2wR06BrqE4xR4GA8B6QEvmEtQTqfIDfhF08aWAgYKgMRg4eijui0x4AzukqXii06wz9NdLnaFp0d8NnYZXWwwPUfmYGEVrOM4dkj0diM",
                    RequestId = "c75ec487-3847-4122-9caa-471f53dcb283",
                };
                Response.Transaction response = await request.Send(client);
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
                    "3dd77b65-409c-4af3-a730-1989bd49e260",
                    "a004110c-12ae-4f4c-b608-6f1269a53c52",
                    "e17e46f0-f424-4f7d-8914-1f5f40bb694f"
                ) {
                    BearPointShopId = "6365ba84-9aaa-42a4-af80-0d786cdf9195",
                    MoneyAmount = 3644.0,
                    PointAmount = 7799.0,
                    PointExpiresAt = "2020-07-03T15:12:46.000000+09:00",
                    Description = "MFBNKhTrrGkGVnz7dW1L5JRcqWGZoB7J2SLBuVTFPFKYeglUQAESlFenRvUgW2C0Pk55puUaBmR66mDvQf3SzEAz6sFhOXUyleHUBygYLLJFfbbjnOxn1Ii4QyBabDj1sJ7k6dP6L13ja9VovumOjMgFfs83kBzSot4H9G2QRAYPymeRfFOHsPVjb9UCbPcYx5Y",
                    RequestId = "e0af101c-8658-4e02-a9d9-4f4f9b3545d7",
                };
                Response.Transaction response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

    }
}
