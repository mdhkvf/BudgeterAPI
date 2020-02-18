using AuthAPI.Database;
using AuthAPI.DataTransfer;
using System.Collections.Generic;

namespace AuthAPI.Services
{
    public class IncomeService : IIncomeService
    {
        private IncomeContext _database;

        public IncomeService()
        {
            _database = new IncomeContext();
        }

        public void AddIncomeSource(Income incomeSource)
        {
            _database.AddIncomeSource(incomeSource);
        }

        public List<Income> GetIncomeSourcesById(int userId)
        {
            return _database.GetIncomeSourcesByUserId(userId);
        }

        
    }
}
