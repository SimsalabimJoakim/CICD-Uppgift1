﻿using NUnit.Framework;
using CICD_Uppgift1.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CICD_Uppgift1.Models.Tests
{
    [TestFixture()]
    public class AdminAccountTests
    {
        [TestCase("admin1")]
        [TestCase("bob1")]
        public void GetAccountDetailsTest(string userName)
        {
            var adminAccount = new AdminAccount();
            if(userName == "admin1")
            {
                Assert.IsTrue(adminAccount.GetAccountDetails(userName));
            }
            else
            {
                Assert.IsFalse(adminAccount.GetAccountDetails(userName));
            }
        }
    }
}