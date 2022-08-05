using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSAHelpENForFormToNet48.Test
{
    internal class zhifucuanchuli
    {
        /// <summary>
        /// Ip检测
        /// </summary>
        /// <returns></returns>
        public static string[] One()
        {
            string[] result = new string[4];
            bool flag = false;
            bool flag2 = false;
            try
            {
              bool no=  JSAHelpEN.toolsFactory.StringHandling.IPTesting("256.222.222.222");
                if (!no) {
                flag = true;
                }
                bool yes = JSAHelpEN.toolsFactory.StringHandling.IPTesting("192.168.13.123");
                if (yes)
                {
                    flag2 = true;
                }

                if (flag2 && flag)
                {
                    result[0] = "true";
                    result[1] = "Ip检测:";
                    result[2] = "测试正常!";
                    result[3] = "";
                    return result;
                }
                else {
                    throw new Exception("IP检测异常！");
                }
            
            }
            catch (Exception ex)
            {
                result[0] = "false";
                result[1] = "Ip检测:";
                result[2] = "测试异常!";
                result[3] = ex.Message;
                return result;
            }
        }
        /// <summary>
        /// 空值、数值、计算次数、json格式检测、json格式化/压缩检测
        /// </summary>
        /// <returns></returns>
        public static string[] Two()
        {
            string[] result = new string[4];
            bool flag = false;
            bool flag2 = false;
            bool flag3=false;
            bool  flag4=false;
            try
            {               
                 flag = JSAHelpEN.toolsFactory.StringHandling.StringNullTesting("");
                flag2 = JSAHelpEN.toolsFactory.StringHandling.StringNumberTesting("123");
                flag3 = JSAHelpEN.toolsFactory.StringHandling.SubstringCount("12311113333","3")>0;

                string jsonStr = JSAHelpEN.toolsFactory.LocalFileManage.ReadFileToProgramDirectory("JSON2.json","File");
                JSAHelpEN.toolsFactory.StringHandling.StringJSONTesting(jsonStr);
                jsonStr=JSAHelpEN.toolsFactory.StringHandling.StringJsonCompress(jsonStr);
                jsonStr = JSAHelpEN.toolsFactory.StringHandling.FormatJsonString(jsonStr);
                flag4 = true;


                if (flag2 && flag&&flag3&&flag4)
                {
                    result[0] = "true";
                    result[1] = "空值、数值、计算次数、json格式检测、json格式化/压缩检测:";
                    result[2] = "测试正常!";
                    result[3] = "";
                    return result;
                }
                else
                {
                    throw new Exception("空值、数值、计算次数、json格式检测、json格式化/压缩检测异常！");
                }

            }
            catch (Exception ex)
            {
                result[0] = "false";
                result[1] = "空值、数值、计算次数、json格式检测、json格式化/压缩检测:";
                result[2] = "测试异常!";
                result[3] = ex.Message;
                return result;
            }
        }
        /// <summary>
        /// 转义字符、字符串替换检测
        /// </summary>
        /// <returns></returns>
        public static string[] Three()
        {
            //Ip检测
            string[] result = new string[4];
            bool flag = false;
            bool flag2 = false;
            try
            {
                string jsonStr = JSAHelpEN.toolsFactory.LocalFileManage.ReadFileToProgramDirectory("JSON.json", "File");
                string str= JSAHelpEN.toolsFactory.StringHandling.UnescapeJson(jsonStr);

                if (!str.Contains("\\\"")) {
                    flag = true;
                }
                string strs = "1111111222";
                strs = JSAHelpEN.toolsFactory.StringHandling.Replace(strs,"222","444");

                if (strs.Contains("4"))
                {
                    flag2 = true;
                }

                if (flag2 && flag)
                {
                    result[0] = "true";
                    result[1] = "转义字符、字符串替换检测:";
                    result[2] = "测试正常!";
                    result[3] = "";
                    return result;
                }
                else
                {
                    throw new Exception("转义字符、字符串替换检测异常！");
                }

            }
            catch (Exception ex)
            {
                result[0] = "false";
                result[1] = "转义字符、字符串替换检测:";
                result[2] = "测试异常!";
                result[3] = ex.Message;
                return result;
            }
        }
    }
}
