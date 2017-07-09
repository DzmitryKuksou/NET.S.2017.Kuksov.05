using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace NOD
{
    public static class NODofNumbers
    {
        /// <summary>
        /// checking of array numbers.
        /// </summary>
        /// <param name="a">array of numbers</param>
        private static void Checking(params int[] a)
        {
            if (a.Length < 2) throw new ArgumentOutOfRangeException($"nameof{a} has number of digits less then 2!");
        }
        /// <summary>
        /// Eucllid method for finding NOD.
        /// </summary>
        /// <param name="a">array of numbers</param>
        /// <returns>NOD, time finding</returns>
        public static Tuple<int, long> EucklidNOD(params int[] a)
        {
            Checking(a);
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            int c = a[0];
            for (int i = 0; i < a.Length; i++) 
            {
                c = EucklidNOD(c, a[i]);
            }
            stopwatch.Stop();
            return Tuple.Create(c, stopwatch.ElapsedMilliseconds);
        }
        /// <summary>
        /// Binary Eucllid method for finding NOD.
        /// </summary>
        /// <param name="a">array of numbers</param>
        /// <returns>NOD, time finding</returns>
        public static Tuple<int, long> BinEucklidNOD(params int[] a)
        {
            Checking(a);
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            int c = 0;
            for (int i = 0; i < a.Length; i++)
            {
                c = BinEucklidNOD(a[i], c);
            }
            stopwatch.Stop();
            return Tuple.Create(c, stopwatch.ElapsedMilliseconds);
        }
        /// <summary>
        /// Eucllid method for finding NOD of 2 numbers.
        /// </summary>
        /// <param name="a">first number</param>
        /// <param name="b">second number</param>
        /// <returns>NOD</returns>
        private static int EucklidNOD(int a, int b)
        {
            while (a != b)
            {
                if (a > b)
                {
                    a -= b;
                }
                else
                {
                    b -= a;
                }
            }
            return a;
        }
        /// <summary>
        /// Binary Eucllid method for finding NOD of 2 numbers.
        /// </summary>
        /// <param name="a">first number</param>
        /// <param name="b">second number</param>
        /// <returns>NOD</returns>
        private static int BinEucklidNOD(int a, int b)
        {
            if (a == b)
            {
                return a;
            }
            if (a == 0)
                return b;
            if (b == 0)
                return a;
            if ((~a & 1) != 0)
            {
                if ((b & 1) != 0)
                {
                    return BinEucklidNOD(a >> 1, b);
                }
                else
                {
                    return BinEucklidNOD(a >> 1, b >> 1) << 1;
                }
            }
            if ((~b & 1) != 0)
            {
                return BinEucklidNOD(a, b >> 1);
            }
            if (a > b)
            {
                return BinEucklidNOD((a - b) >> 1, b);
            }
            return BinEucklidNOD((b - a) >> 1, a);
        }

    }
}
