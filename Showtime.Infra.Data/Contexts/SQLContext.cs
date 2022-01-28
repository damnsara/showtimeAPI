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
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Show>(new ShowMap().Configure);
            modelBuilder.Entity<User>(new UserMap().Configure);
        }


    }

}
