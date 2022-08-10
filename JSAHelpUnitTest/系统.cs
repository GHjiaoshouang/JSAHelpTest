using Microsoft.VisualStudio.TestTools.UnitTesting;
using static JSAHelpEN.toolsFactory;
using System;

namespace JSAHelpUnitTest
{
    [TestClass]
    public class 系统
    {
        [TestMethod]
        public void TestMethod1()
        {
            string cpuid = SystemManager.GetCpuID(); // 获取CPU编号
            string ip = SystemManager.GetSystemAnyInfo(AnyPCInfoEnumerate.Sys5);//  获取指定信息
            Assert.IsNotNull(ip);
        }
    }
}
