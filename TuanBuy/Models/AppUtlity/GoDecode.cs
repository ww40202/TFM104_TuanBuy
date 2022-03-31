using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace TuanBuy.Models.AppUtlity
{
    public class GoDecode
    {
        public static string Decode(string str)
        {
            try
            {
                string textToDecrypt = str;
                string ToReturn = "";
                string publicKey = "12345678";
                string secretKey = "87654321";
                byte[] privateKeyByte = { };
                privateKeyByte = System.Text.Encoding.UTF8.GetBytes(secretKey);
                byte[] publicKeyByte = { };
                publicKeyByte = System.Text.Encoding.UTF8.GetBytes(publicKey);
                MemoryStream ms = null;
                CryptoStream cs = null;
                byte[] inputbyteArray = new byte[textToDecrypt.Replace(" ", "+").Length];
                inputbyteArray = Convert.FromBase64String(textToDecrypt.Replace(" ", "+"));
                using (DESCryptoServiceProvider des = new DESCryptoServiceProvider())
                {
                    ms = new MemoryStream();
                    cs = new CryptoStream(ms, des.CreateDecryptor(publicKeyByte, privateKeyByte), CryptoStreamMode.Write);
                    cs.Write(inputbyteArray, 0, inputbyteArray.Length);
                    cs.FlushFinalBlock();
                    Encoding encoding = Encoding.UTF8;
                    ToReturn = encoding.GetString(ms.ToArray());
                }
                return ToReturn;
            }
            catch (Exception ae)
            {
                throw new Exception(ae.Message, ae.InnerException);
            }
        }
    }
}
