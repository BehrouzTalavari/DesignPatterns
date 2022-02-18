namespace FactoriesPattern
{
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