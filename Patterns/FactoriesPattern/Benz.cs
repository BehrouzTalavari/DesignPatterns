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
    public class BenzS200 : ICar
    {
        public void Start()
        {
            Console.WriteLine($"{nameof(BenzS200)} Start!");
        }

        public void Stop()
        {
            Console.WriteLine($"{nameof(BenzS200)} End!");
        }
    }
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