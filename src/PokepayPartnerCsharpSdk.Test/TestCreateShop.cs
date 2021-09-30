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
    public class TestCreateShop
    {
        private Client? client;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            client = new Client("~/.pokepay/test-config.ini");
        }

        [Test]
        public async Task CreateShop0()
        {
            try {
                Request.CreateShop request = new Request.CreateShop(
                    "jBGi2vt3IVLujfoeXIyA6Ao821XE55hc29pv4sZBooZY5wA4Og2kdAYLVTxSOsaSsUmdY0CLcfoUMFSIdEJMG98zC6otpSw3LnpbrPkZnNjPWO55U7DSfY3LgW5M2IvR52CgIBy3eLTys12HHDFFeqLoUtYmfM0XLYceQxhubY3jVYhbh4RW4SjcPHu2gIp7HlCgxYlFZzBuHZ8tjsh68ScZg3aAMErPcV9o0TcGJkIJgRMahTjY"
                );
                Response.User response = await request.Send(client!);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.StatusCode!, (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.StatusCode >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task CreateShop1()
        {
            try {
                Request.CreateShop request = new Request.CreateShop(
                    "jBGi2vt3IVLujfoeXIyA6Ao821XE55hc29pv4sZBooZY5wA4Og2kdAYLVTxSOsaSsUmdY0CLcfoUMFSIdEJMG98zC6otpSw3LnpbrPkZnNjPWO55U7DSfY3LgW5M2IvR52CgIBy3eLTys12HHDFFeqLoUtYmfM0XLYceQxhubY3jVYhbh4RW4SjcPHu2gIp7HlCgxYlFZzBuHZ8tjsh68ScZg3aAMErPcV9o0TcGJkIJgRMahTjY"
                ) {
                    OrganizationCode = "-6"
                };
                Response.User response = await request.Send(client!);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.StatusCode!, (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.StatusCode >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task CreateShop2()
        {
            try {
                Request.CreateShop request = new Request.CreateShop(
                    "jBGi2vt3IVLujfoeXIyA6Ao821XE55hc29pv4sZBooZY5wA4Og2kdAYLVTxSOsaSsUmdY0CLcfoUMFSIdEJMG98zC6otpSw3LnpbrPkZnNjPWO55U7DSfY3LgW5M2IvR52CgIBy3eLTys12HHDFFeqLoUtYmfM0XLYceQxhubY3jVYhbh4RW4SjcPHu2gIp7HlCgxYlFZzBuHZ8tjsh68ScZg3aAMErPcV9o0TcGJkIJgRMahTjY"
                ) {
                    ShopExternalId = "LyPhoCqWW",
                    OrganizationCode = "3Jo--YCK-P-5-VOzj9k8c--N8rR-E"
                };
                Response.User response = await request.Send(client!);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.StatusCode!, (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.StatusCode >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task CreateShop3()
        {
            try {
                Request.CreateShop request = new Request.CreateShop(
                    "jBGi2vt3IVLujfoeXIyA6Ao821XE55hc29pv4sZBooZY5wA4Og2kdAYLVTxSOsaSsUmdY0CLcfoUMFSIdEJMG98zC6otpSw3LnpbrPkZnNjPWO55U7DSfY3LgW5M2IvR52CgIBy3eLTys12HHDFFeqLoUtYmfM0XLYceQxhubY3jVYhbh4RW4SjcPHu2gIp7HlCgxYlFZzBuHZ8tjsh68ScZg3aAMErPcV9o0TcGJkIJgRMahTjY"
                ) {
                    ShopEmail = "AJhWFwASll@2hGk.com",
                    ShopExternalId = "zja1Nm",
                    OrganizationCode = "b-Yg2CYvkO4z-2Q4n"
                };
                Response.User response = await request.Send(client!);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.StatusCode!, (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.StatusCode >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task CreateShop4()
        {
            try {
                Request.CreateShop request = new Request.CreateShop(
                    "jBGi2vt3IVLujfoeXIyA6Ao821XE55hc29pv4sZBooZY5wA4Og2kdAYLVTxSOsaSsUmdY0CLcfoUMFSIdEJMG98zC6otpSw3LnpbrPkZnNjPWO55U7DSfY3LgW5M2IvR52CgIBy3eLTys12HHDFFeqLoUtYmfM0XLYceQxhubY3jVYhbh4RW4SjcPHu2gIp7HlCgxYlFZzBuHZ8tjsh68ScZg3aAMErPcV9o0TcGJkIJgRMahTjY"
                ) {
                    ShopTel = "0020-419595",
                    ShopEmail = "0GR2pRvNpU@LEoT.com",
                    ShopExternalId = "5p2Y5YBaO",
                    OrganizationCode = "6A"
                };
                Response.User response = await request.Send(client!);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.StatusCode!, (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.StatusCode >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task CreateShop5()
        {
            try {
                Request.CreateShop request = new Request.CreateShop(
                    "jBGi2vt3IVLujfoeXIyA6Ao821XE55hc29pv4sZBooZY5wA4Og2kdAYLVTxSOsaSsUmdY0CLcfoUMFSIdEJMG98zC6otpSw3LnpbrPkZnNjPWO55U7DSfY3LgW5M2IvR52CgIBy3eLTys12HHDFFeqLoUtYmfM0XLYceQxhubY3jVYhbh4RW4SjcPHu2gIp7HlCgxYlFZzBuHZ8tjsh68ScZg3aAMErPcV9o0TcGJkIJgRMahTjY"
                ) {
                    ShopAddress = "vZ3N4x3uvaLnbw12Ii4C82SzJJG4lODNS2Ij7U5b72UTWbjXGfzCmZ2vkYmrCrWwA7IkDmk9acr8tX9JQSHyiFoseHqYyK8GIOW0PGU45uzPdd0dJeNNvUC0bqs1hvmd5I8evbrAQGpnYomE2cpD4cThkIOO2LW0e3G1sTmjjHcN57ZbAikJ2opGyr1ja3zumve771kQ",
                    ShopTel = "02706711-1910",
                    ShopEmail = "b1Dq2UL9Kx@0jYk.com",
                    ShopExternalId = "sZRicOTg23f5GXrX6ozTzm0HG0TosxK",
                    OrganizationCode = "-Z-ZWu-ws-22"
                };
                Response.User response = await request.Send(client!);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.StatusCode!, (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.StatusCode >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task CreateShop6()
        {
            try {
                Request.CreateShop request = new Request.CreateShop(
                    "jBGi2vt3IVLujfoeXIyA6Ao821XE55hc29pv4sZBooZY5wA4Og2kdAYLVTxSOsaSsUmdY0CLcfoUMFSIdEJMG98zC6otpSw3LnpbrPkZnNjPWO55U7DSfY3LgW5M2IvR52CgIBy3eLTys12HHDFFeqLoUtYmfM0XLYceQxhubY3jVYhbh4RW4SjcPHu2gIp7HlCgxYlFZzBuHZ8tjsh68ScZg3aAMErPcV9o0TcGJkIJgRMahTjY"
                ) {
                    ShopPostalCode = "880-6885",
                    ShopAddress = "KBVf4jVtecQNubIdHetIBPUrvpeN86f46tWgyM43AJZ0KTwWOYBSX4EzfsIiIDCSxoowqwobMRj4K8plKuk4zON6lsKCXAkk07Q9YuV27x2ZZwJNPJ0aXH1uRWCYsw6VRBfXAF7xeoT0y6lNlDnKEOyMV89HUL5OwvTmfkSpdcLQvsJQ",
                    ShopTel = "02967-0250",
                    ShopEmail = "hzntqbTr2v@HF1i.com",
                    ShopExternalId = "F0Y7dBxe8hi",
                    OrganizationCode = "R9-lukvYT50ubO70jcnj"
                };
                Response.User response = await request.Send(client!);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.StatusCode!, (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.StatusCode >= 300, "Should be larger than 300");
            }
        }

    }
}
