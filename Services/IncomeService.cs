using AuthAPI.Database;
using AuthAPI.DataTransfer;
using System.Collections.Generic;

namespace AuthAPI.Services
{
    public class IncomeService : IIncomeService
    {
        private IncomeSourceContext _database;

        public IncomeService()
        {
            _database = new IncomeSourceContext();
        }

        public void AddIncomeSource(IncomeSource incomeSource)
        {
            _database.AddIncomeSource(incomeSource);
        }

        public List<IncomeSource> GetIncomeSourcesById(int userId)
        {
            return _database.GetIncomeSourcesByUserId(userId);
        }

        
    }
}
