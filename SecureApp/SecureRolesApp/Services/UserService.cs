using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using SecureRolesApp.Entities;
using SecureRolesApp.Helpers;
using SecureRolesApp.Models;
using System.Data;

namespace SecureRolesApp.Services
{ 

    public class UserService : IUserService
    {
        private List<User> _users = new List<User>
        {
            new User { Id = 1, FirstName = "Swarali", LastName = "L", Username = "swarali", Password = "swarali", Role = Role.Admin },
            new User { Id = 2, FirstName = "Ganesh", LastName = "S", Username = "ganesh", Password = "ganesh", Role = Role.User } ,
            new User { Id = 3, FirstName = "Rutuja", LastName = "T", Username = "rutuja", Password = "rutuja", Role = Role.User },
            new User { Id = 4, FirstName = "Vishwambhar", LastName = "K", Username = "vishwambhar", Password = "vishwambhar", Role = Role.User },
            new User { Id = 5, FirstName = "Rohit", LastName = "W", Username = "rohit", Password = "rohit", Role = Role.Admin },

        };

        private readonly AppSettings _appSettings;

        public UserService(IOptions<AppSettings> appSettings)
        {
            _appSettings = appSettings.Value;
        }

        public AuthResponse Authenticate(AuthRequest model)
        {
            var user = _users.SingleOrDefault(x => x.Username == model.Username && x.Password == model.Password);

            if (user == null) return null;

            var token = generateJwtToken(user);

            return new AuthResponse(user, token);
        }

        public IEnumerable<User> GetAll()
        {
            return _users;
        }

        public User GetById(int id)
        {
            return _users.FirstOrDefault(x => x.Id == id);
        }

        private string generateJwtToken(User user)
        {

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[] { new Claim("id", user.Id.ToString()),
                                                     new Claim("role",user.Role)}),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), 
                                                            SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}