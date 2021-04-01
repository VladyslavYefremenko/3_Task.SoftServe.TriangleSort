using System;
using System.Collections.Generic;
using System.Text;

using Printers;

namespace SoftServe.TriangleSort
{
    class AppController
    {
        public static void StartApp()
        {
            List<Triangle> triangles = new List<Triangle>();

            TrianglesListCreator.CreateListOfTriangles(triangles);

            if (triangles.Count != 0)
            {
                TrianglesSorting.Sort(triangles);

                ResultViewer.ViewResult(triangles);
            }
            else
            {
                return;
            }
        }
    }
}
