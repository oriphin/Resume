namespace Resume.Domain
{
    public class Location
    {
        public int LocationId { get; set; }
        public string StreetNumber { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public int PostCode { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Description { get; set; }
    }
}