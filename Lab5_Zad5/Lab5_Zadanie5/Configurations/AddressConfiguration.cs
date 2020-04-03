using System;
using System.Collections.Generic;
using System.Text;
using Lab5_Zadanie5.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Lab5_Zadanie5.Configurations
{
    class AddressConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.ToTable("Address");

            builder.HasKey(x => x.AdresId);
            builder.HasOne(x => x.City).WithMany(x => x.Addresses);
        }
    }
}
