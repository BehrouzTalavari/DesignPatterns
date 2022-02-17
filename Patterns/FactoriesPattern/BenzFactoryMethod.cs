namespace FactoriesPattern
{
    public partial class Program
    {
        public class BenzFactoryMethod : ICarFactoryMethod
        {
            public ICar CreateInstance()
            {
                return new Benz();
            }
        }
    }

}