using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSAHelpENForFormToNet45.Test
{
    internal class YiChang
    {
        public static string[] One()
        {
            bool flag = false;
            bool flag2 = false;
            string[] result = new string[4];
            try
            {
                //展示详细
                try
                {
                    JSAHelpEN.toolsFactory.isReturnExceptionMessage = true;
                    JSAHelpEN.toolsFactory.LocalFileManage.ReadFileToDirectory("sssff", false);
                }
                catch (Exception ex)
                {

                    if (!ex.Message.Contains("JSAHelp run log"))
                    {
                        flag = true;
                    }
                }
                //不展示详细
                try
                {
                    JSAHelpEN.toolsFactory.isReturnExceptionMessage = false;
                    JSAHelpEN.toolsFactory.LocalFileManage.ReadFileToDirectory("sssff", false);
                }
                catch (Exception ex)
                {

                    if (ex.Message.Contains("JSAHelp run log"))
                    {
                        flag2 = true;
                    }
                }

                if (flag && flag2)
                {

                    result[0] = "true";
                    result[1] = "异常:";
                    result[2] = "测试正常!";
                    result[3] = "";
                    return result;
                }
                else
                {

                    throw new Exception("异常配置打开异常！请检查");
                }

            }
            catch (Exception ex)
            {
                result[0] = "false";
                result[1] = "异常:";
                result[2] = "测试异常!";
                result[3] = ex.Message;
                return result;
            }
            finally {
                JSAHelpEN.toolsFactory.isReturnExceptionMessage = false;
            }
        }
    }
}
