using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting {
    internal class circle {
        
        public double Area(double radius) {
            return 3.1415d * radius * radius;
        }

        public double Perimeter(double radius) { return 2 * 3.1415d * radius; }
    }
}
