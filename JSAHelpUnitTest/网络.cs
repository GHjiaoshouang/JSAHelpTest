using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace JSAHelpUnitTest
{
    [TestClass]
    public class 网络
    {
        [TestMethod]
        public void TestMethod1()
        {
            bool flag = JSAHelpEN.toolsFactory.Network.Internet();// 判断是否可以通外网
            Assert.IsTrue(flag);

            bool flag2=JSAHelpEN.toolsFactory.Network.Ping("127.0.0.1");// 判断ip地址是否可以连接
            Assert.IsTrue(flag2);
        }
    }
}
