using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_Zadanie5.Models
{
    public class Event
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public virtual City City { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }
        public virtual Band Band { get; set; }

    }
}
