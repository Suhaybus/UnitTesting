using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting {
    internal class circle {
        
        public double Area(double radius) {
            return Math.PI * radius * radius;
        }

        public double Perimeter(double radius) { return 2 * Math.PI * radius; }
    }
}
