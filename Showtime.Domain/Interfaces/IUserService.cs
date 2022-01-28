using Showtime.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Showtime.Domain.Interfaces
{
    public interface IUserService : IBaseService<User>
    {
        bool Login(string username, string password);
    }
}
