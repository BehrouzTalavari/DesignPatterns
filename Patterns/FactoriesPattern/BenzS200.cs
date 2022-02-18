namespace FactoriesPattern
{
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

}