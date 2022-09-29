namespace TrustNetwork.Data.Models
{
    public class Person
    {
        public Person()
        {
            Topics = new HashSet<Topic>();
            Connections = new HashSet<Connection>();
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public ICollection<Topic> Topics { get; set; }
        public ICollection<Connection> Connections { get; set; }
    }
}