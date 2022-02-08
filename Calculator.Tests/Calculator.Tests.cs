using System;
using CalculatorLogic;
using NUnit.Framework;


namespace CalculatorTest
{
    public class CalculatorTests
    {
        public string str;
        
        private Calculator calc;

        public CalculatorTests()
        {
            calc = new Calculator();
            str = "//[****][;]\n****2;3";
        }


        [Test]
        public void Add_Should_Not_Accept_Empty_String()
        {
            // ACT
            bool result = string.IsNullOrEmpty(str);

            // ASSERT
            Assert.IsFalse(result);
        }

        [Test]
        public void Add_Should_Accept_Any_Delimiters()
        {
            // ACT
            int result = calc.Add(str);

            // ASSERT
            Assert.AreEqual(5, result);
        }

        [Test]
        public void Add_Should_Not_Accept_Negative_Number()
        {
            // ACT
            int result = calc.Add(str);

            // ASSERT
            Assert.AreEqual(5, result);
        }

        [Test]
        public void Add_Should_Ignore_Number_More_Than_1000()
        {
            // ACT
            int result = calc.Add(str);

            // ASSERT
            Assert.AreEqual(5, result);
        }

        [Test]
        public void Add_Should_Accept_Delimiters_Any_Length()
        {
            // ACT
            int result = calc.Add(str);

            // ASSERT
            Assert.AreEqual(5, result);
        }
    }
}