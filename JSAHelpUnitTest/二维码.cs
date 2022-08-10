using Microsoft.VisualStudio.TestTools.UnitTesting;
using static JSAHelpEN.toolsFactory;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace JSAHelpUnitTest
{
    [TestClass]
    public class 二维码
    {
        [TestMethod]
        public void TestMethod1()
        {
            QRCodeHelper.QRsetting qRsetting = new QRCodeHelper.QRsetting();
            qRsetting.IsCreateQRcode = true;
            string[] vs = new string[] { "111123" };
            Dictionary<Bitmap, string> bit = QRCodeHelper.GetQRCode(vs, qRsetting); //创建二维码
            string pathImage = QRCodeHelper.GetQRcodeImagePath(bit);        //获取生成二维码路径
            Assert.IsNotNull(pathImage);            
        }
    }
}
