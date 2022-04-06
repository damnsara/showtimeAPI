using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Showtime.Domain.Entities
{
    public class User : BaseEntity
    {
        public String Username { get; set; }

        public String Email { get; set; }

        public String Password { get; set; }

        public String Role { get; set; }

    }
}
