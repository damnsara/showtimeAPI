using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Showtime.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Showtime.Infra.Data.Mappings
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");
            builder.HasKey(x => x.Id);

            builder.Property(prop => prop.Username)
                .HasConversion(prop => prop.ToString(), prop => prop)
                .IsRequired()
                .HasColumnName("Name")
                .HasColumnType("varchar(100)");

            builder.Property(prop => prop.Email)
                .HasConversion(prop => prop.ToString(), prop => prop)
                .IsRequired()
                .HasColumnName("E-mail")
                .HasColumnType("varchar(100)");

            builder.Property(prop => prop.Password)
                .HasConversion(prop => prop.ToString(), prop => prop)
                .IsRequired()
                .HasColumnName("password")
                .HasColumnType("varchar(100)");

            builder.Property(prop => prop.Role)
                .HasConversion(prop => prop.ToString(), prop => prop)
                .IsRequired()
                .HasColumnName("role")
                .HasColumnType("varchar(15)");
        }
    }
}
