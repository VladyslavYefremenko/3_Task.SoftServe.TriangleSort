using System;

namespace SoftServe.TriangleSort
{
    class Calculator : ICalculator
    {
        public double Square(double LenghtSideA, double LenghtSideB, double LenghtSideC)
        {
            double result = 0.0;
            double semiPerimeter = 0.0;

            semiPerimeter = (LenghtSideA + LenghtSideB + LenghtSideC) / 2;
            result = Math.Sqrt(semiPerimeter * (semiPerimeter - LenghtSideA) * (semiPerimeter - LenghtSideB) * (semiPerimeter - LenghtSideC));

            return result;
        }
    }
}
