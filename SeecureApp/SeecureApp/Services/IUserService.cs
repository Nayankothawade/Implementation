using System.Collections.Generic;
using SecureApp.Entities;
using SecureApp.Models;

namespace SecureApp.Services
{
    public interface IUserService
    {
        AuthResponse Authenticate(AuthRequest model);
        IEnumerable<User> GetAll();
        User GetById(int id);
    }
}