using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSAHelpENForFormToNet60.Test
{
    internal class xmljiexi
    {
        /// <summary>
        /// xml解析
        /// </summary>
        /// <returns></returns>
        public static string[] One()
        {
            string[] result = new string[4];
            try
            {
                string Xmlstr = JSAHelpEN.toolsFactory.LocalFileManage.ReadFileToProgramDirectory("XML2.xml", "File");

                DataTable dt = JSAHelpEN.toolsFactory.XmlPars.ConvertByXmlToDataTable(JSAHelpEN.toolsFactory.XmlPars.getXmlFileTypeEnumeration.content, Xmlstr);

                //Xmlstr = JSAHelpEN.toolsFactory.XmlPars.Serialize(dt);
                //Xmlstr = JSAHelpEN.toolsFactory.XmlPars.Serialize2(dt);

                Xmlstr = JSAHelpEN.toolsFactory.StringHandling.FormatXML(Xmlstr);

               Xmlstr= JSAHelpEN.toolsFactory.XmlPars.Update(Xmlstr,JSAHelpEN.toolsFactory.XmlPars.getXmlFileTypeEnumeration.content, "book/author","", "success");

                if (Xmlstr.Contains("success"))
                {
                    result[0] = "true";
                    result[1] = "xml解析:";
                    result[2] = "测试正常!";
                    result[3] = "";
                    return result;
                }
                else
                {
                    throw new Exception("xml解析异常！");
                }
            }
            catch (Exception ex)
            {
                result[0] = "false";
                result[1] = "xml解析:";
                result[2] = "测试异常!";
                result[3] = ex.Message;
                return result;
            }
        }
    }
}
