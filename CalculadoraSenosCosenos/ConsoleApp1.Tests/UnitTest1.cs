using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ConsoleApp1;

namespace ConsoleApp1.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void OperacionCosenoLAL_ValidNumbers_ReturnsNumber()
        {
            //Arrange
            var operacion = new ClassOp(11, 5, 20);

            //Act
            var result = operacion.OpcionCosenoLAL();

            //Assert
            Assert.AreEqual("6.53", result.ToString());
        }

        [TestMethod]
        public void OperacionCosenoLAL_NumbersEqualsZero_ReturnsException()
        {
            var operacion = new ClassOp(0, 0, 0);

            //Assert
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => operacion.OpcionCosenoLAL());
        }

        [TestMethod]
        public void OperacionCosenoLLL_ValidNumbers_ReturnsNumber()
        {
            //Arrange
            var operacion = new ClassOp(8, 19, 14);

            //Act
            var result = operacion.OpcionCosenoLLL();

            //Assert
            Assert.AreEqual("116.8", result.ToString());
        }

        [TestMethod]
        public void OperacionCosenoLLL_NumbersEqualsZero_ReturnsException()
        {
            var operacion = new ClassOp(0, 0, 0);

            //Assert
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => operacion.OpcionCosenoLLL());
        }

        [TestMethod]
        public void OperacionCosenoLLL_IncorrectSizes_ReturnsException()
        {
            var operacion = new ClassOp(1, 2, 4);

            //Assert
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => operacion.OpcionCosenoLLL());
        }

        [TestMethod]
        public void OperacionSenoAA_ValidNumbers_ReturnsNumber()
        {
            //Arrange
            var operacion = new ClassOp(20, 100, 0);

            //Act
            var result = operacion.OpcionSenoAAL();

            //Assert
            Assert.AreEqual("60", result.ToString());
        }

        [TestMethod]
        public void OperacionSenoAA_NumbersEqualsZero_ReturnsException()
        {
            var operacion = new ClassOp(0, 0, 0);

            //Assert
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => operacion.OpcionSenoAAL());
        }

    }
}
