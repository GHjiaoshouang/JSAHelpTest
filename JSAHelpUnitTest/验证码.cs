using Microsoft.VisualStudio.TestTools.UnitTesting;
using static JSAHelpEN.toolsFactory;
using System;

namespace JSAHelpUnitTest
{
    [TestClass]
    public class 验证码
    {
        [TestMethod]
        public void TestMethod1()
        {
            string str = VerificationCode.CreateValidateNumber(5);// 生成验证码
            Assert.IsTrue(str.Length == 5);
        }
    }
}
