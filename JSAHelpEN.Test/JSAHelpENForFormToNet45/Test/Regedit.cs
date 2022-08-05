using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSAHelpENForFormToNet45.Test
{
    internal class Regedit
    {
        //注册表
        public static string[] One()
        {
            bool flag=false;
            string[] result = new string[4];
            try
            {
                //写入注册表

                JSAHelpEN.toolsFactory.RegeditManager.SetValue(JSAHelpEN.toolsFactory.RegeditManager.KeyType.HKEY_CURRENT_USER,"AAAAA","AAAA","AA");
              

                string str=  JSAHelpEN.toolsFactory.RegeditManager.GetValue(JSAHelpEN.toolsFactory.RegeditManager.KeyType.HKEY_CURRENT_USER, "AAAAA", "AAAA");
                if (str.Equals("AA")) {

                   flag=true;

                }
               bool flag2= JSAHelpEN.toolsFactory.RegeditManager.DeleteValue(JSAHelpEN.toolsFactory.RegeditManager.KeyType.HKEY_CURRENT_USER, "AAAAA", "AAAA");

                if (flag && flag2)
                {
                    result[0] = "true";
                    result[1] = "注册表:";
                    result[2] = "测试正常!";
                    result[3] = "";
                    return result;

                }
                else {
                    throw new Exception("注册表操作失败！");
                }
          
            }
            catch (Exception ex)
            {
                result[0] = "false";
                result[1] = "注册表:";
                result[2] = "测试异常!";
                result[3] = ex.Message;
                return result;
            }
        }
    }
}
