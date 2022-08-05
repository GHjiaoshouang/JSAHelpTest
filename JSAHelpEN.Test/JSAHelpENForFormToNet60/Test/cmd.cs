using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSAHelpENForFormToNet60.Test
{
    internal class cmd
    {
        //CMD
        public static string[] One()
        {
            string[] result = new string[4];
            try
            {
                JSAHelpEN.toolsFactory.CMD.RunShowPath(JSAHelpEN.toolsFactory.PathHelper.GetSavePath(JSAHelpEN.toolsFactory.PathHelper.FilePathEnumerate.ProgramNoDebug));

                    result[0] = "true";
                    result[1] = "CMD:";
                    result[2] = "请自行检测是否有打开文件夹!";
                    result[3] = "";
                    return result;
            }
            catch (Exception ex)
            {
                result[0] = "false";
                result[1] = "CMD:";
                result[2] = "测试异常!";
                result[3] = ex.Message;
                return result;
            }
        }
    }
}
