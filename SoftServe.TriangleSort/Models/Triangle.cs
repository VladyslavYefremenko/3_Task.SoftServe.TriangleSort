using System;

namespace SoftServe.TriangleSort
{
    public class Triangle : IComparable
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

            Calculator calculator = new Calculator();

            square = Math.Round(calculator.Square(lengthSideA, lengthSideB, lengthSideC), 2);
        }

        public override string ToString()
        {
            string triangleStr = $"[{name}]: {square} cm";

            return triangleStr;
        }

        public int CompareTo(object obj)
        {
            Triangle triangle = obj as Triangle;
            if (triangle != null)
            {
                return this.square.CompareTo(triangle.square);
            }
            else
            {
                throw new Exception("Faild.");
            }
        }
    }
}
