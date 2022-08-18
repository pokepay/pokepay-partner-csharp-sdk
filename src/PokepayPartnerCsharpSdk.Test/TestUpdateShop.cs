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
    public class TestUpdateShop
    {
        private Client client;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            client = new Client("~/.pokepay/test-config.ini");
        }

        [Test]
        public async Task UpdateShop0()
        {
            try {
                Request.UpdateShop request = new Request.UpdateShop(
                    "319a0c01-8a60-4ee2-80b0-4ec9c89f47d9"
                );
                Response.ShopWithAccounts response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task UpdateShop1()
        {
            try {
                Request.UpdateShop request = new Request.UpdateShop(
                    "319a0c01-8a60-4ee2-80b0-4ec9c89f47d9"
                ) {
                    CanTopupPrivateMoneyIds = new string[]{"7ce7811e-1db8-458b-a320-4d026aa53e84", "062d3c3a-1429-4602-b36a-93a18ee414d3", "bd82a17f-57ac-40f9-ada9-4b1b54747b1a", "d74d7080-e539-478a-9080-d943136b2406", "13e8c54c-849e-44ea-ab71-5238cedf3179", "514f338c-0b6a-4c5f-aa5e-c97f00d22d78", "208ccdc9-9c24-486e-bf7d-af6ff9c3c6af", "c5682613-ccc2-416e-8a4c-c6563cea22f7", "7a805705-bfb5-498a-8a4e-269e46026078", "97a55001-a49c-42c8-90a2-a3b7f0ec90c3"},
                };
                Response.ShopWithAccounts response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task UpdateShop2()
        {
            try {
                Request.UpdateShop request = new Request.UpdateShop(
                    "319a0c01-8a60-4ee2-80b0-4ec9c89f47d9"
                ) {
                    PrivateMoneyIds = new string[]{"5a27a1c9-5a39-4dd9-a221-48b541d65790", "2ce967f4-eccf-4551-9a2a-b4b2f2f34471"},
                    CanTopupPrivateMoneyIds = new string[]{"a64ae791-5f70-4db6-a58b-78425dda8190", "a5ea67ec-9421-42ef-829e-f570f3e68bf5", "22cb80ea-642b-4cce-ad99-874a8fa44713"},
                };
                Response.ShopWithAccounts response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task UpdateShop3()
        {
            try {
                Request.UpdateShop request = new Request.UpdateShop(
                    "319a0c01-8a60-4ee2-80b0-4ec9c89f47d9"
                ) {
                    ExternalId = "uVKWvjUjC0",
                    PrivateMoneyIds = new string[]{"c64458af-0ab3-465d-9b86-90664eff11b2", "61154127-fe01-47cc-bdef-933913db0fce", "c898b0f1-236c-48d6-b6ae-0575cf9ae458", "ce5e100c-9da6-4abe-aaa0-abcd5c833634", "d3440c3e-a879-4645-b96b-2d6403e72a5b"},
                    CanTopupPrivateMoneyIds = new string[]{"f924df37-7cec-4dd6-b65f-130165b1fd90", "1a190817-d11f-4151-8d5d-600d7d36c64b", "0a46d77c-4dde-466b-bc93-baa610954c7a", "0b38e436-5686-4ad2-bb9f-1b054eb4a1fb", "b3a403c5-f387-4b7a-af80-15490e3dccb7", "d72cc81f-c2e3-4eda-993d-ddfda395863a", "1097e857-3540-4b34-bfa9-cbe3c86e9ba7", "6049838d-0d97-4e0d-9b30-9499f0fed147"},
                };
                Response.ShopWithAccounts response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task UpdateShop4()
        {
            try {
                Request.UpdateShop request = new Request.UpdateShop(
                    "319a0c01-8a60-4ee2-80b0-4ec9c89f47d9"
                ) {
                    Email = "yNh6EpQVqX@4KE4.com",
                    ExternalId = "5KR",
                    PrivateMoneyIds = new string[]{"92d773a5-54dc-463c-8478-0f0206ce2dbd", "1e073b53-d053-422d-bd70-cf8f465a56f0", "ed67b71c-8c56-4988-8f52-5799cb86822b"},
                    CanTopupPrivateMoneyIds = new string[]{"dbf2f57b-6f4c-4a79-b650-325f782fdbcf"},
                };
                Response.ShopWithAccounts response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task UpdateShop5()
        {
            try {
                Request.UpdateShop request = new Request.UpdateShop(
                    "319a0c01-8a60-4ee2-80b0-4ec9c89f47d9"
                ) {
                    Tel = "038-87-5062",
                    Email = "7dHE8reh9b@3v7z.com",
                    ExternalId = "YS2",
                    PrivateMoneyIds = new string[]{"4d62e930-4525-40c5-870a-11f340449dbf", "3734f6a0-e7d0-4ed0-a207-a276f90d83a3", "2b1cd3d1-e2ba-4a76-83bb-ae2fb1519e18", "cd1f8e7c-84d9-4e6b-8150-5ac2f344eea9", "70b576ca-3c37-4a1a-b7a0-a8ed43d150e7", "8a00ce14-0d13-4c43-9e0e-203b19378957", "2f603e4e-67cb-429a-8450-e8a7b32cb4b1"},
                    CanTopupPrivateMoneyIds = new string[]{},
                };
                Response.ShopWithAccounts response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task UpdateShop6()
        {
            try {
                Request.UpdateShop request = new Request.UpdateShop(
                    "319a0c01-8a60-4ee2-80b0-4ec9c89f47d9"
                ) {
                    Address = "enxAKZBD2FhNoFZKIbAgSoRCKxxDEWQZO9yz4Mc4BWxPS7UaVHpVi4pZYZOGKLSewvJuaN97ObUNQZ0A0Rwk2Z2omGatDjCcJfOMaGd4kHySUJYrKI48UyLazcdaqg9M9b56VUQzIG7Yr7fsBnFuG56tOVY8vi9Z9lrb",
                    Tel = "07-8431-6229",
                    Email = "dPS2DfLew9@jsvL.com",
                    ExternalId = "XjFRqAsdyU0EjzFGdoCEVoN09yrlyTlHcxkp",
                    PrivateMoneyIds = new string[]{"1e253ae8-b900-4364-8d69-ae1220adce4a", "c990d3af-79d7-482f-b35e-278ab6e04338"},
                    CanTopupPrivateMoneyIds = new string[]{"f6294826-30a5-4b2d-9fa7-548ac8c250e5", "c1197029-5aef-4b41-b1f6-79678d085486", "0febff67-1e30-4488-b17a-305ac560f915"},
                };
                Response.ShopWithAccounts response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task UpdateShop7()
        {
            try {
                Request.UpdateShop request = new Request.UpdateShop(
                    "319a0c01-8a60-4ee2-80b0-4ec9c89f47d9"
                ) {
                    PostalCode = "777-7247",
                    Address = "gWRTNwobRsB1baR1aePdc9fGH",
                    Tel = "03-452-017",
                    Email = "5Jr7zEeO7n@UDqx.com",
                    ExternalId = "j74j643AIOVakyq8QHWKNric3",
                    PrivateMoneyIds = new string[]{"98829d42-795e-4d7f-9fd1-afd942de89a8", "9aba5da3-35bb-4657-b34b-bd5bf85d005f", "b8cf7af4-4f8b-4276-ae78-f76f201e3428", "1ffb49fb-8f51-4dca-af1d-d905313401cc"},
                    CanTopupPrivateMoneyIds = new string[]{},
                };
                Response.ShopWithAccounts response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task UpdateShop8()
        {
            try {
                Request.UpdateShop request = new Request.UpdateShop(
                    "319a0c01-8a60-4ee2-80b0-4ec9c89f47d9"
                ) {
                    Name = "loM94TQVFchkaVLnKXq1JcpZfZUH2UsKCxnRcuSoLNAly4QR5kzfucn7LZFZw",
                    PostalCode = "8958602",
                    Address = "JGwbFSZ2qU3L9frpqlrETgz3O9wlyQ0TWfR4Gx21zM7WIQGDsPsJyAShBlCJPjtVj6RA58jW2j8noWbhryHKQAP2bBeZkmIh2UeN7Z047tEp9MnaMKkPTTOh4KlFXKgtixsqVTYrrSHZ1a0tz4EzkuhUCHWp85qyAYWUJWst1yIlHOt0XiM6Qkur8SbZd3wcuCesxkTgeU",
                    Tel = "06419716",
                    Email = "L5t780R8L5@VrLx.com",
                    ExternalId = "zR",
                    PrivateMoneyIds = new string[]{"e0ab3283-3c51-4612-bc6c-7756cbf66c75", "ab66f78a-4d24-442f-b0dc-beac75d52dda", "f4e91560-95e4-44eb-adc8-9481ec8c27d7", "d0d0f59b-e927-4764-90dd-b5d5d648ee98", "0c428be9-6d00-408a-ba56-47acec9262bd", "60427415-8ac4-4daa-b1e5-8748ed87ee5e", "bf947585-3450-4006-a3d1-88d6bace351b", "7f990cfc-5274-4799-919d-702360279503", "e535e5ec-c34f-41ea-ba53-c51c3cf57fa9"},
                    CanTopupPrivateMoneyIds = new string[]{"231178b3-8731-4c05-8d7f-01f8af007490", "321f9f15-5706-4b71-9bb8-1fd3fe26f421"},
                };
                Response.ShopWithAccounts response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

    }
}
