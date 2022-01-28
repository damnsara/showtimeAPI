using Showtime.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Showtime.Domain.Interfaces
{
    public interface IUserRepository : IBaseRepository<User>
    {
        User GetUserByLoginAndPassword(string username, string password);
    }
}
