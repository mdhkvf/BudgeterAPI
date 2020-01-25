using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthAPI.Entities
{
    public class ExpenseEntity
    {
        public int ExpenseId { get; set; }
        public int UserId { get; set; }

        public string ExpenseName { get; set; }

        public string ExpenseDescription { get; set; }

        public decimal Amount { get; set; }

        public DateTime ExpenseDate { get; set; }

        public string Frequency { get; set; }

        public string CategoryName { get; set;}
        public string CategoryDescription { get; set; }

    }
}
