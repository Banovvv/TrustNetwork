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

        public void AddTrustedConnection(int id, string name, int trustLevel)
        {
            var person = DbSet.FirstOrDefault(x => x.ID == id);
            var connection = DbSet.FirstOrDefault(x => x.Name == name);

            if (connection == null || person == null)
            {
                throw new ArgumentNullException("No such person in the network");
            }

            var trustConnection = new TrustConnection()
            {
                PersonID = connection.ID,
                TrustLevel = trustLevel
            };

            Context.TrustConnections.Add(trustConnection);

            person.TrustConnections.Add(trustConnection);
        }
    }
}
