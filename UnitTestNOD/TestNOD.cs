using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NOD;
namespace UnitTestNOD
{
    [TestFixture]
    public class TestNOD
    {
        [TestCase(22, 11, ExpectedResult = 11)]
        [TestCase(2234, 222, ExpectedResult = 2)]
        [TestCase(2323, 232323, 23, ExpectedResult = 23)]
        [TestCase(20, 32, 64, 128, ExpectedResult = 4)]
        [TestCase(99, 33, 1111, 111122, ExpectedResult = 11)]
        public int Test_EucklidNOD(params int[] a)
        {
            return NODofNumbers.EucklidNOD(a).Item1;
        }
        [TestCase(22, 11, ExpectedResult = 11)]
        [TestCase(2234, 222, ExpectedResult = 2)]
        [TestCase(2323, 232323, 23, ExpectedResult = 23)]
        [TestCase(20, 32, 64, 128, ExpectedResult = 4)]
        [TestCase(99, 33, 1111, 111122, ExpectedResult = 11)]
        public int Test_BinEucklidNOD(params int[] a)
        {
            return NODofNumbers.BinEucklidNOD(a).Item1;
        }
        
        [TestCase(1)]
        public void Test_EucklidNOD_ArgumentOutOfRangeException(params int[] a)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => NODofNumbers.EucklidNOD(a));
        }
        [TestCase(1)]
        public void Test_BinEucklidNOD_ArgumentOutOfRangeException(params int[] a)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => NODofNumbers.BinEucklidNOD(a));
        }
    }
}
