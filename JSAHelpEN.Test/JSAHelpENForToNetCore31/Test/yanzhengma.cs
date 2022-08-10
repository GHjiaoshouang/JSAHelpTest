using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSAHelpENForToNetCore31.Test
{
    public class yanzhengma
    {
        //验证码生成
        public static string[] One()
        {
            string[] result = new string[4];
            try
            {
                JSAHelpEN.toolsFactory.VerificationCode.ArithmeticEquation Vstr = JSAHelpEN.toolsFactory.VerificationCode.CreateValidateArithmetic();
                List<string> str=  Vstr.text;   // 算数式
                string vv = Vstr.value;         // 算数式结果
               string sNum= JSAHelpEN.toolsFactory.VerificationCode.CreateValidateNumber(5);
  
                result[0] = "true";
                result[1] = "验证码生成:";
                result[2] = "请自行检测是否有验证码生成！!";
                result[3] = "";
                return result;
            }
            catch (Exception ex)
            {
                result[0] = "false";
                result[1] = "验证码生成:";
                result[2] = "测试异常!";
                result[3] = ex.Message;
                return result;
            }
        }

    }
}
