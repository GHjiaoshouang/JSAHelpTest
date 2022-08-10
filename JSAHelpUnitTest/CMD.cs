using Microsoft.VisualStudio.TestTools.UnitTesting;
using static JSAHelpEN.toolsFactory;
using System;

namespace JSAHelpUnitTest
{
    [TestClass]
    public class CMD
    {
        [TestMethod]
        public void TestMethod1()
        {
            JSAHelpEN.toolsFactory.CMD.RunShowPath(PathHelper.GetCallDomainPath());// 静默打开文件夹
        }
    }
}
