namespace TrustNetwork.Data.Models
{
    public class Message
    {
        public int ID { get; set; }
        public string Text { get; set; }
        public Person FromPerson { get; set; }
        public int MinTrustLevel { get; set; }
    }
}
