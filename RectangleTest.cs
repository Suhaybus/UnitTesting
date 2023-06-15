using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting {
    [TestFixture]
    internal class RectangleTest {
        // 4 x 5
        [Test]
        public void testRectangleArea() {
            // Arrange
            Rectangle rect = new Rectangle();
            double width = 5, height = 4, expectedValue = 20;
            // Act
            double actualValue = rect.Area(width, height);
            // Area
            Assert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public void testRectanglePerimeter() { 
            // Arrange
            Rectangle rectangle = new Rectangle();
            double width = 5, height = 4, expectedValue = 18;
            // Act
            double actualValue = rectangle.Perimeter(width, height);
            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}
