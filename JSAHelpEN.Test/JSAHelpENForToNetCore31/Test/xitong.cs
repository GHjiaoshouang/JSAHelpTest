using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSAHelpENForToNetCore31.Test
{
    public class xitong
    {
        //系统信息
        public static string[] One()
        {
            string[] result = new string[4];
            try
            {
                //获取IP
                string IP = JSAHelpEN.toolsFactory.SystemManager.GetLocalIpAddress();
                string info = JSAHelpEN.toolsFactory.SystemManager.GetSystemAnyInfo(JSAHelpEN.toolsFactory.AnyPCInfoEnumerate.Sys3);
                 info = JSAHelpEN.toolsFactory.SystemManager.GetSystemAnyInfo(JSAHelpEN.toolsFactory.AnyPCInfoEnumerate.Sys3);
                 info = JSAHelpEN.toolsFactory.SystemManager.GetSystemAnyInfo(JSAHelpEN.toolsFactory.AnyPCInfoEnumerate.Sys5);
                 info = JSAHelpEN.toolsFactory.SystemManager.GetSystemAnyInfo(JSAHelpEN.toolsFactory.AnyPCInfoEnumerate.Sys6);
                 info = JSAHelpEN.toolsFactory.SystemManager.GetSystemAnyInfo(JSAHelpEN.toolsFactory.AnyPCInfoEnumerate.Sys7);
                 info = JSAHelpEN.toolsFactory.SystemManager.GetSystemAnyInfo(JSAHelpEN.toolsFactory.AnyPCInfoEnumerate.Sys9);
                 info = JSAHelpEN.toolsFactory.SystemManager.GetSystemAnyInfo(JSAHelpEN.toolsFactory.AnyPCInfoEnumerate.Sys10);
                 info = JSAHelpEN.toolsFactory.SystemManager.GetSystemAnyInfo(JSAHelpEN.toolsFactory.AnyPCInfoEnumerate.Sys12);
                 info = JSAHelpEN.toolsFactory.SystemManager.GetSystemAnyInfo(JSAHelpEN.toolsFactory.AnyPCInfoEnumerate.Sys13);
                result[0] = "true";
                result[1] = "系统信息:";
                result[2] = "测试成功!";
                result[3] = "";
                return result;
            }
            catch (Exception ex)
            {
                result[0] = "false";
                result[1] = "系统信息:";
                result[2] = "测试异常!";
                result[3] = ex.Message;
                return result;
            }
        }
    }
}
