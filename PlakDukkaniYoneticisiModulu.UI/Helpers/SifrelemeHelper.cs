using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PlakDukkaniYoneticisiModulu.UI.Helpers
{
    public class SifrelemeHelper
    {
        /// <summary>
        /// Girilen şifreyi SHA256 algoritması ile hashler ve büyük harfli hex formatında döner.
        /// </summary>
        /// <param name="sifre">Hashlenecek şifre</param>
        /// <returns>SHA256 ile hashlenmiş şifre (hexadecimal)</returns>
        public static string Sha256Hash(string sifre)
        {
            using (SHA256 hash = SHA256.Create())
            {
                return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(sifre))
                    .Select(b => b.ToString("X2")));
            }
        }
    }
}
