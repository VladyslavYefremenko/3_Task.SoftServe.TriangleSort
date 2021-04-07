namespace SoftServe.TriangleSort
{
    public class TriangleCreator
    {
        public static Triangle Create(string name, string lenghtSideA, string lenghtSideB, string lenghtSideC)
        {
            Triangle triangle = new Triangle(name, double.Parse(lenghtSideA), double.Parse(lenghtSideB), double.Parse(lenghtSideC));

            return triangle;
        }
    }
}
