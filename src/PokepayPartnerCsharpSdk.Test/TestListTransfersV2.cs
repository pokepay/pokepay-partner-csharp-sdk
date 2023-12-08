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
    public class TestListTransfersV2
    {
        private Client client;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            client = new Client("~/.pokepay/test-config.ini");
        }

        [Test]
        public async Task ListTransfersV20()
        {
            try {
                Request.ListTransfersV2 request = new Request.ListTransfersV2();
                Response.PaginatedTransfersV2 response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListTransfersV21()
        {
            try {
                Request.ListTransfersV2 request = new Request.ListTransfersV2() {
                    To = "2018-05-11T05:19:09.000000+09:00",
                };
                Response.PaginatedTransfersV2 response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListTransfersV22()
        {
            try {
                Request.ListTransfersV2 request = new Request.ListTransfersV2() {
                    From = "2017-07-31T16:13:57.000000+09:00",
                    To = "2016-03-19T16:27:03.000000+09:00",
                };
                Response.PaginatedTransfersV2 response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListTransfersV23()
        {
            try {
                Request.ListTransfersV2 request = new Request.ListTransfersV2() {
                    Description = "M3xNEFCgQheyCbSnP7P0SqnjQ",
                    From = "2023-11-29T02:11:22.000000+09:00",
                    To = "2025-07-27T19:27:02.000000+09:00",
                };
                Response.PaginatedTransfersV2 response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListTransfersV24()
        {
            try {
                Request.ListTransfersV2 request = new Request.ListTransfersV2() {
                    TransferTypes = new string[]{},
                    Description = "aBHzjlAdXU9fbl4BElEfYJcTmiRof0lbldCRsSSTgoxqh3aCnDQum7xlHp8mSoN73gaH3XPjunt8NgffostplBJ13qPcXVXQ9E7OqefuC0zsB8aQbgel1VX",
                    From = "2025-01-18T15:07:34.000000+09:00",
                    To = "2021-03-22T14:00:02.000000+09:00",
                };
                Response.PaginatedTransfersV2 response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListTransfersV25()
        {
            try {
                Request.ListTransfersV2 request = new Request.ListTransfersV2() {
                    PerPage = 37,
                    TransferTypes = new string[]{"topup", "transfer", "exchange", "payment", "campaign", "cashback", "expire"},
                    Description = "CGfzH0EqAidHGV4baZPNRUSJ9iQNhB3KMhlAuhO2DrrEN6v7h6DIeIXBVaS0Zi07XrJykFEWCqS7fIGsgSUetvz",
                    From = "2020-09-09T02:03:39.000000+09:00",
                    To = "2016-04-05T23:50:38.000000+09:00",
                };
                Response.PaginatedTransfersV2 response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListTransfersV26()
        {
            try {
                Request.ListTransfersV2 request = new Request.ListTransfersV2() {
                    PrevPageCursorId = "0cc5caad-c5df-42ff-a39a-abf9f061bb59",
                    PerPage = 778,
                    TransferTypes = new string[]{"exchange", "payment", "expire", "cashback", "campaign", "transfer"},
                    Description = "aW8dVGclxW2nJI1LDT3BhMLUADblZz6ydgd6gveWK49xDzlQxtC3xLL1ERUl6NhqKkDSvghab5bsImY7PcHPZH7mHIXsOqC2xcKBYhL1xCfnaEpDLcNgoBzsuiKajpcQf4nuECfdVUoATZ0pZ1FEusk3svdOIWNVHFftM1EZPsd7jOCTvYgQY",
                    From = "2017-10-20T17:12:18.000000+09:00",
                    To = "2025-08-04T05:32:07.000000+09:00",
                };
                Response.PaginatedTransfersV2 response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListTransfersV27()
        {
            try {
                Request.ListTransfersV2 request = new Request.ListTransfersV2() {
                    NextPageCursorId = "ffcc2619-eace-4b54-9800-845bed88840a",
                    PrevPageCursorId = "72dca3b3-3afb-4159-9533-0a06b76c73f1",
                    PerPage = 550,
                    TransferTypes = new string[]{"expire", "exchange", "coupon", "campaign", "payment", "transfer"},
                    Description = "b1wlkuiN7kKWKF",
                    From = "2024-02-23T19:10:44.000000+09:00",
                    To = "2017-10-30T02:54:59.000000+09:00",
                };
                Response.PaginatedTransfersV2 response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListTransfersV28()
        {
            try {
                Request.ListTransfersV2 request = new Request.ListTransfersV2() {
                    TransactionTypes = new string[]{"payment", "expire", "exchange", "transfer", "topup"},
                    NextPageCursorId = "cc5793a9-9740-4acc-b5cc-d7c83fb2979c",
                    PrevPageCursorId = "1fa89fb4-6c04-4825-8548-5503cb38f593",
                    PerPage = 666,
                    TransferTypes = new string[]{"topup", "cashback", "expire", "campaign", "exchange", "payment", "coupon", "transfer"},
                    Description = "ZSoJ1krFHQyhzGXerHPOPDvrwRgeSOaGF6stofVWAQmmxPEjbZK4rVxAUW7FWHk",
                    From = "2019-11-12T16:18:05.000000+09:00",
                    To = "2024-08-22T15:04:57.000000+09:00",
                };
                Response.PaginatedTransfersV2 response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListTransfersV29()
        {
            try {
                Request.ListTransfersV2 request = new Request.ListTransfersV2() {
                    IsModified = true,
                    TransactionTypes = new string[]{"cashback", "expire", "topup", "transfer"},
                    NextPageCursorId = "421fe718-1a23-43bd-b946-4ea756a0a87f",
                    PrevPageCursorId = "7df66bce-4fba-4261-99a4-e72c7eb00710",
                    PerPage = 597,
                    TransferTypes = new string[]{"campaign", "cashback", "transfer", "exchange", "coupon", "expire"},
                    Description = "xMPy8uYVQrlAwBlTLDHylYVoU0Lud9b5MHdM8UnuwQ7jNoaulXZjgrVDfW2ufNp0gAs9phyFh2aSmdruAKFNN9YCEWSULZdpylXeF6qvGwUl7ATMaf3NqLOcKmTPNREiEdfOxleM",
                    From = "2019-02-19T07:53:50.000000+09:00",
                    To = "2020-12-07T15:19:29.000000+09:00",
                };
                Response.PaginatedTransfersV2 response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListTransfersV210()
        {
            try {
                Request.ListTransfersV2 request = new Request.ListTransfersV2() {
                    PrivateMoneyId = "a7ab0171-ace2-4c31-bc3a-2385a67c8119",
                    IsModified = true,
                    TransactionTypes = new string[]{"exchange", "expire", "cashback", "transfer", "topup", "payment"},
                    NextPageCursorId = "a3779551-4e6f-4159-b267-b9338c890ba2",
                    PrevPageCursorId = "cd9a9f7e-4a90-4557-8b2d-b7081e607630",
                    PerPage = 29,
                    TransferTypes = new string[]{"expire", "campaign", "exchange", "topup", "transfer", "payment", "cashback"},
                    Description = "D8anN0lX3R6Ngh2OAi1BcnwfTRLJa4uoIhpR40nORwuCknsFuOeDw3ETEoYbDEhr0AwKkiQOHCQCIIRDiJ5EWSp",
                    From = "2016-08-07T15:07:23.000000+09:00",
                    To = "2017-04-07T08:10:39.000000+09:00",
                };
                Response.PaginatedTransfersV2 response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListTransfersV211()
        {
            try {
                Request.ListTransfersV2 request = new Request.ListTransfersV2() {
                    TransactionId = "3e79df5b-2543-493c-a3d0-166d6f2a2534",
                    PrivateMoneyId = "df043dae-95c3-42f5-bc82-052e3f1e4bea",
                    IsModified = true,
                    TransactionTypes = new string[]{"expire"},
                    NextPageCursorId = "47390fe9-c2be-4279-a1d2-fa888658b8ff",
                    PrevPageCursorId = "1bc74e0f-49d0-4190-9f8e-9b3c23b4deba",
                    PerPage = 867,
                    TransferTypes = new string[]{},
                    Description = "2CSzS35RxVGrM7sDhsRor5EZrBgBnWdBpXW3vXZAsIGmxl3OdV3odlFFoKvu4lobeulXI7c3F9nyrjjRiAP0nDGe4yWdLtrR0H47hbbDvB2dkQWYC4RWqJwsq2yT7AWpCDkyLBkYzAxe",
                    From = "2022-06-02T20:11:33.000000+09:00",
                    To = "2024-03-06T17:07:18.000000+09:00",
                };
                Response.PaginatedTransfersV2 response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListTransfersV212()
        {
            try {
                Request.ListTransfersV2 request = new Request.ListTransfersV2() {
                    CustomerName = "aKowuUfekyaJIsuHhxZpopNYyv6dLAyty2EMgPVlahlWYdbEevpLkzdUFCwG4QGOnpUXmwhMFkO9ufFPOzF9Lvv7JJIkMwpNGlwPY7w3AePumXzLvyF75pQlwzsKLA3j0RsOTGgnfI7tlICoQDpnLAiZiYSVIBpBUCCSgk4gnk7sP6E17lkMgQrA88yuG2X4KRlpHewo2CgFQkdXPF4V9XHbL6z",
                    TransactionId = "ac8402d9-d4be-42a2-9836-36fda0e2681f",
                    PrivateMoneyId = "ae9c68f6-ac88-4403-b177-a00ea980a824",
                    IsModified = false,
                    TransactionTypes = new string[]{},
                    NextPageCursorId = "54095ac5-2b5b-4850-885c-80674df51347",
                    PrevPageCursorId = "0cf9d1ee-3d7c-4c45-a4dc-58818680db7a",
                    PerPage = 873,
                    TransferTypes = new string[]{"expire", "exchange", "topup"},
                    Description = "vJwcetItJxO93cN0lVNG0lwTGLR8ci2cIIE66fhj2n6iiZ64HpvFGkJr1uo4NLstnS7EAbDgQaYkUrDsQyk3kwOisNW9XsMHBVPsrs",
                    From = "2020-04-28T07:40:36.000000+09:00",
                    To = "2021-05-10T11:39:15.000000+09:00",
                };
                Response.PaginatedTransfersV2 response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListTransfersV213()
        {
            try {
                Request.ListTransfersV2 request = new Request.ListTransfersV2() {
                    CustomerId = "94842fa3-bd3d-4cee-8cc7-f3bac2e3b387",
                    CustomerName = "RYzu4noxPXNWpdUvBBp2JsuVIINCRpxja7me48LNXqpqJtjZwJILsuUBm8J0tu2v6zDKp9iO7Ari3UHmo6XPE5Oqy1DljVh9nsqgzongKg5SFSpcaiWqMVEyXiabD2fPkrS1NvYbmwucdTPjBOMyHVeFGY5vB7gjE0J3rzoZQgeuXW4rw3Ob3VUIWbzDljJ6klDtciJUcw1wir4yYsQVBNqeX",
                    TransactionId = "b90ba9ec-b9ef-4b44-9d40-f22925676de2",
                    PrivateMoneyId = "e391a7fa-c31f-4ca8-8912-f47a98f537c7",
                    IsModified = true,
                    TransactionTypes = new string[]{"cashback", "transfer", "expire", "exchange", "topup", "payment"},
                    NextPageCursorId = "de09912b-d2c4-4501-ab4f-8366da047e2c",
                    PrevPageCursorId = "493c338e-9a8a-4b4d-a2bc-18c1aef25ecb",
                    PerPage = 64,
                    TransferTypes = new string[]{"campaign"},
                    Description = "aiYXr4rnNnjCoeQHMuXiGNUysmU86lvAOTbcLzXO1sbMRuBNUlL6K0ReLv75kg6qcs3cEpI1m3wABqtL3bdaVTKdkTjUxGpAh3awQssfAXqJYYr4ARYbJcmLujs894lRg4qB30GRMkbzDn742v8m6fDAksXCcjSnMwkyUVD7C",
                    From = "2023-03-19T11:45:26.000000+09:00",
                    To = "2016-01-31T10:08:28.000000+09:00",
                };
                Response.PaginatedTransfersV2 response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListTransfersV214()
        {
            try {
                Request.ListTransfersV2 request = new Request.ListTransfersV2() {
                    ShopName = "SrG8bUcu2404OwW2YlKo3D8R7F9uqtTYDUe0c6WMBb0vMyrrNo2CtAij6bFWlBc9nMouBhD3xaVyDbF9dQAdVbIjdKodnIqsg2hwfCC3ynrJLnPSb5d8avvWNGGZpHcQub7jyKGPEze4eDg0kaj205Q9Vfs0xg",
                    CustomerId = "729bdee4-7557-499a-a36c-2245e0eaa60c",
                    CustomerName = "jRqPOb8BVVabHLEG4agkq2G8IRGQBS0nchLLndRaY2NqmWOdlkOhTjC67yWAbgIrPt858HfVRa8DX5UPvkC2RO0Ka4",
                    TransactionId = "a322c46c-e859-4f0e-9819-b202f428fdd8",
                    PrivateMoneyId = "acb9f39f-4c79-4a5e-b68d-aef6fe24aaa4",
                    IsModified = true,
                    TransactionTypes = new string[]{"expire", "transfer", "exchange", "cashback"},
                    NextPageCursorId = "1aa9fcaa-f274-4dec-9c33-8bf9bba73084",
                    PrevPageCursorId = "e60a1778-d12d-48e3-8c6c-d9d714a99e92",
                    PerPage = 468,
                    TransferTypes = new string[]{"payment", "transfer", "exchange"},
                    Description = "oZ5q4f3l3OfQm9YtxuJKrDFgfnOa5xAhF9FsFDzTIAFGDPhpBgKNmzEARJ1rvmqI1bSsRkkjQVB7WPQBN4OQef6",
                    From = "2020-12-03T00:53:05.000000+09:00",
                    To = "2021-01-12T06:05:52.000000+09:00",
                };
                Response.PaginatedTransfersV2 response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListTransfersV215()
        {
            try {
                Request.ListTransfersV2 request = new Request.ListTransfersV2() {
                    ShopId = "b36f0050-1d9d-4c84-8b4a-aa2c6e02eb9a",
                    ShopName = "eX4akuWpKD9afhWN8gpYbk1UQRVGeT6q9QlLL4St0RhV6KdSsO2fKUxMoBriyYb61zvPjBcIHUY8RekKTAhSuM7Lo0VuZ1eCkX9fHokIFlVQAOjB0XTIEf02Fg3NvwAf7hOlSBfFEUcOQMXEYHzF8m9cIjwUyTMaVMoVAP5OP1CjryzsDN5Z0UkOPXKep1jFsPNeua1jB7iZEF7xhaxWIxTjjuPniB6yr4Okg2Udv9iXSqMQb8J",
                    CustomerId = "da2527b3-0369-451c-91d3-264ab7f167a2",
                    CustomerName = "eJic2mGuJKmsKLeWViwh5Xh0Ohe1EHst26OluNAixs6BC1rh1DjTMJERyJtkUyg63OuNEg3mOoFwMhlx1RPa6KYFReAbXhU3xeAmdgIIk86pUwNP4PXVypEGcP3yMzT6mxM4uuK6GdmBVGY71PucWuEB8iBjiFIbSubHrvAi7K4jy",
                    TransactionId = "f2b91d0b-d0e6-48bf-93b9-5c649e892ee7",
                    PrivateMoneyId = "e8344131-4f9d-47fc-b57e-6c5342a14181",
                    IsModified = false,
                    TransactionTypes = new string[]{"payment", "cashback", "topup", "transfer", "expire", "exchange"},
                    NextPageCursorId = "8c0f7836-23a0-46af-aabc-9e1f54a4f048",
                    PrevPageCursorId = "156e173b-31b3-4d0d-b48d-b5d508ccab2d",
                    PerPage = 607,
                    TransferTypes = new string[]{"cashback", "topup", "payment", "expire", "exchange", "coupon", "transfer"},
                    Description = "iuk2Hs0mRi4FH4wAH9Jfj7o054MsL4b1CJFFK6iXZLbDkWhxmVZQrN7vHF2MDKVtEIQupvmKHRwHKhrE1cew1CNfgi7sglFQ4wI7YctoKArmPX6ICAqae4Gsnk7CCks4Hk5SfM8qCg753Xc8s",
                    From = "2025-01-05T20:39:41.000000+09:00",
                    To = "2020-12-02T18:50:37.000000+09:00",
                };
                Response.PaginatedTransfersV2 response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

    }
}
