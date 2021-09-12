using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Models
{

    public class SearchStatusInvest : SearchEngineStatusInvest
    {
        public SearchStatusInvest()
        {

        }
        public SearchStatusInvest(Guid id, string name, string url)
        {
            Id = id;
            Name = name;
            Url = url;
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }

    }
}
