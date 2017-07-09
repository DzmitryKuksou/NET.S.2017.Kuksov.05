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
    public class TestPolinom
    {
        [TestCase(1, 0, -3, 4, ExpectedResult = "+4x^3-3x^2+1=0")]
        [TestCase(1, 2, 3, 4, ExpectedResult = "+4x^3+3x^2+2x^1+1=0")]
        public string Test_Polinom_toString(params double[] coeff)
        {
            Polinom a = new Polinom(coeff);
            return a.ToString();
        }
        [TestCase(ExpectedResult = "+1x^3+3x^2+2x^1+3=0")]
        public string Test_Polinom_sum(params double[] coeff)
        {
            Polinom a = new Polinom(2, 0, 2);
            Polinom b = new Polinom(1, 2, 1, 1);
            Polinom c = a + b;
            return c.ToString();
        }
    }
}
