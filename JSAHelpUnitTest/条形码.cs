using Microsoft.VisualStudio.TestTools.UnitTesting;
using static JSAHelpEN.toolsFactory;
using System;

namespace JSAHelpUnitTest
{
    [TestClass]
    public class 条形码
    {
        [TestMethod]
        public void TestMethod1()
        {
            BarCodeHelper.GetBarcodeBitmap("1111",PathHelper.GetCallDomainPath()+"/aa.png");// 创建条形码
            Assert.IsTrue(true);
        }
    }
}
