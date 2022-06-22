// DO NOT EDIT: File is generated by code generator.
using System;
using System.Net;
using System.Net.Http;
using NUnit.Framework;
using System.Threading.Tasks;

using PokepayPartnerCsharpSdk;

namespace PokepayPartnerCsharpSdk.Test
{
    public class TestCreateOrganization
    {
        private Client client;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            client = new Client("~/.pokepay/test-config.ini");
        }

        [Test]
        public async Task CreateOrganization0()
        {
            try {
                Request.CreateOrganization request = new Request.CreateOrganization(
                    "2NE9OohrFLhvABt92YjeNGkeRyZCxDw",
                    "yuzPdWfYw482S6oHFsZh9ksnqTSKQYaLtgBF21Mao0iMx72McbAtuQfbwPK5Ol2Udeu5ClBnNsqGtwvAjO8SQrjpTlUKU7ix6vD3BTnNcaIv4Cy",
                    new string[]{"eb110732-d01b-4e84-bb07-9a71c68d5516"},
                    "iGNeSDJueW@NAF2.com",
                    "iLhkB08mWo@SEw4.com"
                );
                Response.Organization response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task CreateOrganization1()
        {
            try {
                Request.CreateOrganization request = new Request.CreateOrganization(
                    "2NE9OohrFLhvABt92YjeNGkeRyZCxDw",
                    "yuzPdWfYw482S6oHFsZh9ksnqTSKQYaLtgBF21Mao0iMx72McbAtuQfbwPK5Ol2Udeu5ClBnNsqGtwvAjO8SQrjpTlUKU7ix6vD3BTnNcaIv4Cy",
                    new string[]{"eb110732-d01b-4e84-bb07-9a71c68d5516"},
                    "iGNeSDJueW@NAF2.com",
                    "iLhkB08mWo@SEw4.com"
                ) {
                    ContactName = "fnz5e3bjXKldANGzSZe49qKV1rholLnfHAgpNJKDDEjuzSmETPUL6TDRxNmjKWPDEzen9VEh9JKwUlzsxb9tQKSZdMATJHlP3s2aiyvcn732KUYpvpwWJTv2DUcmsWBTf3SfgLVNlOhNoRUioebBno3HZhnyNZ5Q77U04aLs4hmy4C28WnCRfz2leovb1R7O6QOgboW2zpcaLxa2QZma6CRo8n",
                };
                Response.Organization response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task CreateOrganization2()
        {
            try {
                Request.CreateOrganization request = new Request.CreateOrganization(
                    "2NE9OohrFLhvABt92YjeNGkeRyZCxDw",
                    "yuzPdWfYw482S6oHFsZh9ksnqTSKQYaLtgBF21Mao0iMx72McbAtuQfbwPK5Ol2Udeu5ClBnNsqGtwvAjO8SQrjpTlUKU7ix6vD3BTnNcaIv4Cy",
                    new string[]{"eb110732-d01b-4e84-bb07-9a71c68d5516"},
                    "iGNeSDJueW@NAF2.com",
                    "iLhkB08mWo@SEw4.com"
                ) {
                    BankAccountHolderName = "ﾗ",
                    ContactName = "9",
                };
                Response.Organization response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task CreateOrganization3()
        {
            try {
                Request.CreateOrganization request = new Request.CreateOrganization(
                    "2NE9OohrFLhvABt92YjeNGkeRyZCxDw",
                    "yuzPdWfYw482S6oHFsZh9ksnqTSKQYaLtgBF21Mao0iMx72McbAtuQfbwPK5Ol2Udeu5ClBnNsqGtwvAjO8SQrjpTlUKU7ix6vD3BTnNcaIv4Cy",
                    new string[]{"eb110732-d01b-4e84-bb07-9a71c68d5516"},
                    "iGNeSDJueW@NAF2.com",
                    "iLhkB08mWo@SEw4.com"
                ) {
                    BankAccount = "474481",
                    BankAccountHolderName = "ﾋ",
                    ContactName = "wJ1udEIb7zDJ6KZTEk0mDRGqd8jGih",
                };
                Response.Organization response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task CreateOrganization4()
        {
            try {
                Request.CreateOrganization request = new Request.CreateOrganization(
                    "2NE9OohrFLhvABt92YjeNGkeRyZCxDw",
                    "yuzPdWfYw482S6oHFsZh9ksnqTSKQYaLtgBF21Mao0iMx72McbAtuQfbwPK5Ol2Udeu5ClBnNsqGtwvAjO8SQrjpTlUKU7ix6vD3BTnNcaIv4Cy",
                    new string[]{"eb110732-d01b-4e84-bb07-9a71c68d5516"},
                    "iGNeSDJueW@NAF2.com",
                    "iLhkB08mWo@SEw4.com"
                ) {
                    BankAccountType = "other",
                    BankAccount = "27",
                    BankAccountHolderName = "ｿ",
                    ContactName = "3QYDG6CZS1PVe5LZzi2NmWBluHrzflOytNd3ROmH9nMfAHnX3LOs6P3dxLhDjrt4CFESWJnPCLUxGLtrgoghS3pPHE574eeX1ksH4R2MgyW6z149JBRZmQUgzecqWdDVSstoEtPVoykbtA6",
                };
                Response.Organization response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task CreateOrganization5()
        {
            try {
                Request.CreateOrganization request = new Request.CreateOrganization(
                    "2NE9OohrFLhvABt92YjeNGkeRyZCxDw",
                    "yuzPdWfYw482S6oHFsZh9ksnqTSKQYaLtgBF21Mao0iMx72McbAtuQfbwPK5Ol2Udeu5ClBnNsqGtwvAjO8SQrjpTlUKU7ix6vD3BTnNcaIv4Cy",
                    new string[]{"eb110732-d01b-4e84-bb07-9a71c68d5516"},
                    "iGNeSDJueW@NAF2.com",
                    "iLhkB08mWo@SEw4.com"
                ) {
                    BankBranchCode = "977",
                    BankAccountType = "saving",
                    BankAccount = "1718",
                    BankAccountHolderName = " ",
                    ContactName = "hWYdlIHfSBBKI1KQl4cK6HLesoN7AsxjaX4bkzoW5SSzFCKjOEE829PJZq44v95w5OTBAsM3ixdWcd35lzGg9k8zX5Zx6rdzZ6Kiw60EKpO7FL05ARSiRG2UPRPUxc",
                };
                Response.Organization response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task CreateOrganization6()
        {
            try {
                Request.CreateOrganization request = new Request.CreateOrganization(
                    "2NE9OohrFLhvABt92YjeNGkeRyZCxDw",
                    "yuzPdWfYw482S6oHFsZh9ksnqTSKQYaLtgBF21Mao0iMx72McbAtuQfbwPK5Ol2Udeu5ClBnNsqGtwvAjO8SQrjpTlUKU7ix6vD3BTnNcaIv4Cy",
                    new string[]{"eb110732-d01b-4e84-bb07-9a71c68d5516"},
                    "iGNeSDJueW@NAF2.com",
                    "iLhkB08mWo@SEw4.com"
                ) {
                    BankBranchName = "w9rvtxOfCP20hUm1E2Nlz5V1CO5TSFyNtopqI6bCrDgQ",
                    BankBranchCode = "409",
                    BankAccountType = "other",
                    BankAccount = "05",
                    BankAccountHolderName = "｣",
                    ContactName = "v10dzqDmxXKufPIjjJpzSXKPSRMVYMVxniANdM0yy6srRZNC9bYJUFWp4SJDd9Vw0ghvUwHY4GPMgqa4p3NBV6jnDEmNinmBAkCQlWqd4VgtaT7nx9nCCSGOYqsqY3PQB7j8S1LcJM99jV6h5DQ4TL9sXbFiutZ4wFjGxBLsRpox6uXLc6he8Kxv6FPaZ8I6AxiybIUdjn2JlMSQ6V8dRYSFDiggsas4Nm4Pbqn0MLycuAIyd8Tc91",
                };
                Response.Organization response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task CreateOrganization7()
        {
            try {
                Request.CreateOrganization request = new Request.CreateOrganization(
                    "2NE9OohrFLhvABt92YjeNGkeRyZCxDw",
                    "yuzPdWfYw482S6oHFsZh9ksnqTSKQYaLtgBF21Mao0iMx72McbAtuQfbwPK5Ol2Udeu5ClBnNsqGtwvAjO8SQrjpTlUKU7ix6vD3BTnNcaIv4Cy",
                    new string[]{"eb110732-d01b-4e84-bb07-9a71c68d5516"},
                    "iGNeSDJueW@NAF2.com",
                    "iLhkB08mWo@SEw4.com"
                ) {
                    BankCode = "1245",
                    BankBranchName = "A0BEPaxu5hz8quH88gYqQC45YQseyms9QyHVorEq6zLZyg",
                    BankBranchCode = "",
                    BankAccountType = "current",
                    BankAccount = "39240",
                    BankAccountHolderName = "\\",
                    ContactName = "e1DJRmWCvXV5f7NFxRTTWOKh4cp2t8rtdj0F82",
                };
                Response.Organization response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

        [Test]
        public async Task CreateOrganization8()
        {
            try {
                Request.CreateOrganization request = new Request.CreateOrganization(
                    "2NE9OohrFLhvABt92YjeNGkeRyZCxDw",
                    "yuzPdWfYw482S6oHFsZh9ksnqTSKQYaLtgBF21Mao0iMx72McbAtuQfbwPK5Ol2Udeu5ClBnNsqGtwvAjO8SQrjpTlUKU7ix6vD3BTnNcaIv4Cy",
                    new string[]{"eb110732-d01b-4e84-bb07-9a71c68d5516"},
                    "iGNeSDJueW@NAF2.com",
                    "iLhkB08mWo@SEw4.com"
                ) {
                    BankName = "huu2d72PSRBNNGTP71wcJLJGkIvTZnRNAv7oeQjUe",
                    BankCode = "",
                    BankBranchName = "z1G0bwCFurxmaLHHuXDOcuycP",
                    BankBranchCode = "",
                    BankAccountType = "other",
                    BankAccount = "04",
                    BankAccountHolderName = "6",
                    ContactName = "yWZt9ZjHKqLir6qmCF3zfoEN4hG6jzrPFiN4YTSJ9o4hVc0u6tzaZ3sbYKCNybmAlkaNJiOvuRswwQSmiJco3KwhjqpMqyENnnotJKNM2DvQSu06FE8juzeNINZktFZU0JpHpSrpNbF8O3WzYFSGY9bWV5jbNBEz14f9BIpTXI2luGWaGy1CoCYoYmaLr1BLYdgsrsB7nf3z7z76OYqLZhd2VmnwZ1YQA",
                };
                Response.Organization response = await request.Send(client);
                Assert.NotNull(response, "Shouldn't be null at least");
            } catch (HttpRequestException e) {
                Assert.AreNotEqual((int) e.Data["StatusCode"], (int) HttpStatusCode.BadRequest, "Shouldn't be BadRequest");
                Assert.True((int) e.Data["StatusCode"] >= 300, "Should be larger than 300");
            }
        }

    }
}
