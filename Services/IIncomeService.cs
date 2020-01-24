using AuthAPI.DataTransfer;
using System.Collections.Generic;

namespace AuthAPI.Services
{
    public interface IIncomeService
    {
        List<IncomeSource> GetIncomeSourcesById(int userId);
        void AddIncomeSource(IncomeSource incomeSource);
    }
}
