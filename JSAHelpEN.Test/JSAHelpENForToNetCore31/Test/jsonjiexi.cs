using JSAHelpEN;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSAHelpENForToNetCore31.Test
{
    internal class jsonjiexi
    {
        /// <summary>
        /// json解析
        /// </summary>
        /// <returns></returns>
        public static string[] One()
        {
            string[] result = new string[4];
            try
            {
                JSAHelpEN.toolsFactory.StringHandling.SplitString("sssff", "ff");

                string jsonStr = JSAHelpEN.toolsFactory.LocalFileManage.ReadFileToProgramDirectory("JSON2.json","File");

                DataTable dt= JSAHelpEN.toolsFactory.JsonPars.ConvertByJsonToDataTable(jsonStr);

               Dictionary<string,object> dic= JSAHelpEN.toolsFactory.JsonPars.ConvertByJsonToDictionary(jsonStr);

               string newJsonStr= JSAHelpEN.toolsFactory.JsonPars.SerializeObject(JSAHelpEN.toolsFactory.JsonPars.ConvertByJsonToDictionarySort(jsonStr));

                Dictionary<string, string> dicc = new Dictionary<string, string>();
                dicc.Add("name", "HHHHHH");
                newJsonStr = JSAHelpEN.toolsFactory.JsonPars.ReplaceJsonByDictionary(newJsonStr, dicc);

               string hs= JSAHelpEN.toolsFactory.JsonPars.GetJsonValue("name",newJsonStr)[0];

                if (hs.Equals("HHHHHH"))
                {
                    result[0] = "true";
                    result[1] = "json解析:";
                    result[2] = "测试正常!";
                    result[3] = "";
                    return result;
                }
                else {
                    throw new Exception("json解析异常！");                
                }
            }
            catch (Exception ex)
            {
                result[0] = "false";
                result[1] = "json解析:";
                result[2] = "测试异常!";
                result[3] = ex.Message;
                return result;
            }
        }
    }
}
