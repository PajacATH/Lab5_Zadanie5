using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_Zadanie5.Models
{
    public class City
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Voivodeship { get; set; }
        public virtual ICollection<Event> Events { get; set; }
        public virtual ICollection<Address> Addresses { get; set; }
    }
}
