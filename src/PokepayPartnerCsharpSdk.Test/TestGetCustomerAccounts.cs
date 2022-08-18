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
    public class TestGetCustomerAccounts
    {
        private Client client;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            client = new Client("~/.pokepay/test-config.ini");
        }

        [Test]
        public async Task GetCustomerAccounts0()
        {
            try {
                Request.GetCustomerAccounts request = new Request.GetCustomerAccounts(
                    "5a434e63-82f5-4d3b-9357-6d0bf3dd402a"
                );
                Response.PaginatedAccountWithUsers response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task GetCustomerAccounts1()
        {
            try {
                Request.GetCustomerAccounts request = new Request.GetCustomerAccounts(
                    "5a434e63-82f5-4d3b-9357-6d0bf3dd402a"
                ) {
                    Email = "xfr4xKRRC5@UPfd.com",
                };
                Response.PaginatedAccountWithUsers response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task GetCustomerAccounts2()
        {
            try {
                Request.GetCustomerAccounts request = new Request.GetCustomerAccounts(
                    "5a434e63-82f5-4d3b-9357-6d0bf3dd402a"
                ) {
                    Tel = "09-1302581",
                    Email = "hDpkltxfpG@BgKz.com",
                };
                Response.PaginatedAccountWithUsers response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task GetCustomerAccounts3()
        {
            try {
                Request.GetCustomerAccounts request = new Request.GetCustomerAccounts(
                    "5a434e63-82f5-4d3b-9357-6d0bf3dd402a"
                ) {
                    ExternalId = "LBWMCY",
                    Tel = "0680922280",
                    Email = "nT3R8fCd81@15Vz.com",
                };
                Response.PaginatedAccountWithUsers response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task GetCustomerAccounts4()
        {
            try {
                Request.GetCustomerAccounts request = new Request.GetCustomerAccounts(
                    "5a434e63-82f5-4d3b-9357-6d0bf3dd402a"
                ) {
                    Status = "pre-closed",
                    ExternalId = "SNwUPij0JCeKaErwIngTct5VctC8ahSG576",
                    Tel = "029-20-627",
                    Email = "hNuqsd2aOE@u5ug.com",
                };
                Response.PaginatedAccountWithUsers response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task GetCustomerAccounts5()
        {
            try {
                Request.GetCustomerAccounts request = new Request.GetCustomerAccounts(
                    "5a434e63-82f5-4d3b-9357-6d0bf3dd402a"
                ) {
                    IsSuspended = false,
                    Status = "suspended",
                    ExternalId = "0fcKmGRUw7sMhCFW8ODbHkZSUPXBsmObvnHUjDTSSciw",
                    Tel = "0302-887",
                    Email = "IImkvl5vCA@Hh7Q.com",
                };
                Response.PaginatedAccountWithUsers response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task GetCustomerAccounts6()
        {
            try {
                Request.GetCustomerAccounts request = new Request.GetCustomerAccounts(
                    "5a434e63-82f5-4d3b-9357-6d0bf3dd402a"
                ) {
                    CreatedAtTo = "2017-11-11T00:03:31.000000+09:00",
                    IsSuspended = false,
                    Status = "active",
                    ExternalId = "YIcm0Sp2RluFOAxJTKKlkJp5ENq52OLTcJlns",
                    Tel = "0775-9145-4752",
                    Email = "n7Z1wrrgdx@WfKk.com",
                };
                Response.PaginatedAccountWithUsers response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task GetCustomerAccounts7()
        {
            try {
                Request.GetCustomerAccounts request = new Request.GetCustomerAccounts(
                    "5a434e63-82f5-4d3b-9357-6d0bf3dd402a"
                ) {
                    CreatedAtFrom = "2021-08-28T21:00:04.000000+09:00",
                    CreatedAtTo = "2015-11-25T18:11:51.000000+09:00",
                    IsSuspended = true,
                    Status = "pre-closed",
                    ExternalId = "pOR",
                    Tel = "00807-2523",
                    Email = "d4nadmeyKn@qGyq.com",
                };
                Response.PaginatedAccountWithUsers response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task GetCustomerAccounts8()
        {
            try {
                Request.GetCustomerAccounts request = new Request.GetCustomerAccounts(
                    "5a434e63-82f5-4d3b-9357-6d0bf3dd402a"
                ) {
                    PerPage = 4016,
                    CreatedAtFrom = "2018-03-12T00:01:50.000000+09:00",
                    CreatedAtTo = "2021-12-03T04:41:26.000000+09:00",
                    IsSuspended = false,
                    Status = "active",
                    ExternalId = "36l34SSSOxW72gqSjd8Q",
                    Tel = "04040475",
                    Email = "merReZGbvG@gvAZ.com",
                };
                Response.PaginatedAccountWithUsers response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task GetCustomerAccounts9()
        {
            try {
                Request.GetCustomerAccounts request = new Request.GetCustomerAccounts(
                    "5a434e63-82f5-4d3b-9357-6d0bf3dd402a"
                ) {
                    Page = 1123,
                    PerPage = 890,
                    CreatedAtFrom = "2021-11-19T16:34:34.000000+09:00",
                    CreatedAtTo = "2020-01-07T05:35:58.000000+09:00",
                    IsSuspended = false,
                    Status = "pre-closed",
                    ExternalId = "Lea6an4P1AnQALadFsAzgfKjbtuXgZDedI",
                    Tel = "08-40087872",
                    Email = "iwZBj5AvHd@O2At.com",
                };
                Response.PaginatedAccountWithUsers response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

    }
}
