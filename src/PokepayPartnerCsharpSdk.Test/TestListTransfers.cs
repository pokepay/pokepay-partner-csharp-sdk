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
    public class TestListTransfers
    {
        private Client? client;

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
                Response.PaginatedTransfers response = await request.Send(client!);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.StatusCode!, (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.StatusCode >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListTransfers1()
        {
            try {
                Request.ListTransfers request = new Request.ListTransfers() {
                    Description = "xR4GA8B6QEvmEtQTqfIDfhF08aWAgYKgMRg4eijui0x4AzukqXii06wz9NdLnaFp0d8NnYZXWwwPUfmYGEVrOM4dkj0diMGxwkBMFBNKhTrrGkGVnz7dW1L5JRcqWGZoB7J2SLBuVTFPFKYeglUQAESlFenRvUgW2C0Pk55puUaBmR66mDvQf",
                };
                Response.PaginatedTransfers response = await request.Send(client!);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.StatusCode!, (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.StatusCode >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListTransfers2()
        {
            try {
                Request.ListTransfers request = new Request.ListTransfers() {
                    TransferTypes = new string[]{},
                    Description = "zEAz6sFhOXUyleHUBygYLLJFfbbjnOxn1",
                };
                Response.PaginatedTransfers response = await request.Send(client!);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.StatusCode!, (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.StatusCode >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListTransfers3()
        {
            try {
                Request.ListTransfers request = new Request.ListTransfers() {
                    TransactionTypes = new string[]{"payment"},
                    TransferTypes = new string[]{"coupon", "exchange"},
                    Description = "bDj1sJ7k6dP6L13ja9VovumOjMgFfs83kBzSot4H9G2QRAYPymeRfFOHsPVjb9UCbPcYx5YXiYOW0oa5SUOR88F7Ubd6EIlmfb",
                };
                Response.PaginatedTransfers response = await request.Send(client!);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.StatusCode!, (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.StatusCode >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListTransfers4()
        {
            try {
                Request.ListTransfers request = new Request.ListTransfers() {
                    IsModified = false,
                    TransactionTypes = new string[]{"exchange", "transfer"},
                    TransferTypes = new string[]{"exchange", "topup", "transfer", "campaign"},
                    Description = "h3aM3MFSn6Z9Xp0dYAIwKPnm62HiK775FUjJKUwWsCFULHC5xu9xwKzEEFrv0",
                };
                Response.PaginatedTransfers response = await request.Send(client!);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.StatusCode!, (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.StatusCode >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListTransfers5()
        {
            try {
                Request.ListTransfers request = new Request.ListTransfers() {
                    PrivateMoneyId = "c65b0a84-bb86-47f0-b5d6-b443a30c8b2f",
                    IsModified = false,
                    TransactionTypes = new string[]{"transfer", "exchange", "topup"},
                    TransferTypes = new string[]{"topup"},
                    Description = "xeKc6v3uyZaCEMZ2Ju8UbXHSU9E0Qlg3gebvAwjzG8UYapgA4DXNtjsg9PgQkXqYPn4dGIxCAVXu8wPFd",
                };
                Response.PaginatedTransfers response = await request.Send(client!);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.StatusCode!, (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.StatusCode >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListTransfers6()
        {
            try {
                Request.ListTransfers request = new Request.ListTransfers() {
                    TransactionId = "a3f148cd-adc9-4f2b-a2b0-bb676afc0c5d",
                    PrivateMoneyId = "535f40b8-6a52-42af-a0d8-ac39e593f147",
                    IsModified = false,
                    TransactionTypes = new string[]{"topup"},
                    TransferTypes = new string[]{"campaign", "exchange", "payment", "coupon", "transfer", "topup"},
                    Description = "H0runisLVA8D7RtvLwRN8QmXijHIyMGxrgTxrmP2c2b7AqdqrRaU4tsNqOUthYSxSa5qYfKcdpEzIZoGgQ8JT7nM2XSRS8qzeJVaYua2WPHw1UTjf1quigD2l2JnK33Y2",
                };
                Response.PaginatedTransfers response = await request.Send(client!);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.StatusCode!, (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.StatusCode >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListTransfers7()
        {
            try {
                Request.ListTransfers request = new Request.ListTransfers() {
                    CustomerName = "PKkmhgdj1RbwEdGAkTKdkwDZEgx5wET5OvQdZofRUOUAciXVcpzKCMcrOD6Emk2wkp2iXzqZDQWG9JIPYO9QhKjYAAaWngq9PQfQxKRvEszf3mWAEHwNafuFelOU7xCAyi0eUz4xXH",
                    TransactionId = "016dc3b5-d7cf-469c-8ce8-c2250cd9079e",
                    PrivateMoneyId = "4fdcc056-5e05-4eef-87c2-ad1ab99f2593",
                    IsModified = false,
                    TransactionTypes = new string[]{"payment"},
                    TransferTypes = new string[]{"coupon", "campaign"},
                    Description = "piSD0ualUMr1aiXbRr0Yt6Ont0eqhymEV4KDx3FmD9kbbli1vOnH69EFivIjA6JEHCCuKlnfNVTWFTkh4YZxFDhr8QjYlB42oGAhylpmFOwCdKPABZdrgh98R",
                };
                Response.PaginatedTransfers response = await request.Send(client!);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.StatusCode!, (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.StatusCode >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListTransfers8()
        {
            try {
                Request.ListTransfers request = new Request.ListTransfers() {
                    CustomerId = "4afd3c23-693e-4973-acc4-31bbf5a0a724",
                    CustomerName = "BuoJS",
                    TransactionId = "54834b5c-2549-4c46-95f2-4d29e2e821d4",
                    PrivateMoneyId = "f5f8a4d2-f1ee-49e5-b9a2-8631397a70f5",
                    IsModified = true,
                    TransactionTypes = new string[]{"topup", "exchange", "payment"},
                    TransferTypes = new string[]{},
                    Description = "Cce6NgXmM6SU8mT9N7YdoyhvI",
                };
                Response.PaginatedTransfers response = await request.Send(client!);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.StatusCode!, (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.StatusCode >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListTransfers9()
        {
            try {
                Request.ListTransfers request = new Request.ListTransfers() {
                    ShopName = "K96oQgvpt3OE4bGWfPwqWxwC3DU0ZYNIFrYHkTuOzrywGRNkAeSHinr7X7r9y8K62vZdczxzKDF7Ozzt",
                    CustomerId = "2b4181c9-483a-435e-baba-78401722ad20",
                    CustomerName = "dIBCYTSHrtKwDRbFJx9qY9kB8kVDqJMjy6rf4CluMJ3q8UHdGY9c6av2inoQmoszzzj7gjncZRjG49ZyE9d",
                    TransactionId = "301147bc-3a2f-4fc0-82fd-82b858b3ea40",
                    PrivateMoneyId = "f2e96a66-0843-4d9a-ba2f-42824b382693",
                    IsModified = false,
                    TransactionTypes = new string[]{"transfer", "exchange", "payment", "topup"},
                    TransferTypes = new string[]{"coupon", "transfer"},
                    Description = "lj4kfEe2uvMtiKxUivt9MIJ97msI3tB",
                };
                Response.PaginatedTransfers response = await request.Send(client!);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.StatusCode!, (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.StatusCode >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListTransfers10()
        {
            try {
                Request.ListTransfers request = new Request.ListTransfers() {
                    ShopId = "75bef93f-7005-4ce5-9d36-bc5f52ee8074",
                    ShopName = "0SO07EXHC5hQ61pWDcVyEH0QvPCR5IiYZhX71qxxCDFjWtGssb86D9XZfo8j2fPJCGzVYdohDRxcepsSsdecspEcH6zAIM8ju98Xf3eDqYA5vYg7TRPpd99WNI7yrXSKnnTIb76zTEtm8AaIiuGx9L9HalOMU5vigXX7Icn5jXA5QxJPbbGkUILhTXtRtmknLVk7hQOvzRC9zFhAU2LnJOGL09rrRBaBOdWWGJsxAr",
                    CustomerId = "ecf1ee67-a619-43a3-8926-165e06407c75",
                    CustomerName = "mMVdl31leH5Dl7ZUHzS51rJLdw2n2tQfnXr078yWrpzKRIJrBD5D7CpKjeG53Xpalhw5eupOSaoLetupiLJGKA08kULtDXm7mGq20CccqYOFtqhMLy1fSr",
                    TransactionId = "2b1ca2cf-2e83-413b-a711-2207d10f2627",
                    PrivateMoneyId = "4df4117e-0612-4887-897e-e12b4b8efaa6",
                    IsModified = false,
                    TransactionTypes = new string[]{},
                    TransferTypes = new string[]{"payment", "coupon"},
                    Description = "mwTeB7HbtOFrcDL7mosyloW0gLyNig5qU771SYwG9bLFfHIbs98VpOgmc8pS7WZiumuB2TNJcJGvSmksA1MuW1A79SIV",
                };
                Response.PaginatedTransfers response = await request.Send(client!);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.StatusCode!, (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.StatusCode >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListTransfers11()
        {
            try {
                Request.ListTransfers request = new Request.ListTransfers() {
                    PerPage = 1567,
                    ShopId = "8790a206-12be-4cab-9134-6ca74327ccd1",
                    ShopName = "caCTIuwp4PaSBE0QhobjzNQVW3hP0Ve0rN3Em7q1SjNjatjjDZX7RIKgDX3b9oA142xLkpis0qy5MfISyoLqEQKhMnAGBrL3KeptreugpuZPDhn3kvKQdinTisU7JGahMN0pspm5VBpWaMfH3OlTb5uoxVylmhf3ESdF0EHZGgpE19g89rUgV81h6fR4XXAReVSL8MjPf2nDJncUb7prKqWXHoSFTkZLdy8B9WWqNrXVXI1wRTqwqz",
                    CustomerId = "6b7b7356-1686-403c-bf24-b9bb6f2d752c",
                    CustomerName = "sahBGWwps3iARDJTRZkOOEQFC19Wtss23YjQBhHozeYJjV02y90GWowMI3ASCsApxBJptaJJRDQ6YTYkiFEIISprQ3cmpI6bh8YrVsWGSghDCw1Un7nnaTSFczRArCskatgTSAk3a",
                    TransactionId = "d27cdc88-5538-4389-9fad-97206d021994",
                    PrivateMoneyId = "eccd10e0-4ed4-40e3-88d4-9db09a3600a5",
                    IsModified = true,
                    TransactionTypes = new string[]{"transfer", "exchange", "topup", "payment"},
                    TransferTypes = new string[]{"topup", "transfer", "payment", "coupon", "campaign", "exchange"},
                    Description = "vEGRwH1gqt79bzapcrIrLur4lrAgRY4qmYCDpX8Ny7Ex4zLyYmVuuwRZjnfSOf90IL",
                };
                Response.PaginatedTransfers response = await request.Send(client!);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.StatusCode!, (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.StatusCode >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListTransfers12()
        {
            try {
                Request.ListTransfers request = new Request.ListTransfers() {
                    Page = 1129,
                    PerPage = 6706,
                    ShopId = "734ec046-c66e-47bd-8586-e53b5f3a5494",
                    ShopName = "5pCv1ztILSktq1cNxb1w0fAXCRcSE6z5QHSLVITcWyXkWwNeThLpKI1N6RIMY7t0u9TuR54ZsbCHGDImjW34z4jE8W9hhkpYWEzZLn5uyvbNkfkqdGOYba42tK1ETZVrimXQx2toEzw7Z1gM6fgx4uEjyIUvTVKqmlOa23scUcryj4GBWTbDzAVeKXVTyNRuvNAUp6ljdawfubjQ03lDRu1dHypEu4pqRk9KXyywxfAsvQQw8eNXwtP",
                    CustomerId = "6385eb40-9ae6-4027-9f3e-31cbdf6f8c88",
                    CustomerName = "W4UwDxtqXzHNdytk1inQrWiktMK0FHLyLnvzTdFf0Y1JODoBhEEJFs7RURiJHf6mnglgKA3t551AWYy2EKxgIvudVQKM3ivlyVYA6fe68jtm2G7nC3SW8MPeFKTYT7eEYLwvHQFKDImV0W8uMWRziTXMumFeaEHdh8PePoMZwnAEmuUL6pb761IWS7zT3jmF3X",
                    TransactionId = "3caba7be-3fcd-4c7a-8067-754b559c1f44",
                    PrivateMoneyId = "aeaf25be-9b4b-4bad-8d4f-262cf2905bb5",
                    IsModified = false,
                    TransactionTypes = new string[]{"exchange"},
                    TransferTypes = new string[]{"campaign", "coupon"},
                    Description = "MF41dYUnemzRdROKbGph7rDrumGN6tQ3vZwFKRF7w7plclcWB9bNRwQ0LABzLS5AginlSJbgCOpN21EzYv53e8C68gL6nh3hboA1VaXQqYz47H8v5OYX2Bb7kgjpYtpWxkJ26TN1VktFjJy7P",
                };
                Response.PaginatedTransfers response = await request.Send(client!);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.StatusCode!, (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.StatusCode >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListTransfers13()
        {
            try {
                Request.ListTransfers request = new Request.ListTransfers() {
                    To = "2019-01-09T15:47:03.000000+09:00",
                    Page = 5725,
                    PerPage = 5685,
                    ShopId = "38473e13-0853-4862-8b6b-e46feb7e297a",
                    ShopName = "4u4vqNtkYjPXUyJ1V0r5CHRNT2ecfLdc33OSn94wpSCBGnb27KI1Ko9Ro9P2UOPHKcZd7kJ0a09BOfpTrIxahzBDxgf0eAPjokEVHRFLghiMn2sJjV2bGnLruRc9c27Gp",
                    CustomerId = "483a2104-49f5-4e1f-b769-f65798fdfa62",
                    CustomerName = "08UbIXfaz",
                    TransactionId = "06d32ec9-e589-4e9a-976f-c3e74df9fa6a",
                    PrivateMoneyId = "3cdf125c-9e64-4da0-a1dc-3d782f481b9b",
                    IsModified = false,
                    TransactionTypes = new string[]{},
                    TransferTypes = new string[]{"campaign", "payment"},
                    Description = "phEzx62f8FNzaDel7ro4JT6XY3Y33ek4ahxmsrZJPb5B1K9ZLJjlQzrcG4cFx990D5go4dBLdUCSZVd4cTqnNfSRiXLw6IXx",
                };
                Response.PaginatedTransfers response = await request.Send(client!);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.StatusCode!, (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.StatusCode >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task ListTransfers14()
        {
            try {
                Request.ListTransfers request = new Request.ListTransfers() {
                    From = "2019-08-14T09:14:35.000000+09:00",
                    To = "2021-03-26T06:55:36.000000+09:00",
                    Page = 1845,
                    PerPage = 3344,
                    ShopId = "5c103d4e-0833-4ae0-a258-eb5c8fbae437",
                    ShopName = "yEerLNEKMYsRf9vriYiP8HndtLKgFWIeB413C8zcpa0a0ipuLt3",
                    CustomerId = "ab504349-7dd1-464b-9151-b9010663148b",
                    CustomerName = "b6fikVg8U3XBigR3jya01cL7edhmrVi5NIsblUeDquiQL8YRreNoLAWMJdywYSICtYcbHl2ktF16gpa54attROZcBbejZS9wdnnNKINI7vj8qEDPsdJ8JkL6K4fbUtzmymsdzvhUXmrc210VozYCz4wR9Gfv1ooHMcqzJF0zVNZ8zHF5mnetJol0g7uhhZVwBBSB9NQuG",
                    TransactionId = "3b92770b-6b3c-457f-bb09-158719436b14",
                    PrivateMoneyId = "ef847494-d531-4dae-b9b8-d90ebeae6aef",
                    IsModified = false,
                    TransactionTypes = new string[]{},
                    TransferTypes = new string[]{"payment"},
                    Description = "Cptr8X3OQSs9cvMVMzYpfEHHq4AVCPhpFJVl",
                };
                Response.PaginatedTransfers response = await request.Send(client!);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.StatusCode!, (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.StatusCode >= 300, "Should be larger than 300");
            }
        }

    }
}
