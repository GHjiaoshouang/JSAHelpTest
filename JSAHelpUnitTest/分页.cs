using Microsoft.VisualStudio.TestTools.UnitTesting;
using static JSAHelpEN.toolsFactory;
using System;

namespace JSAHelpUnitTest
{
    [TestClass]
    public class 分页
    {
        [TestMethod]
        public void TestMethod1()
        {
            // sql 分页语句
            string str = Paper.CreatePagingSql(10, 3, 1, "SELECT * FROM Table", "auto_id");
            Assert.IsTrue(true);
        }
    }
}
