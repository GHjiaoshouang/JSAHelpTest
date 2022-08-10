using Microsoft.VisualStudio.TestTools.UnitTesting;
using static JSAHelpEN.toolsFactory;
using System;
using System.Net;

namespace JSAHelpUnitTest
{
    [TestClass]
    public class 服务
    {
        [TestMethod]
        public void TestMethod1()
        {
           Assert.IsTrue(true);
        }
        public void Start()
        {
            RestfulService.Start("127.0.0.1", 8081, Function, System.Text.Encoding.UTF8, "Demo/v1"); // 开启服务

        }
        public void Stop() { 
        
        RestfulService.Stop();  //  停止服务

        }
        private void Function(HttpListenerRequest arg1, HttpListenerResponse arg2, string arg3)
        {                                                                   //客户端接收 arg3
            RestfulService.Send(arg2, "Test string.");       // 客户端发送
        }
    }
}
