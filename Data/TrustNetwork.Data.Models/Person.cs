namespace TrustNetwork.Data.Models
{
    public class Person
    {
        public string ID { get; set; }
        public ICollection<Topic> Topics { get; set; }
        public ICollection<Connection> Connections { get; set; }
    }
}