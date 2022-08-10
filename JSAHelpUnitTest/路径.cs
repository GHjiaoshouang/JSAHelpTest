using Microsoft.VisualStudio.TestTools.UnitTesting;
using static JSAHelpEN.toolsFactory;
using System;

namespace JSAHelpUnitTest
{
    [TestClass]
    public class 路径
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = PathHelper.GetCallDomainPath();// 获取目录
            Assert.IsNotNull(path);
        }
    }
}
