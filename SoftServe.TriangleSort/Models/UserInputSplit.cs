using System;
using System.Collections.Generic;
using System.Text;

using StringEditor;

namespace SoftServe.TriangleSort
{
    class UserInputSplit
    {
        public static void Split(string userInput, out string name, out string lenghtSideA, out string lenghtSideB, out string lenghtSideC)
        {
            const char SPLITTER = ',';

            userInput = Editor.RemoveSpaces(userInput);
            userInput = Editor.RemoveTabulation(userInput);

            string[] userInputArr = userInput.Split(SPLITTER);

            name = userInputArr[0];
            lenghtSideA = userInputArr[1];
            lenghtSideB = userInputArr[2];
            lenghtSideC = userInputArr[3];
        }
    }
}
