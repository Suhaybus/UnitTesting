using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting {
    [TestFixture]
    internal class Test {
        // Testing circle.cs
        [Test]
        public void TestCircleArea() {
            // Arrange
            circle circle = new circle();
            double radius = 5, expectedValue = 78.53981633974483;

            // Act
            double actualValue = circle.Area(radius);

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public void TestCirclePerimiter() {
            // Arrange
            circle circle = new circle();
            double radius = 5, expectedValue = 31.41592653589793;

            // Act
            double actualValue = circle.Perimeter(radius);

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        // Testing Rectangle.cs
        [Test]
        public void testRectangleArea() {
            // Arrange
            Rectangle rect = new Rectangle();
            double width = 5, height = 4, expectedValue = 20;

            // Act
            double actualValue = rect.Area(width, height);

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public void testRectanglePerimeter() {
            // Arrange
            Rectangle rectangle = new Rectangle();
            double width = 5, height = 4, expectedValue = 18;

            // Act
            double actualValue = rectangle.Perimeter(width, height);

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }


        // Testing Triangle.cs
        [Test]
        public void testTriangleArea() {
            // Arrange
            Triangle triangle = new Triangle();
            double sideA = 3, sideB = 4, sideC = 5, expectedValue = 6;

            // Act
            double actualValue = triangle.Area(sideA, sideB, sideC);

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public void testTrianglePerimeter() {
            // Arrange
            Triangle tri = new Triangle();
            double sideA = 3, sideB = 4, sideC = 5, expectedValue = 12;

            // Act
            double ActualValue = tri.Perimeter(sideA, sideB, sideC);

            // Assert
            Assert.AreEqual(expectedValue, ActualValue);
        }
    }
}
