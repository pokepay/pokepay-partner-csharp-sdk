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
    public class TestBulkCreateTransaction
    {
        private Client client;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            client = new Client("~/.pokepay/test-config.ini");
        }

        [Test]
        public async Task BulkCreateTransaction0()
        {
            try {
                Request.BulkCreateTransaction request = new Request.BulkCreateTransaction(
                    "PsLAa0LofoeILq2j",
                    "Jb",
                    "okM11iel9SifEKQQKEl5jTOYEn550ChTMJy5"
                );
                Response.BulkTransaction response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task BulkCreateTransaction1()
        {
            try {
                Request.BulkCreateTransaction request = new Request.BulkCreateTransaction(
                    "PsLAa0LofoeILq2j",
                    "Jb",
                    "okM11iel9SifEKQQKEl5jTOYEn550ChTMJy5"
                ) {
                    PrivateMoneyId = "2f45c65d-775e-495d-92e9-f2b4ed81287a",
                };
                Response.BulkTransaction response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task BulkCreateTransaction2()
        {
            try {
                Request.BulkCreateTransaction request = new Request.BulkCreateTransaction(
                    "PsLAa0LofoeILq2j",
                    "Jb",
                    "okM11iel9SifEKQQKEl5jTOYEn550ChTMJy5"
                ) {
                    Description = "ipR66DYXbWwtCBK4yI7b7ruIn1DQefV0LKmn0D6u1aqXUgLXLPq2aRw08aQ0rfHosccmXhG1yeE5aq4GKV",
                    PrivateMoneyId = "7064fed3-a423-4c16-af3a-3843c1fdb73c",
                };
                Response.BulkTransaction response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

    }
}
