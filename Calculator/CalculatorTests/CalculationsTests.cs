using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Tests
{
    [TestClass()]
    public class CalculationsTests
    {
        [TestMethod()]
        public void AddTest()
        {
            //Arrange
            var n1 = 10;
            var n2 = 15;

            //Act
            var result = Calculations.Add(n1, n2);

            //Assert
            Assert.AreEqual(25,result);
        }
        [TestMethod()]
        public void SubtractTest()
        {
            //Arrange
            var n1 = 10;
            var n2 = 15;

            //Act
            var result = Calculations.Subtract(n1, n2);

            //Assert
            Assert.AreEqual(-5, result);
        }
        [TestMethod()]
        public void MultiplyTest()
        {
            //Arrange
            var n1 = 10;
            var n2 = 15;

            //Act
            var result = Calculations.Multiply(n1, n2);

            //Assert
            Assert.AreEqual(150, result);
        }
        [TestMethod()]
        public void DivideTest()
        {
            //Arrange
            var n1 = 10;
            var n2 = 15;

            //Act
            var result = Calculations.Divide(n1, n2);

            //Assert
            Assert.AreEqual((10d/15), result);
        }
    }
}