namespace Stocks.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Identify Identify { get; set; }
        public int IdentifyId { get; set; }

    }
}