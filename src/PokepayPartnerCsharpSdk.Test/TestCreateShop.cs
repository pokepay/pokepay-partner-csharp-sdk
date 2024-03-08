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
    public class TestCreateShop
    {
        private Client client;

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
                    "0XmxAy3ATlXa99m3Ela8zcR94JgHtiXrfi45gdORj3Jla3Pfb8OgNh"
                );
                Response.User response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task CreateShop1()
        {
            try {
                Request.CreateShop request = new Request.CreateShop(
                    "0XmxAy3ATlXa99m3Ela8zcR94JgHtiXrfi45gdORj3Jla3Pfb8OgNh"
                ) {
                    OrganizationCode = "5f--P--",
                };
                Response.User response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task CreateShop2()
        {
            try {
                Request.CreateShop request = new Request.CreateShop(
                    "0XmxAy3ATlXa99m3Ela8zcR94JgHtiXrfi45gdORj3Jla3Pfb8OgNh"
                ) {
                    ShopExternalId = "wwlNZ",
                    OrganizationCode = "cv3786tt-8b-tR--",
                };
                Response.User response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task CreateShop3()
        {
            try {
                Request.CreateShop request = new Request.CreateShop(
                    "0XmxAy3ATlXa99m3Ela8zcR94JgHtiXrfi45gdORj3Jla3Pfb8OgNh"
                ) {
                    ShopEmail = "x8cOR3TFR9@a8hM.com",
                    ShopExternalId = "Mtt7RdIKeKSciqwdkkgvqZ",
                    OrganizationCode = "Z0-50-gK-d-ZQh66q",
                };
                Response.User response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task CreateShop4()
        {
            try {
                Request.CreateShop request = new Request.CreateShop(
                    "0XmxAy3ATlXa99m3Ela8zcR94JgHtiXrfi45gdORj3Jla3Pfb8OgNh"
                ) {
                    ShopTel = "0268705290",
                    ShopEmail = "29oTCv16fP@XjhV.com",
                    ShopExternalId = "pKgtr0aXml0I8",
                    OrganizationCode = "KYD6-Qy-02Yp----iy-A0",
                };
                Response.User response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task CreateShop5()
        {
            try {
                Request.CreateShop request = new Request.CreateShop(
                    "0XmxAy3ATlXa99m3Ela8zcR94JgHtiXrfi45gdORj3Jla3Pfb8OgNh"
                ) {
                    ShopAddress = "8sqMTw9CGMrpupnZP3tXLGdI4BQeMKNjNC6v4LdJ9q0nifAUuGHUnCvc4A5HlCo2a7OllUlOCGYapVIyu0AtoOYT3d8xXDGe31wijgcuuWSuuP7qXIDVYzNj",
                    ShopTel = "0109-309718",
                    ShopEmail = "ADYEWxDRpy@5o7r.com",
                    ShopExternalId = "N4eiDq",
                    OrganizationCode = "Y2lJz-JS2K-H-k4Jp2m---",
                };
                Response.User response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task CreateShop6()
        {
            try {
                Request.CreateShop request = new Request.CreateShop(
                    "0XmxAy3ATlXa99m3Ela8zcR94JgHtiXrfi45gdORj3Jla3Pfb8OgNh"
                ) {
                    ShopPostalCode = "850-7917",
                    ShopAddress = "tSHvWHxDbu1GOKxoKM3BkiQ5JCNLUQPpDOoGNkBoKxTvABwe33UWeSzKCZwv4PwJOyIcULWzrNeMACItmOkY1pUONfZUthj8CTdPwk2g7DYhFuXWtax2gH7mosTYAgSjd1Lu4N1G4DllEfWLsx2f1PjIk5LFEcZYZR1K1ULgGU5oSrsDCn36n92LJoBnxVWA0Bmx0P3sSh52djDx2E8q2Tl06IVYw4zb7KKLj26g9",
                    ShopTel = "0848-097",
                    ShopEmail = "3fT2ekfbMy@pSoZ.com",
                    ShopExternalId = "rm",
                    OrganizationCode = "k610S7NJ-u-h9D0B79-",
                };
                Response.User response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

    }
}
