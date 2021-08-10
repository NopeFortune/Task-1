using FiguresTask;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FiguresTests
{
    [TestClass]
    public class TriangleAreaTest
    {
        [TestMethod]
        public void TriangleAreaTestMethod()
        {
            // Arrange
            double A = 2;
            double B = 2;
            double C = 3;
            double expected = 1.98;

            // Act
            Triangle triangle = new Triangle(A, B, C);
            double actual = triangle.Area();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RightTriangleTestMethod()
        {
            //Arrange
            double a = 3;
            double b = 4;
            double c = 5;
            bool expected = true;

            // Act
            Triangle triangle = new Triangle();
            bool actual = triangle.isRightTriangle(a, b, c);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(TriangleException))]
        public void TriangleBigSideMethod()
        {
            double A = 2;
            double B = 4;
            double C = 7;

            try
            {
                Triangle triangle = new Triangle(A, B, C);
            }
            catch (TriangleException)
            {
                throw;
            }
        }

        [TestMethod]
        [ExpectedException(typeof(TriangleException))]
        public void TriangleSideEqualsZeroTestMethod()
        {
            double A = 0;
            double B = 0;
            double C = 0;

            try
            {
                Triangle triangle = new Triangle(A, B, C);
            }
            catch (TriangleException)
            {
                throw;
            }
        }
    }
}
