using AuthAPI.Database;
using AuthAPI.DataTransfer;
using AuthAPI.Entities;
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

        public List<ExpenseEntity> GetExpensesByUserId(int userId)
        {
            var rtnList = new List<ExpenseEntity>();
            foreach (Expense e in _database.GetExpensesByUserId(userId))
            {
                var exp = new ExpenseEntity()
                {
                    Amount = e.Amount,
                    CategoryDescription = e.Category.Description,
                    CategoryName = e.Category.Name,
                    ExpenseDate = e.ExpenseDate,
                    Description = e.ExpenseDescription,
                    ExpenseId = e.ExpenseId,
                    Name = e.ExpenseName,
                    Frequency = e.Frequency,
                    UserId = e.UserId
                };
                rtnList.Add(exp);
            }

            return rtnList;
        }
    }
}
