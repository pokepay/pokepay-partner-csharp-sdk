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
    public class TestUpdateCashtray
    {
        private Client? client;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            client = new Client("~/.pokepay/test-config.ini");
        }

        [Test]
        public async Task UpdateCashtray0()
        {
            try {
                Request.UpdateCashtray request = new Request.UpdateCashtray(
                    "2fb52007-c055-4363-bbf2-3cbaf35659f5"
                );
                Response.Cashtray response = await request.Send(client!);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.StatusCode!, (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.StatusCode >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task UpdateCashtray1()
        {
            try {
                Request.UpdateCashtray request = new Request.UpdateCashtray(
                    "2fb52007-c055-4363-bbf2-3cbaf35659f5"
                ) {
                    ExpiresIn = 8154,
                };
                Response.Cashtray response = await request.Send(client!);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.StatusCode!, (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.StatusCode >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task UpdateCashtray2()
        {
            try {
                Request.UpdateCashtray request = new Request.UpdateCashtray(
                    "2fb52007-c055-4363-bbf2-3cbaf35659f5"
                ) {
                    Description = "P4H5cCw5ExNqh41OXXFwVmaHYw6oEFbK8qER1LlAIi5qYTqeIN9jftsBTkZDKCnQigIBcgyeHE0tecRrYBgXoYNaRDH3xa5ZXl3L94kmDiQZVmfdCV9wGJUROgp1VTNstKsbk2wvZcZmJCZwuee4w9Rkvag9C19xRl1IlJpGXqlhd5uwOg53j3Qic0iyKL",
                    ExpiresIn = 7844,
                };
                Response.Cashtray response = await request.Send(client!);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.StatusCode!, (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.StatusCode >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task UpdateCashtray3()
        {
            try {
                Request.UpdateCashtray request = new Request.UpdateCashtray(
                    "2fb52007-c055-4363-bbf2-3cbaf35659f5"
                ) {
                    Amount = 6023,
                    Description = "nZxaZi9iCa2kj9IDD4FLU",
                    ExpiresIn = 3878,
                };
                Response.Cashtray response = await request.Send(client!);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.StatusCode!, (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.StatusCode >= 300, "Should be larger than 300");
            }
        }

    }
}
