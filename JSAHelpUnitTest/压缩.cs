using Microsoft.VisualStudio.TestTools.UnitTesting;
using static JSAHelpEN.toolsFactory;
using System;
using System.IO;

namespace JSAHelpUnitTest
{
    [TestClass]
    public class 压缩
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = PathHelper.CombineSystemRelativePath(PathHelper.GetCallDomainPath(), "../");
            LocalFileManage.SaveFileToDirectory("Test string.",path,"AAAA.txt");
            string zipPath = PathHelper.CombineSystemRelativePath(path,"../../")+"AAAA.zip";
            bool flag=UncompressZIP.GitHubZip.GitHubZipZipFile(Path.Combine(path,"AAAA.txt"),zipPath);// 压缩
            Assert.IsTrue(flag);
        }
    }
}
