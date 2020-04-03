using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_Zadanie5.Models
{
    public class Address
    {
        public int ID { get; set; }
        public City City { get; set; }
        public string Street { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }

    }
}
