using AuthAPI.DataTransfer;
using System.Collections.Generic;

namespace AuthAPI.Services
{
    public interface IIncomeService
    {
        List<Income> GetIncomeSourcesById(int userId);
        void AddIncomeSource(Income incomeSource);
    }
}
