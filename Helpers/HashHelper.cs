using System.Security.Cryptography;
using System.Text;

namespace Oyuncakci.Helpers
{
    public static class HashHelper
    {
        public static string ComputeHash(string input)
        {
            using (var sha256 = SHA256.Create())
            {
                var bytes = Encoding.UTF8.GetBytes(input); //bytre dizisine çevirdik asc2 kodlarına 
                var hashBytes = sha256.ComputeHash(bytes); //byte dizisini hash sonucu için kullandık 32 elemanlı btye dizisi

                var sb = new StringBuilder(); //string için düzgün birleştirme yapmada kullanılır
                foreach (var b in hashBytes)
                {
                    sb.Append(b.ToString("x2")); // Hexadecimal format için burada tek tek dizi gezilir 16lık gösterim
                }

                return sb.ToString();
            }
        }

        public static bool VerifyHash(string input, string storedHash)
        {
            var inputHash = ComputeHash(input);
            return inputHash.Equals(storedHash);
        }
    }
}
