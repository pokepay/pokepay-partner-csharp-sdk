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
                    "lf9tWgAr9KxjsUzeefEvU98BI4BdtnYV",
                    "OF5IXA6lNw66Yqs62ry4EX0H5SsjBGi2vt3IVLujfoeXIyA6Ao821XE55hc29pv4sZBooZY5wA4Og2kdAYLVTxSOsaSsUmdY0CLcfoUMFSIdEJMG98zC6otpSw3LnpbrPkZnNjPWO55U7DSfY3LgW5M2IvR52CgIBy3eLTys12HHDFFeqLoUtYmfM0XLYceQxhubY3j",
                    new string[]{"64a0b0a8-5d1c-40d9-a8e2-5ce8d2e01834", "16a08f52-da8d-4aac-800c-6fd7a610f6a4", "247d36b4-6253-4c6a-8a93-9e8d1f5d381c", "ecc14663-4550-45fb-ba11-e902cb2525c8", "c8d9e640-ba75-4eb2-a7ab-2349b7c11470", "89431037-fa0f-4c48-9084-bc907a7f636c", "b33c8493-5392-439f-8367-97f8457d80bc"},
                    "YlFZzBuHZ8@tjsh.com",
                    "68ScZg3aAM@ErPc.com"
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
                    "lf9tWgAr9KxjsUzeefEvU98BI4BdtnYV",
                    "OF5IXA6lNw66Yqs62ry4EX0H5SsjBGi2vt3IVLujfoeXIyA6Ao821XE55hc29pv4sZBooZY5wA4Og2kdAYLVTxSOsaSsUmdY0CLcfoUMFSIdEJMG98zC6otpSw3LnpbrPkZnNjPWO55U7DSfY3LgW5M2IvR52CgIBy3eLTys12HHDFFeqLoUtYmfM0XLYceQxhubY3j",
                    new string[]{"64a0b0a8-5d1c-40d9-a8e2-5ce8d2e01834", "16a08f52-da8d-4aac-800c-6fd7a610f6a4", "247d36b4-6253-4c6a-8a93-9e8d1f5d381c", "ecc14663-4550-45fb-ba11-e902cb2525c8", "c8d9e640-ba75-4eb2-a7ab-2349b7c11470", "89431037-fa0f-4c48-9084-bc907a7f636c", "b33c8493-5392-439f-8367-97f8457d80bc"},
                    "YlFZzBuHZ8@tjsh.com",
                    "68ScZg3aAM@ErPc.com"
                ) {
                    ContactName = "V9o0TcGJkIJgRMahTjY4B83KCbssdnciBK2yKUyBpazsF",
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
                    "lf9tWgAr9KxjsUzeefEvU98BI4BdtnYV",
                    "OF5IXA6lNw66Yqs62ry4EX0H5SsjBGi2vt3IVLujfoeXIyA6Ao821XE55hc29pv4sZBooZY5wA4Og2kdAYLVTxSOsaSsUmdY0CLcfoUMFSIdEJMG98zC6otpSw3LnpbrPkZnNjPWO55U7DSfY3LgW5M2IvR52CgIBy3eLTys12HHDFFeqLoUtYmfM0XLYceQxhubY3j",
                    new string[]{"64a0b0a8-5d1c-40d9-a8e2-5ce8d2e01834", "16a08f52-da8d-4aac-800c-6fd7a610f6a4", "247d36b4-6253-4c6a-8a93-9e8d1f5d381c", "ecc14663-4550-45fb-ba11-e902cb2525c8", "c8d9e640-ba75-4eb2-a7ab-2349b7c11470", "89431037-fa0f-4c48-9084-bc907a7f636c", "b33c8493-5392-439f-8367-97f8457d80bc"},
                    "YlFZzBuHZ8@tjsh.com",
                    "68ScZg3aAM@ErPc.com"
                ) {
                    BankAccountHolderName = "｢",
                    ContactName = "yPhoCqWWrzikH0DrThI9ndCARX9iZhUIwUrsQ8Uijo55dyiBxXbKWYhqIQcADAJhWFwASll2hGkEz",
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
                    "lf9tWgAr9KxjsUzeefEvU98BI4BdtnYV",
                    "OF5IXA6lNw66Yqs62ry4EX0H5SsjBGi2vt3IVLujfoeXIyA6Ao821XE55hc29pv4sZBooZY5wA4Og2kdAYLVTxSOsaSsUmdY0CLcfoUMFSIdEJMG98zC6otpSw3LnpbrPkZnNjPWO55U7DSfY3LgW5M2IvR52CgIBy3eLTys12HHDFFeqLoUtYmfM0XLYceQxhubY3j",
                    new string[]{"64a0b0a8-5d1c-40d9-a8e2-5ce8d2e01834", "16a08f52-da8d-4aac-800c-6fd7a610f6a4", "247d36b4-6253-4c6a-8a93-9e8d1f5d381c", "ecc14663-4550-45fb-ba11-e902cb2525c8", "c8d9e640-ba75-4eb2-a7ab-2349b7c11470", "89431037-fa0f-4c48-9084-bc907a7f636c", "b33c8493-5392-439f-8367-97f8457d80bc"},
                    "YlFZzBuHZ8@tjsh.com",
                    "68ScZg3aAM@ErPc.com"
                ) {
                    BankAccount = "915015",
                    BankAccountHolderName = "\\",
                    ContactName = "CUATGGz590dtBhucZ4e0BzAWy80f2MmxJUnd92RrjDmsbpR1t9xme9U0GR2pRvNpULEoTr6H5p2Y5YBaOZdS1seolNILNbVpFGvZ3N4x3uvaLnbw12Ii4C82SzJJG4lODNS2Ij7U5b72UTWbjXGfzCmZ2vkYmrCrWwA7IkDmk9acr8tX9JQSHyiFoseHqYyK8GIOW0PGU",
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
                    "lf9tWgAr9KxjsUzeefEvU98BI4BdtnYV",
                    "OF5IXA6lNw66Yqs62ry4EX0H5SsjBGi2vt3IVLujfoeXIyA6Ao821XE55hc29pv4sZBooZY5wA4Og2kdAYLVTxSOsaSsUmdY0CLcfoUMFSIdEJMG98zC6otpSw3LnpbrPkZnNjPWO55U7DSfY3LgW5M2IvR52CgIBy3eLTys12HHDFFeqLoUtYmfM0XLYceQxhubY3j",
                    new string[]{"64a0b0a8-5d1c-40d9-a8e2-5ce8d2e01834", "16a08f52-da8d-4aac-800c-6fd7a610f6a4", "247d36b4-6253-4c6a-8a93-9e8d1f5d381c", "ecc14663-4550-45fb-ba11-e902cb2525c8", "c8d9e640-ba75-4eb2-a7ab-2349b7c11470", "89431037-fa0f-4c48-9084-bc907a7f636c", "b33c8493-5392-439f-8367-97f8457d80bc"},
                    "YlFZzBuHZ8@tjsh.com",
                    "68ScZg3aAM@ErPc.com"
                ) {
                    BankAccountType = "saving",
                    BankAccount = "42804",
                    BankAccountHolderName = "ﾀ",
                    ContactName = "eNNvUC0bqs1hvmd5I8evbrAQGpnYomE2cpD4cThkIOO2LW0e3G1sTmjjHcN57ZbAikJ2opGyr1ja3zumve771kQ7mwZnfGMQasC1yb1Dq2UL9Kx0jYk7sZRicOTg23f5GXrX6ozTzm0HG0TosxKz4jitwHtujKhwCFGwiyv4vlRBRxfHZeKBVf4jVtecQNubIdHetIBPUrv",
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
                    "lf9tWgAr9KxjsUzeefEvU98BI4BdtnYV",
                    "OF5IXA6lNw66Yqs62ry4EX0H5SsjBGi2vt3IVLujfoeXIyA6Ao821XE55hc29pv4sZBooZY5wA4Og2kdAYLVTxSOsaSsUmdY0CLcfoUMFSIdEJMG98zC6otpSw3LnpbrPkZnNjPWO55U7DSfY3LgW5M2IvR52CgIBy3eLTys12HHDFFeqLoUtYmfM0XLYceQxhubY3j",
                    new string[]{"64a0b0a8-5d1c-40d9-a8e2-5ce8d2e01834", "16a08f52-da8d-4aac-800c-6fd7a610f6a4", "247d36b4-6253-4c6a-8a93-9e8d1f5d381c", "ecc14663-4550-45fb-ba11-e902cb2525c8", "c8d9e640-ba75-4eb2-a7ab-2349b7c11470", "89431037-fa0f-4c48-9084-bc907a7f636c", "b33c8493-5392-439f-8367-97f8457d80bc"},
                    "YlFZzBuHZ8@tjsh.com",
                    "68ScZg3aAM@ErPc.com"
                ) {
                    BankBranchCode = "",
                    BankAccountType = "current",
                    BankAccount = "64",
                    BankAccountHolderName = " ",
                    ContactName = "6tWgyM43AJZ0KTwWOYBSX4EzfsIiIDCSxoowqwobMRj4K8plKuk4zON6lsKCXAkk07Q9YuV27x2ZZwJNPJ0aXH1uRWCYsw6VRBfXAF7xeoT0y6lNlDnKEOyMV89HUL5OwvTmfkSpdcLQvsJQRiuvWpRkphzntq",
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
                    "lf9tWgAr9KxjsUzeefEvU98BI4BdtnYV",
                    "OF5IXA6lNw66Yqs62ry4EX0H5SsjBGi2vt3IVLujfoeXIyA6Ao821XE55hc29pv4sZBooZY5wA4Og2kdAYLVTxSOsaSsUmdY0CLcfoUMFSIdEJMG98zC6otpSw3LnpbrPkZnNjPWO55U7DSfY3LgW5M2IvR52CgIBy3eLTys12HHDFFeqLoUtYmfM0XLYceQxhubY3j",
                    new string[]{"64a0b0a8-5d1c-40d9-a8e2-5ce8d2e01834", "16a08f52-da8d-4aac-800c-6fd7a610f6a4", "247d36b4-6253-4c6a-8a93-9e8d1f5d381c", "ecc14663-4550-45fb-ba11-e902cb2525c8", "c8d9e640-ba75-4eb2-a7ab-2349b7c11470", "89431037-fa0f-4c48-9084-bc907a7f636c", "b33c8493-5392-439f-8367-97f8457d80bc"},
                    "YlFZzBuHZ8@tjsh.com",
                    "68ScZg3aAM@ErPc.com"
                ) {
                    BankBranchName = "Tr2vHF1iF0Y7dBxe8hiTzwkLtzBfAa7kaQm",
                    BankBranchCode = "861",
                    BankAccountType = "other",
                    BankAccount = "91694",
                    BankAccountHolderName = " ",
                    ContactName = "tu83N0tnRGbdpbMjOs6NsjUaiDroY6Q3IK7BQ6AmswdAM3IJrwVbs9pMxfMCthiv1a2EEHFmQw4OmJsXraAGliEBPmHrH76ocsr7yZptwOIMGRxZLktLdV7uiWarFr5GP0wp4l70ZsGyPlyZYRURgUMf0P5ozHDn0iOeoWIRRMyR0nQkh8Zz7eaFGoiO",
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
                    "lf9tWgAr9KxjsUzeefEvU98BI4BdtnYV",
                    "OF5IXA6lNw66Yqs62ry4EX0H5SsjBGi2vt3IVLujfoeXIyA6Ao821XE55hc29pv4sZBooZY5wA4Og2kdAYLVTxSOsaSsUmdY0CLcfoUMFSIdEJMG98zC6otpSw3LnpbrPkZnNjPWO55U7DSfY3LgW5M2IvR52CgIBy3eLTys12HHDFFeqLoUtYmfM0XLYceQxhubY3j",
                    new string[]{"64a0b0a8-5d1c-40d9-a8e2-5ce8d2e01834", "16a08f52-da8d-4aac-800c-6fd7a610f6a4", "247d36b4-6253-4c6a-8a93-9e8d1f5d381c", "ecc14663-4550-45fb-ba11-e902cb2525c8", "c8d9e640-ba75-4eb2-a7ab-2349b7c11470", "89431037-fa0f-4c48-9084-bc907a7f636c", "b33c8493-5392-439f-8367-97f8457d80bc"},
                    "YlFZzBuHZ8@tjsh.com",
                    "68ScZg3aAM@ErPc.com"
                ) {
                    BankCode = "",
                    BankBranchName = "KR0rUW9UTcnGDBsZuPfA",
                    BankBranchCode = "249",
                    BankAccountType = "saving",
                    BankAccount = "915619",
                    BankAccountHolderName = "W",
                    ContactName = "HnocikBJOkD3FvwnaI0WeOGlWmmegc1KGhe3TxnuKac7CS1DK4Gnrr3oBLGMXHrz9mqfRhRmUp8pN9pjtBKEK15Dd3XxCT0Zmu6u7tOxquneNatGolCf6SjeF7SeZXyMS6WkNJ2GvSwQUcruYP4H5cCw5ExNqh41OXXFwVmaHYw6oEFbK8qER1LlAIi5qYTqeIN9jftsBTkZDKCnQigIB",
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
                    "lf9tWgAr9KxjsUzeefEvU98BI4BdtnYV",
                    "OF5IXA6lNw66Yqs62ry4EX0H5SsjBGi2vt3IVLujfoeXIyA6Ao821XE55hc29pv4sZBooZY5wA4Og2kdAYLVTxSOsaSsUmdY0CLcfoUMFSIdEJMG98zC6otpSw3LnpbrPkZnNjPWO55U7DSfY3LgW5M2IvR52CgIBy3eLTys12HHDFFeqLoUtYmfM0XLYceQxhubY3j",
                    new string[]{"64a0b0a8-5d1c-40d9-a8e2-5ce8d2e01834", "16a08f52-da8d-4aac-800c-6fd7a610f6a4", "247d36b4-6253-4c6a-8a93-9e8d1f5d381c", "ecc14663-4550-45fb-ba11-e902cb2525c8", "c8d9e640-ba75-4eb2-a7ab-2349b7c11470", "89431037-fa0f-4c48-9084-bc907a7f636c", "b33c8493-5392-439f-8367-97f8457d80bc"},
                    "YlFZzBuHZ8@tjsh.com",
                    "68ScZg3aAM@ErPc.com"
                ) {
                    BankName = "gyeHE0tecRrYBgXoYNaRDH3xa5ZXl3L94kmD",
                    BankCode = "9129",
                    BankBranchName = "mfdCV9wGJUROgp1VTNstKsb",
                    BankBranchCode = "276",
                    BankAccountType = "saving",
                    BankAccount = "57869",
                    BankAccountHolderName = "ｱ",
                    ContactName = "wuee4w9Rkvag9C19xRl1IlJpGXqlhd5uwOg53j3Qic0iyKLnZxaZi9iCa2kj9IDD4FLU53H4cTCafuN856J50SdiADG",
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
