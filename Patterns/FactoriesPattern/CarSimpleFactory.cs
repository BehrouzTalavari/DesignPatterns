namespace FactoriesPattern
{
    public class CarSimpleFactory
    {
        public ICar GetCar(string carName)
        {
            switch (carName)
            {
                case nameof(BMW):
                    return new BMW();
                case nameof(Benz):
                    return new Benz();
                default:
                    return null;
            }
        }
    }
 
}