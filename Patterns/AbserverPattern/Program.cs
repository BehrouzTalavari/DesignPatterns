

namespace AbserverPattern
{

    public interface ISubject
    {
        List<IObserver> List { get; set; }
        void Register(IObserver observer);
        void Unregister(IObserver observer);
    }
    public interface IObserver
    {

        void Update();
    }

    public class Person : IObserver
    {
        public string FullName { get; set; }
        public void Update()
        {
            Console.WriteLine($"{FullName} is Happy");
        }
    }
    public class Departmant : IObserver
    {
        public int DepartmentId { get; set; }
        public void Update()
        {
            Console.WriteLine($"Departmant {DepartmentId} is sad");
        }
    }
    public class Warehouse : ISubject
    {
        public List<IObserver> List { get; set; } = new List<IObserver>();
        private int product;

        public int Propduct
        {
            get { return product; }
            set
            {
                product = value; foreach (var item in List)
                {
                    item.Update();
                }
            }
        }

        public void Register(IObserver observer)
        {
            List.Add(observer);
        }

        public void Unregister(IObserver observer)
        {
            List.Remove(observer);
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            var person = new Person()
            {
                FullName = "Behrouz Talavari"
            };

            var behrad = new Person()
            {
                FullName = "behrad Talavari"
            };

            Departmant departmant = new Departmant()
            {
                DepartmentId = 1
            };
            Departmant departmant2 = new Departmant()
            {
                DepartmentId = 2
            };

            Warehouse warehouse = new Warehouse();
            warehouse.Register(person);
            warehouse.Register(behrad);
            warehouse.Register(departmant);
            warehouse.Register(departmant2);
            warehouse.Propduct = 2;
            Console.WriteLine("----------------------");
            warehouse.Propduct = 3;
            Console.WriteLine("----------------------");
            warehouse.Propduct = 25;
            warehouse.Unregister(departmant2);
            Console.WriteLine("----------------------");
            warehouse.Propduct = 2;

        }
    }
}