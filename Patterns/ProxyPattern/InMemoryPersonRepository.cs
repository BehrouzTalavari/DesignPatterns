
namespace ProxyPattern
{
    public class InMemoryPersonRepository : IPersonRepository
    {
        private readonly List<Person> people = new List<Person>()
        {
            new Person(){ FirstName = "Behrouz",LastName ="Talavari",Id=1},
            new Person(){ FirstName = "Behrad",LastName ="Talavari",Id=2},
            new Person(){ FirstName = "Mehrdad",LastName ="ShokouhiNia",Id=3},
        };
        public void Add(Person person)
        {
            person.Id = people.Count + 1;
            people.Add(person);
        }
        public Person Get(int id)
        {
            return people.Single(x => x.Id == id);
        }

        public List<Person> GetAll()
        {
            return people;
        }
    }
}