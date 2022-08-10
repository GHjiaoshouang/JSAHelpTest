using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSAHelpENForToNetCore31.Test
{
    internal class yasuo
    {
        /// <summary>
        /// 压缩
        /// </summary>
        /// <returns></returns>
        public static string[] One()
        {
            bool flag = false;
     
            bool flag3 = false;
            bool flag4 = false;
            string[] result = new string[4];
            try
            {
                string path = JSAHelpEN.toolsFactory.PathHelper.GetSavePath(JSAHelpEN.toolsFactory.PathHelper.FilePathEnumerate.ProgramNoDebug)+ "/myselfFolderTemp";
                string filePath = JSAHelpEN.toolsFactory.PathHelper.GetSavePath(JSAHelpEN.toolsFactory.PathHelper.FilePathEnumerate.ProgramNoDebug,"Test.txt", "myselfFolderTemp");

                flag= JSAHelpEN.toolsFactory.UncompressZIP.ZIPCompression(path,JSAHelpEN.toolsFactory.PathHelper.GetSavePath(JSAHelpEN.toolsFactory.PathHelper.FilePathEnumerate.ProgramNoDebug)+"/ZIPtest.zip");


                //flag2= JSAHelpEN.toolsFactory.UncompressZIP.ZIPdecompress(JSAHelpEN.toolsFactory.PathHelper.GetSavePath(JSAHelpEN.toolsFactory.PathHelper.FilePathEnumerate.ProgramNoDebug) + "/myselfFolderTemp/ZIPtest", JSAHelpEN.toolsFactory.PathHelper.GetSavePath(JSAHelpEN.toolsFactory.PathHelper.FilePathEnumerate.ProgramNoDebug) + "/ZIPtest.zip");

                flag3=JSAHelpEN.toolsFactory.UncompressZIP.GitHubZip.GitHubZipZipFile(filePath, path + "/test.zip",password:"888888",9);

                flag4 = JSAHelpEN.toolsFactory.UncompressZIP.ZIPdecompressPassword(path, path + "/test.zip","55555");     
                if (flag&&flag3&&flag4)
                {
                    result[0] = "true";
                    result[1] = "压缩:";
                    result[2] = "测试正常!";
                    result[3] = "";
                    return result;
                }
                else
                {
                    throw new Exception("压缩异常！");
                }
            }
            catch (Exception ex)
            {
                result[0] = "false";
                result[1] = "压缩:";
                result[2] = "压缩异常!";
                result[3] = ex.Message;
                return result;
            }
        }
    }
}
