using System.Collections.Generic;

using SoftServe.TriangleSort;

namespace SoftServe.TriangleSortView
{
    interface IResultViewer
    {
        void ViewResult(List<Triangle> triangles);
    }
}
