using Microsoft.VisualStudio.TestTools.UnitTesting;
using static JSAHelpEN.toolsFactory;
using System;
using System.Threading;

namespace JSAHelpUnitTest
{
    [TestClass]
    public class 窗体
    {
        [TestMethod]
        public void TestMethod1()
        {
            WinfromManager.ShowMessage("hhhh"); //同步提示弹窗
            WinfromManager.MessageAnync("警告", "what's this?", 10000,"aaaa");// 异步提示弹窗
            Thread.Sleep(2000);
        }
    }
}
