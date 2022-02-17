
namespace ProxyPattern
{
    public class CachePersonRepository : IPersonRepository
    {
        private readonly IPersonRepository personRepository;

        public CachePersonRepository(IPersonRepository personRepository)
        {
            this.personRepository = personRepository;
        }
        public void Add(Person person)
        {
            personRepository.Add(person);
        }

        public Person Get(int id)
        {
            //check Cache
            if (1 == 1)
            {
                var result = personRepository.GetAll();
                //add result to cache
            }
            var cachedResult = new Person(); //read from cache
            return cachedResult;
        }

        public List<Person> GetAll()
        {
            //check Cache
            if (1 == 1)
            {
                var result = personRepository.GetAll();
                //add result to cache
            }
            var cachedResult = new List<Person>(); //read from cache
            return cachedResult;
        }
    }
}