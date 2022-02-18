
namespace FactoriesPattern
{
    public class BenzFactory : IAbstractFactory
    {
        public ICar Cross()
        {
            return new Benz220();
        }

        public ICar Luxtury()
        {
            return new BenzS200();
        }

        public ICar Sedan()
        {
            return new Benz();
        }
    }

}