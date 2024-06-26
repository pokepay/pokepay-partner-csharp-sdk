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
    public class TestListCoupons
    {
        private Client client;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            client = new Client("~/.pokepay/test-config.ini");
        }

        [Test]
        public async Task ListCoupons0()
        {
            try {
                Request.ListCoupons request = new Request.ListCoupons(
                    "5287d249-2b06-4f32-a066-9deb582af3ef"
                );
                Response.PaginatedCoupons response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListCoupons1()
        {
            try {
                Request.ListCoupons request = new Request.ListCoupons(
                    "5287d249-2b06-4f32-a066-9deb582af3ef"
                ) {
                    PerPage = 4492,
                };
                Response.PaginatedCoupons response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListCoupons2()
        {
            try {
                Request.ListCoupons request = new Request.ListCoupons(
                    "5287d249-2b06-4f32-a066-9deb582af3ef"
                ) {
                    Page = 7514,
                    PerPage = 9614,
                };
                Response.PaginatedCoupons response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListCoupons3()
        {
            try {
                Request.ListCoupons request = new Request.ListCoupons(
                    "5287d249-2b06-4f32-a066-9deb582af3ef"
                ) {
                    AvailableTo = "2020-06-15T13:24:22.000000Z",
                    Page = 8382,
                    PerPage = 1415,
                };
                Response.PaginatedCoupons response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListCoupons4()
        {
            try {
                Request.ListCoupons request = new Request.ListCoupons(
                    "5287d249-2b06-4f32-a066-9deb582af3ef"
                ) {
                    AvailableFrom = "2022-07-07T12:03:30.000000Z",
                    AvailableTo = "2024-03-16T11:48:43.000000Z",
                    Page = 5387,
                    PerPage = 6558,
                };
                Response.PaginatedCoupons response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListCoupons5()
        {
            try {
                Request.ListCoupons request = new Request.ListCoupons(
                    "5287d249-2b06-4f32-a066-9deb582af3ef"
                ) {
                    AvailableShopName = "uaeWPZ",
                    AvailableFrom = "2023-10-16T13:14:07.000000Z",
                    AvailableTo = "2023-02-01T02:23:36.000000Z",
                    Page = 5410,
                    PerPage = 8238,
                };
                Response.PaginatedCoupons response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListCoupons6()
        {
            try {
                Request.ListCoupons request = new Request.ListCoupons(
                    "5287d249-2b06-4f32-a066-9deb582af3ef"
                ) {
                    IssuedShopName = "K6Z",
                    AvailableShopName = "1zTkB",
                    AvailableFrom = "2022-05-23T02:13:37.000000Z",
                    AvailableTo = "2020-06-09T01:09:47.000000Z",
                    Page = 4092,
                    PerPage = 5130,
                };
                Response.PaginatedCoupons response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListCoupons7()
        {
            try {
                Request.ListCoupons request = new Request.ListCoupons(
                    "5287d249-2b06-4f32-a066-9deb582af3ef"
                ) {
                    CouponName = "UJIx",
                    IssuedShopName = "9pUjuQLW",
                    AvailableShopName = "JQAl",
                    AvailableFrom = "2021-04-02T07:43:37.000000Z",
                    AvailableTo = "2022-06-18T14:13:01.000000Z",
                    Page = 8088,
                    PerPage = 2652,
                };
                Response.PaginatedCoupons response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListCoupons8()
        {
            try {
                Request.ListCoupons request = new Request.ListCoupons(
                    "5287d249-2b06-4f32-a066-9deb582af3ef"
                ) {
                    CouponId = "IBEGWMO",
                    CouponName = "qgVzvG",
                    IssuedShopName = "f46VZC1gRO",
                    AvailableShopName = "yDwwPosw",
                    AvailableFrom = "2024-01-31T15:16:32.000000Z",
                    AvailableTo = "2022-07-23T13:58:10.000000Z",
                    Page = 327,
                    PerPage = 2797,
                };
                Response.PaginatedCoupons response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

    }
}
