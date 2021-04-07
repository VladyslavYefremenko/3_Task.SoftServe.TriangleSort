namespace SoftServe.TriangleSort
{
    interface IInputSplitter
    {
        void Split(string userInput, out string name, out string lenghtSideA, out string lenghtSideB, out string lenghtSideC);
    }
}
