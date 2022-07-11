using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace GeneratorLib
{
    public static class Generator
    {
        public static long GenerirajBarkod()
        {
            Random rand = new Random();
            
            long min = 100000000000;
            long max = 999999999999;

            byte[] buf = new byte[8];
            rand.NextBytes(buf);
            long longRand = BitConverter.ToInt64(buf, 0);

            return (Math.Abs(longRand % (max - min)) + min);
        }

        public static string GenerirajSifru(int length)
        {
            StringBuilder sb = new StringBuilder();
            Random rand = new Random();

            const string chars = "0123456789abcdefghijkmnopqrstuvwxyzABCDEFGHJKLMNOPQRSTUVWXYZ";

            for (int i = 0; i < length; i++)
            {
                int index = rand.Next(chars.Length);
                sb.Append(chars[index]);
            }

            return sb.ToString();
        }
    }
}
