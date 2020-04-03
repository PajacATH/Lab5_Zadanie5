using Lab5_Zadanie5.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;


namespace Lab5_Zadanie5.Configurations
{
    public class BandConfiguration : IEntityTypeConfiguration<Band>
    {
        public void Configure(EntityTypeBuilder<Band> builder)
        {
            builder.ToTable("Band");
            builder
                .HasMany(x => x.Events)
                .WithOne(x => x.Band);
        }
    }
}
