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
    public class TestCreateTopupTransaction
    {
        private Client client;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            client = new Client("~/.pokepay/test-config.ini");
        }

        [Test]
        public async Task CreateTopupTransaction0()
        {
            try {
                Request.CreateTopupTransaction request = new Request.CreateTopupTransaction(
                    "13ea8a00-1672-42e9-8759-7ae9b93c833d",
                    "ea5fdad0-b87b-4d00-a93a-e3b870df68c8",
                    "d99fde8a-c6ee-4ae4-b44c-324b71153ee7"
                );
                Response.TransactionDetail response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task CreateTopupTransaction1()
        {
            try {
                Request.CreateTopupTransaction request = new Request.CreateTopupTransaction(
                    "13ea8a00-1672-42e9-8759-7ae9b93c833d",
                    "ea5fdad0-b87b-4d00-a93a-e3b870df68c8",
                    "d99fde8a-c6ee-4ae4-b44c-324b71153ee7"
                ) {
                    RequestId = "75afb6bb-7a0e-498e-8626-5857d985893b",
                };
                Response.TransactionDetail response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task CreateTopupTransaction2()
        {
            try {
                Request.CreateTopupTransaction request = new Request.CreateTopupTransaction(
                    "13ea8a00-1672-42e9-8759-7ae9b93c833d",
                    "ea5fdad0-b87b-4d00-a93a-e3b870df68c8",
                    "d99fde8a-c6ee-4ae4-b44c-324b71153ee7"
                ) {
                    Metadata = "{\"key\":\"value\"}",
                    RequestId = "5c5ecec9-0f1b-45e5-ab8d-252faf1ef03e",
                };
                Response.TransactionDetail response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task CreateTopupTransaction3()
        {
            try {
                Request.CreateTopupTransaction request = new Request.CreateTopupTransaction(
                    "13ea8a00-1672-42e9-8759-7ae9b93c833d",
                    "ea5fdad0-b87b-4d00-a93a-e3b870df68c8",
                    "d99fde8a-c6ee-4ae4-b44c-324b71153ee7"
                ) {
                    Description = "B413C8zcpa0a0ipuLt3IQKQQHb6fikVg8U3XBigR3jya01cL7edhmrVi5NIsblUeDquiQL8YRreNoLAWMJdywYSICtYcbHl2ktF16gpa54attROZcBbejZS9wdnnNKINI7vj8qEDPsdJ8JkL6K4fbUtzmymsdzvhUXmrc210Vo",
                    Metadata = "{\"key\":\"value\"}",
                    RequestId = "ef50e897-cc7a-4959-ab43-f3fa6bf94d81",
                };
                Response.TransactionDetail response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task CreateTopupTransaction4()
        {
            try {
                Request.CreateTopupTransaction request = new Request.CreateTopupTransaction(
                    "13ea8a00-1672-42e9-8759-7ae9b93c833d",
                    "ea5fdad0-b87b-4d00-a93a-e3b870df68c8",
                    "d99fde8a-c6ee-4ae4-b44c-324b71153ee7"
                ) {
                    PointExpiresAt = "2023-04-17T19:00:11.000000+09:00",
                    Description = "4wR9Gfv1ooHMcqzJF0zVNZ8zHF5mnetJol0g7uhhZVwBBSB9NQuG198o4cE8ye8xiCptr8X3OQSs9cvMVMzYpfEHHq4AVCPhpFJVl2NE9OohrFLhvABt92YjeNGkeRyZCxDwnyuzPdWfYw482S6oHFsZh9ksnqTSKQYaLtgBF21",
                    Metadata = "{\"key\":\"value\"}",
                    RequestId = "ef9cdccd-f19a-4961-af30-71e90fcf08bc",
                };
                Response.TransactionDetail response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task CreateTopupTransaction5()
        {
            try {
                Request.CreateTopupTransaction request = new Request.CreateTopupTransaction(
                    "13ea8a00-1672-42e9-8759-7ae9b93c833d",
                    "ea5fdad0-b87b-4d00-a93a-e3b870df68c8",
                    "d99fde8a-c6ee-4ae4-b44c-324b71153ee7"
                ) {
                    PointAmount = 3202,
                    PointExpiresAt = "2024-03-02T12:46:31.000000+09:00",
                    Description = "x72McbAtuQfbwPK5Ol2Udeu5ClBnNsqGtwvAjO8SQrjpT",
                    Metadata = "{\"key\":\"value\"}",
                    RequestId = "fced7420-b56c-4bd5-98a5-5f4be056920c",
                };
                Response.TransactionDetail response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task CreateTopupTransaction6()
        {
            try {
                Request.CreateTopupTransaction request = new Request.CreateTopupTransaction(
                    "13ea8a00-1672-42e9-8759-7ae9b93c833d",
                    "ea5fdad0-b87b-4d00-a93a-e3b870df68c8",
                    "d99fde8a-c6ee-4ae4-b44c-324b71153ee7"
                ) {
                    MoneyAmount = 5461,
                    PointAmount = 555,
                    PointExpiresAt = "2022-07-30T13:12:06.000000+09:00",
                    Description = "ix6vD3BTnNcaIv4Cy2qiGNeSDJueWNAF2iLhkB08mWoSEw4Yfnz5e3bjXKldANGzSZe49qKV1rholLnfHAgpNJKDDEjuzSmETPUL6TDRxNmjKWPDEzen9VEh9JKwUlzsxb9tQKSZdMATJHlP3s2aiyvcn732KUYpvpwWJTv2DUcmsWBTf3SfgLVN",
                    Metadata = "{\"key\":\"value\"}",
                    RequestId = "a0db3eec-5bbf-4c95-8f0e-96e89e7c004e",
                };
                Response.TransactionDetail response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task CreateTopupTransaction7()
        {
            try {
                Request.CreateTopupTransaction request = new Request.CreateTopupTransaction(
                    "13ea8a00-1672-42e9-8759-7ae9b93c833d",
                    "ea5fdad0-b87b-4d00-a93a-e3b870df68c8",
                    "d99fde8a-c6ee-4ae4-b44c-324b71153ee7"
                ) {
                    BearPointShopId = "db94a50f-e06f-4452-8555-1b698d3a02ef",
                    MoneyAmount = 7394,
                    PointAmount = 5950,
                    PointExpiresAt = "2020-03-02T05:31:46.000000+09:00",
                    Description = "no3HZhnyNZ5Q77U04aLs4hmy4C28WnCRfz2leovb1R7O6QOgboW2zpcaLxa2QZma6CRo8nyJO9Y3f9djMgk8QSZwJ1udEIb7zDJ6KZTEk0mDRGqd8jGihF2zo2GN3QYDG6CZS1PVe5LZzi2NmWBluHrzflOytNd3ROmH9",
                    Metadata = "{\"key\":\"value\"}",
                    RequestId = "f5ac24ee-824d-4fbc-ab66-fb2cda88657f",
                };
                Response.TransactionDetail response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

    }
}
