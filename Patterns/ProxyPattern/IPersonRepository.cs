
namespace ProxyPattern
{
    public interface IPersonRepository
    {
        List<Person> GetAll();
        void Add(Person person);
        Person Get(int id);
    }
}