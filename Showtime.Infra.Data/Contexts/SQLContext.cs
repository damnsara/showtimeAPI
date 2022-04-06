using Microsoft.EntityFrameworkCore;
using Showtime.Domain.Entities;
using Showtime.Infra.Data.Mappings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Showtime.Infra.Data.Contexts
{
    public class SQLContext : DbContext
    {

    public SQLContext(DbContextOptions<SQLContext> options) : base(options)
        {

        }
        public DbSet<Show> Shows { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Show>().HasData(
                   new Show
                   {
                       Id = 1,
                       Name = "Squid Game",
                       NumberOfSeasons = 1,
                       Channel = "Netflix",
                       ParentalRating = 18
                   },
                   new Show
                   {
                       Id = 2,
                       Name = "Glee",
                       NumberOfSeasons = 6,
                       Channel = "Fox",
                       ParentalRating = 12
                   },
                   new Show
                   {
                       Id = 3,
                       Name = "Breaking Bad",
                       NumberOfSeasons = 5,
                       Channel = "AMC",
                       ParentalRating = 16
                   }
                );

            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 10,
                    Username = "Buzz Lightyear",
                    Email = "buzz@gmail.com",
                    Password = "infinitybeyond",
                    Role = "admin"
                },
                new User
                {
                    Id = 11,
                    Username = "Catwoman",
                    Email = "selinakyle@gmail.com",
                    Password = "meow1234",
                    Role = "admin"
                   
                },
                new User
                {
                    Id = 12,
                    Username = "WandaMaximoff",
                    Email = "wandavision@gmail.com",
                    Password = "sokovia",
                    Role = "admin"
                }
               );

            modelBuilder.Entity<Show>(new ShowMap().Configure);
            modelBuilder.Entity<User>(new UserMap().Configure);
        }


    }

}
