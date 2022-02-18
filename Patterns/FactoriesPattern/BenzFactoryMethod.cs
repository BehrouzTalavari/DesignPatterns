namespace FactoriesPattern
{
    public class BenzFactoryMethod : ICarFactoryMethod
    {
        public ICar CreateInstance()
        {
            return new Benz();
        }
    } 

}