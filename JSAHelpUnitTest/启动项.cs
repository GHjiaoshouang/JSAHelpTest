using Microsoft.VisualStudio.TestTools.UnitTesting;
using static JSAHelpEN.toolsFactory;
using System;

namespace JSAHelpUnitTest
{
    [TestClass]
    public class 启动项
    {
        [TestMethod]
        public void TestMethod1()
        {
            bool flag = StartupTool.RegisterAdd("names", @"D:\2022企业云\MsunSoft\YUYU.exe", true);//添加启动项
            bool flag2 = StartupTool.Shortcut("names", @"D:\2022企业云\MsunSoft\YUYU.exe", true);
            bool flag11 = StartupTool.RegisterAdd("names", @"D:\2022企业云\MsunSoft\YUYU.exe",false);//删除启动项
            bool flag22 = StartupTool.Shortcut("names", @"D:\2022企业云\MsunSoft\YUYU.exe",false);
            Assert.IsTrue(flag);
            Assert.IsTrue(flag2);
          
        }
    }
}
