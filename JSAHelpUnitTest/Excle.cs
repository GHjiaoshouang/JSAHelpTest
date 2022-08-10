using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using static JSAHelpEN.toolsFactory;

namespace JSAHelpUnitTest
{
    [TestClass]
    public class Excle
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsTrue(SaveExcle.SaveTable(PathHelper.GetCallDomainPath(), "222", "NewTablesCSV", "csv", false));//  保存CSV文件到指定路径
        }
    }
}
