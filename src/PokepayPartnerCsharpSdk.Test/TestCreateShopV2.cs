// DO NOT EDIT: File is generated by code generator.
#nullable enable
using System;
using System.Net;
using System.Net.Http;
using NUnit.Framework;
using System.Threading.Tasks;

using PokepayPartnerCsharpSdk;

namespace PokepayPartnerCsharpSdk.Test
{
    public class TestCreateShopV2
    {
        private Client? client;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            client = new Client("~/.pokepay/test-config.ini");
        }

        [Test]
        public async Task CreateShopV20()
        {
            try {
                Request.CreateShopV2 request = new Request.CreateShopV2(
                    "jOs6NsjUaiDroY6Q3IK7BQ6AmswdAM3IJrwVbs9pMxfMCthiv1a2EEHFmQw4OmJsXraAGliEBPmHrH76ocsr7yZptwOIMGRxZLktLdV7uiWarFr5GP0wp4l70ZsGyPlyZYRURgUMf0P5ozHDn0iOeoWIRRMyR0n"
                );
                Response.ShopWithAccounts response = await request.Send(client!);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.StatusCode!, (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.StatusCode >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task CreateShopV21()
        {
            try {
                Request.CreateShopV2 request = new Request.CreateShopV2(
                    "jOs6NsjUaiDroY6Q3IK7BQ6AmswdAM3IJrwVbs9pMxfMCthiv1a2EEHFmQw4OmJsXraAGliEBPmHrH76ocsr7yZptwOIMGRxZLktLdV7uiWarFr5GP0wp4l70ZsGyPlyZYRURgUMf0P5ozHDn0iOeoWIRRMyR0n"
                ) {
                    CanTopupPrivateMoneyIds = new string[]{"4ccce7aa-20a7-4f51-ab80-5881d8c043e8"}
                };
                Response.ShopWithAccounts response = await request.Send(client!);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.StatusCode!, (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.StatusCode >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task CreateShopV22()
        {
            try {
                Request.CreateShopV2 request = new Request.CreateShopV2(
                    "jOs6NsjUaiDroY6Q3IK7BQ6AmswdAM3IJrwVbs9pMxfMCthiv1a2EEHFmQw4OmJsXraAGliEBPmHrH76ocsr7yZptwOIMGRxZLktLdV7uiWarFr5GP0wp4l70ZsGyPlyZYRURgUMf0P5ozHDn0iOeoWIRRMyR0n"
                ) {
                    PrivateMoneyIds = new string[]{"c74c565e-8221-471b-9a23-152a646604fa", "13e97d25-8f0c-4b16-b765-50e145d69e46", "eb515ec7-7a9f-4b5e-af69-f78957c2154f", "b68835d0-5a13-4929-8b8b-59d242755030", "a956e427-9b72-46ff-9ad5-d62c49960cd7", "2fc97c60-6e39-4e3e-9a87-86556579b73a", "1fa46d96-d67b-48bb-bafe-b660c4427dd4", "8bbc81e0-e0e3-40a6-abee-e70462dad73b", "75bac4a1-e89f-43c7-84ac-f324becf0542"},
                    CanTopupPrivateMoneyIds = new string[]{"ed103603-24f3-4fa4-945a-5af558d3e7d0", "7e6244e6-d441-4081-8264-7a69f6fcce3f", "7a3fb3a0-a1ce-498d-b600-3ba987319ae6", "5c1d459d-43d3-43b9-81bc-056e412fdaf5", "2803d5e6-657b-49a1-a9ea-60a1a18cb2b6"}
                };
                Response.ShopWithAccounts response = await request.Send(client!);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.StatusCode!, (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.StatusCode >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task CreateShopV23()
        {
            try {
                Request.CreateShopV2 request = new Request.CreateShopV2(
                    "jOs6NsjUaiDroY6Q3IK7BQ6AmswdAM3IJrwVbs9pMxfMCthiv1a2EEHFmQw4OmJsXraAGliEBPmHrH76ocsr7yZptwOIMGRxZLktLdV7uiWarFr5GP0wp4l70ZsGyPlyZYRURgUMf0P5ozHDn0iOeoWIRRMyR0n"
                ) {
                    OrganizationCode = "P--ux-4-SknIf-G-1-Hf",
                    PrivateMoneyIds = new string[]{"acb4fc14-45fb-4ab3-9499-5b942ae4ca3d", "42987178-27ee-4daa-8175-ba4b9bca8261", "376fd41b-f87f-4c08-a3fe-9337e942039b"},
                    CanTopupPrivateMoneyIds = new string[]{"a4c2c4d3-7b31-4a1a-9fc4-fdfbc46ed07d", "8c138786-75e0-4ecb-9334-fb47de8ca8ee", "f6c871f2-affe-4272-b3bc-142cda0e52ef"}
                };
                Response.ShopWithAccounts response = await request.Send(client!);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.StatusCode!, (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.StatusCode >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task CreateShopV24()
        {
            try {
                Request.CreateShopV2 request = new Request.CreateShopV2(
                    "jOs6NsjUaiDroY6Q3IK7BQ6AmswdAM3IJrwVbs9pMxfMCthiv1a2EEHFmQw4OmJsXraAGliEBPmHrH76ocsr7yZptwOIMGRxZLktLdV7uiWarFr5GP0wp4l70ZsGyPlyZYRURgUMf0P5ozHDn0iOeoWIRRMyR0n"
                ) {
                    ExternalId = "LGM",
                    OrganizationCode = "8-5-V---x4Z-",
                    PrivateMoneyIds = new string[]{"e18ac77d-2bf8-4b43-94b0-035a96ec88db", "8abee5ed-d40e-4375-b675-a40ded0bc937", "69c844f4-6a82-420e-8f40-b178f984a05b", "c0ff6d71-71dd-4dfe-b5ee-6f81161abbde", "31226265-5cdc-47dd-8e61-1a74c0942e47", "a7af98a8-12de-4dbf-867c-cb6f4d6fcb6c", "fc913343-f5e6-4f36-a48d-1953122ba0ea", "b999cd65-e8c6-4637-bdd3-aa6583f4900a", "b320447e-6a2e-43ba-9a58-03f94e04154d"},
                    CanTopupPrivateMoneyIds = new string[]{"1ca68553-7ab6-4dfd-a957-a67f77bf776b", "f89896de-923e-4f2c-92be-a5cedba00d15", "0744c7ca-0a01-4c3c-862a-b884fcc52a32", "716e4ac7-7976-44d3-98f7-7b3faa388596", "5bab6090-7c12-4205-8c87-d53e21fffed1", "154bba7e-2007-4055-a33b-08f2c5133cba", "f35659f5-5fd9-4ebd-9034-544842ae7a0a", "cb39b695-4cb5-4e63-9fc3-ba1ae0bb5177", "a1739735-59c5-4b78-98ce-cfa633c8b1f1", "af932368-0b34-47b1-bfcf-bed8e64dedd8"}
                };
                Response.ShopWithAccounts response = await request.Send(client!);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.StatusCode!, (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.StatusCode >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task CreateShopV25()
        {
            try {
                Request.CreateShopV2 request = new Request.CreateShopV2(
                    "jOs6NsjUaiDroY6Q3IK7BQ6AmswdAM3IJrwVbs9pMxfMCthiv1a2EEHFmQw4OmJsXraAGliEBPmHrH76ocsr7yZptwOIMGRxZLktLdV7uiWarFr5GP0wp4l70ZsGyPlyZYRURgUMf0P5ozHDn0iOeoWIRRMyR0n"
                ) {
                    Email = "FwVmaHYw6o@EFbK.com",
                    ExternalId = "R1LlAI",
                    OrganizationCode = "f-QU5-297-",
                    PrivateMoneyIds = new string[]{"bbe5baa7-c011-4288-af2a-5b5972578e0a", "0e0c874e-552c-48e1-9216-d8c4c4324848", "50959989-1b33-4978-a135-935d3ee8775d", "b925d2da-c794-45d8-8d20-ee8433d106ec", "a920a933-444c-47b9-b418-05ded9ca926b", "bce72f6d-0d44-433f-a951-42dd43abedaf", "ce31705a-cba2-465f-89d6-366d461c8f00", "9278620e-1ae6-429e-9d17-b1a74dc94202", "48dc41e4-f5be-4243-963f-912f8f4c9139"},
                    CanTopupPrivateMoneyIds = new string[]{"33632477-0fc7-49ca-bb55-14af0fb9d8d2", "b826c31c-12ae-4bde-8ffd-30e77a6893a2", "dacc49f0-da80-4dbd-b185-862252be44d6", "60f996d4-6fce-4a0c-b32a-91744b842f1f", "665933a4-454b-43dd-be73-705e7995378f", "e7e694e2-1c6b-4fb2-b776-468ce8bed33d"}
                };
                Response.ShopWithAccounts response = await request.Send(client!);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.StatusCode!, (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.StatusCode >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task CreateShopV26()
        {
            try {
                Request.CreateShopV2 request = new Request.CreateShopV2(
                    "jOs6NsjUaiDroY6Q3IK7BQ6AmswdAM3IJrwVbs9pMxfMCthiv1a2EEHFmQw4OmJsXraAGliEBPmHrH76ocsr7yZptwOIMGRxZLktLdV7uiWarFr5GP0wp4l70ZsGyPlyZYRURgUMf0P5ozHDn0iOeoWIRRMyR0n"
                ) {
                    Tel = "05789307-455",
                    Email = "4w9Rkvag9C@19xR.com",
                    ExternalId = "lJpGXqlhd5",
                    OrganizationCode = "---aG",
                    PrivateMoneyIds = new string[]{"242b545a-e589-430b-b8fe-740b5bbe03e1", "53dd00da-91e9-4e0f-ae95-723923b8cee9", "2e6f34c3-990d-4e61-b291-7d0cd4fa7feb", "9718a5ea-0a93-4fa8-b9c9-349055e82e44", "d2d2c8c4-6b90-4d93-9534-e0c6986a0d1a", "9f2dfd3c-77cc-445b-9d55-4f2526479cb5", "6b9e77b3-de48-438b-9ba9-ae14b47f9a34", "ce4f63a2-a763-4e54-8425-62c3458bbd61", "577317e6-a2f5-4b06-a30d-6e0764523ce0"},
                    CanTopupPrivateMoneyIds = new string[]{"04a0ce0c-9c15-4d35-bb3e-6e97b6d34936", "059ac2af-fb4a-4287-8c06-521f7119a135", "8d1533e0-c0b0-442c-935e-87e489c66f69", "9e4a3dc1-e62b-401d-8402-bbc7cf59ec2e", "579335fd-b019-4e0f-bc05-8edd3efb9733", "8f34c21b-e560-42b7-8e65-a3f97c16228e", "0777bfe4-a301-4087-8745-5d1360ce7bac", "11aa511c-7ace-4acd-9075-9cd3230f5ad5"}
                };
                Response.ShopWithAccounts response = await request.Send(client!);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.StatusCode!, (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.StatusCode >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task CreateShopV27()
        {
            try {
                Request.CreateShopV2 request = new Request.CreateShopV2(
                    "jOs6NsjUaiDroY6Q3IK7BQ6AmswdAM3IJrwVbs9pMxfMCthiv1a2EEHFmQw4OmJsXraAGliEBPmHrH76ocsr7yZptwOIMGRxZLktLdV7uiWarFr5GP0wp4l70ZsGyPlyZYRURgUMf0P5ozHDn0iOeoWIRRMyR0n"
                ) {
                    Address = "GCPNHip0Y3dBWcNdXe1sIjLSVztCspdpKcDGU85LATApzQ2dQG1XtK0UfX1fzmKZw4jAX5TdVMZA3FsBWHTaR7q8iHovbTWoPNbCUX3WmvU0lnYW7MWulxJqejEoXiemEzy22TP2wtSY9IoDSrJUA2sSTBsOwjVmr0b",
                    Tel = "04-7976-894",
                    Email = "nnz7WaCAiQ@d9B8.com",
                    ExternalId = "sl",
                    OrganizationCode = "vbMJ-9M2-01-95UK--q",
                    PrivateMoneyIds = new string[]{"22d1f7a0-ca8f-4e60-bfb0-d72f45e001c9"},
                    CanTopupPrivateMoneyIds = new string[]{"b08ccc83-bba4-4d85-8ed2-27b4c42f67dc", "86839f34-3814-44c9-b59e-c8032b898ebc", "aabb4dbb-5d4b-43cc-a987-b1aa071d2194", "1feab5dd-facf-4385-a672-4a000df77202", "e52f4e21-e82f-46bc-928d-568f57a7933d", "2d15c386-7e0e-4023-8bac-46717f4a5033", "6cbfb571-519c-4aaa-812c-a4df9ac52cf8", "21aabac0-1110-44f4-abbc-6f20db47f1d4", "0af40847-f3e9-4366-a1ce-8eb65f38273f"}
                };
                Response.ShopWithAccounts response = await request.Send(client!);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.StatusCode!, (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.StatusCode >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task CreateShopV28()
        {
            try {
                Request.CreateShopV2 request = new Request.CreateShopV2(
                    "jOs6NsjUaiDroY6Q3IK7BQ6AmswdAM3IJrwVbs9pMxfMCthiv1a2EEHFmQw4OmJsXraAGliEBPmHrH76ocsr7yZptwOIMGRxZLktLdV7uiWarFr5GP0wp4l70ZsGyPlyZYRURgUMf0P5ozHDn0iOeoWIRRMyR0n"
                ) {
                    PostalCode = "2215543",
                    Address = "wDmQdLNOKHIlDiaOh78QfhNbZ3YfGhlbqaOElvScjtjkG1WEjltqaYkhp7caXjUtBcNe9XyY4wthFo0glXBErIUB1p7aPMzXnAdDrY96Gn0OAQ9xSN0zfKx7ivixiVqjgvBNcsQLQxAtJmVTcXWtKUzkNd35gyuBKlwozbM8BIp6WWFtoNM3mKKWyblmmAHRSYCV0EDw10SY48ZoA8oj9alrEKYDjBWPKCwbirzvScU",
                    Tel = "06633-0660",
                    Email = "IL9qlVMwg0@ANEH.com",
                    ExternalId = "j5eM",
                    OrganizationCode = "UTNs0-209wh--J6iKHk6P3k68",
                    PrivateMoneyIds = new string[]{"d0cab44b-5c48-4b90-8a5b-c230ec0c642d", "3db02b8e-859e-42d9-9557-c2de28df3a2b", "81a82716-88ad-45a3-9fb8-deafe652e569", "b5f577a8-d617-48f7-a9bf-df4a6e9ec34a", "fd53ada6-a9a8-4e02-b587-484a1679e925"},
                    CanTopupPrivateMoneyIds = new string[]{}
                };
                Response.ShopWithAccounts response = await request.Send(client!);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.StatusCode!, (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.StatusCode >= 300, "Should be larger than 300");
            }
        }

    }
}
