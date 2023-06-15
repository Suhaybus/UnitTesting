using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting {
    [TestFixture]
    internal class TriangleTest {
        // Classic 3-4-5 triangle (Right-Angled)
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
