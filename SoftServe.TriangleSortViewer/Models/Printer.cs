using System;
using System.IO;

namespace SoftServe.TriangleSortView
{
    class Printer : IPrinter
    {
        public void Instraction(string filePath)
        {
            StreamReader sr = new StreamReader(filePath);
            string line = sr.ReadLine();

            Console.Clear();
            while (line != null)
            {
                Console.WriteLine(line);
                line = sr.ReadLine();
            }

            sr.Close();
            Console.ReadKey();
        }

        public void Message(string message)
        {
            Console.WriteLine(message);
        }
    }
}
