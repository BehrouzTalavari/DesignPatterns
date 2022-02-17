using System;
namespace FactoriesPattern
{
    public interface IAbstractFactory
    {
        ICar Luxtury();
        ICar Cross();
        ICar Sedan();
    }
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
    public partial class Program
    {
        public static void Main(string[] args)
        {
            //var car = new CarSimpleFactory().GetCar(nameof(Benz));
            //car.Start();
            //car.Stop();
            

            //var bmw = new BMWFactoryMethod().CreateInstance();
            //bmw.Start();
            //bmw.Stop();




            Console.ReadKey();
        }
    }

}