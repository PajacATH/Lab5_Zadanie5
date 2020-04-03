using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_Zadanie5.Models
{
    public class Ticket
    {
        public int ID { get; set; }
        public double Price { get; set; }
        public enum Type
        {
            vip,
            standard
        }
        public Event Event { get; set; }
    }
}
