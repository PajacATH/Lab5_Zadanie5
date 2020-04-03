using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_Zadanie5.Models
{
    public class Event
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public City City { get; set; }
        public ICollection<Ticket> Tickets { get; set; }
        public Band Band { get; set; }

    }
}
