using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Showtime.Domain.Entities
{
    public class Show : BaseEntity
    {
        public string Name { get; set; }
        public int NumberOfSeasons { get; set; }
        public string Channel { get; set; }
        public int ParentalRating { get; set; }

    }
}
