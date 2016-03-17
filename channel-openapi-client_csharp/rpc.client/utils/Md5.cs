using System;
using System.Security.Cryptography;

namespace com.hzins.rpc.client.utils
{
    /// <summary>
    /// md5工具类
    /// </summary>
    public class Md5
    {
        /// <summary>
        /// md5序列化
        /// </summary>
        /// <param name="src"></param>
        /// <returns></returns>
        public static string encrypt(string src)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] result = md5.ComputeHash(System.Text.Encoding.Default.GetBytes(src));
            string x = BitConverter.ToString(result).Replace("-", "").ToLower();
            return x;


        }


    }
}
