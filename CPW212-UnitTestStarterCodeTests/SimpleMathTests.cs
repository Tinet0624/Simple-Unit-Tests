using Microsoft.VisualStudio.TestTools.UnitTesting;
using CPW212_UnitTestStarterCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPW212_UnitTestStarterCode.Tests
{

    [TestClass()]
    public class SimpleMathTests
    {

        [TestMethod()]
        [DataRow(5, 10)]
        [DataRow(0, 100)]
        [DataRow(-1, -10)]
        [DataRow(0, -0)]
        public void Add_TwoNumbers_ReturnsSum(double num1, double num2)
        {
            Assert.AreEqual(num1 + num2, SimpleMath.Add(num1, num2));
        }

        [TestMethod]
        [DataRow(5, 10)]
        [DataRow(7, 5)]
        [DataRow(8, 12)]
        [DataRow(-13, 11)]
        public void Multiply_TwoNumbers_ReturnsProduct(double num1, double num2)
        {
            // Use a few pairs of values to test the Multiply method
            Assert.AreEqual(num1 * num2, SimpleMath.Multiply(num1, num2));
        }

        [TestMethod]
        [DataRow(16, 0)]
        [DataRow(0, 5)]
        public void Divide_DenominatorZero_ThrowsArgumentException(double num1, double num2)
        {
            // Divide by zero should throw an argument exception with a message
            // "Denominator cannot be zero"
            Assert.ThrowsException<ArithmeticException>(() => SimpleMath.Divide(num1, num2));
        }

        // TODO: Test Divide method with two valid numbers
        [TestMethod]
        [DataRow(5, 10)]
        [DataRow(7, 5)]
        [DataRow(8, 12)]
        [DataRow(-13, 11)]
        public void Divide_TwoNumbers_ReturnsQuotient(double num1, double num2)
        {
            // Use a few pairs of values to test the Multiply method
            Assert.AreEqual(num1 / num2, SimpleMath.Divide(num1, num2));
        }

        // TODO: Test subtract method with two valid numbers
        [TestMethod]
        [DataRow(10, 3)]
        [DataRow(25, 12)]
        [DataRow(8, 12)]
        [DataRow(-5, -7)]
        [DataRow(3, 13)]
        public void Subtract_TwoNumbers_ReturnsDifference(double num1, double num2)
        {
            // Use a few pairs of values to test the Multiply method
            Assert.AreEqual(num1 - num2, SimpleMath.Subtract(num1, num2));
        }
    }
}