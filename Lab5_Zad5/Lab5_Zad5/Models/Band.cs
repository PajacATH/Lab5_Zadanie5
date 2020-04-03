using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_Zadanie5.Models
{
    public class Band
    {
        public int ID { get; set; }
        public string Nazwa { get; set; }
        public Address Address { get; set; }
        public ICollection<Event> Events { get; set; }
    }
}
