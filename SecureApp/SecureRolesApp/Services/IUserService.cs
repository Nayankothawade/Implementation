using System.Collections.Generic;
using SecureRolesApp.Entities;
using SecureRolesApp.Models;

namespace SecureRolesApp.Services
{
    public interface IUserService
    {
        AuthResponse Authenticate(AuthRequest model);
        IEnumerable<User> GetAll();
        User GetById(int id);
    }
}