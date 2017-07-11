using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Polinoms;

namespace NUnitPolinom.Tests2
{
    [TestFixture]
    public class TestPolinomyal
    {
        [TestCase(1, 0, -3, 4, ExpectedResult = "+4x^3-3x^2+1=0")]
        [TestCase(1, 2, 3, 4, ExpectedResult = "+4x^3+3x^2+2x^1+1=0")]
        public string Test_Polinom_toString(params double[] coeff)
        {
            Polynomial a = new Polynomial(coeff);
            return a.ToString();
        }
        [TestCase(ExpectedResult = "+1x^3+3x^2+2x^1+3=0")]
        public string Test_Polinom_sum()
        {
            Polynomial a = new Polynomial(2, 0, 2);
            Polynomial b = new Polynomial(1, 2, 1, 1);
            Polynomial c = a + b;
            return c.ToString();
        }
        [TestCase(ExpectedResult = "+4x^2-4=0")]
        public string Test_Polinom_multiply()
        {
            Polynomial a = new Polynomial(2, 2);
            Polynomial b = new Polynomial(-2, 2);
            Polynomial c = a * b;
            return c.ToString();
        }
        [TestCase(ExpectedResult = "-1x^3+1x^2-2x^1+1=0")]
        public string Test_Polinom_substract()
        {
            Polynomial a = new Polynomial(2, 0, 2);
            Polynomial b = new Polynomial(1, 2, 1, 1);
            Polynomial c = a - b;
            return c.ToString();
        }
        public void Test_Polinom_equals_and_clone()
        {
            Polynomial a = new Polynomial(1, 2, 1, 2);
            Polynomial b = (Polynomial)a.Clone();
            Assert.AreEqual(true, b.Equals(a));
        }
    }
}
