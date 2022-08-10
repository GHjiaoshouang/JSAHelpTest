using Microsoft.VisualStudio.TestTools.UnitTesting;
using static JSAHelpEN.toolsFactory;
using System;
using System.Threading;
using Polly.Timeout;

namespace JSAHelpUnitTest
{
    [TestClass]
    public class 熔断
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.ThrowsException<TimeoutRejectedException>(() =>
            {

                PollyManage.CircuitBreaker(() =>
                {  // 熔断机制

                    Thread.Sleep(5000);
                },
                err =>
                {
                throw (Exception)err;
                }, 3);       // 3 秒熔断

            }
                );

        }
    }
}
