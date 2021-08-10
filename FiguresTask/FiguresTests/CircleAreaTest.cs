using FiguresTask;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FiguresTests
{
    [TestClass]
    public class CircleAreaTest
    {
        [TestMethod]
        public void CircleAreaTestMethod()
        {
            // Arrange
            double radius = 2.5;
            double expected = 19.63;

            // Act
            Circle circle = new Circle(radius);
            double actual = circle.Area();

            // Assert
            Console.WriteLine(actual);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(CircleException))]
        public void CircleZeroRadiusTestMethod()
        {
            double radius = 0;

            try
            {
                Circle circle = new Circle(radius);
            }
            catch (CircleException)
            {
                throw;
            }
        }
    }
}
