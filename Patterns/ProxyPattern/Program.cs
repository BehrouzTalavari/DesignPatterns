
namespace ProxyPattern
{

    public class Program
    {
        public static void Main(string[] args)
        {
            var cacheSetting = false;
            IPersonRepository personRepository = cacheSetting ? new CachePersonRepository(new InMemoryPersonRepository()) : new InMemoryPersonRepository();
            var searchResult = personRepository.GetAll();
            foreach (var item in searchResult)
            {
                Console.WriteLine($"{item.Id} {item.FirstName} {item.LastName}");
            }
            Console.ReadKey();
        }
    }
}