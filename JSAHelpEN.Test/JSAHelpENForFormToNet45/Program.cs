using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static JSAHelpEN.toolsFactory;

namespace JSAHelpENForFormToNet45
{
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {

            string ssr = ApplicationFunc.HandingMethodTryCatch(AnyPCInfoEnumerate.Sys6,SystemManager.GetSystemAnyInfo,null);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
