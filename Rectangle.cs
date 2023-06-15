using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting {
    internal class Rectangle {

        public double Area(double x, double y) {
            return x * y;
        }

        public double Perimeter(double x, double y) {
            return (2 * x) + (2 * y);
        }
    }
}
