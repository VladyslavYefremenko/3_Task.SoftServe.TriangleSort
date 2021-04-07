using System;
using System.Collections.Generic;

using SoftServe.TriangleSort;

namespace SoftServe.TriangleSortView
{
    class Startup
    {
        public static void Start()
        {
            List<Triangle> triangles = new List<Triangle>();

            TriangleController triangleController = new TriangleController();

            triangleController.CreateListOfTriangles(triangles);

            if (triangles.Count != 0)
            {
                triangles.Sort();
                triangles.Reverse();

                ResultViewer.ViewResult(triangles);
            }
            else
            {
                return;
            }
        }
    }
}
