
namespace FactoriesPattern
{
    public class BMWFactory : IAbstractFactory
    {
        public ICar Cross()
        {
            return new BMWX3();
        }

        public ICar Luxtury()
        {
            return new BMWX7();
        }

        public ICar Sedan()
        {
            return new BMW();
        }
    }

}