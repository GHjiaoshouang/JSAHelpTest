using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using static JSAHelpEN.toolsFactory;

namespace JSAHelpUnitTest
{
    [TestClass]
    public class 日志
    {
        [TestMethod]
        public void TestMethod1()
        {            
            Logger.InitializationSetting.logType = logSaveType.txt; //日志类型设置
            Logger.InitializationSetting.logPath = PathHelper.FilePathEnumerate.ProgramNoDebug; //日志路径设置
            Trace.WriteLine(LogsLevel.Level1,"Test write.");    //日志记录
            List<string> list = JSAHelpEN.toolsFactory.PathHelper.GetFilesFromFolder(JSAHelpEN.toolsFactory.PathHelper.GetSavePath(PathHelper.FilePathEnumerate.ProgramNoDebug, "Custom Logs"),System.IO.SearchOption.TopDirectoryOnly,"*.txt");
            Assert.IsTrue(list.Count>0);         
        }
    }
}
