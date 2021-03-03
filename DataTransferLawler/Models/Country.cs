namespace DataTransferLawler.Models
{
    public class Country
    {
        public string CountryID { get; set; }
        public string Name { get; set; }
        public Game Game { get; set; }
        public Sport Sport { get; set; }
        public string CountryFlag { get; set; }
    }
}
