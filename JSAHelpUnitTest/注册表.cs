using Microsoft.VisualStudio.TestTools.UnitTesting;
using static JSAHelpEN.toolsFactory;
using System;

namespace JSAHelpUnitTest
{
    [TestClass]
    public class 注册表
    {
        [TestMethod]
        public void TestMethod1()
        {
            if (RegeditManager.IsExist(RegeditManager.KeyType.HKEY_CURRENT_USER,"AAA")) {   // 检测注册表是否存在
                RegeditManager.DeleteSubKey(RegeditManager.KeyType.HKEY_CURRENT_USER, "AAA"); // 删除指定项
            }
            RegeditManager.SetValue(RegeditManager.KeyType.HKEY_CURRENT_USER, "AAA","names","111222333");//  添加注册表项

            string values =RegeditManager.GetValue(RegeditManager.KeyType.HKEY_CURRENT_USER, "AAA","names");// 获取注册表项
            Assert.AreEqual(values, "111222333");
        
        }
    }
}
