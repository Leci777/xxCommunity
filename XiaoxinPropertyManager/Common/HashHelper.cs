using System.Security.Cryptography;
using System.Text;

namespace XiaoxinPropertyManager.Common
{
    // 密码用 MD5 加密，数据库里存的是大写十六进制
    public static class HashHelper
    {
        public static string Md5(string input)
        {
            using (var md5 = MD5.Create())
            {
                byte[] data = md5.ComputeHash(Encoding.UTF8.GetBytes(input ?? string.Empty));
                var sb = new StringBuilder();
                for (int i = 0; i < data.Length; i++)
                {
                    sb.Append(data[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }

        // 比对用户输入的密码和数据库里存的是否一样
        public static bool Verify(string plainText, string storedHash)
        {
            if (string.IsNullOrEmpty(storedHash)) return false;
            return string.Equals(Md5(plainText), storedHash.Trim().ToUpperInvariant());
        }

        // 123456 的加密结果，提示初始密码时用
        public const string DefaultPasswordHash = "E10ADC3949BA59ABBE56E057F20F883E";
    }
}
