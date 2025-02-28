// CalculatorTests/CalculatorTests.cs
using NUnit.Framework;
using CalculatorLibrary;
using System;   

namespace CalculatorTests
{
    public class Calculator
    {
        public double Add(double a, double b) => a + b;
        public double Subtract(double a, double b) => a - b;
        public double Multiply(double a, double b) => a * b;
        public double Divide(double a, double b) => b == 0 ? throw new DivideByZeroException("Cannot divide by zero.") : a / b;
    }
    public class CalculatorTests
    {
        private Calculator _calculator;

        // [SetUp]
        public void Setup() => _calculator = new Calculator();

        public void Add_ShouldReturnSum() => Assert.AreEqual(5, _calculator.Add(2, 3));
        public void Subtract_ShouldReturnDifference() => Assert.AreEqual(1, _calculator.Subtract(5, 4));
        public void Multiply_ShouldReturnProduct() => Assert.AreEqual(20, _calculator.Multiply(5, 4));
        public void Divide_ShouldReturnQuotient() => Assert.AreEqual(2, _calculator.Divide(6, 3));
        public void Divide_ByZero_ShouldThrowException() => Assert.Throws<DivideByZeroException>(() => _calculator.Divide(5, 0));


    }
}
