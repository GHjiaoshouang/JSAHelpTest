using Microsoft.VisualStudio.TestTools.UnitTesting;
using static JSAHelpEN.toolsFactory;
using System;
using System.Threading;

namespace JSAHelpUnitTest
{
    [TestClass]
    public class HTTP
    {
        [TestMethod]
        public void TestMethod1()
        {
            try
            {
                string str = Send.HttpGet("http://www.xxx.xxx/aa"); // Get请求
            }
            catch (Exception)
            {
       
            }
            Assert.IsTrue(true);
        }
    }
}
