﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Senparc.Core.Enums;
using Senparc.Core.Extensions;
using System;

namespace Senparc.SMS.Tests
{
    [TestClass]
    public class SmsPlatform_JunMeiTest : BaseSMSTest
    {
        public SmsPlatform_JunMeiTest()
        {

        }
        [TestMethod]
        public void SendTest()
        {
            var content = "【SCF】验证码测试 客服热线：400-301-8816"; //加上签名和后缀
            SmsPlatform_JunMei junMei = new SmsPlatform_JunMei(null, "CORPID", "UserName", "Password ", "subNumber");
            var result = junMei.Send(content, "<手机号>‬");
            Console.WriteLine(result);
            Assert.IsTrue(result == SmsResult.成功);
        }
    }
}
