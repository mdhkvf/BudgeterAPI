using AuthAPI.DataTransfer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthAPI.Database
{
    public class UserContext : DbContext
    {
        private DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=localhost;Database=Budget;Integrated Security=True");
        }

        public bool AddUser(User user)
        {
            try
            {
                Users.Add(user);
                this.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<User> GetUsers()
        {
            return Users.ToList();
        }
    }
}
