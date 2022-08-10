using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSAHelpENForFormToNet45.Test
{
    internal class wenjian
    {
        /// <summary>
        /// 文件读取写入
        /// </summary>
        /// <returns></returns>
        public static string[] One()
        {
            bool flag=false;
            string[] result = new string[4];
            try
            {
                string content = "This is test string.";               JSAHelpEN.toolsFactory.LocalFileManage.SaveFileToProgramDirectory(content,"Test.txt","myselfFolderTemp");
                string content2 = JSAHelpEN.toolsFactory.LocalFileManage.ReadFileToProgramDirectory("Test.txt", "myselfFolderTemp");
                if (content.Equals(content2)) { 
                flag=true;
                }
                if (flag)
                {
                    result[0] = "true";
                    result[1] = "签名:";
                    result[2] = "测试正常!";
                    result[3] = "";
                    return result;
                }
                else {
                    throw new Exception("文件读取写入异常！");              }
            }
            catch (Exception ex)
            {
                result[0] = "false";
                result[1] = "签名:";
                result[2] = "文件读取写入异常!";
                result[3] = ex.Message;
                return result;
            }
        }

        /// <summary>
        /// 获取文件路径、分割字符串
        /// </summary>
        /// <returns></returns>
        public static string[] Two()
        {
            string[] result = new string[4];
            try
            {
                string path = JSAHelpEN.toolsFactory.PathHelper.GetSavePath(JSAHelpEN.toolsFactory.PathHelper.FilePathEnumerate.ProgramNoDebug,"Test.txt", "myselfFolderTemp");
               path= JSAHelpEN.toolsFactory.StringHandling.SplitString(path, "myselfFolderTemp")[0];
                if (path.Length>5) {
                    result[0] = "true";
                    result[1] = "获取文件路径、分割字符串检测:";
                    result[2] = "测试正常!";
                    result[3] = "";
                    return result;
                }
                else
                {
                    throw new Exception("获取文件路径、分割字符串检测异常！");
                }

            }
            catch (Exception ex)
            {
                result[0] = "false";
                result[1] = "获取文件路径、分割字符串检测:";
                result[2] = "测试异常!";
                result[3] = ex.Message;
                return result;
            }
        }
    }
}
