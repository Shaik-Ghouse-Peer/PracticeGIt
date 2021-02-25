using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace NunitSample
{
    [TestFixture]
    public class Class1
    {
        [OneTimeSetUp]
        public void SetUp()
        {
            Console.WriteLine("SetUP");
        }
        [Test]
        public void TestCaseOne()
        {
            Console.WriteLine("Test Case One");
        }
        [OneTimeTearDown]
        public void ClearResources()
        {
            Console.WriteLine("Clear Resources");
        }
    }
}
