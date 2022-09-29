namespace TrustNetwork.Data.Models
{
    public class Connection
    {
        public int Id { get; set; }

        public int PersonID { get; set; }
        public Person Person { get; set; }

        public int ConnectedPersonID { get; set; }
        public Person ConnectedPerson { get; set; }

        public int TrustLevel { get; set; }
    }
}
