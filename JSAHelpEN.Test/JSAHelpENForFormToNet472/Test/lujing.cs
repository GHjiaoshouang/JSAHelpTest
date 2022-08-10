using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSAHelpENForFormToNet472.Test
{
    public class lujing
    {
        /// <summary>
        /// 各种路径获取
        /// </summary>
        /// <returns></returns>

        public static string[] One()
        {
            string[] result = new string[4];
            string str = "";
            string path = @"D:\2022Git云\JSAHelpEN\JSAHelpEN.Test\JSAHelpENForFormToNet472\File2";
            string path4 = @"D:\2022Git云\JSAHelpEN\JSAHelpEN.Test\JSAHelpENForFormToNet472";
            string path3 = @"R:\20227\JSAHelFormToNet6444.txt\";
            string path2 = @"D:\2022Git云\JSAHelpEN\JSAHelpEN.Test\JSAHelpENForFormToNet472\File\XML.xml";
            string path5 = @"D:\2022Git云\JSAHelpEN\JSAHelpEN.Test\JSAHelpENForFormToNet472\File";
            string path6 = @"D:\\2022Git云\\JSAHelpEN\\JSAHelpEN.Test/JSAHelpENForFormToNet472/File";
            try
            {
              str=  JSAHelpEN.toolsFactory.PathHelper.GetCallDllFullPath();
                str = JSAHelpEN.toolsFactory.PathHelper.GetCallDllFullName();
                str = JSAHelpEN.toolsFactory.PathHelper.GetDllFullPath<Newtonsoft.Json.Converters.BinaryConverter>();
                str= JSAHelpEN.toolsFactory.PathHelper.GetDllFullName<Newtonsoft.Json.Converters.BinaryConverter>();
                str = JSAHelpEN.toolsFactory.PathHelper.GetDllFullPath<object>(new Newtonsoft.Json.Converters.BinaryConverter());
                str = JSAHelpEN.toolsFactory.PathHelper.GetDllFullName<object>(new JSAHelpEN.toolsFactory.PathHelper());
                str = JSAHelpEN.toolsFactory.PathHelper.GetCallDomainPath();//获取路径
                JSAHelpEN.toolsFactory.PathHelper.InitDirectoryPath(path);
                str = JSAHelpEN.toolsFactory.PathHelper.GetFolderPath(path3);

                str = JSAHelpEN.toolsFactory.PathHelper.CombineRelativePath(path4, "../../");
                str = JSAHelpEN.toolsFactory.PathHelper.CombineSystemRelativePath(path,"../../");
                str = JSAHelpEN.toolsFactory.PathHelper.CombineHttpRelativePath("http://www.baidu.com/ere/qqq/rr","../aaa.html");
                str = JSAHelpEN.toolsFactory.PathHelper.MakeRelativePath(path4,path2);
                str = JSAHelpEN.toolsFactory.PathHelper.GetFileName(path2);
                str = JSAHelpEN.toolsFactory.PathHelper.GetFileNameWithFilterInvalidFileNameChars(path6);
                str = JSAHelpEN.toolsFactory.PathHelper.GetDirectoryParentName(JSAHelpEN.toolsFactory.PathHelper.GetCallDomainPath());
                str = JSAHelpEN.toolsFactory.PathHelper.GetDirectoryParentPath(JSAHelpEN.toolsFactory.PathHelper.GetDirectoryParentPath(JSAHelpEN.toolsFactory.PathHelper.GetCallDomainPath()));

          
                List<string> ll = JSAHelpEN.toolsFactory.PathHelper.GetFilesFromFolder(path5,SearchOption.AllDirectories, "*.xml");

                result[0] = "true";
                result[1] = "各种路径获取:";
                result[2] = "测试成功!";
                result[3] = "";
                return result;
            }
            catch (Exception ex)
            {
                result[0] = "false";
                result[1] = "各种路径获取:";
                result[2] = "测试异常!";
                result[3] = ex.Message;
                return result;
            }
        }

    }
}
