using AuthAPI.DataModels;
using AuthAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthAPI.Services
{
    public class ExpenseService //: IExpenseService
    {
        private BudgetContext _database;

        public ExpenseService()
        {
            _database = new BudgetContext();
        }

        public void AddExpense(Expenses expense)
        {
            _database.Expenses.Add(expense);
            _database.Commit();
        }

        public List<ExpenseEntity> GetExpensesByUserId(int userId)
        {
            var rtnList = new List<ExpenseEntity>();
            foreach (Expenses e in _database.GetExpensesByUserId(userId))
            {
                var exp = new ExpenseEntity()
                {
                    Amount = e.Amount,
                    CategoryDescription = e.Category.Description,
                    CategoryName = e.Category.Name,
                    ExpenseDate = e.ExpenseDate,
                    //Description = e.ExpenseDescription,
                    ExpenseId = e.ExpenseId,
                    //Name = e.ExpenseName,
                    //Frequency = e.Frequency,
                    UserId = e.UserId
                };
                rtnList.Add(exp);
            }

            return rtnList;
        }
    }
}
