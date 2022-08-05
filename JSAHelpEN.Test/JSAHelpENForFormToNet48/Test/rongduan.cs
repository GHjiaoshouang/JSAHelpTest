using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace JSAHelpENForFormToNet48.Test
{
    internal class rongduan
    {

        /// <summary>
        /// 熔断
        /// </summary>
        /// <returns></returns>
        public static string[] One()
        {
            string[] result = new string[4];
            try
            {
                JSAHelpEN.toolsFactory.PollyManage.CircuitBreaker(() =>
                {

                    for (int i = 0; i < 3; i++)
                    {
                        Thread.Sleep(1000);
                    }

                }, err =>
                {
                    return null;
                }, 5);
                #region MyRegion

                //JSAHelpEN.toolsFactory.PollyManage.CircuitBreaker(res =>
                //{

                //    for (int i = 0; i < 3; i++)
                //    {
                //        Thread.Sleep(1000);
                //    }
                //    return null;

                //}, err =>
                //{
                //    throw (Exception)err;
                //}, 5);

                //JSAHelpEN.toolsFactory.PollyManage.CircuitBreaker(() =>
                //{

                //    for (int i = 0; i < 3; i++)
                //    {
                //        Thread.Sleep(1000);
                //    }

                //}, err =>
                //{
                //    return new object();
                //}, 5);



                //JSAHelpEN.toolsFactory.PollyManage.CircuitBreakerOther(() =>
                //{

                //    for (int i = 0; i < 3; i++)
                //    {
                //        Thread.Sleep(1000);
                //    }

                //}, err =>
                //{
                //    return null;
                //}, 5);

                //JSAHelpEN.toolsFactory.PollyManage.CircuitBreakerOther(res =>
                //{

                //    for (int i = 0; i < 3; i++)
                //    {
                //        Thread.Sleep(1000);
                //    }
                //    return null;

                //}, err =>
                //{
                //    throw (Exception)err;
                //}, 5);

                //JSAHelpEN.toolsFactory.PollyManage.CircuitBreakerOther(() =>
                //{

                //    for (int i = 0; i < 3; i++)
                //    {
                //        Thread.Sleep(1000);
                //    }

                //}, err =>
                //{
                //    return new object();
                //}, 5);



                //JSAHelpEN.toolsFactory.PollyManage.Retry(() =>
                //{

                //    for (int i = 0; i < 3; i++)
                //    {
                //        Thread.Sleep(1000);
                //    }

                //}, 1, 5);


                //JSAHelpEN.toolsFactory.PollyManage.Retry(res =>
                //{

                //    for (int i = 0; i < 3; i++)
                //    {
                //        Thread.Sleep(1000);
                //    }
                //    return new object();
                //}, 1, 3);

                //JSAHelpEN.toolsFactory.PollyManage.Retry(() =>
                //{

                //    for (int i = 0; i < 3; i++)
                //    {
                //        Thread.Sleep(1000);
                //    }
                //    return new object();

                //}, 1, 5);


                //JSAHelpEN.toolsFactory.PollyManage.RetryOther(() =>
                //{

                //    for (int i = 0; i < 3; i++)
                //    {
                //        Thread.Sleep(1000);
                //    }

                //}, 1, 5);


                //JSAHelpEN.toolsFactory.PollyManage.RetryOther(res =>
                //{

                //    for (int i = 0; i < 3; i++)
                //    {
                //        Thread.Sleep(1000);
                //    }
                //    return new object();
                //}, 1, 5);

                //JSAHelpEN.toolsFactory.PollyManage.RetryOther(() =>
                //{

                //    for (int i = 0; i < 3; i++)
                //    {
                //        Thread.Sleep(1000);
                //    }
                //    return new object();

                //}, 1, 5);
                #endregion


                result[0] = "true";
                result[1] = "熔断:";
                result[2] = "测试正常!";
                result[3] = "";
                return result;

            }
            catch (Exception ex)
            {
                result[0] = "false";
                result[1] = "熔断:";
                result[2] = "测试异常!";
                result[3] = ex.Message;
                return result;
            }
        }

    }
}
