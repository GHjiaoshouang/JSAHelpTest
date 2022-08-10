using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSAHelpENForFormToNet45.Test
{
    internal class RiZhi
    {
        public static string[] One()
        {
            string[] result = new string[4];
 //若目录下生成日志，则正常
                result[0] = "true";
                result[1] = "日志:";
                result[2] = "测试正常!";
                result[3] = "需要自行打开目录检测！";
                return result;

        }
    }
}
