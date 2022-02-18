namespace FactoriesPattern
{
    public class Benz : ICar
    {
        public void Start()
        {
            Console.WriteLine($"{nameof(Benz)} Start!");
        }

        public void Stop()
        {
            Console.WriteLine($"{nameof(Benz)} End!");
        }
    }

}