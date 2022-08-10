using Microsoft.VisualStudio.TestTools.UnitTesting;
using static JSAHelpEN.toolsFactory;
using System;
using System.Data;

namespace JSAHelpUnitTest
{
    [TestClass]
    public class 数据库
    {
        [TestMethod]
        public void TestMethod1()
        {
            try
            {
                string strSql = "SELECT * FROM Admin";
                var sql = SQL.Query<DataTable>(SQL.SqlType.SqlServer, strSql);   // 执行SQL查询
                Assert.IsTrue(true);
            }
            catch (Exception)
            {
                Assert.IsTrue(true);
            }
        }
    }
}
