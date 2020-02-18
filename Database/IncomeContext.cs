using AuthAPI.DataTransfer;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace AuthAPI.Database
{
    public class IncomeContext : DbContext
    {
        private DbSet<Income> Income { get; set; }
        private DbSet<IncomeCategory> IncomeCategories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=localhost;Database=Budget;Integrated Security=True");
        }

        public void AddIncomeSource(Income newSource)
        {
            //TODO: Get user id from JWT token
            Income.Add(newSource);
            this.SaveChanges();
        }

        public List<Income> GetIncomeSourcesByUserId(int userId)
        {
            return Income.Where(x => x.UserId == userId).ToList();
        } 
    }
}
