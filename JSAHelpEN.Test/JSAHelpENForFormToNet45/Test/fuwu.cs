using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace JSAHelpENForFormToNet45.Test
{
    internal class fuwu
    {
        //服务
        public static string[] One()
        {
            string[] result = new string[4];
            try
            {
                //启动服务
                JSAHelpEN.toolsFactory.RestfulService.Start("127.0.0.1", 8080, Function, Encoding.UTF8, "xxx/xxxx/");
                    result[0] = "true";
                    result[1] = "服务:";
                    result[2] = "测试正常!";
                    result[3] = "";
                    return result;
            }
            catch (Exception ex)
            {
                result[0] = "false";
                result[1] = "服务:";
                result[2] = "测试异常!";
                result[3] = ex.Message;
                return result;
            }
        }
        /// <summary>
        /// 请求服务
        /// </summary>
        /// <returns></returns>
        public static string[] Two()
        {
            string[] result = new string[4];
            try
            {
                Dictionary<string, string> obj = new Dictionary<string, string>();
                //obj.Add("Url", "http://10.68.63.54:8086/1.0.0/hsa-fsi-");
                //obj.Add("Content", "5");
                //obj.Add("Method","POST");
                obj.Add("ContentType", "application/json");

               string ssrs= JSAHelpEN.toolsFactory.Send.SparMethods.Send("http://10.68.63.54:8086/1.0.0/hsa-fsi-","5",5, obj);

                //请求服务
                JSAHelpEN.toolsFactory.Send.PostmanPara postmanPara = new JSAHelpEN.toolsFactory.Send.PostmanPara();
                //postmanPara.URL = "http://127.0.0.1:8080/xxx/xxxx/api";
                postmanPara.URL = "http://10.68.63.54:8086/1.0.0/hsa-fsi-";
                postmanPara.Method= "POST";
                postmanPara.Postdata = "5";
                string res = JSAHelpEN.toolsFactory.Send.Postman(postmanPara);
                if (res.Equals("123"))
                {
                    result[0] = "true";
                    result[1] = "请求服务:";
                    result[2] = "测试正常!";
                    result[3] = "";
                    return result;
                }
                else {
                    throw new Exception("服务请求失败！");
                }      
            }
            catch (Exception ex)
            {
                result[0] = "false";
                result[1] = "请求服务:";
                result[2] = "测试异常!";
                result[3] = ex.Message;
                return result;
            }
        }
        /// <summary>
        /// 停止服务
        /// </summary>
        /// <returns></returns>
        public static string[] Three()
        {
            string[] result = new string[4];
            try
            {
                JSAHelpEN.toolsFactory.Send.PostmanPara postmanPara = new JSAHelpEN.toolsFactory.Send.PostmanPara();
                //停止服务
                JSAHelpEN.toolsFactory.RestfulService.Stop();
                postmanPara.URL = "http://127.0.0.1:8080/xxx/xxxx/api";
                postmanPara.Method = "POST";
                postmanPara.Postdata = "5";
                try
                {
                    string res = JSAHelpEN.toolsFactory.Send.Postman(postmanPara);
                }
                catch (Exception)
                {
                    result[0] = "true";
                    result[1] = "停止服务:";
                    result[2] = "测试正常!";
                    result[3] = "";
                    return result;
                }
                    throw new Exception("服务停止失败！");
            }
            catch (Exception ex)
            {
                result[0] = "false";
                result[1] = "停止服务:";
                result[2] = "测试异常!";
                result[3] = ex.Message;
                return result;
            }
        }

        private static void Function(HttpListenerRequest arg1, HttpListenerResponse arg2, string arg3)
        {
            if (arg3 == "5")
            {
                JSAHelpEN.toolsFactory.RestfulService.Send(arg2, "123");
            }
            else {

                JSAHelpEN.toolsFactory.RestfulService.Send(arg2, "000");
            }
           
        }
    }
}
