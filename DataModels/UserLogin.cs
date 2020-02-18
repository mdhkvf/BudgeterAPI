using System;
using System.Collections.Generic;

namespace AuthAPI.DataModels
{
    public partial class UserLogin
    {
        public int UserLoginId { get; set; }
        public int UserId { get; set; }
        public int FailedLoginAttempts { get; set; }
        public bool LockedOut { get; set; }
        public DateTime? UnlockDate { get; set; }

        public virtual Users User { get; set; }
    }
}
