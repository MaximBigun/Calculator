using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Constraints;

namespace CalcTests
{
    public class Class1
    {
        [Test]
        public void TestPhysicalM()
        {
            Assert.That(Calculator.Program.BMR("M", 23, 188, 100, 1.55), Is.EqualTo(3409.47));
        }
        [Test]
        public void TestPhysicalW()
        {
            Assert.That(Calculator.Program.BMR("W", 23, 162, 50.9, 1.2), Is.EqualTo(1583.02));
        }
        [Test]
        public void TestPhysicalMnot()
        {
            Assert.That(Calculator.Program.BMR("M", 23, 188, 106, 1.2), Is.Not.EqualTo(3409.47));
        }
        [Test]
        public void TestPhysicalWnot()
        {
            Assert.That(Calculator.Program.BMR("W", 42, 172, 50.9, 1.9), Is.Not.EqualTo(1583.02));
        }
    }
}