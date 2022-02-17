namespace FactoriesPattern
{
    public partial class Program
    {
        public class BMWFactoryMethod : ICarFactoryMethod
        {
            public ICar CreateInstance()
            {
                return new BMW();
            }
        }
    }

}