﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SessionTraining.Models.Entities
{
    public class UserSession
    {
        public DateTime StartedAt { get; }
        public User UserDetail { get; }

        public UserSession(User user)
        {
            StartedAt = DateTime.UtcNow;
            UserDetail = user;
        }
    }
}
