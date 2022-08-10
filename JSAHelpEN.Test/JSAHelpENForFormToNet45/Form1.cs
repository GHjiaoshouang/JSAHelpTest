using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JSAHelpENForFormToNet45
{
    public partial class Form1 : Form
    {
        string[] res = new string[4];
        public Form1()
        {
            InitializeComponent();
            JSAHelpEN.toolsFactory.WinfromManager WM = new JSAHelpEN.toolsFactory.WinfromManager(this, this.richTextBox1);


        }

        private void TestClick_Click(object sender, EventArgs e)
        {
            JSAHelpEN.toolsFactory.isReturnExceptionMessage = true;
            bool flag = false;
            foreach (Control MyCheckBox in groupBox1.Controls)
            {
                if (MyCheckBox is CheckBox)
                {
                    CheckBox ck = MyCheckBox as CheckBox;
                    if (ck.Checked)

                    {
                        ck.ForeColor = Color.Green;
                        select(ck);
                        if (res[0] == "true")
                        {
                            ck.ForeColor = Color.Green;
                        }
                        else
                        {
                            flag = true;
                            ck.ForeColor = Color.Red;
                        }
                        if (checkBox_yibu.Checked)
                        {
                            JSAHelpEN.toolsFactory.ThreadTools.QueueUserWorkItem(res =>
                            {
                                Show(ck);
                            });

                        }
                        else
                        {
                            Show(ck);
                        }
                        Application.DoEvents();
                    }
                    else
                    {
                        ck.ForeColor = Color.Black;
                    }
                }
            }
            if (flag)
            {
                MessageBox.Show(richTextBox1.Text);
            }
        }
        ///<summary>/// 输出
        ///</summary>///<param name="content"></param>///<param name="color"></param>
        private void Output(string content, Color color)
        {
            Invoke(new MethodInvoker(delegate ()
            {
                //        //超出一万行，清空this._lines++;
                //        if (this._lines > 10000)
                //        {
                //    this.txtOutput.Text = string.Empty;
                //    this._lines = 1;
                //}

                content += Environment.NewLine;
                this.richTextBox1.SelectionColor = color;//设置文本颜色
                this.richTextBox1.AppendText(content);//输出文本，换行

                this.richTextBox1.SelectionStart = this.richTextBox1.Text.Length;//设置插入符位置为文本框末
                this.richTextBox1.ScrollToCaret();//滚动条滚到到最新插入行
                                                  //
            }));
            JSAHelpEN.toolsFactory.WinfromManager.Refresh(100000);
            //JSAHelpEN.toolsFactory.WinfromManager.DelayMs();
        }

        private void select(CheckBox ck)
        {

            switch (ck.Text)
            {
                case "签名":
                    res = Test.QianMing.One();
                    break;
                case "异步":
                    res[0] = "true";
                    res[1] = "异步:";
                    res[2] = "测试正常!";
                    res[3] = "";
                    break;
                case "日志":
                    res = Test.RiZhi.One();
                    break;
                case "缓存":
                    res = Test.huancun.One();
                    break;
                case "路径":
                    res = Test.lujing.One();
                    break;
                case "验证码":
                    res = Test.yanzhengma.One();
                    //
                    JSAHelpEN.toolsFactory.VerificationCode.BitmapParam bitmapParam = new JSAHelpEN.toolsFactory.VerificationCode.BitmapParam();
                    List<string> vs = new List<string>();
                    vs.Add(JSAHelpEN.toolsFactory.VerificationCode.CreateValidateNumber(5));
                    bitmapParam.textarr = vs;
                    JSAHelpEN.toolsFactory.VerificationCode.BitmapStyle bitmapStyle = new JSAHelpEN.toolsFactory.VerificationCode.BitmapStyle();
                    bitmapStyle.IsGif = false;
                    Bitmap bitmap = JSAHelpEN.toolsFactory.VerificationCode.CreateValidateImage(bitmapParam, bitmapStyle);
                    pictureBox1.Image = bitmap;
                    res[0] = "true";
                    res[1] = "验证码:";
                    res[2] = "测试正常!";
                    res[3] = "";
                    JSAHelpEN.toolsFactory.WinfromManager.Refresh();
                    break;
                case "文件":
                    res = Test.wenjian.One();
                    if (res[0] != "true")
                    {
                        res[3] += res[3];
                    }
                    res = Test.wenjian.Two();
                    if (res[0] != "true")
                    {
                        res[3] += res[3];
                    }
                    break;

                case "字符串处理":
                    res = Test.zhifucuanchuli.One();
                    if (res[0] != "true")
                    {
                        res[3] += res[3];
                    }
                    res = Test.zhifucuanchuli.Two();
                    if (res[0] != "true")
                    {
                        res[3] += res[3];
                    }
                    res = Test.zhifucuanchuli.Three();
                    if (res[0] != "true")
                    {
                        res[3] += res[3];
                    }
                    break;

                case "JSON解析":
                    res = Test.jsonjiexi.One();
                    break;

                case "XML解析":
                    res = Test.xmljiexi.One();
                    break;

                case "网络":
                    bool flag = JSAHelpEN.toolsFactory.Network.Internet();// 判断是否可以通外网         
                    bool flag2 = JSAHelpEN.toolsFactory.Network.Ping("127.0.0.1");// 判断ip地址是否可以连接
                    res[0] = "true";
                    res[1] = "验证码:";
                    res[2] = "测试正常!";
                    res[3] = "";
                    break;

                case "表格":
                    res = Test.biaoge.One();
                    if (res[0] != "true")
                    {
                        res[3] += res[3];
                    }
                    res = Test.biaoge.Two();
                    if (res[0] != "true")
                    {
                        res[3] += res[3];
                    }
                    break;

                case "加解密":
                    res = Test.jiajiemi.One();
                    break;

                case "熔断":
                    res = Test.rongduan.One();
                    break;

                case "压缩":
                    res = Test.yasuo.One();
                    break;
                case "二维码":

                    JSAHelpEN.toolsFactory.QRCodeHelper.QRsetting qRsetting = new JSAHelpEN.toolsFactory.QRCodeHelper.QRsetting();
                    qRsetting.IsCreateQRcode = true;
                    qRsetting.IconSize = 8;
                    string[] vs1 = { "1234567890" };
                    Dictionary<Bitmap, string> dicImg = JSAHelpEN.toolsFactory.QRCodeHelper.GetQRCode(vs1, qRsetting);
                    pictureBox1.Image = JSAHelpEN.toolsFactory.QRCodeHelper.GetQRcodeImage(dicImg);
                    //pictureBox1.Image= JSAHelpEN.toolsFactory.BarCodeHelper.GetBarcode("123123123");
                    //string encry = JSAHelpEN.toolsFactory.ApplicationFunc.HandingMethodTryCatch5("123123123", JSAHelpEN.toolsFactory.EncryptionAndDecryption.MD5Encrypt);
                    //string encry2 = JSAHelpEN.toolsFactory.TryCatchExtensions.HandingMethodTryCatch("sdsd", JSAHelpEN.toolsFactory.EncryptionAndDecryption.MD5Encrypt);
                    //pictureBox1.Image = JSAHelpEN.toolsFactory.TryCatchExtensions.TryCatch(dicImg, JSAHelpEN.toolsFactory.QRCodeHelper.GetQRcodeImage, null, null);


                    res[0] = "true";
                    res[1] = "二维码:";
                    res[2] = "测试正常!";
                    res[3] = "";
                    break;
                case "数据库":
                    res = Test.shujuku.One();
                    break;
                case "CMD":
                    res = Test.cmd.One();
                    break;
                case "注册表":
                    res = Test.Regedit.One();
                    break;
                case "系统":
                    res = Test.xitong.One();
                    break;
                case "服务":
                    res = Test.fuwu.One();
                    res = Test.fuwu.Two();
                    res = Test.fuwu.Three();
                    break;
                default:
                    break;
            }

        }

        private void Fault(Exception obj)
        {
            MessageBox.Show("失败！" + obj);

        }


        private void Show(CheckBox ck)
        {
            if (res[0] == "true")
            {
                //Output("------------["+ ck.Name + "]------------", Color.Black);
                JSAHelpEN.toolsFactory.WinfromManager.richTextBoxWriteLine("--------[" + ck.Name + "]--------", Color.Black);
                JSAHelpEN.toolsFactory.WinfromManager.richTextBoxWriteLine(res[1], Color.Black);
                JSAHelpEN.toolsFactory.WinfromManager.richTextBoxWriteLine(res[2], Color.Green);
                JSAHelpEN.toolsFactory.WinfromManager.richTextBoxWriteLine(res[3], Color.Blue);
                //Output(res[1], Color.Black);
                //Output(res[2], Color.Green);
                //Output(res[3], Color.Blue);
            }
            else
            {

                JSAHelpEN.toolsFactory.WinfromManager.richTextBoxWriteLine("--------[" + ck.Name + "]--------", Color.Black, this.richTextBox2, isRefreshAsyncTime: 200);
                JSAHelpEN.toolsFactory.WinfromManager.richTextBoxWriteLine(res[1], Color.Black, this.richTextBox2, isRefreshAsyncTime: 200);
                JSAHelpEN.toolsFactory.WinfromManager.richTextBoxWriteLine(res[2], Color.Blue, this.richTextBox2, isRefreshAsyncTime: 200);
                JSAHelpEN.toolsFactory.WinfromManager.richTextBoxWriteLine(res[3], Color.Red, this.richTextBox2, isRefreshAsyncTime: 200);

                //Output("------------["+ ck.Name + "]------------", Color.Black);
                //Output(res[1], Color.Black);
                //Output(res[2], Color.Blue);
                //Output(res[3], Color.Red);
            }
            res = new string[4];

        }
    }
}
