using AuthAPI.DataTransfer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthAPI.Database
{
    public class IncomeSourceContext : DbContext
    {
        private DbSet<IncomeSource> IncomeSources { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=localhost;Database=Budget;Integrated Security=True");
        }

        public void AddIncomeSource(IncomeSource newSource)
        {
            newSource.UserId = 1; //TODO: Get user id from JWT token
            IncomeSources.Add(newSource);
            this.SaveChanges();
        }

        public List<IncomeSource> GetIncomeSourcesByUserId(int userId)
        {
            return IncomeSources.Where(x => x.UserId == userId).ToList();
        } 
    }
}
