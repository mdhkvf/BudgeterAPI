using AuthAPI.DataTransfer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthAPI.Database
{
    public class ExpenseContext : DbContext
    {
        private DbSet<Expense> Expenses { get; set; }
        private DbSet<ExpenseCategory> ExpenseCategories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=localhost;Database=Budget;Integrated Security=True");
        }

        public void AddExpense(Expense expense)
        {
            Expenses.Add(expense);
            this.SaveChanges();
        }

        public List<Expense> GetExpensesByUserId(int userId)
        {
            return Expenses.Where(x => x.UserId == userId).ToList();
        }
    }
}
