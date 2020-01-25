using AuthAPI.DataTransfer;
using AuthAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthAPI.Services
{
    public interface IExpenseService
    {
        public List<ExpenseEntity> GetExpensesByUserId(int userId);

        public void AddExpense(Expense expense);
    }
}
