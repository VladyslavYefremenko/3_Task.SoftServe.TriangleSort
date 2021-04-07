using System;
using System.Collections.Generic;

using SoftServe.TriangleSort;

namespace SoftServe.TriangleSortView
{
    class ResultViewer
    {
        public static void ViewResult(List<Triangle> triangles)
        {
            int triangleNumber = 1;

            string head = "============= Triangles list: ===============";

            Console.Clear();

            Printer printer = new Printer();

            printer.Message(head);

            foreach (var triangle in triangles)
            {
                string triangleParams = triangle.ToString();

                printer.Message($"{triangleNumber}. {triangleParams}");

                triangleNumber++;
            }

            Console.ReadKey();
        }
    }
}
