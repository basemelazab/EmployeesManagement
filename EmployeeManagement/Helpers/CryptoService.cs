using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;

namespace EmployeeManagement.Helpers
{
    public class CryptoService
    {
        private const int saltSize = 32;
        public static byte[] GenerateSalt()
        {
            using(var rng = new RNGCryptoServiceProvider())
            {
                var RandomNumber=new byte[saltSize];
                rng.GetBytes(RandomNumber);
                return RandomNumber;
            }
        }
        public static byte[] ComputeHMAC256(byte[]data, byte[] salt)
        {
            using(var hmac = new HMACSHA256(salt))
            {
                return hmac.ComputeHash(data);
            }
        }
    }
}