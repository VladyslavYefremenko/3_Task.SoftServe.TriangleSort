using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SoftServe.TriangleSort
{
    class TrianglesSorting : ITrianglesSorting
    {
        public static void Sort(List<Triangle> triangles)
        {
            var sortedTriangles = from triangle in triangles 
                                  orderby triangle.Square descending
                                  select triangle;

            int i = 0;

            foreach (var triangle in sortedTriangles)
            {
                triangles[i] = triangle;

                i++;
            }
        }
    }
}
