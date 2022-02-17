namespace MementoPattern
{
    public class CarState
    {
        public int Speed { get; set; }
        public int Fule { get; set; }

    }
    public class Car
    {
        private int _fule;
        private int _speed;

        public CarState CarState { get; }

        public void AddFule(int value)
        {
            _fule += value;
        }
        public void IncreaseSpeed()
        {
            _speed++;
        }
        public void DecreaseSpeed()
        {
            _speed--;
        }
        public void Kilometer()
        {
            _fule -= 6;
        }
        public Car()
        {

        }
        public Car(CarState carState)
        {
            CarState = carState;
        }
        public CarState GetCarState()
        {
            return new CarState
            {
                Speed = _speed,
                Fule = _fule
            };

        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
        }
    }
}