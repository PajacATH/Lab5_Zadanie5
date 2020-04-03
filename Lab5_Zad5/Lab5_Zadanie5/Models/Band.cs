using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_Zadanie5.Models
{
    public class Band
    {
        public int BandId { get; set; }
        public int AdresId { get; set; }
        public string Nazwa { get; set; }
        public virtual Address Address { get; set; }
        public virtual ICollection<Event> Events { get; set; }
    }
}
