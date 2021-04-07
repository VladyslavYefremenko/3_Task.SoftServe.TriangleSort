using System;
using System.Threading;

namespace SoftServe.TriangleSortView
{
    class Program
    {
        static void Main(string[] args)
        {
            // ToDo: add XML

            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

            Startup.Start();
        }
    }
}
