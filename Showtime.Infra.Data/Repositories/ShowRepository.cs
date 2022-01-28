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
    public class ShowRepository : BaseRepository<Show>, IShowRepository
    {
        public ShowRepository(SQLContext sqlContext) : base(sqlContext)
        {
        }
    }
}
