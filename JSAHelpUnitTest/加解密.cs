using Microsoft.VisualStudio.TestTools.UnitTesting;
using static JSAHelpEN.toolsFactory;
using System;

namespace JSAHelpUnitTest
{
    [TestClass]
    public class 加解密
    {
        [TestMethod]
        public void TestMethod1()
        {
            object str;
            str=EncryptionAndDecryption.MD5Encrypt("Test string.");// md5加密
            Assert.IsNotNull(str);
        }
    }
}
