using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSAHelpENForFormToNet472.Test
{
    internal class shujuku
    {
        //数据库
        public static string[] One()
        {
            bool flag = false;
            bool flag2 = false;
            bool flag3 = false;
            string[] result = new string[4];
            try
            {
                string mysql = "server=127.0.0.1;port=3306;user=root;password=root;database=Admin;SslMode=none;charset=utf8mb4";
                string pgsql = "server=localhost; port=5432; Database=Admin; user Id=postgres; password=root";
                string sqlser = "Server=127.0.0.1,40906;Database=Admin;User Id=sa;Password=root;";
                string sqlnpg = "SELECT * FROM \"Admin\".\"public\".\"StudentInfo\"";
                string sqlmy = "SELECT * FROM studentinfo";
                string sqlserver = "SELECT top 30 * FROM [Admin].[dbo].[Admin]";
                DataTable dt = (DataTable)JSAHelpEN.toolsFactory.SQL.Query<DataTable>(JSAHelpEN.toolsFactory.SQL.SqlType.MySql, sqlmy, mysql);
                DataTable dt2 = (DataTable)JSAHelpEN.toolsFactory.SQL.Query<DataTable>(JSAHelpEN.toolsFactory.SQL.SqlType.NpgSql, sqlnpg, pgsql);
                DataTable dt3 = (DataTable)JSAHelpEN.toolsFactory.SQL.Query<DataTable>(JSAHelpEN.toolsFactory.SQL.SqlType.SqlServer, sqlserver, sqlser);

                if (dt.Rows.Count > 0)
                {
                    flag = true;
                }
                if (dt2.Rows.Count > 0)
                {
                    flag2 = true;
                }
                if (dt3.Rows.Count > 0)
                {
                    flag3 = true;
                }
                if (flag && flag2&& flag3)
                {
                    result[0] = "true";
                    result[1] = "数据库:";
                    result[2] = "测试正常!";
                    result[3] = "";
                    return result;
                }
                else
                {
                    throw new Exception("数据库查询失败！");
                }

            }
            catch (Exception ex)
            {
                result[0] = "false";
                result[1] = "数据库:";
                result[2] = "测试异常!";
                result[3] = ex.Message;
                return result;
            }
        }
    }
}
