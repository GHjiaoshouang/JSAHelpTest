using Microsoft.VisualStudio.TestTools.UnitTesting;
using static JSAHelpEN.toolsFactory;
using System;
using System.Collections.Generic;

namespace JSAHelpUnitTest
{
    [TestClass]
    public class JSON解析
    {
        object rest;
        [TestMethod]
        public void TestMethod1()
        {
            JSONTestClass jSONTestClass = new JSONTestClass();
            jSONTestClass.Name = "AAA";
            jSONTestClass.Description = "BBB";
            jSONTestClass.FFF = "CCC";
          
            string str = JsonPars.SerializeObject(jSONTestClass);// json序列化
            Assert.IsTrue(StringHandling.StringJSONTesting(str));// json格式检测

            rest=JsonPars.GetJsonValue("Name",str);// 获取节点
            Assert.AreEqual(((List<string>)rest)[0],"AAA");
        }
    }
    public class JSONTestClass
    {

        public string Name { get; set; }
        public string Description { get; set; }
        public string FFF { get; set; }
    }
}
