using TrustNetwork.Data.Models;

namespace TrustNetwork.Services.Data
{
    public interface IPersonService
    {
        IEnumerable<Person> GetAll();
        Person? GetByID(int id);
        Person? GetByName(string name);
        void AddTrustedConnection(int id, string name, int trustLevel);
    }
}