using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using static JSAHelpEN.toolsFactory;

namespace JSAHelpUnitTest
{
    [TestClass]
    public class 字符串处理
    {
        [TestMethod]
        public void TestMethod1()
        {
            string[] arr; bool flag; string guid; long times; string time;


            arr = StringHandling.SplitString("aabbccaavv", "aa"); // 分割字符串
            Assert.AreEqual(arr[1], "bbcc");

            
            flag= StringHandling.ConfigSet("a5","ok");// 添加配置
            string info = StringHandling.ConfigGet("a5");// 获取配置
            Assert.AreEqual(info,"ok");

           
            guid = StringHandling.GetGuidB(); // 获取GUID
            guid = StringHandling.GetGuidD();
            guid = StringHandling.GetGuidN();
            guid = StringHandling.GetGuidP();
            Assert.IsTrue(guid.Length>10);

           
            times = StringHandling.DateTimeGetTimestamp();// 获取时间戳
            Assert.IsTrue(times > 0);

            
            time = StringHandling.DateTimeCompactString(DateTime.Now);// 获取指定的时间格式
            time = StringHandling.DateTimeDetailString(DateTime.Now);
            time = StringHandling.DateTimeStandardString(DateTime.Now);           
            Assert.IsTrue(time.Length > 10);
        }
    }
}
