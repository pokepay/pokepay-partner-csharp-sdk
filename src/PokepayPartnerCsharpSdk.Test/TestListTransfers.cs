// DO NOT EDIT: File is generated by code generator.
using System;
using System.Net;
using System.Net.Http;
using NUnit.Framework;
using System.Threading.Tasks;

using PokepayPartnerCsharpSdk;

namespace PokepayPartnerCsharpSdk.Test
{
    public class TestListTransfers
    {
        private Client client;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            client = new Client("~/.pokepay/test-config.ini");
        }

        [Test]
        public async Task ListTransfers0()
        {
            try {
                Request.ListTransfers request = new Request.ListTransfers();
                Response.PaginatedTransfers response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListTransfers1()
        {
            try {
                Request.ListTransfers request = new Request.ListTransfers() {
                    Description = "2oGAhylpmFOwCdKPABZdrgh98RslDBuoJSIFUrTRne91u8KmONYXCce6NgXmM6SU8mT9N7YdoyhvIOK96oQgvpt3OE4bGWfPwqWxwC3DU0ZYNIFrYHkTuOzrywGRNkAeSHinr7X7r9y8K62vZdczxzKDF7OzztIRdIBCYTSHrtKwDRbFJx9qY",
                };
                Response.PaginatedTransfers response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListTransfers2()
        {
            try {
                Request.ListTransfers request = new Request.ListTransfers() {
                    TransferTypes = new string[]{"payment", "topup", "campaign"},
                    Description = "qJMjy6rf4CluMJ3q8UHdGY9c6av2inoQmoszzzj7gjncZRjG49ZyE9dB8fCGfTM2Oyolj4kfEe2uvMtiKxUivt9MIJ97msI3tBe6ti0SO07EXHC5hQ61pWDcVyEH0QvPCR5IiYZhX71qxxCDFjWtGssb86D9XZfo8j2fPJCGzVYdohDRxcepsSsdecspEcH6zAIM8",
                };
                Response.PaginatedTransfers response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListTransfers3()
        {
            try {
                Request.ListTransfers request = new Request.ListTransfers() {
                    TransactionTypes = new string[]{"transfer"},
                    TransferTypes = new string[]{"coupon", "payment", "exchange", "campaign", "transfer", "topup"},
                    Description = "eDqYA5vYg7TRPpd99WNI7yrXSKnnTIb76zTEtm8AaIiuGx9L9HalOMU5vigXX7Icn5jXA5QxJPbbGkUILhTXtRtmknLVk7hQOvzRC9zFhAU2LnJOGL09rrRBaBOdWWGJsxArgIuumMVdl31leH5Dl7ZUHzS51rJLdw2n2tQfnXr078yWrpzK",
                };
                Response.PaginatedTransfers response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListTransfers4()
        {
            try {
                Request.ListTransfers request = new Request.ListTransfers() {
                    IsModified = true,
                    TransactionTypes = new string[]{"payment", "topup", "transfer"},
                    TransferTypes = new string[]{"payment", "transfer", "coupon", "campaign"},
                    Description = "D7CpKjeG53Xpalhw5eupOSaoLetupiLJGKA08kULtDXm7mGq20CccqYOFtqhMLy1fSrOZfnZ2mwTeB7HbtOFrcDL7mosyloW0gLyNig5qU771SYwG9bLFfHIbs98VpOgmc8pS7WZiumuB2TNJcJGvSmksA1MuW1A79SIV4QucaCTIuwp4PaSBE",
                };
                Response.PaginatedTransfers response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListTransfers5()
        {
            try {
                Request.ListTransfers request = new Request.ListTransfers() {
                    PrivateMoneyId = "5defb7dc-e630-4f51-91aa-e6206e0d8c68",
                    IsModified = true,
                    TransactionTypes = new string[]{"exchange", "topup"},
                    TransferTypes = new string[]{"exchange", "payment", "transfer"},
                    Description = "P0Ve0rN3Em7q1SjNjatjjDZX7RIKgDX3b9oA142xLkpis0qy5MfISyoLqEQKhMnAGBrL3KeptreugpuZPDhn3kvKQdinTisU7JGahMN0p",
                };
                Response.PaginatedTransfers response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListTransfers6()
        {
            try {
                Request.ListTransfers request = new Request.ListTransfers() {
                    TransactionId = "06036012-ef27-4473-b02d-5e2e261ddc6d",
                    PrivateMoneyId = "e44fffdc-96a2-4d21-b5d6-10408dcea042",
                    IsModified = true,
                    TransactionTypes = new string[]{"topup", "exchange", "payment"},
                    TransferTypes = new string[]{"topup", "payment", "exchange", "coupon"},
                    Description = "OlTb5uox",
                };
                Response.PaginatedTransfers response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListTransfers7()
        {
            try {
                Request.ListTransfers request = new Request.ListTransfers() {
                    CustomerName = "ylmhf3ESdF0EHZGgpE19g89rUgV81h6fR4XXAReVSL8MjPf2nDJncUb7prKqWXHoSFTkZLdy8B9WWqNrXVXI1wRTqwqzVsahBGWwps3iARDJTRZkOOEQFC19Wtss23YjQBhHozeYJjV02y90GWowMI3ASCsApxBJptaJJRDQ6YTYkiFEIISprQ3cmpI6bh8YrVsWGSghDCw1Un7nnaTSFcz",
                    TransactionId = "fa61d65e-5ad2-4b0f-84a6-b7c15fae663e",
                    PrivateMoneyId = "45eefbf2-34c0-49c3-b398-8c98a36ef96b",
                    IsModified = false,
                    TransactionTypes = new string[]{"topup", "transfer"},
                    TransferTypes = new string[]{"coupon", "payment", "campaign"},
                    Description = "8TcT02JvhzyAvEGRwH1gqt79bzapcrIrLur4lrAgRY4qmYCDpX8Ny7Ex4zLyYmVuuwRZjnfSOf90ILh1FnEv5pCv1ztILSktq1cNxb1w0fAXCRcSE6z5QHSLVITcWyXkWwNeThLpK",
                };
                Response.PaginatedTransfers response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListTransfers8()
        {
            try {
                Request.ListTransfers request = new Request.ListTransfers() {
                    CustomerId = "876a9809-c249-41b1-ad0c-e0a9ee74334e",
                    CustomerName = "6RIMY7t0u9TuR54ZsbCHGDImjW34z4jE8W9hhkpYWEzZLn5uyvbNkfkqdGOYba42tK1ETZVrimXQx2toEzw7Z1gM6fgx4uEjyIUvTVKqmlOa23scUcryj4GBWTbDzAVeKXVTyNRuvNAUp6ljdawfubjQ",
                    TransactionId = "2af6c1b0-51b3-48ec-8452-6e0e9b19ab75",
                    PrivateMoneyId = "41ac542e-382f-4afc-b1e4-b3c863c8b779",
                    IsModified = true,
                    TransactionTypes = new string[]{"topup", "transfer", "payment", "exchange"},
                    TransferTypes = new string[]{"campaign", "topup"},
                    Description = "KXyywxfAsvQQw8eNXwtPfKAW4UwDxtqXzHNdytk1inQrWiktMK0FHLyLnv",
                };
                Response.PaginatedTransfers response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListTransfers9()
        {
            try {
                Request.ListTransfers request = new Request.ListTransfers() {
                    ShopName = "zTdFf0Y1JODoBhEEJFs7RURiJHf6mnglgKA3t551AWYy2EKxgIvudVQKM3ivlyVYA6fe68jtm2G7nC3SW8MPeFKTYT7eEYLwvHQFKDImV0W8uMWRziTXMumFeaEHdh8PePoMZwnAEmuUL6pb761IWS7zT3jmF3XMzgKDKO5o6UqQsbMF41dYUnemzRdROKbGph7rDrumGN6tQ3vZwFKRF7w7plclc",
                    CustomerId = "5453c93d-a357-4c1e-823f-1539a73224e2",
                    CustomerName = "RwQ0LABzLS5AginlSJbgCOpN21EzYv53e8C68gL6nh3hboA1VaXQqYz47H8v5OYX2Bb7kgjpYtpWxkJ26TN1VktFjJy7P4SbKkoz4u4vqNtkYjPXUyJ1V0r5CHRNT2ecfLdc33OSn94wpSCBGnb27KI1Ko9Ro9P2UOPHKcZd7kJ0a09BOfpTrIxahzBDxgf0eAPjokEVHRFLghi",
                    TransactionId = "d997c8cd-3f6e-4632-b3fc-714a0641499e",
                    PrivateMoneyId = "63a04897-b8ea-4040-af2f-fe9ed9503656",
                    IsModified = false,
                    TransactionTypes = new string[]{"topup", "exchange", "payment"},
                    TransferTypes = new string[]{"exchange", "coupon", "campaign", "topup", "transfer", "payment"},
                    Description = "ruRc9c27Gpu7iWb08UbIXfazIWogjdxJNEfM7ZphEzx62f8FNzaDel7ro4JT6XY3Y33ek4ahxmsrZ",
                };
                Response.PaginatedTransfers response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListTransfers10()
        {
            try {
                Request.ListTransfers request = new Request.ListTransfers() {
                    ShopId = "33a76fca-6319-4950-a697-8a1c6049173e",
                    ShopName = "5B1K9ZLJjlQzrcG4cFx990D5go4dBLdUCSZVd4cTqnNfSRiXLw6IXxof4N3bX72yEerLNEKMYsRf9vriYiP8HndtLKgFWIeB413",
                    CustomerId = "799b06c3-9211-40be-a038-9085dc694123",
                    CustomerName = "cpa0a0ipuLt3IQKQQHb6fikVg8U3XBigR3jya01cL7edhmrVi5NIsblUeDquiQL8YRreNoLAWMJdywYSICtYcbHl2ktF16gpa54attROZcBbejZS9wdnnNKINI7vj8qEDPsdJ8JkL6K4fbUtzmymsdzvhUXmrc210VozYCz4wR9Gfv1ooHMcqzJF0zVNZ8zHF5mnetJol0g7uhhZVwBBSB9NQuG198o4cE8ye8xiCptr8X3OQSs9cvMVMzY",
                    TransactionId = "c3d1d870-a966-4212-85dd-cd97d3e45e48",
                    PrivateMoneyId = "80eade27-eb48-4e3d-8871-622f0dd002b4",
                    IsModified = false,
                    TransactionTypes = new string[]{"transfer", "payment", "exchange"},
                    TransferTypes = new string[]{},
                    Description = "FJVl2NE9OohrFLhvABt92YjeNGkeRyZCxDwnyuzPdWfYw482S6oHFsZh9ksnqTSKQYaLtgBF21Mao0iMx72McbAtuQfbwPK5Ol2Udeu5ClBnNsqGtwvAjO8SQrjpTlUKU7ix6vD3BTnNcaIv4Cy2qiGNeSDJueWNAF2i",
                };
                Response.PaginatedTransfers response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListTransfers11()
        {
            try {
                Request.ListTransfers request = new Request.ListTransfers() {
                    PerPage = 5797,
                    ShopId = "871888af-c65c-4c4c-a268-8815f2f6f8eb",
                    ShopName = "08mWoSEw4Yfnz5e3bjXKldANGzSZe49qKV1rholLnfHAgpNJKDDEjuzSmETPUL6TDRxNmjKWPDEzen9VEh9JKwUlzsxb9tQKSZdMATJHlP3s2aiyvcn732KUYpvpwWJTv2DUcmsWBTf3SfgLVNlOhNoRUioebBno3HZhnyNZ5Q77U04aLs4hmy4C28WnCRfz2le",
                    CustomerId = "4ae879fd-7827-4cef-8f23-4429c76517f6",
                    CustomerName = "b1R7O6QOgboW2zpcaLxa2QZma6CRo8nyJO9Y3f9djMgk8QSZwJ1udEIb7zDJ6KZTEk0mDRGqd8jGihF2zo2GN3QYDG6CZS1PVe5LZzi2NmWBluHrzflOytNd3ROmH9nMfAHnX3LOs6P3dxLh",
                    TransactionId = "6c8469c4-04a1-48ea-8a90-18726158bdf4",
                    PrivateMoneyId = "e0f8fc21-5d34-48af-838c-f146147b01bc",
                    IsModified = false,
                    TransactionTypes = new string[]{"topup", "exchange", "transfer"},
                    TransferTypes = new string[]{},
                    Description = "CLUxGLtrgoghS3pPHE574eeX1ksH4R2MgyW6z149JBRZmQUgzecqWdDVSstoEtPVoykbtA6l7WDayqQLAKXyhWYdlIHfSBBKI1KQl4cK6HLesoN7AsxjaX4bkzoW5SSzFCKjOEE829PJZq44v95w5O",
                };
                Response.PaginatedTransfers response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListTransfers12()
        {
            try {
                Request.ListTransfers request = new Request.ListTransfers() {
                    Page = 2517,
                    PerPage = 9599,
                    ShopId = "eb9908a8-81c2-40c1-a2bb-b391414d2da6",
                    ShopName = "M3ixdWcd35lzGg9k8zX5Zx6rdzZ6Kiw60EKpO7FL05ARSiRG2UPRPUxcw9rvtxOfCP20hUm1E2Nlz5V1CO5TSFyNtopqI6bCrDgQTiBz8hopleWuv10d",
                    CustomerId = "67091fba-8226-4282-99a5-1efaf306fef1",
                    CustomerName = "DmxXKufPIjjJpzSXKPSRMVYMVxniANdM0yy6srRZNC9bYJUFWp4SJDd9Vw0ghvUwHY4GPMgqa4p3NBV6jnDEmNinmBAkCQlWqd4VgtaT7nx9nCCSGOYqsqY3PQB7j8S",
                    TransactionId = "a7345bbb-62b1-499e-8ce3-58ca66371e9e",
                    PrivateMoneyId = "30e7b8cd-27b9-40bb-9db9-deac0078acea",
                    IsModified = false,
                    TransactionTypes = new string[]{},
                    TransferTypes = new string[]{"campaign", "topup", "transfer", "exchange", "coupon", "payment"},
                    Description = "TL9sXbFiutZ4wFjGxBLsRpox6uXLc6he8Kxv6FPaZ8I6AxiybIUdjn2JlMSQ6V8dRYSFDiggsas4Nm4Pbqn0MLycuAIyd8Tc91YrDumA0BEPaxu5hz8quH88gYqQC45YQseyms9QyHVorEq6zL",
                };
                Response.PaginatedTransfers response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListTransfers13()
        {
            try {
                Request.ListTransfers request = new Request.ListTransfers() {
                    To = "2019-10-21T10:05:21.000000+09:00",
                    Page = 1115,
                    PerPage = 5288,
                    ShopId = "4b788af9-2519-4e03-88e7-03888de2041b",
                    ShopName = "3cEPs9bN7e1DJRmWCvXV5f7NFxRTTWOKh4cp2t8rtdj0F82hhuu2d72PSRBNNGTP71wcJLJGkIvTZnRNAv7oeQjUez1G0bwCFurxmaLHHuXDOcuycPW2WYY40yWZt9ZjHKqLir6qmCF3zfoEN4hG6jzrPFiN4YTSJ9o4hVc0u6",
                    CustomerId = "ccb3c780-4174-418b-ba61-e87d22ab14da",
                    CustomerName = "sbYKCNybmAlkaNJiOvuRswwQSmiJco3KwhjqpMqyENnnotJKNM2D",
                    TransactionId = "12d3dc8a-4aab-45f6-bcd1-828bc24caba8",
                    PrivateMoneyId = "9a665627-9c18-4e05-9375-102d7c8ec127",
                    IsModified = false,
                    TransactionTypes = new string[]{},
                    TransferTypes = new string[]{"topup", "payment", "transfer", "campaign", "coupon"},
                    Description = "juzeNINZktFZU0JpHpSrpNbF8O3WzYFSGY9bWV5jbNBEz14f9BIpTXI2l",
                };
                Response.PaginatedTransfers response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListTransfers14()
        {
            try {
                Request.ListTransfers request = new Request.ListTransfers() {
                    From = "2018-08-29T05:59:38.000000+09:00",
                    To = "2019-12-16T09:56:17.000000+09:00",
                    Page = 9304,
                    PerPage = 1724,
                    ShopId = "50302847-7425-44df-922e-471d3548a9f9",
                    ShopName = "CoCYoYmaLr1BLYdgsrsB7nf3z7z76OYqLZhd2VmnwZ1YQAtf2GPfHYeeJWiJLn1TOWVNqKCYgaN6maSZWJn127yVjYZzSkjksojB4PnV9sBfF1BkHf1A87wLQ9bOIRS2WYI5ck8HRSP5FHw4UX4tGWi4N1WpwhPzDe8V1DYdcKn6nAl4cE",
                    CustomerId = "e2da2758-8c8d-4984-9737-dbb1b95fe508",
                    CustomerName = "br7jv7EDkwXN76HyKk1SGbd2fzw9nBiKXYeHN7C4dOhcXyEVzhZku2OJwUM0ktk1yse4CdNhZgpKbkXWC5tLFNUhqVPCyC44juCu9OYkti8QhcNElbkx4K7ompotaJBLyz8",
                    TransactionId = "f05a7acb-518d-4c4e-b137-35ba7a0e1d27",
                    PrivateMoneyId = "fb74bc66-724c-4bf8-908e-ec1a4f26a319",
                    IsModified = false,
                    TransactionTypes = new string[]{"exchange", "transfer", "topup"},
                    TransferTypes = new string[]{"transfer", "campaign", "coupon", "payment"},
                    Description = "oJnH6hOfBgmDSuxOmphkziTG6p4HsLeIcNrFvlQBIX1JBgnrD1yLFl",
                };
                Response.PaginatedTransfers response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

    }
}
