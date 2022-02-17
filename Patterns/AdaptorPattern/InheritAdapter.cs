namespace AdaptorPattern
{
    public class InheritAdapter : ScreenPrinter, IPrinter
    {
        public void Print(string text)
        {
            this.PrintToScreen(text);
        }
    }
}