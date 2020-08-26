using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SEN_Account_Generator_by_Unknauwn
{
    class Security
    {
        #region Encore/Decode
        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }
        public static string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }
        #endregion
        #region PHPCrypt
        public class APIProtect
        {
            public static String AES_Key = "PSVJQRk9QTEpNVU1DWUUNKVFGV1VVT0ZOV1RRU1NaWQ=";
            public static String AES_IV = "YWlFLVEZUNKNaWlhPQ01ZT0lLWU5HTFJQVFNCRUJZVA=";
            #region ProtectKey
            public static String ProtectKey(String Input)
            {
                var aes = new RijndaelManaged();
                aes.KeySize = 256;
                aes.BlockSize = 256;
                aes.Padding = PaddingMode.PKCS7;
                aes.Key = Convert.FromBase64String(AES_Key);
                aes.IV = Convert.FromBase64String(AES_IV);

                var encrypt = aes.CreateEncryptor(aes.Key, aes.IV);
                byte[] xBuff = null;
                using (var ms = new MemoryStream())
                {
                    using (var cs = new CryptoStream(ms, encrypt, CryptoStreamMode.Write))
                    {
                        byte[] xXml = Encoding.UTF8.GetBytes(Input);
                        cs.Write(xXml, 0, xXml.Length);
                    }

                    xBuff = ms.ToArray();
                }

                String Output = Convert.ToBase64String(xBuff);
                return Output;
            }

            public static String UnProtectKey(String Input)
            {
                RijndaelManaged aes = new RijndaelManaged();
                aes.KeySize = 256;
                aes.BlockSize = 256;
                aes.Mode = CipherMode.CBC;
                aes.Padding = PaddingMode.PKCS7;
                aes.Key = Convert.FromBase64String(AES_Key);
                aes.IV = Convert.FromBase64String(AES_IV);

                var decrypt = aes.CreateDecryptor();
                byte[] xBuff = null;
                using (var ms = new MemoryStream())
                {
                    using (var cs = new CryptoStream(ms, decrypt, CryptoStreamMode.Write))
                    {
                        byte[] xXml = Convert.FromBase64String(Input);
                        cs.Write(xXml, 0, xXml.Length);
                    }

                    xBuff = ms.ToArray();
                }

                String Output = Encoding.UTF8.GetString(xBuff);
                return Output;
            }

            #endregion
            #region ProtectInfosURL
            public static byte[] key = Encoding.UTF8.GetBytes("PSVJQRK9QTEPNVU1DWUUNKVFGV1VVT0=");
            public static byte[] IV = Encoding.UTF8.GetBytes("YWaFL6EZUNKN0WL=");

            public static String protect64(String Text)
            {
                byte[] encodedbytes = System.Text.ASCIIEncoding.ASCII.GetBytes(Text);
                return System.Convert.ToBase64String(encodedbytes);
            }
            public static String unprotect64(String Text)
            {
                byte[] tobedecodedbytes = System.Convert.FromBase64String(Text);
                return System.Text.ASCIIEncoding.ASCII.GetString(tobedecodedbytes);
            }
            public static String ProtectInfos(String s)
            {
                String result;
                RijndaelManaged rijn = new RijndaelManaged();
                rijn.Mode = CipherMode.ECB;
                rijn.Padding = PaddingMode.Zeros;
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (ICryptoTransform encryptor = rijn.CreateEncryptor(key, IV))
                    {
                        using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                        {
                            using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                            {
                                swEncrypt.Write(s);
                            }
                        }
                    }
                    result = Convert.ToBase64String(msEncrypt.ToArray());
                }
                rijn.Clear();
                return result;
            }
            public static String UnProtectInfos(String s)
            {
                String result;
                RijndaelManaged rijn = new RijndaelManaged();
                rijn.Mode = CipherMode.ECB;
                rijn.Padding = PaddingMode.Zeros;
                using (MemoryStream msDecrypt = new MemoryStream(Convert.FromBase64String(s)))
                {
                    using (ICryptoTransform decryptor = rijn.CreateDecryptor(key, IV))
                    {
                        using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                        {
                            using (StreamReader swDecrypt = new StreamReader(csDecrypt))
                            {
                                result = swDecrypt.ReadToEnd();
                            }
                        }
                    }
                }
                rijn.Clear();
                return result;
            }

            #endregion
        }
        #endregion
    }
}
