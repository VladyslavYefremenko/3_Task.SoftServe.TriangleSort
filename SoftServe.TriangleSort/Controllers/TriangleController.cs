using System;
using System.Collections.Generic;
using System.Text;

using Printers;

namespace SoftServe.TriangleSort
{
    class TriangleController
    {
        public static Triangle CreateTriangle(string name, string lenghtSideA, string lenghtSideB, string lenghtSideC)
        {
            Triangle triangle = new Triangle(name, double.Parse(lenghtSideA), double.Parse(lenghtSideB), double.Parse(lenghtSideC));

            return triangle;
        }
    }
}
