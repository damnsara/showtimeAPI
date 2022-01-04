using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Showtime.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Showtime.Infra.Data.Mapping
{
    public class ShowMap : IEntityTypeConfiguration<Show>
    {
        public void Configure(EntityTypeBuilder<Show> builder)
        {
            builder.ToTable("Shows");
            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Name)
                .HasConversion(prop => prop.ToString(), prop => prop)
                .IsRequired()
                .HasColumnName("Name")
                .HasColumnType("varchar(100)");

            builder.Property(prop => prop.NumberOfSeasons)
                .IsRequired()
                .HasColumnName("Number of Seasons")
                .HasColumnType("int");

            builder.Property(prop => prop.Channel)
                .HasConversion(prop => prop.ToString(), prop => prop)
                .IsRequired()
                .HasColumnName("Channel")
                .HasColumnType("varchar(100)");

            builder.Property(prop => prop.ParentalRating)
                .IsRequired()
                .HasColumnName("Parental Rating")
                .HasColumnType("int");

        }
    }
}
