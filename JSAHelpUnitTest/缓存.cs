using Microsoft.VisualStudio.TestTools.UnitTesting;
using static JSAHelpEN.toolsFactory;
using System;

namespace JSAHelpUnitTest
{
    [TestClass]
    public class 缓存
    {
        [TestMethod]
        public void TestMethod1()
        {
            if (Cache.Exists("name"))
            {
                bool flag2 = Cache.Del("name");  // 删除缓存
                Assert.IsTrue(flag2);
            }
            bool flag = Cache.Set<string>("name", "Test string.", TimeSpan.FromSeconds(9000));    // 添加缓存
            Assert.IsTrue(flag);
            var rest = Cache.Get<string>("name");  //  获取缓存
            Assert.IsNotNull(rest);

        }
    }
}
