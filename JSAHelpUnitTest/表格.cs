using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Data;
using static JSAHelpEN.toolsFactory;

namespace JSAHelpUnitTest
{
    [TestClass]
    public class 表格
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("name");
            dataTable.Columns.Add("sex");
            dataTable.Columns.Add("age");
            dataTable.Rows.Add(new object[] { "P", "PP", "PPP" });
            List<Dictionary<string,object>> list= TableProcess.ConvertByDataTableToDictionary(dataTable);// 表格转集合
            Assert.IsNotNull(list);
            
        }
    }
}
