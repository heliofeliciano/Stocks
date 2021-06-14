using Stocks.Interfaces;

namespace Stocks.Models
{
    public class Identity : IIdentity
    {
        public int Id { get; set; }
        public string Numero { get; set; }

        public virtual string isValid()
        {
            throw new System.NotImplementedException();
        }
    }
}