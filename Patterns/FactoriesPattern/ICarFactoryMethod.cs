namespace FactoriesPattern
{
    public partial class Program
    {
        public interface ICarFactoryMethod
        {
            ICar CreateInstance();
        }
    }

}