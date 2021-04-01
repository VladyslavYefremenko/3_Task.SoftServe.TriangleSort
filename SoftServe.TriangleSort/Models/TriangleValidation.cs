using System;
using System.Collections.Generic;
using System.Text;

using Validators;

namespace SoftServe.TriangleSort
{
    class TriangleValidation
    {
        public static bool isValidTriangle(string lengthSideAStr, string lengthSideBStr, string lengthSideCStr)
        {
            bool isValid = false;

            const double MIN_SIZE = 0.1;
            const double MAX_SIZE = 100.0;

            if (Validator.IsNumDouble(lengthSideAStr) && Validator.IsNumDouble(lengthSideBStr) && Validator.IsNumDouble(lengthSideCStr))
            {
                if ((double.Parse(lengthSideAStr) > MIN_SIZE && double.Parse(lengthSideAStr) < MAX_SIZE) 
                    && (double.Parse(lengthSideBStr) > MIN_SIZE && double.Parse(lengthSideBStr) < MAX_SIZE) 
                    && (double.Parse(lengthSideCStr) > MIN_SIZE && double.Parse(lengthSideCStr) < MAX_SIZE))
                {
                    isValid = true;
                }
            }

            return isValid;
        }
    }
}
