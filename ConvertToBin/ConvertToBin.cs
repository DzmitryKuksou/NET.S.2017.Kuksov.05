using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConvertToBin
{
    public static class ConvertToBinary
    {
        /// <summary>
        /// Converting To Binanry
        /// </summary>
        /// <param name="number">number</param>
        /// <returns>Binary in </returns>
        public static string ConvertToBin(this double number)
        {
            BitArray bits = new BitArray(BitConverter.GetBytes(number));
            return ToString(bits);
        }
        private static string ToString(BitArray arr)
        {
            StringBuilder str = new StringBuilder(arr.Length);
            for (int i = arr.Length - 1; i >= 0; i--)
                str.Append(arr[i] == true ? '1' : '0');
            return str.ToString();
        }
    }
}
