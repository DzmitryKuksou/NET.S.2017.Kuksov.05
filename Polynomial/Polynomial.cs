using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polinoms
{
    /// <summary>
    /// work with polynomials
    /// </summary>
    public class Polynomial:ICloneable
    {
        /// <summary>
        /// coefficients of Polynomial
        /// </summary>
        private readonly double[] coefficient;
        /// <summary>
        /// property Degree return degree of Polynomial.
        /// </summary>
        public int Degree { get { return coefficient.Length; } }
        /// <summary>
        /// c-or with parameter
        /// </summary>
        /// <param name="arrayCoeff">array of coefficients</param>
        public Polynomial(params double[] arrayCoeff)
        { 
            coefficient = new double[arrayCoeff.Length];
            Array.Copy(arrayCoeff, coefficient, arrayCoeff.Length);
        }
        /// <summary>
        /// sum of polynomial
        /// </summary>
        /// <param name="obj1">first polynomial</param>
        /// <param name="obj2">second polynomial</param>
        /// <returns>new polynomial</returns>
        public static Polynomial operator +(Polynomial obj1, Polynomial obj2)
        {
            
            if (obj1 == null || obj2 == null) throw new ArgumentNullException("Null argument!");
            if (obj1.Degree == 0) return new Polynomial(obj2.coefficient);
            if (obj2.Degree == 0) return new Polynomial(obj1.coefficient);
            double[] arr; 
            if (obj1.Degree > obj2.Degree)
            {
                arr = new double[obj1.Degree];
                for (int i = 0; i < obj1.Degree; i++)
                    arr[i] = obj1.coefficient[i];
                for (int i = 0; i < obj2.Degree; i++)
                    arr[i] += obj2.coefficient[i];
            }
            else
            {
                arr = new double[obj2.Degree];
                for (int i = 0; i < obj2.Degree; i++)
                    arr[i] = obj2.coefficient[i];
                for (int i = 0; i < obj1.Degree; i++)
                    arr[i] += obj1.coefficient[i];
            }
            return new Polynomial(arr);
        }
        /// <summary>
        /// substract of polynomial
        /// </summary>
        /// <param name="obj1">first polynomial</param>
        /// <param name="obj2">second polynomial</param>
        /// <returns>new polynomial</returns>
        public static Polynomial operator -(Polynomial obj1, Polynomial obj2)
        {

            if (obj1 == null || obj2 == null) throw new ArgumentNullException("Null argument!");
            if (obj1.Degree == 0) return new Polynomial(obj2.coefficient);
            if (obj2.Degree == 0) return new Polynomial(obj1.coefficient);
            double[] arr;
            if (obj1.Degree > obj2.Degree)
            {
                arr = new double[obj1.Degree];
                for (int i = 0; i < obj1.Degree; i++) 
                    arr[i]= obj1.coefficient[i];
                for (int i = 0; i < obj2.Degree; i++)
                    arr[i] -= obj2.coefficient[i];
            }
            else
            {
                arr = new double[obj2.Degree];
                for (int i = 0; i < obj2.Degree; i++)
                    arr[i] = -obj2.coefficient[i];
                for (int i = 0; i < obj1.Degree; i++)
                    arr[i] += obj1.coefficient[i];
            }

            return new Polynomial(arr);
        }
        /// <summary>
        /// multiply of polynomial
        /// </summary>
        /// <param name="obj1">first polynomial</param>
        /// <param name="obj2">second polynomial</param>
        /// <returns>new polynomial</returns>
        public static Polynomial operator *(Polynomial obj1, Polynomial obj2)
        {
            if (obj1 == null || obj2 == null) throw new ArgumentNullException("Null argument!");
            if (obj1.Degree == 0 || obj2.Degree == 0) return new Polynomial();
            double[] arr = new double[obj1.Degree + obj2.Degree];
            for (int i = 0; i < obj1.Degree; i++)
                for(int j = 0; j < obj1.Degree; j++)
                {
                    arr[i + j] += obj1.coefficient[i] * obj2.coefficient[j];
                }
            return new Polynomial(arr);
        }
        /// <summary>
        /// convert to string
        /// </summary>
        /// <returns>Polynomial in string format</returns>
        override public string ToString()
        {
            StringBuilder s = new StringBuilder();
            for (int i = coefficient.Length - 1; i >= 0; i--)
            {
                s.AppendFormat("{0}{1}{2}", coefficient[i] > 0 ? "+" : "", coefficient[i] != 0 && i != 0 ? (coefficient[i]) + "x^" + i : "", i == 0 ? coefficient[i] + "=0" : "");
            }
            return s.ToString();
        }
        /// <summary>
        /// HashCode of Polynomial
        /// </summary>
        /// <returns>HashCode</returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        /// <summary>
        /// if polynomials is equals return true, else false
        /// </summary>
        /// <param name="obj1">object</param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Polynomial poly = obj as Polynomial;
            if (poly == null) return false;
            if (poly.Degree != coefficient.Length) return false;
            for (int i = 0; i < poly.Degree; i++)
            {
                if (coefficient[i] != poly.coefficient[i])
                    return false;
            }
            return true;
        }
        /// <summary>
        /// clone polynomial
        /// </summary>
        /// <returns>new equals polynomial</returns>
        public object Clone()
        {
            return new Polynomial(coefficient);
        }
    }
}
