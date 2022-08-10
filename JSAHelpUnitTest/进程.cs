using Microsoft.VisualStudio.TestTools.UnitTesting;
using static JSAHelpEN.toolsFactory;
using System;

namespace JSAHelpUnitTest
{
    [TestClass]
    public class 进程
    {
        [TestMethod]
        public void TestMethod1()
        {
            Kill.ISKillProcess("xxx.exe");// 杀掉进程
        }
    }
}
