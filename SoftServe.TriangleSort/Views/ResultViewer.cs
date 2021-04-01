using System;
using System.Collections.Generic;
using System.Text;

using Printers;

namespace SoftServe.TriangleSort
{
    class ResultViewer : IResultViewer
    {
        public static void ViewResult(List<Triangle> triangles)
        {
            int numOfTriangle = 1;

            string head = "============= Triangles list: ===============";

            Console.Clear();

            Printer<string>.PrintMessage(head);

            foreach (var triangle in triangles)
            {
                string triangleParams = triangle.ToString();

                Printer<string>.PrintMessage($"{numOfTriangle}. {triangleParams}");

                numOfTriangle++;
            }

            Console.ReadKey();
        }
    }
}
