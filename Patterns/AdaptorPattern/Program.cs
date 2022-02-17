namespace AdaptorPattern
{

    public class Program
    {
        public static void Main(string[] args)
        {
            //IPrinter printer = new FilePrinter();
            //IPrinter printer = new ObjectAdapter();
            IPrinter printer = new InheritAdapter();

            var textForPrint = Console.ReadLine();

            printer.Print(textForPrint); 

            Console.ReadKey();

        }
    }
}