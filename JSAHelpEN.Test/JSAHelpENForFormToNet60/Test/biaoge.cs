using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSAHelpENForFormToNet60.Test
{
    internal class biaoge
    {
        
        /// <summary>
        /// 保存表格
        /// </summary>
        /// <returns></returns>
        public static string[] One()
        {
            string[] result = new string[4];
            try
            {
                //string jsonFilePath = JSAHelpEN.toolsFactory.PathHelper.GetSavePath(JSAHelpEN.toolsFactory.PathHelper.FilePathEnumerate.ProgramNoDebug,"JSON2.json", "myselfFolderTemp");

                string jsonStr = JSAHelpEN.toolsFactory.LocalFileManage.ReadFileToProgramDirectory("JSON2.json", "File");

                string saveTablePath= JSAHelpEN.toolsFactory.PathHelper.GetSavePath(JSAHelpEN.toolsFactory.PathHelper.FilePathEnumerate.ProgramNoDebug, "Test.txt", "myselfFolderTemp").Replace("Test.txt","");

               bool flag= JSAHelpEN.toolsFactory.SaveExcle.SaveTable(saveTablePath, jsonStr, "myTable", "csv");
                result[0] = "true";
                result[1] = "保存表格:";
                result[2] = "测试正常!";
                result[3] = "";
                return result;
            }
            catch (Exception ex)
            {
                result[0] = "false";
                result[1] = "保存表格:";
                result[2] = "测试异常!";
                result[3] = ex.Message;
                return result;
            }
        }
        /// <summary>
        /// 表格转换
        /// </summary>
        /// <returns></returns>
        public static string[] Two()
        {
            string[] result = new string[4];
            try
            {
                string jsonStr = JSAHelpEN.toolsFactory.LocalFileManage.ReadFileToProgramDirectory("JSON2.json", "File");

                DataTable dt = new DataTable();
                dt.Columns.Add("name");
                dt.Columns.Add("sex");
                dt.Columns.Add("age");
                dt.Rows.Add("夏天");
                dt.Rows.Add("女");
                dt.Rows.Add("22");
                DataSet ds = new DataSet();
                ds.Tables.Add(dt);

                //DataTable dt = JSAHelpEN.toolsFactory.JsonPars.ConvertByJsonToAnyT<DataTable>(jsonStr);

                //DataSet ds = JSAHelpEN.toolsFactory.JsonPars.ConvertByJsonToAnyT<DataSet>(jsonStr);



                Dictionary<string,List<Dictionary<string,object>>> dic=                         JSAHelpEN.toolsFactory.TableProcess.ConvertByDataSetToDictionary(ds);

                if (dic.Count<=0) {
                    throw new Exception("表格转换集合失败！");
                }

                List<Dictionary<string,object>> list=
                JSAHelpEN.toolsFactory.TableProcess.ConvertByDataTableToDictionary(dt);

                if (list.Count <= 0)
                {
                    throw new Exception("表格转换集合失败！");
                }

                result[0] = "true";
                result[1] = "表格转换:";
                result[2] = "测试正常!";
                result[3] = "";
                return result;
            }
            catch (Exception ex)
            {
                result[0] = "false";
                result[1] = "表格转换:";
                result[2] = "测试异常!";
                result[3] = ex.Message;
                return result;
            }
        }
    }
}
