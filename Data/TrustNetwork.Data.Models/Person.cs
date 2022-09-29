namespace TrustNetwork.Data.Models
{
    public class Person
    {
        public Person()
        {
            Topics = new HashSet<Topic>();
            TrustConnections = new HashSet<TrustConnection>();
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public ICollection<Topic> Topics { get; set; }
        public ICollection<TrustConnection> TrustConnections { get; set; }
    }
}