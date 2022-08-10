using Microsoft.VisualStudio.TestTools.UnitTesting;
using static JSAHelpEN.toolsFactory;
using System;
using System.Data;

namespace JSAHelpUnitTest
{
    [TestClass]
    public class XML解析
    {
        [TestMethod]
        public void TestMethod1()
        {
            XMLTestClass xMLTestClass = new XMLTestClass();
            xMLTestClass.Name = "AAA";
            xMLTestClass.Description = "BBB";
            xMLTestClass.FFF = "CCC";
            string xml = XmlPars.Serialize(xMLTestClass);// xml序列化

            DataTable dt= XmlPars.ConvertByXmlToDataTable(XmlPars.getXmlFileTypeEnumeration.content,xml);// xml转DataTable
            Assert.IsTrue(dt.Rows.Count > 0);
        }
    }
    public class XMLTestClass
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string FFF { get; set; }
    }
}
