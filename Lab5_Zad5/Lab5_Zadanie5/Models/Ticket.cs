using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_Zadanie5.Models
{
    public enum TicketType
    {
        Standard,
        VIP
    }
    public class Ticket
    {
        public int ID { get; set; }
        public double Price { get; set; }
        public virtual Event Event { get; set; }
        public virtual TicketType Type { get; set; }
    }
}
