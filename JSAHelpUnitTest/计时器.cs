using Microsoft.VisualStudio.TestTools.UnitTesting;
using static JSAHelpEN.toolsFactory;
using System;
using System.Threading;

namespace JSAHelpUnitTest
{
    [TestClass]
    public class 计时器
    {
        [TestMethod]
        public void TestMethod1()
        {

            ClockManager.WatchStart();      // 开始计时
            Thread.Sleep(2000);
            double time= ClockManager.WatchStop(); //计时结束
            Assert.IsTrue(time > 2000);
        }
    }
}
