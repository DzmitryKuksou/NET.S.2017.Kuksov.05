using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polinoms
{
    public class Polinom
    {
        private readonly double[] arr;
        public double[] Coefficient{ get { return arr; } }
        public Polinom(params double[] arrayCoeff)
        {
            arr = arrayCoeff;
        }
        public static Polinom operator+(Polinom a, Polinom b)
        {
            double[] arr1 = a.Coefficient;
            double[] arr2 = b.Coefficient;
            if (arr1.Length > arr2.Length)
            {
                for (int i = 0; i < arr2.Length; i++)
                    arr1[i] += arr2[i];
                return new Polinom(arr1);

            }
            else
            {
                for (int i = 0; i < arr1.Length; i++)
                    arr2[i] += arr1[i];
                return new Polinom(arr2);
            }
        }
        public static Polinom operator-(Polinom a, Polinom b)
        {
            double[] arr1 = a.Coefficient;
            double[] arr2 = b.Coefficient;
            if (arr1.Length > arr2.Length)
            {
                for (int i = 0;i < arr2.Length; i++)
                    arr1[i] -= arr2[i];
                return new Polinom(arr1);

            }
            else
            {
                for (int i = 0; i < arr1.Length; i++)
                    arr2[i] -= arr1[i];
                return new Polinom(arr2);
            }
        }
        override public string ToString()
        {
            StringBuilder s = new StringBuilder();
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                s.AppendFormat("{0}{1}{2}", arr[i] > 0 ? "+" : "", arr[i] != 0 && i != 0 ? (arr[i]) + "x^" + i : "", i == 0 ? arr[i] + "=0" : "");
            }
            return s.ToString();
        }
        public static Polinom operator*(Polinom a, Polinom b)
        {
            double[] arr1 = a.Coefficient;
            double[] arr2 = b.Coefficient;

            return a;
        }
        public Polinom Clone(Polinom a)
        {

            return new Polinom(a.Coefficient);
        }
    }
}
