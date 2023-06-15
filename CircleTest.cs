using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting {
    [TestFixture]
    internal class CircleTest {
        [Test]
        public void TestAreaCircle() {
            // Arrange
            circle circle = new circle();
            double radius = 5, expectedValue = 78.53981633974483;

            // Act
            double actualValue = circle.Area(radius);

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [Test] 
        public void TestPerimiterCircle() { 
            // Arrange
            circle circle = new circle();
            double radius = 5, expectedValue = 31.41592653589793;
            
            // Act
            double actualValue = circle.Perimeter(radius);
            
            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}
