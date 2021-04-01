using System;
using System.Threading;

namespace SoftServe.TriangleSort
{
    class Program
    {
        // ToDo: add XML
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

            AppController.StartApp();
        }
    }
}
