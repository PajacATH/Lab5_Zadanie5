using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_Zadanie5.Models
{
    public class Address
    {
        public int AdresId { get; set; }
        public string Street { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }
        public virtual Band Band { get; set; }
        public virtual City City { get; set; }

    }
}
