using TrustNetwork.Data.Models;
using TrustNetwork.Data.Repositories;

namespace TrustNetwork.Services.Data
{
    public class PersonService : IPersonService
    {
        private readonly PersonRepository repository;

        public PersonService(PersonRepository repository)
        {
            this.repository = repository;
        }

        public void AddTrustedConnection(int id, string name, int trustLevel)
        {
            repository.AddTrustedConnection(id, name, trustLevel);
        }

        public IEnumerable<Person> GetAll() => repository.All();

        public Person? GetByID(int id) => repository.GetByID(id);

        public Person? GetByName(string name) => repository.GetByName(name);
    }
}
