using Microsoft.VisualStudio.TestTools.UnitTesting;
using static JSAHelpEN.toolsFactory;
using System;
using System.Threading;

namespace JSAHelpUnitTest
{
    [TestClass]
    public class 异步
    {
        [TestMethod]
        public void TestMethod1()
        {
            ThreadTools.Task(() => {        // 异步调用

                WinfromManager.Message("hhhh");

            });
         Thread.Sleep(4000);
        }
    }
}
