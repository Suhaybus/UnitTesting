using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting {
    internal class Triangle {

        public double Area(double sideA, double sideB, double sideC) {      // requirements force these inputs -> can't calculate the area without assuming any one side to be the perpendicular height
            double semiPerimeter = Perimeter(sideA, sideB, sideC) / 2;
            return Math.Sqrt( semiPerimeter * (semiPerimeter - sideA) * (semiPerimeter - sideB) * (semiPerimeter - sideC));     // heron's formula resolves the issue
        }

        public double Perimeter(double sideA, double sideB, double sideC) {
            return sideA + sideB + sideC;
        }
    }
}
