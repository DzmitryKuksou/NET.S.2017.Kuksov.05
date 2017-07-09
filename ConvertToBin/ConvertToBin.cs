using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertToBin
{
    public static class ConvertToBinary
    {
        public static string FloatToBin(this double number)
        {
            int[] array = new int[sizeof(int) * 4];
            double a = 0.12313;

            return a.ToString();

        }
        private static string DecToBin(int number)
        {
            if (number >= 0)
            {
                int maxBit = 32;
                string result = string.Empty;
                int[] resultArray = new int[32];
                for (; number > 0; number /= 2)
                {
                    int i = number % 2;
                    resultArray[--maxBit] = i;
                }
                for (int i = 0; i < resultArray.Length; i++)
                {
                    result += resultArray[i].ToString();
                }
                return result;
            }
            else return "";
        }
        }
}
