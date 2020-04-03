using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_Zadanie5.Models
{
    public class City
    {
        public string Name { get; set; }
        public string Voivodeship { get; set; }
        public ICollection<Event> Events { get; set; }
    }
}
