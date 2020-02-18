﻿using System;
using System.Collections.Generic;

namespace AuthAPI.DataModels
{
    public partial class Users
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }

        public virtual UserLogin UserLogin { get; set; }
    }
}
