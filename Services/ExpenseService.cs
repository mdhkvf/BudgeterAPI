using AuthAPI.Database;
using AuthAPI.DataTransfer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthAPI.Services
{
    public class ExpenseService : IExpenseService
    {
        private ExpenseContext _database;

        public ExpenseService()
        {
            _database = new ExpenseContext();
        }

        public void AddExpense(Expense expense)
        {
            _database.AddExpense(expense);
        }

        public List<Expense> GetExpensesByUserId(int userId)
        {
            return _database.GetExpensesByUserId(userId);
        }
    }
}
