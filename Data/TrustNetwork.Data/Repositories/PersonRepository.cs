using TrustNetwork.Data.Models;

namespace TrustNetwork.Data.Repositories
{
    public class PersonRepository : Repository<Person>
    {
        public PersonRepository(ApplicationDataContext context) : base(context)
        {
        }

        public Person? GetByID(int id)
        {
            return DbSet
                .FirstOrDefault(x => x.ID == id);
        }

        public Person? GetByName(string name)
        {
            return DbSet
                .FirstOrDefault(x => x.Name == name);
        }
    }
}
