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
                    "5e0e78e6-84b0-4d1d-9159-643a729452dc"
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
                    "5e0e78e6-84b0-4d1d-9159-643a729452dc"
                ) {
                    Status = "disabled",
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
                    "5e0e78e6-84b0-4d1d-9159-643a729452dc"
                ) {
                    CanTopupPrivateMoneyIds = new string[]{"5d49efeb-a667-4aca-ae63-263399a0e969", "d2867d69-9b1f-4085-8093-a95da97ae1ae", "45c36340-9eca-4b0f-a233-024e96d5a240", "0d6c3544-789b-4423-9bd6-050f93e5f0c6", "f793221f-436b-403a-829b-244ecf935be0"},
                    Status = "disabled",
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
                    "5e0e78e6-84b0-4d1d-9159-643a729452dc"
                ) {
                    PrivateMoneyIds = new string[]{"ee306427-5d7a-48ff-937b-d4e6e3056ceb", "ff0ddd32-dac8-45c5-a207-07d82a812e78", "a7092e61-8c7b-4c79-bff8-4e3dde8dd63d", "78f66afa-a5cd-42b2-8963-fbe7ee832903", "718012e8-0064-465f-86e3-e33226b3a100", "cc00c3cc-9f1b-4aea-a061-a2fc210a113c", "c3f11412-060c-48ea-8ab2-747debcb92c7"},
                    CanTopupPrivateMoneyIds = new string[]{"ce08f61e-ab75-452d-a99b-653fb6762c28", "5532297e-59d6-4915-b9d5-5d739d19e444", "90b3449a-79be-4a6e-946c-c5fe17facb2a"},
                    Status = "active",
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
                    "5e0e78e6-84b0-4d1d-9159-643a729452dc"
                ) {
                    ExternalId = "8nhmhWmlD5AgJ4dO8V",
                    PrivateMoneyIds = new string[]{"cf5c05a1-2e60-47a9-993c-f23e5098f2a7", "c1b6c41c-6d74-4a33-94e8-87f92796544e", "7991c030-b127-4f8b-9eb1-d8f81e6c77d7", "77d674a1-30cb-4570-a5f9-3dbc81f23c66", "f134355d-2806-4efb-bd9a-11d31bdb2104"},
                    CanTopupPrivateMoneyIds = new string[]{"eca1a2d8-5a31-44cf-a9ce-d3aab366e107", "055b4e8d-0615-43ab-ad55-810de68587e2", "976da623-f18a-4f99-b1c8-b90835abed3a", "477a572c-99dd-47d8-91f5-65d3618080c5", "37101fd7-9485-4465-8d8a-57386183d402", "e167f6d6-7615-4e29-8c6d-f94d178e27b8", "d1afb33e-485f-490b-9d84-00977fed8371", "1dfcf994-1ffa-4726-99dc-d73a9bd9669e", "359bceee-1c0b-4dcb-896e-fa2465c8bfb9", "f7d86840-24f5-4242-9e2e-f4efeb01c071"},
                    Status = "disabled",
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
                    "5e0e78e6-84b0-4d1d-9159-643a729452dc"
                ) {
                    Email = "N3XKkwmXFn@LL0v.com",
                    ExternalId = "mz7rucmF8n8VnjFoEs5f64mvXKC",
                    PrivateMoneyIds = new string[]{"08e1de30-a479-4cc9-8b2e-a3e0ce6c9e2f", "7c1ac03a-ef08-4713-9944-59724e703ca2", "79001dcf-48ed-4fa8-a683-e6188cb080da"},
                    CanTopupPrivateMoneyIds = new string[]{"a91dc663-99e6-4380-8321-0b2523e86c7b", "b4d662e4-fd26-4914-855b-73d3642d2db8", "c782dca1-3b48-4aff-884a-85ad4f15f960", "94ec44a3-d9dc-441d-88be-ad66b7a9c4bc", "7a989435-a4a4-4eb0-9495-8d824b8872df", "747d59c3-4a92-47b5-b95c-ba90e09f37b2"},
                    Status = "active",
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
                    "5e0e78e6-84b0-4d1d-9159-643a729452dc"
                ) {
                    Tel = "0310734-841",
                    Email = "uxIbudPgKc@AH4L.com",
                    ExternalId = "qtvnYdJrsgVxWy0PirB5ccKSjPsnaJy",
                    PrivateMoneyIds = new string[]{},
                    CanTopupPrivateMoneyIds = new string[]{},
                    Status = "active",
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
                    "5e0e78e6-84b0-4d1d-9159-643a729452dc"
                ) {
                    Address = "UaUZ3KYipGveNp11WiSr08uCzB0JSt7hZNL6cvcqBnhGnyRs1ZbgEX46DL0EY9Dfg2K2KSBJ32yceHkpeJS5",
                    Tel = "02199526029",
                    Email = "uNlhP5RwfR@sdmS.com",
                    ExternalId = "nsKFojcLOuuurZaaP5z",
                    PrivateMoneyIds = new string[]{"f79d17f5-c6e9-4074-8ac1-0c57e8a7a542", "923d5e6e-f9cd-4954-9108-2183bf1ddb07", "da32a409-5072-49f1-914c-fd6240e5be18", "964449b4-4a0a-4186-a786-a54641f375b2", "5b20ebff-7414-4925-b75f-ab9215b0fa39", "50788947-c563-4e05-8773-ef64881eb210"},
                    CanTopupPrivateMoneyIds = new string[]{"cf9981f4-70bc-46a6-834d-d1b3c74ccdac", "c5c87499-e6f5-432c-97c0-408bc5a6a98c", "9eb27d88-aa5e-4c53-a11d-87c540654e59", "c1060862-d4f5-4d98-a17e-eeba284b644f"},
                    Status = "active",
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
                    "5e0e78e6-84b0-4d1d-9159-643a729452dc"
                ) {
                    PostalCode = "971-7494",
                    Address = "bZFvX4DTrnYj6rE9HuWGm5xmBEPErYjV24xKSbfZiVFE1mx2zGT1xfUftI30JyBIPqdCDvWnTRvriMMqT8Y2wPxWWXEUoqg0zXsuvc8LF4mbP1hyPDbNVjct5yQNjVn35rDh040vhQYw5VlT5PtGoiFuhhxPNxJedAo6IB1JwI4",
                    Tel = "0867-0737",
                    Email = "kdygOOVSyz@QqeT.com",
                    ExternalId = "BrSdGB4t2pP3KohbOZsA8epkaCTJpPbbkDn1",
                    PrivateMoneyIds = new string[]{"ed650299-8011-44f2-92a9-ff1f835400cf", "9840cdab-d0c2-4c8d-a166-1013dd582994", "cc875e08-169b-49fb-95fa-454e78c1b1d4", "314ef7c2-e191-4cbd-8711-6b58b6b23349", "657cf1d6-c47f-4d91-b1f7-443d5afaa283", "1cb3de9b-2418-47ac-87fd-c90939e51bf0", "3643f98a-75b1-490c-bbd2-1886aa9b94ee", "c663bbb3-dd55-4f08-9498-1c3daa4b5c09", "77cc6621-dfb4-4416-8b3e-27d17383af73", "5416728c-261f-4baf-af2b-cfc1377e3a13"},
                    CanTopupPrivateMoneyIds = new string[]{"010f4ed6-0327-4089-9813-1c2ac1a83ba3", "208dd801-eed1-4822-a43f-5b905bab6fff", "8e498872-310d-4355-bd1e-57e9092dad0e", "64487712-d168-4d4e-b532-e0e60133d67f"},
                    Status = "disabled",
                };
                Response.ShopWithAccounts response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task UpdateShop9()
        {
            try {
                Request.UpdateShop request = new Request.UpdateShop(
                    "5e0e78e6-84b0-4d1d-9159-643a729452dc"
                ) {
                    Name = "4606Zw3XOfvqGLqQiqaG2p9irVNMOOMEypf2sbMz5sG1GgyrO7oaIPGJ7JGBC1o5Rc96wfmVrWrKd8ZckndPnp3nLoMele3ppOb8vOALeCaVZzJ21Wkjwh096vY0YkfqArkVOxtHaQbqrekxj6KVFbsIqYgBl99xXSIGv3",
                    PostalCode = "263-5876",
                    Address = "ljqEdpqCcPOpWjivoOnvdw0Yvld3IeJyhTlRgTT2NxSiphZRlLoLjMmLSHQhe4tHPdlvKxC8QojNKN0zqICt7BPEIsHw9iaxaPzoaDv6U6SXLkHad9cOSRej1Twb2rvpiwJLSyhoqY6Z",
                    Tel = "0577-4344-4007",
                    Email = "fziyB2HYxa@SuFe.com",
                    ExternalId = "vc",
                    PrivateMoneyIds = new string[]{"16c1a0f3-bb73-402b-8caf-bc1fee1ed1af", "48610d55-7fb2-4ad1-ae88-63034df6ee5e", "f2828938-d333-4ee7-9bbe-7ed75a97e916", "ed90b086-39c8-457f-b768-24bc234286bd", "c8a11846-1630-4aa6-8f1f-ecd4752ee902", "d04ebe04-2b38-4e27-834e-c768e1657c37", "62ebf865-b8ef-4e1f-9b4f-c0a9c8da8810", "e166de17-d5a8-413a-98b6-ce2ad8cd2f3a", "666facff-9519-4361-bc73-04bc6f54ab2e", "1d8693ea-6a1d-42cf-807b-56ff11f10eef"},
                    CanTopupPrivateMoneyIds = new string[]{"64063cb0-73d2-4606-9214-53faf04fecd7", "a45c9efa-252c-4e0d-a701-d54adc1ca608", "a5652738-5e19-4671-a1ec-bfecfa766c7e", "3390cfed-a7fc-4cf8-ae20-1daeee588b9e", "bba2368e-6b6b-404d-9004-ff0c4bb8952f", "12add967-4615-4586-af05-10738c9df615", "760be668-4e0c-4d0f-91c9-d210d721c61f", "80977107-803b-47c8-ba62-5588c1038618"},
                    Status = "disabled",
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
