namespace AdaptorPattern
{
    public class ObjectAdapter : IPrinter
    {
        private readonly ScreenPrinter _screenPrinter;
        public ObjectAdapter()
        {
            _screenPrinter = new ScreenPrinter();
        }
        public void Print(string text)
        {
            _screenPrinter.PrintToScreen(text);
        }
    }
}