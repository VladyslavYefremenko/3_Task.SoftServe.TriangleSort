using System;
using System.Collections.Generic;

using SoftServe.TriangleSort;

namespace SoftServe.TriangleSortView
{
    class TriangleController : ITriangleController
    {
        public void CreateListOfTriangles(List<Triangle> triangles)
        {
            string message = "Invalid triangle, try again!";

            bool continueInput = true;

            InputSplitter splitter = new InputSplitter();

            Printer printer = new Printer();

            do
            {
                string userInput = UserInputReader.ReadUserInput();

                string name;
                string lenghtSideA;
                string lenghtSideB;
                string lenghtSideC;

                try
                {
                    splitter.Split(userInput, out name, out lenghtSideA, out lenghtSideB, out lenghtSideC);

                    Validators validators = new Validators();

                    if (validators.isValidTriangle(lenghtSideA, lenghtSideB, lenghtSideC))
                    {
                        triangles.Add(TriangleCreator.Create(name, lenghtSideA, lenghtSideB, lenghtSideC));
                    }
                    else
                    {
                        printer.Message(message);

                        Console.ReadKey();
                    }
                }
                catch
                {
                    printer.Message(message);

                    Console.ReadKey();
                }


                if (!UserInputReader.ContinueInput())
                {
                    continueInput = false;
                }

            } while (continueInput);
        }
    }
}
