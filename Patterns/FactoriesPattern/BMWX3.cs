namespace FactoriesPattern
{
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

}