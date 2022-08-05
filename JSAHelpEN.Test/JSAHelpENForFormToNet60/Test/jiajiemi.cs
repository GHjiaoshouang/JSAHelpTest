using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSAHelpENForFormToNet60.Test
{
    internal class jiajiemi
    {
        /// <summary>
        /// 加解密
        /// </summary>
        /// <returns></returns>
        public static string[] One()
        {
            bool flag = false;
            bool flag2 = false;
            string[] result = new string[4];
            try
            {
                string str = "This is a string.";
                string defaultStr = "This is a string.";
                str = JSAHelpEN.toolsFactory.EncryptionAndDecryption.AESEncrypt(str);

                str = JSAHelpEN.toolsFactory.EncryptionAndDecryption.AESDecrypt(str);

        
                //str = JSAHelpEN.toolsFactory.EncryptionAndDecryption.AESEncrypt2(str, "16262626262626262626262626262626");

                //str = JSAHelpEN.toolsFactory.EncryptionAndDecryption.AESDecrypt(str, "16262626262626262626262626262626");

                //str = JSAHelpEN.toolsFactory.EncryptionAndDecryption.AESDecrypt2(str, "16262626262626262626262626262626");


                str = JSAHelpEN.toolsFactory.EncryptionAndDecryption.Base64Encrypt(str);

                str = JSAHelpEN.toolsFactory.EncryptionAndDecryption.Base64Decrypt(str);

                str = JSAHelpEN.toolsFactory.EncryptionAndDecryption.DESEncrypt(str, "19087654");
                str = JSAHelpEN.toolsFactory.EncryptionAndDecryption.DESDecrypt(str, "19087654");

                str = JSAHelpEN.toolsFactory.EncryptionAndDecryption.RC4Encrypt(str);

                str = JSAHelpEN.toolsFactory.EncryptionAndDecryption.RC4Decrypt(str);
                string key = "";
                string key2 = "";
                JSAHelpEN.toolsFactory.EncryptionAndDecryption.RSAGetPublicKeyOrPrivateKey(ref key, ref key2);
                str = JSAHelpEN.toolsFactory.EncryptionAndDecryption.RSAEncrypt(str, key);

                str = JSAHelpEN.toolsFactory.EncryptionAndDecryption.RSADecrypt(str, key2);


                str = JSAHelpEN.toolsFactory.EncryptionAndDecryption.SQLSpecificEncryption(str);

                str = JSAHelpEN.toolsFactory.EncryptionAndDecryption.SQLSpecificDecryption(str);

                if (str.Equals(defaultStr))
                {
                    flag = true;
                }

                //非对称加密
                JSAHelpEN.toolsFactory.EncryptionAndDecryption.HASH2Encrypt(str);
                JSAHelpEN.toolsFactory.EncryptionAndDecryption.MD5Encrypt(str);
                JSAHelpEN.toolsFactory.EncryptionAndDecryption.PBKDF2Encrypt(str);
                JSAHelpEN.toolsFactory.EncryptionAndDecryption.SHA1Encrypt(str);
                JSAHelpEN.toolsFactory.EncryptionAndDecryption.SHA224Encrypt(str);
                JSAHelpEN.toolsFactory.EncryptionAndDecryption.SHA256Encrypt(str);
                JSAHelpEN.toolsFactory.EncryptionAndDecryption.SHA384Encrypt(str);
                JSAHelpEN.toolsFactory.EncryptionAndDecryption.SHA512Encrypt(str);
                JSAHelpEN.toolsFactory.EncryptionAndDecryption.TripdesEncrypt(str, "88888888888888888888888888888888");
                flag2 = true;

                if (flag && flag2)
                {
                    result[0] = "true";
                    result[1] = "加解密:";
                    result[2] = "测试正常!";
                    result[3] = "";
                    return result;
                }
                else
                {
                    throw new Exception("加解密出现问题！");
                }
            }
            catch (Exception ex)
            {
                result[0] = "false";
                result[1] = "加解密:";
                result[2] = "加解密异常!";
                result[3] = ex.Message;
                return result;
            }
        }
    }
}
