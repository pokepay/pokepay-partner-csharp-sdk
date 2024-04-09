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
    public class TestListBills
    {
        private Client client;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            client = new Client("~/.pokepay/test-config.ini");
        }

        [Test]
        public async Task ListBills0()
        {
            try {
                Request.ListBills request = new Request.ListBills();
                Response.PaginatedBills response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListBills1()
        {
            try {
                Request.ListBills request = new Request.ListBills() {
                    IsDisabled = false,
                };
                Response.PaginatedBills response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListBills2()
        {
            try {
                Request.ListBills request = new Request.ListBills() {
                    UpperLimitAmount = 3460,
                    IsDisabled = false,
                };
                Response.PaginatedBills response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListBills3()
        {
            try {
                Request.ListBills request = new Request.ListBills() {
                    LowerLimitAmount = 3003,
                    UpperLimitAmount = 2795,
                    IsDisabled = true,
                };
                Response.PaginatedBills response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListBills4()
        {
            try {
                Request.ListBills request = new Request.ListBills() {
                    ShopId = "a9696cec-9a6a-4ba0-b1b1-beff32bea9d1",
                    LowerLimitAmount = 6740,
                    UpperLimitAmount = 874,
                    IsDisabled = false,
                };
                Response.PaginatedBills response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListBills5()
        {
            try {
                Request.ListBills request = new Request.ListBills() {
                    ShopName = "kgNdosrcsbqXkWqVhxkWkSbCcQV2KWKaXCJgJ38wW32AKvILX828FihWZQyqSbK0FMXzQI3K0upT8cYYAuEa7VHyo1Pr6ZXG8JSWzel5X6ggilnbIikjMsDtvgyHs8kX",
                    ShopId = "52fbc519-17e0-450f-a1fb-f1be62dd6c3d",
                    LowerLimitAmount = 6587,
                    UpperLimitAmount = 4324,
                    IsDisabled = true,
                };
                Response.PaginatedBills response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListBills6()
        {
            try {
                Request.ListBills request = new Request.ListBills() {
                    CreatedTo = "2021-06-15T05:13:23.000000+09:00",
                    ShopName = "tCOu5vNtx3bBib1BS1IIGWD4mpTYqNNFPcbcfJ8JMK49acl",
                    ShopId = "cbef9865-d3d6-4852-b37c-6b70d28869e3",
                    LowerLimitAmount = 868,
                    UpperLimitAmount = 2036,
                    IsDisabled = false,
                };
                Response.PaginatedBills response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListBills7()
        {
            try {
                Request.ListBills request = new Request.ListBills() {
                    CreatedFrom = "2020-05-14T12:28:11.000000+09:00",
                    CreatedTo = "2024-03-24T00:30:45.000000+09:00",
                    ShopName = "tmURvImdniels4ZrQj5DbpL3fJFTwwcn9WP3m8VyuReCXx5WTYs7Yv5KDLwBcz7zjgazophuiC1VR8XiXW8JGdOuAk94khcXRAwlFr4tlYuwMI02c6YHU8uGe8qGN",
                    ShopId = "1d2bbcf6-f616-4187-946d-ee24a6e9495d",
                    LowerLimitAmount = 7489,
                    UpperLimitAmount = 7853,
                    IsDisabled = true,
                };
                Response.PaginatedBills response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListBills8()
        {
            try {
                Request.ListBills request = new Request.ListBills() {
                    Description = "tH06f3cpkGDNNhHR4jcwCrCwplpzKOK41muEKIO2q9f6dQ5BvDAnz25uvrmGGKjRYVWTh4n3trK0bvzHyQJ1u0mKrSXl5b4zkBhHXIiOwN14umNbs9HzTMzg2AFGgoFwChMKyFjnp6NWuVTvukHEJJxjvwAaSkrlPscgFZA7kgmnQGh0g7x",
                    CreatedFrom = "2022-02-22T17:09:50.000000+09:00",
                    CreatedTo = "2023-09-23T15:25:45.000000+09:00",
                    ShopName = "0gjIfqsy3qqeO2uL3gmJXocI00jDfhi9n",
                    ShopId = "fd3b47eb-2dfc-4487-99fb-f6af6952f0dc",
                    LowerLimitAmount = 5451,
                    UpperLimitAmount = 8442,
                    IsDisabled = true,
                };
                Response.PaginatedBills response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListBills9()
        {
            try {
                Request.ListBills request = new Request.ListBills() {
                    OrganizationCode = "-X-9",
                    Description = "AWVHYRkMJaQT0YWfQtgxVhq9RVZQG6j5A2pjVon4uuDqic8AnsoXtmv8LerXQe8LjF8Q6qvpD5ZbBwXFvQ1skGDixXFJczCMVyjlRecAjobCopZKVFLb9UiV0XEm",
                    CreatedFrom = "2022-09-10T23:11:39.000000+09:00",
                    CreatedTo = "2021-02-13T02:56:52.000000+09:00",
                    ShopName = "9iB2syyuELfawMoOZtkTktpas3rTKhS7CSUreJUtTC5W6xtdNcZmGzg6LOAwdB03Wi69g5bppku3R9lJVdDaUu8gKI7uxlsX8tJT",
                    ShopId = "f599f724-1dd6-4f25-8e9a-8231f2b0485f",
                    LowerLimitAmount = 3970,
                    UpperLimitAmount = 9367,
                    IsDisabled = true,
                };
                Response.PaginatedBills response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListBills10()
        {
            try {
                Request.ListBills request = new Request.ListBills() {
                    PrivateMoneyId = "76cb48ab-1022-4981-b43e-d1c122a753f6",
                    OrganizationCode = "iTiTkm9kUT0GB-p9y-O3MH-3KR--",
                    Description = "5Urh2rbZx2aArvrKFEW0caD1nqOzKQjZCyx1Ep4V",
                    CreatedFrom = "2021-03-17T00:57:33.000000+09:00",
                    CreatedTo = "2020-10-18T20:14:57.000000+09:00",
                    ShopName = "mGgvgI7YgVKC9RfQiSpTWZrd0hVSBtTuiSKN3fmfJoVUvvyWz4acD4YN59s59xIWG",
                    ShopId = "bf8dab2c-ba87-45bf-8275-e96a11ee4fe3",
                    LowerLimitAmount = 7962,
                    UpperLimitAmount = 7066,
                    IsDisabled = true,
                };
                Response.PaginatedBills response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListBills11()
        {
            try {
                Request.ListBills request = new Request.ListBills() {
                    BillId = "FFrrXyLyM",
                    PrivateMoneyId = "967b698e-4ccf-4173-a274-e440aeed4465",
                    OrganizationCode = "e-rUFv-xFCvH54G51-",
                    Description = "t7Q5BMcC1v73v60y8DMLWrlnr061xWZsz",
                    CreatedFrom = "2020-09-12T06:07:45.000000+09:00",
                    CreatedTo = "2022-03-16T12:50:50.000000+09:00",
                    ShopName = "ogogHitDMic7XGDhIwoiIw8buBfBCDG7j4DoWkpZIbqBi9TROGFtlR9rLj2Y1ER9gKdUSrcKHlFd3Ur1MCMIUROIYftW7",
                    ShopId = "851944d1-637b-4de0-a2cd-9d8271642a8f",
                    LowerLimitAmount = 5132,
                    UpperLimitAmount = 1439,
                    IsDisabled = false,
                };
                Response.PaginatedBills response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListBills12()
        {
            try {
                Request.ListBills request = new Request.ListBills() {
                    PerPage = 7626,
                    BillId = "bzCAj1GsSv",
                    PrivateMoneyId = "c24c2166-3189-461c-987e-f204c0bb4a9f",
                    OrganizationCode = "T1--v-G724-7qs-0fqD1J46-L",
                    Description = "z7mGpF3omDB92rueqlmfnAfu7erS3gFr3FTdQ8rwckpkfwdxwxZ95sfTG55oAI4VCG4sTwcYeFwcP7ZmLygXYRtjxN2aIco6xNkWo0aYr1y1KHCmQGL0IM3EaCDd87kJG01a7GOWj7LV4v5yot",
                    CreatedFrom = "2020-03-03T04:15:12.000000+09:00",
                    CreatedTo = "2022-03-06T13:34:32.000000+09:00",
                    ShopName = "Rj2vkjikjfOo5Zy9zD8cfycxdjXF6cmwiKvevzAx7rHin0MHYFpvhqZUg2yG4Wo0L4evFZLjpsodOQD43fZ5T5bk20dIuBp2e25agSXyEGick",
                    ShopId = "40f3ab70-3e8b-4265-9c7d-d67a288d4ce5",
                    LowerLimitAmount = 4023,
                    UpperLimitAmount = 7414,
                    IsDisabled = false,
                };
                Response.PaginatedBills response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListBills13()
        {
            try {
                Request.ListBills request = new Request.ListBills() {
                    Page = 873,
                    PerPage = 3868,
                    BillId = "ltNB5ed",
                    PrivateMoneyId = "d153fbea-8674-44b1-b5b7-49135a97ff9c",
                    OrganizationCode = "",
                    Description = "9wlEEj2gZC8ckmFOzWRdKb11QTIHM0x5oJQ4O2Nwel4rHJTDGFvqXggC9Tcy7ogKmUw0VnsFyzfyt6Bg95FB1a7IFTBkW9tPubyeqITUoc54HWI6lY3NxA2Qq6LVyn2dOGJj5BoyL1MgjctfisL",
                    CreatedFrom = "2024-03-27T07:23:33.000000+09:00",
                    CreatedTo = "2023-01-07T18:05:13.000000+09:00",
                    ShopName = "o4aorO",
                    ShopId = "272f828f-a7a0-4ef7-86af-8b824979cc72",
                    LowerLimitAmount = 2925,
                    UpperLimitAmount = 1053,
                    IsDisabled = true,
                };
                Response.PaginatedBills response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

    }
}
