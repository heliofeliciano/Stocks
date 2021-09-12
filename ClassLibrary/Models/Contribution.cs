using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Models
{
    public class Contribution
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public string Description { get; set; }

    }
}
