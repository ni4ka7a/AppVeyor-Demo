namespace HelloWorld_Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using HelloWorld;

    [TestClass]
    public class SimpleCalculatorTests
    {
        [TestMethod]
        public void AddTwoNumbersShouldReturnCorrectResult()
        {
            var calculator = new SimpleCalculator();
            var firstNumber = 5;
            var secondNumber = 6;

            var expectedResult = 11;
            var result = calculator.Add(firstNumber, secondNumber);
            Assert.AreEqual(expectedResult, result, "The result is {0}, which is incorrect value", result);
        }

        [TestMethod]
        public void FailingTest()
        {
            Assert.Fail();
        }
    }
}
