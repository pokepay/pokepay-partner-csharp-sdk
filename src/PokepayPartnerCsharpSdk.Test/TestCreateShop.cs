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
                    "fIlsQjs1Uxv98uoxa9cfqdBZBSSyuPsLgc14jRH1daAJWkWpeGVt7BTtK3VwbUSgXIGfDPEPwHED0KtmDzxLUbUeg7w8cIU7UKhxLe1FMHoh3041czvU7tiTGNYlDyRk3aGMps1HN2Oi8GzWre6yIHCge3KvTMWtvAOdqc6t46b4EgFIpDVk2sqQhlAUNF0Kr6ekdB7WSGlsT24mzzvf0uixfzgMS7DAxRVXjpoYOkLYbJM46YGKDJV"
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
                    "fIlsQjs1Uxv98uoxa9cfqdBZBSSyuPsLgc14jRH1daAJWkWpeGVt7BTtK3VwbUSgXIGfDPEPwHED0KtmDzxLUbUeg7w8cIU7UKhxLe1FMHoh3041czvU7tiTGNYlDyRk3aGMps1HN2Oi8GzWre6yIHCge3KvTMWtvAOdqc6t46b4EgFIpDVk2sqQhlAUNF0Kr6ekdB7WSGlsT24mzzvf0uixfzgMS7DAxRVXjpoYOkLYbJM46YGKDJV"
                ) {
                    OrganizationCode = "T-sG-A-Y4rx3806--",
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
                    "fIlsQjs1Uxv98uoxa9cfqdBZBSSyuPsLgc14jRH1daAJWkWpeGVt7BTtK3VwbUSgXIGfDPEPwHED0KtmDzxLUbUeg7w8cIU7UKhxLe1FMHoh3041czvU7tiTGNYlDyRk3aGMps1HN2Oi8GzWre6yIHCge3KvTMWtvAOdqc6t46b4EgFIpDVk2sqQhlAUNF0Kr6ekdB7WSGlsT24mzzvf0uixfzgMS7DAxRVXjpoYOkLYbJM46YGKDJV"
                ) {
                    ShopExternalId = "cqmENfDor1zgwF9x3",
                    OrganizationCode = "2-",
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
                    "fIlsQjs1Uxv98uoxa9cfqdBZBSSyuPsLgc14jRH1daAJWkWpeGVt7BTtK3VwbUSgXIGfDPEPwHED0KtmDzxLUbUeg7w8cIU7UKhxLe1FMHoh3041czvU7tiTGNYlDyRk3aGMps1HN2Oi8GzWre6yIHCge3KvTMWtvAOdqc6t46b4EgFIpDVk2sqQhlAUNF0Kr6ekdB7WSGlsT24mzzvf0uixfzgMS7DAxRVXjpoYOkLYbJM46YGKDJV"
                ) {
                    ShopEmail = "fU4cD6smAe@qngi.com",
                    ShopExternalId = "ikqDE3OudXpYhNw",
                    OrganizationCode = "ZA7BK-",
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
                    "fIlsQjs1Uxv98uoxa9cfqdBZBSSyuPsLgc14jRH1daAJWkWpeGVt7BTtK3VwbUSgXIGfDPEPwHED0KtmDzxLUbUeg7w8cIU7UKhxLe1FMHoh3041czvU7tiTGNYlDyRk3aGMps1HN2Oi8GzWre6yIHCge3KvTMWtvAOdqc6t46b4EgFIpDVk2sqQhlAUNF0Kr6ekdB7WSGlsT24mzzvf0uixfzgMS7DAxRVXjpoYOkLYbJM46YGKDJV"
                ) {
                    ShopTel = "0476633-271",
                    ShopEmail = "1FfneXYRV1@FBu9.com",
                    ShopExternalId = "VqwmK2QWEkaIk3Nf304AeRoMBnYR",
                    OrganizationCode = "I-sc750tZXruc",
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
                    "fIlsQjs1Uxv98uoxa9cfqdBZBSSyuPsLgc14jRH1daAJWkWpeGVt7BTtK3VwbUSgXIGfDPEPwHED0KtmDzxLUbUeg7w8cIU7UKhxLe1FMHoh3041czvU7tiTGNYlDyRk3aGMps1HN2Oi8GzWre6yIHCge3KvTMWtvAOdqc6t46b4EgFIpDVk2sqQhlAUNF0Kr6ekdB7WSGlsT24mzzvf0uixfzgMS7DAxRVXjpoYOkLYbJM46YGKDJV"
                ) {
                    ShopAddress = "EvFhF0JaiWpiphXqNgzf5XFTYAHJdFeGZi1JIa9NTrkMeAKNU2qNMrw4Jay2YBOfulEIFK5T7Dc8oOst1MM9PmjRDk75J779k3qO5Tt2uQGKACRqDnzgekX1v8dvD0ApeDNVXLZhDHmMPohPl8jvZE0kmWyBRnvtcRhoAfyfPvqbgkbgVyEBxJ",
                    ShopTel = "02557640",
                    ShopEmail = "g3h5b1QYmV@Ctk7.com",
                    ShopExternalId = "JxdSgtNZkgpDcQrvPvYu9rBGsdWvnLspa",
                    OrganizationCode = "Y1l-3S-a99d39XW2-OAW4--i",
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
                    "fIlsQjs1Uxv98uoxa9cfqdBZBSSyuPsLgc14jRH1daAJWkWpeGVt7BTtK3VwbUSgXIGfDPEPwHED0KtmDzxLUbUeg7w8cIU7UKhxLe1FMHoh3041czvU7tiTGNYlDyRk3aGMps1HN2Oi8GzWre6yIHCge3KvTMWtvAOdqc6t46b4EgFIpDVk2sqQhlAUNF0Kr6ekdB7WSGlsT24mzzvf0uixfzgMS7DAxRVXjpoYOkLYbJM46YGKDJV"
                ) {
                    ShopPostalCode = "1393414",
                    ShopAddress = "bb8U4LoGEUFzMVQ4l9WdfwN1GBXrbSDIYZlYLOis5sBRV50E243Lt7Q0CkQGlHLmFUomkHrvNClWFSWTgMn5wd",
                    ShopTel = "0061231408",
                    ShopEmail = "qoWmfQbT09@Lp66.com",
                    ShopExternalId = "g0d7eGITtIklkYFTO7OJe9dSEOGAL",
                    OrganizationCode = "t518798nQhn-67",
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
