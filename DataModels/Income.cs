using System;
using System.Collections.Generic;

namespace AuthAPI.DataModels
{
    public partial class Income
    {
        public int IncomeId { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public DateTime? PayDate { get; set; }
        public int MonthId { get; set; }

        public virtual IncomeCategories Category { get; set; }
    }
}
