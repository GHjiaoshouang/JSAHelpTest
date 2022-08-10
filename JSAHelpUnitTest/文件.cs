using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using static JSAHelpEN.toolsFactory;

namespace JSAHelpUnitTest
{
    [TestClass]
    public class 文件
    {
        [TestMethod]
        public void TestMethod1()
        {

            string str = "Test string";
            // save
            Assert.IsTrue(LocalFileManage.SaveFileToDirectory(str, PathHelper.GetCallDomainPath(), "TestFile.txt", Encoding.UTF8, false));//   保存文件到程序目录
            Assert.IsTrue(LocalFileManage.SaveFileToEnumerationDirectory(str, PathHelper.FilePathEnumerate.Desktop, "TestDesktop.txt", "", Encoding.UTF8, false));//   保存文件到桌面
     
            // read
            string info= LocalFileManage.ReadFileToDirectory(Path.Combine(PathHelper.GetCallDomainPath(), "TestFile.txt"));// 读取指定目录文件的内容
            Assert.IsTrue(info.Length>0);
        }

    }

}
