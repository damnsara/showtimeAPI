using Showtime.Domain.Entities;
using Showtime.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Showtime.Service.Services
{
    public class ShowService : BaseService<Show>, IShowService
    {
        private readonly IShowRepository _showRepository;
        public ShowService(IShowRepository showRepository, IBaseRepository<Show> baseRepository) : base(baseRepository)
        {
            _showRepository = showRepository;
        }
    }
}
