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
    public class InputValidatorTests
    {
        [TestMethod()]
        public void ValidInputTest()
        {
            //Arrange
            string input = "10";
            //Act
            var result = InputValidator.IsInputValid(input);
            //Assert
            Assert.AreEqual(true, result);
        }

        [TestMethod()]
        public void InvalidInputTest()
        {
            //Arrange
            string input = "aa";
            //Act
            var result = InputValidator.IsInputValid(input);
            //Assert
            Assert.AreEqual(false, result);
        }
        [TestMethod()]
        public void ValidAddOperationInputTest()
        {
            //Arrange
            string input = "ADD";
            //Act
            var result = InputValidator.IsOperationValid(input);
            //Assert
            Assert.AreEqual(true, result);
        }
        [TestMethod()]
        public void ValidSubOperationInputTest()
        {
            //Arrange
            string input = "SUB";
            //Act
            var result = InputValidator.IsOperationValid(input);
            //Assert
            Assert.AreEqual(true, result);
        }
        [TestMethod()]
        public void ValidMultInputTest()
        {
            //Arrange
            string input = "MUL";
            //Act
            var result = InputValidator.IsOperationValid(input);
            //Assert
            Assert.AreEqual(true, result);
        }
        [TestMethod()]
        public void ValidDivInputTest()
        {
            //Arrange
            string input = "DIV";
            //Act
            var result = InputValidator.IsOperationValid(input);
            //Assert
            Assert.AreEqual(true, result);
        }
        [TestMethod()]
        public void InvalidOperationInputTest()
        {
            //Arrange
            string input = "aaa";
            //Act
            var result = InputValidator.IsOperationValid(input);
            //Assert
            Assert.AreEqual(false, result);
        }
    }
}