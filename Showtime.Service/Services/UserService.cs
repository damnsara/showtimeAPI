using Showtime.Domain.Entities;
using Showtime.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Showtime.Service.Services
{
    public class UserService : BaseService<User>, IUserService
    {
        private readonly IUserRepository _userRepository;   
        public UserService(IUserRepository userRepository, IBaseRepository<User> baseRepository) : base(baseRepository)
        {
            _userRepository = userRepository;
        }

        public bool Login(string username, string password)
        {
            // Buscar no repositório do usuário, um usuário, passando os parâmetros acima
            return _userRepository.GetUserByLoginAndPassword(username, password) != null; 
        }
    }
}
