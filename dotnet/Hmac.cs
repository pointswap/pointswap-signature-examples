using System;
using System.Security.Cryptography;
using System.Text;

namespace PointSwap
{
    public static class Hmac
    {
        /// <summary>Signs the given value with the given key using HMAC-SHA512.</summary>
        public static string Sign(string val, string key) {
            byte[] keyBytes = Encoding.UTF8.GetBytes(key);
            using(HMACSHA512 hmacsha512 = new HMACSHA512(keyBytes)) {
                byte[] sourceBytes = Encoding.UTF8.GetBytes(val);

                byte[] hash = hmacsha512.ComputeHash(sourceBytes);

                return BitConverter.ToString(hash).Replace("-", "").ToLower();
            }
        }
    }
}
