using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SessionTraining.Models.Entities;

namespace SessionTraining.Data
{
    public class SessionTrainingContext : DbContext
    {
        public SessionTrainingContext (DbContextOptions<SessionTrainingContext> options)
            : base(options)
        {
        }

        public DbSet<SessionTraining.Models.Entities.User> User { get; set; }
    }
}
