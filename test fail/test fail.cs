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
        public void TestPhysicalMd()
        {
            Assert.That(Calculator.Program.BMR("M", 23, 188, 100, 1.55), Is.EqualTo(3466.47));
        }

    }
}
