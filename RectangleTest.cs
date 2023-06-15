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
        public void testArea() {
            Rectangle rect = new Rectangle();
            double width = 5, height = 4, expectedValue = 20;
            double actualValue = rect.Area(width, height);
            Assert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public void testPerimeter() { 
            Rectangle rectangle = new Rectangle();
            double width = 5, height = 4, expectedValue = 18;
            double actualValue = rectangle.Perimeter(width, height);
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}
