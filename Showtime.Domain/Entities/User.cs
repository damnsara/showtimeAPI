using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Showtime.Domain.Entities
{
    public class User : BaseEntity
    {
        public String username { get; set; }

        public String email { get; set; }

        public String password { get; set; }

        public String role { get; set; }

    }
}
