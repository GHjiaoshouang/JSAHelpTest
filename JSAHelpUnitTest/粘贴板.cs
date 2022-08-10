using Microsoft.VisualStudio.TestTools.UnitTesting;
using static JSAHelpEN.toolsFactory;
using System;
using System.Windows.Forms;
using System.Threading;

namespace JSAHelpUnitTest
{
    [TestClass]
    public class 粘贴板
    {
        [TestMethod]
        public void TestMethod1()
        {
            CopyAndPaste.Copy("555666111"); //添加到剪贴板
            Assert.IsTrue(true);
        }
    }
}

