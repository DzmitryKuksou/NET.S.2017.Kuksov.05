using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConvertToBin;

namespace NUnitConvertToBin.Tests1
{
    [TestFixture]
    public class TestConvertToBin
    {
        [Test]
        public void TestMethod()
        {
           double a = 0;
           Assert.AreEqual("",a.FloatToBin());
        }
    }
}
