namespace SoftServe.TriangleSort
{
    public class InputSplitter : IInputSplitter
    {
        public void Split(string userInput, out string name, out string lenghtSideA, out string lenghtSideB, out string lenghtSideC)
        {
            StringEditor stringEditor = new StringEditor();

            userInput = stringEditor.RemoveSpaces(userInput);
            userInput = stringEditor.RemoveTabulation(userInput);

            string[] userInputArr = userInput.Split(DefaultSettings.SPLITTER);

            name = userInputArr[0];
            lenghtSideA = userInputArr[1];
            lenghtSideB = userInputArr[2];
            lenghtSideC = userInputArr[3];
        }
    }
}
