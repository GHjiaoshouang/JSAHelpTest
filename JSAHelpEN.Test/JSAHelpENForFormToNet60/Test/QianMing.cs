using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSAHelpENForFormToNet60.Test
{
    internal class QianMing
    {
        //检测签名
        public static string[] One() {
            string[] result = new string[4];
            try
            {
                JSAHelpEN.toolsFactory.StringHandling.SplitString("sssff","ff");
                result[0] = "true";
                result[1] = "签名:";
                result[2] = "测试正常!";
                result[3] = "";
                return result;
            }
            catch (Exception ex)
            {
                result[0] = "false";
                result[1] = "签名:";
                result[2] = "测试异常!";
                result[3] = ex.ToString();
                return result;
            }
        }
    }
}
