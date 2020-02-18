using System;
using System.Collections.Generic;

namespace AuthAPI.DataModels
{
    public partial class Expenses
    {
        public int ExpenseId { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public DateTime? ExpenseDate { get; set; }
        public int CategoryId { get; set; }
        public int MonthId { get; set; }

        public virtual ExpenseCategories Category { get; set; }
    }
}
