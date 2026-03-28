using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Core.Models;
using TaskManager.Data.Repositories;

namespace TaskManager.Business.Services
{
    public class AuthService
    {
        private readonly UserRepository _userRepository;

        public AuthService()
        {
            _userRepository = new UserRepository();
        }

        public User Login(string username, string password)
        {
            return _userRepository.GetUser(username, password);
        }
    }
}