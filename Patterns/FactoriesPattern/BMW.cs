namespace FactoriesPattern
{
    public class BMW : ICar
    {
        public void Start()
        {
            Console.WriteLine($"{nameof(BMW)} Start!");
        }

        public void Stop()
        {
            Console.WriteLine($"{nameof(BMW)} End!");
        }
    }
    public class BMWX3 : ICar
    {
        public void Start()
        {
            Console.WriteLine($"{nameof(BMWX3)} Start!");
        }

        public void Stop()
        {
            Console.WriteLine($"{nameof(BMWX3)} End!");
        }
    }
    public class BMWX7 : ICar
    {
        public void Start()
        {
            Console.WriteLine($"{nameof(BMWX7)} Start!");
        }

        public void Stop()
        {
            Console.WriteLine($"{nameof(BMWX3)} End!");
        }
    }

}