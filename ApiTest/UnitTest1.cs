﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QM.Server.ApiClient.Methods;
using QM.Server.ApiClient;

namespace ApiTest {
    [TestClass]
    public class UnitTest1 {
        [TestMethod]
        public void GetTriggerTest() {

            var mth = new GetTrigger() {
                Name = "111",
                Group = "111"
            };

            var trigger = ApiClient.Instance.Execute(mth).Result;
        }
    }
}