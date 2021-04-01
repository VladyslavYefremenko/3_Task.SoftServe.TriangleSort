using System;
using System.Collections.Generic;
using System.Text;

using Printers;


namespace SoftServe.TriangleSort
{
    class TrianglesListCreator : ITrianglesListCreator
    {
        public static void CreateListOfTriangles(List<Triangle> triangles)
        {
            string message = "Invalid triangle, try again!";

            bool continueInput = true;

            do
            {
                string userInput = ReaderUserInput.ReadUserInput();

                string name;
                string lenghtSideA;
                string lenghtSideB;
                string lenghtSideC;

                try
                {
                    UserInputSplit.Split(userInput, out name, out lenghtSideA, out lenghtSideB, out lenghtSideC);

                    if (TriangleValidation.isValidTriangle(lenghtSideA, lenghtSideB, lenghtSideC))
                    {
                        triangles.Add(TriangleController.CreateTriangle(name, lenghtSideA, lenghtSideB, lenghtSideC));
                    }
                    else
                    {
                        Printer<string>.PrintMessage(message);

                        Console.ReadKey();
                    }
                }
                catch
                {
                    Printer<string>.PrintMessage(message);

                    Console.ReadKey();
                }

                
                if (!ReaderUserInput.ContinueInput())
                {
                    continueInput = false;
                }

            } while (continueInput);
        }
    }
}
