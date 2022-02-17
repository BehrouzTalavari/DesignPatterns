namespace AdaptorPattern
{
    public class FilePrinter : IPrinter
    {
        public void Print(string text)
        {
            System.IO.File.WriteAllText("C:\\output.txt", text);
        }
    }
}