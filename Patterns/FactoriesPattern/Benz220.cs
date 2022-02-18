namespace FactoriesPattern
{
    public class Benz220 : ICar
    {
        public void Start()
        {
            Console.WriteLine($"{nameof(Benz220)} Start!");
        }

        public void Stop()
        {
            Console.WriteLine($"{nameof(Benz220)} End!");
        }
    }

}