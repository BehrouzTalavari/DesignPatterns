namespace AdaptorPattern
{
    public class ScreenPrinter 
    {
        public bool PrintToScreen(string text)
        {
            Console.WriteLine(text);
            return true;
        }
    }
}