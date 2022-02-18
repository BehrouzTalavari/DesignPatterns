namespace FactoriesPattern
{        public class BMWFactoryMethod : ICarFactoryMethod
        {
            public ICar CreateInstance()
            {
                return new BMW();
            }
        } 

}