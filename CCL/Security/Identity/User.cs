﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CCL.Security.Identity
{
    public abstract class User
    {
        public int UserId { get; }
        public string Name { get; }
        public string Surname { get; }
        public int MateriallId { get; }
        protected string UserType { get; }


        public User(int userId, string name, string surname, int materiallId, string userType)
        {
            UserId = userId;
            Name = name;
            Surname = surname;
            MateriallId = materiallId;
            UserType = userType;
        }
    }
}
