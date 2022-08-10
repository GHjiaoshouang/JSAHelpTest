using Microsoft.VisualStudio.TestTools.UnitTesting;
using static JSAHelpEN.toolsFactory;
using System;

namespace JSAHelpUnitTest
{
    [TestClass]
    public class 字符编码
    {
        [TestMethod]
        public void TestMethod1()
        {
            string str = Encod.ToUTF8("asdajshdjhagj"); // 转字符编码（UTF-8）
            Assert.IsNotNull(str);
        }
    }
}
