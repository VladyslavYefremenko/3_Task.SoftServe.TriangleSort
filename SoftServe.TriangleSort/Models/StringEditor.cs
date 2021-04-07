using System;

namespace SoftServe.TriangleSort
{
    class StringEditor
    {
        public string RemoveSpaces(string inputString)
        {
            inputString = inputString.Replace("  ", string.Empty);
            inputString = inputString.Trim().Replace(" ", string.Empty);

            return inputString;
        }

        public string RemoveTabulation(string inputString)
        {
            inputString = inputString.Replace("\t", String.Empty);

            return inputString;
        }
    }
}
