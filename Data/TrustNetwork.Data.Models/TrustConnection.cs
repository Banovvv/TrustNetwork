namespace TrustNetwork.Data.Models
{
    public class TrustConnection
    {
        public int Id { get; set; }

        public int PersonID { get; set; }
        public Person Person { get; set; }

        public int TrustLevel { get; set; }
    }
}
