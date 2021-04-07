namespace SoftServe.TriangleSort
{
    public class Validators : IValidators
    {
        public bool IsNumDouble(string arg)
        {
            bool isDouble = true;

            if (!double.TryParse(arg, out _))
            {
                isDouble = false;
            }
            return isDouble;
        }

        public bool isValidTriangle(string lengthSideAStr, string lengthSideBStr, string lengthSideCStr)
        {
            bool isValid = false;

            const double MIN_SIZE = 0.1;
            const double MAX_SIZE = 100.0;

            if (IsNumDouble(lengthSideAStr) && IsNumDouble(lengthSideBStr) && IsNumDouble(lengthSideCStr))
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
