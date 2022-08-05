namespace JSAHelpENForFormToNet60
{
    public partial class Form1 : Form
    {
        string[] res = new string[4];
        public Form1()
        {
            InitializeComponent();
            JSAHelpEN.toolsFactory.WinfromManager WM= new JSAHelpEN.toolsFactory.WinfromManager(this,this.richTextBox1);
           

        }

        private void TestClick_Click(object sender, EventArgs e)
        {           
            JSAHelpEN.toolsFactory.isReturnExceptionMessage=true;
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
                            flag=true;
                            ck.ForeColor = Color.Red;
                        }
                        if (checkBox_yibu.Checked)
                        {
                            JSAHelpEN.toolsFactory.ThreadTools.QueueUserWorkItem(res =>
                            {
                                Show(ck);
                            });
                            
                        }
                        else {
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
        ///<summary>/// ���
        ///</summary>///<param name="content"></param>///<param name="color"></param>
        private void Output(string content, Color color)
        {
            Invoke(new MethodInvoker(delegate ()
            {
                //        //����һ���У����this._lines++;
                //        if (this._lines > 10000)
                //        {
                //    this.txtOutput.Text = string.Empty;
                //    this._lines = 1;
                //}

                content += Environment.NewLine;
                this.richTextBox1.SelectionColor = color;//�����ı���ɫ
                this.richTextBox1.AppendText(content);//����ı�������

                this.richTextBox1.SelectionStart = this.richTextBox1.Text.Length;//���ò����λ��Ϊ�ı���ĩ
                this.richTextBox1.ScrollToCaret();//���������������²�����
                                               //
            }));
             JSAHelpEN.toolsFactory.WinfromManager.Refresh(100000);
            //JSAHelpEN.toolsFactory.WinfromManager.DelayMs();
        }

        private void select(CheckBox ck)
        {

            switch (ck.Text)
            {
                case "ǩ��":
                    res = Test.QianMing.One();
                    break;
                case "�첽":
                    res[0] = "true";
                    res[1] = "�첽:";
                    res[2] = "��������!";
                    res[3] = "";
                    break;
                case "��־":
                    res = Test.RiZhi.One();
                    break;
                case "����":
                    res = Test.huancun.One();
                    break;
                case "·��":
                    res = Test.lujing.One();
                    break;
                case "��֤��":
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
                    res[1] = "��֤��:";
                    res[2] = "��������!";
                    res[3] = "";
                    JSAHelpEN.toolsFactory.WinfromManager.Refresh();
                    break;
                case "�ļ�":
                    res=Test.wenjian.One();
                    if (res[0] != "true")
                    {
                        res[3] += res[3];
                    }
                    res =Test.wenjian.Two();
                    if (res[0] != "true")
                    {
                        res[3] += res[3];
                    }
                    break;

                case "�ַ�������":
                    res=Test.zhifucuanchuli.One();
                    if (res[0] != "true") { 
                    res[3]+=res[3];
                    }
                    res=Test.zhifucuanchuli.Two();
                    if (res[0] != "true")
                    {
                        res[3] += res[3];
                    }
                    res =Test.zhifucuanchuli.Three();
                    if (res[0] != "true")
                    {
                        res[3] += res[3];
                    }
                    break;

                case "JSON����":
                    res = Test.jsonjiexi.One();
                    break;

                case "XML����":
                    res = Test.xmljiexi.One();
                    break;

                case "����":

                    break;

                case "���":
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

                case "�ӽ���":
                    res = Test.jiajiemi.One();
                    break;

                case "�۶�":
                    res = Test.rongduan.One();
                    break;

                case "ѹ��":
                    res = Test.yasuo.One();
                    break;
                case "��ά��":
                    string path = "";
                    JSAHelpEN.toolsFactory.QRCodeHelper.QRsetting qRsetting = new JSAHelpEN.toolsFactory.QRCodeHelper.QRsetting();
                    qRsetting.IsCreateQRcode = true;
                    qRsetting.IconSize = 8;
                    string[] vs1 = { "1234567890" };
                   Dictionary<Bitmap,string> dicImg = JSAHelpEN.toolsFactory.QRCodeHelper.GetQRCode(vs1, qRsetting);
                    pictureBox1.Image = JSAHelpEN.toolsFactory.QRCodeHelper.GetQRcodeImage(dicImg);
                    //pictureBox1.Image= JSAHelpEN.toolsFactory.BarCodeHelper.GetBarcode("123123123");
                    //string encry = JSAHelpEN.toolsFactory.ApplicationFunc.HandingMethodTryCatch5("123123123", JSAHelpEN.toolsFactory.EncryptionAndDecryption.MD5Encrypt);
                    //string encry2 = JSAHelpEN.toolsFactory.TryCatchExtensions.HandingMethodTryCatch("sdsd", JSAHelpEN.toolsFactory.EncryptionAndDecryption.MD5Encrypt);
                    //pictureBox1.Image = JSAHelpEN.toolsFactory.TryCatchExtensions.TryCatch(dicImg, JSAHelpEN.toolsFactory.QRCodeHelper.GetQRcodeImage, null, null);


                    res[0] = "true";
                    res[1] = "��ά��:";
                    res[2] = "��������!";
                    res[3] = "";
                    break;
                case "���ݿ�":
                    res = Test.shujuku.One();
                    break;
                case "CMD":
                    res = Test.cmd.One();
                    break;
                case "ע���":
                    res = Test.Regedit.One();
                    break;
                case "ϵͳ":
                    res = Test.xitong.One();
                    break;
                case "����":
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
            MessageBox.Show("ʧ�ܣ�"+obj);
 
        }


        private void Show(CheckBox ck)
        {
            if (res[0] == "true")
            {
                //Output("------------["+ ck.Name + "]------------", Color.Black);
                JSAHelpEN.toolsFactory.WinfromManager.richTextBoxWriteLine("--------[" + ck.Name + "]--------", Color.Black);
                JSAHelpEN.toolsFactory.WinfromManager.richTextBoxWriteLine( res[1], Color.Black);
                JSAHelpEN.toolsFactory.WinfromManager.richTextBoxWriteLine( res[2], Color.Green);
                JSAHelpEN.toolsFactory.WinfromManager.richTextBoxWriteLine( res[3], Color.Blue);
                //Output(res[1], Color.Black);
                //Output(res[2], Color.Green);
                //Output(res[3], Color.Blue);
            }
            else {

                JSAHelpEN.toolsFactory.WinfromManager.richTextBoxWriteLine("--------[" + ck.Name + "]--------", Color.Black, this.richTextBox2, isRefreshAsyncTime: 200);
                JSAHelpEN.toolsFactory.WinfromManager.richTextBoxWriteLine( res[1], Color.Black, this.richTextBox2, isRefreshAsyncTime: 200);
                JSAHelpEN.toolsFactory.WinfromManager.richTextBoxWriteLine( res[2], Color.Blue, this.richTextBox2, isRefreshAsyncTime: 200);
                JSAHelpEN.toolsFactory.WinfromManager.richTextBoxWriteLine( res[3], Color.Red, this.richTextBox2,isRefreshAsyncTime:200);

                //Output("------------["+ ck.Name + "]------------", Color.Black);
                //Output(res[1], Color.Black);
                //Output(res[2], Color.Blue);
                //Output(res[3], Color.Red);
            }
            res = new string[4];

        }
    }
}