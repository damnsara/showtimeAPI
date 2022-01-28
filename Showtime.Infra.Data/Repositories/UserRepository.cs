using Microsoft.AspNetCore.Authorization;
using Showtime.Domain.Entities;
using Showtime.Domain.Interfaces;
using Showtime.Infra.Data.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Showtime.Infra.Data.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(SQLContext sqlContext) : base(sqlContext)
        {
        }

        public User GetUserByLoginAndPassword(string username, string password)
        {
            return base.Select().Where(x => x.email.ToLower() == username.ToLower() && x.password == password ).FirstOrDefault();
        }
  
        public static User Get(string username, string password)
        {
            var users = new List<User>();
            users.Add(new User { Id = 1, username = "buzz lightyear", email = "buzz@gmail.com", password = "infinityandbeyond", role = "admin" });
            users.Add(new User { Id = 2, username = "naruto", email = "naruto@gmail.com", password = "hokage", role = "admin" });
            users.Add(new User { Id = 3, username = "spongebob", email = "spongebob@gmail.com", password = "gary", role = "admin" });
            return users.Where(x => x.username.ToLower() == username.ToLower() && x.password == x.password).FirstOrDefault();

        }
    }
}
