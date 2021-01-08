using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using SessionTraining.Data;
using SessionTraining.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SessionTraining.Services
{
    public class LoginService
    {
        public User User { get; set; }
        private readonly SessionTrainingContext _context;

        public LoginService(User user,SessionTrainingContext context)
        {
            User = user;
            _context = context;
        }

        public async Task<User> AuthenticationAsync(User user)
        {
            User user1 = null;
            if (user != null)
            {
                user1 = await  _context.User
               .FirstOrDefaultAsync(m => m.Username == user.Username);
                
            }
            return user1;
            
        }
    }
}
