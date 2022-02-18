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

}