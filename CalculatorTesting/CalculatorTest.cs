using System;
using NUnit.Framework;

namespace CalculatorTesting
{
    [TestFixture]
    public class CalculatorTest
    {
        private Calculator _calculator;

        [OneTimeSetUp]
        public void SetUpEnvironment()
        {
            _calculator = new Calculator();
        }

        [Test]
        public void AddTest()
        {
            int expectedSum = 30;
            Assert.AreEqual(expectedSum, _calculator.Add(10, 20));
        }
        [Test]
        public void SubTest()
        {
            int expectedSubstraction = 20;
            Assert.AreEqual(expectedSubstraction, _calculator.Sub(40, 20));
        }
        [Test]
        public void MultiplyTest()
        {
            int expectedMultiplication = 100;
            Assert.AreEqual(expectedMultiplication, _calculator.Multiply(10, 10));
        }
    }
}
