using System;
using CalculatorLogic;
using NUnit.Framework;


namespace CalculatorTest
{
    public class CalculatorTests
    {
        private Calculator calculate;

        public CalculatorTests()
        {
            calculate = new Calculator();
        }


        [Test]
        [TestCase("", 0)]
        public void Add_ShouldNotAcceptEmptyString(string numbers, int expectedResult)
        {
            int result = calculate.Add(numbers);

            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        [TestCase("//[*]\n1*2*3", 6)]
        public void Add_ShouldAcceptAnyDelimiters(string numbers, int expectedResult)
        {
            int result = calculate.Add(numbers);

            Assert.AreEqual(expectedResult, result);
        }


        [Test]
        [TestCase("//[*]\n1*2*3", 6)]
        public void Add_ShouldAcceptMultipleDelimiters(string numbers, int expectedResult)
        {
            int result = calculate.Add(numbers);

            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        [TestCase("1,-2,3,-5", "negatives not allowed: -2 -5")]
        public void Add_ShouldNotAcceptNegativeNumber(string numbers, string expectedResult)
        {
            var exception = Assert.Throws<Exception>(() => calculate.Add(numbers));

            Assert.AreEqual(expectedResult, exception.Message);
            
        }

        [Test]
        [TestCase("1, 2, 1000, 1002, 3", 6)]
        public void Add_ShouldIgnoreNumberMoreThanThousand(string numbers, int expectedResult)
        {
            int result = calculate.Add(numbers);

            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        [TestCase("//[***]\n1***2***3", 6)]
        public void Add_ShouldAcceptDelimitersAnyLength(string numbers, int expectedResult)
        {
            int result = calculate.Add(numbers);

            Assert.AreEqual(expectedResult, result);
        }
    }
}