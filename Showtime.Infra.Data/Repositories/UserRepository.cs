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
            return base.Select().Where(x => x.Email.ToLower() == username.ToLower() && x.Password == password ).FirstOrDefault();
        }
  
        public static User Get(string username, string password)
        {
            var users = new List<User>();
            users.Add(new User { Id = 1, Username = "buzz lightyear", Email = "buzz@gmail.com", Password = "infinityandbeyond", Role = "admin" });
            users.Add(new User { Id = 2, Username = "naruto", Email = "naruto@gmail.com", Password = "hokage", Role = "admin" });
            users.Add(new User { Id = 3, Username = "spongebob", Email = "spongebob@gmail.com", Password = "gary", Role = "admin" });
            return users.Where(x => x.Username.ToLower() == username.ToLower() && x.Password == x.Password).FirstOrDefault();

        }
    }
}
