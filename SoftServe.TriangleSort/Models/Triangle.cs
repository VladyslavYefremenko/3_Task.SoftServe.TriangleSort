using System;
using System.Collections.Generic;
using System.Text;

namespace SoftServe.TriangleSort
{
    class Triangle
    {
        private string name;
        private double lengthSideA;
        private double lengthSideB;
        private double lengthSideC;
        private double square;

        public string Name { get { return name; } }
        public double LengthSideA { get { return lengthSideA; } }
        public double LengthSideB { get { return lengthSideB; } }
        public double LengthSideC { get { return lengthSideC; } }

        public double Square { get { return square; } }

        public Triangle(string name, double lengthSideA, double lengthSideB, double lengthSideC)
        {
            this.lengthSideA = lengthSideA;
            this.lengthSideB = lengthSideB;
            this.lengthSideC = lengthSideC;

            this.name = name;
            name = name.Insert(0, "[");
            name += "]";
            square = Math.Round(SquareCalculator.calculateSquare(lengthSideA, lengthSideB, lengthSideC), 2);
        }

        public override string ToString()
        {
            string triangleStr = $"[{name}]: {square} cm";

            return triangleStr;
        }
    }
}
