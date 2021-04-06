using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System;

namespace HelloWorldTest1
{
    [TestClass]
    public class UnitTest1
    {
        private const string Expected = "Hello World!";
        private HelloWorldCore.Program calculator = new HelloWorldCore.Program();

        [TestMethod]
        public void TestMethod1()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                HelloWorldCore.Program.Main();
                var result = sw.ToString().Trim();
                Assert.AreEqual(Expected, result);
            }
        }

        //Test Method for adding numbers
        //Arrange
        private const int addExpected = 23;
        [TestMethod]
        public void AddTwoNumbersWithoutParametersTest()
        {
            //Act
            int result = calculator.AddTwoNumbers(11,12);
            //Assert
            Assert.AreEqual(addExpected, result);
        }


        //Test Method for adding numbers with multiple parameters
        //Arrange
        [DataTestMethod]
        [DataRow(-4, 3, -1)]
        [DataRow(12, -2, 10)]
        [DataRow(12, 4, 16)]
        public void AddTwoNumbersWithParametersTest(int number1, int number2, int resultExpected)
        {
            //Act
            int result = calculator.AddTwoNumbers(number1, number2);
            //Assert
            Assert.AreEqual(resultExpected, result);
        }

        //Test Method for multiplying numbers with multiple parameters
        //Arrange
        [DataTestMethod]
        [DataRow(-4, 3, -12)]
        [DataRow(12, -2, -24)]
        [DataRow(-3, -4, 12)]
        [DataRow(3, 4, 12)]
        public void MultiplyTwoNumbersTest(int number1, int number2, int resultExpected)
        {
            //Act
            int result = calculator.MultiplyTwoNumbers(number1, number2);
            //Assert
            Assert.AreEqual(resultExpected, result);
        }


        //Test Method for dividing numbers with multiple parameters
        //Arrange
        [DataTestMethod]
        [DataRow(-12, 3, -4)]
        [DataRow(12, -2, -6)]
        [DataRow(-12, -4, 3)]
        [DataRow(12, 4, 3)]
        [DataRow(12, 0, 0)]
        public void DivideTwoNumbersTest(int number1, int number2, int resultExpected)
        {
            //Act
            int result = calculator.DivideTwoNumbers(number1, number2);
            //Assert
            Assert.AreEqual(resultExpected, result);
        }
    }
}
