using System;
using System.Collections.Generic;

namespace AuthAPI.DataModels
{
    public partial class ExpenseCategories
    {
        public ExpenseCategories()
        {
            Expenses = new HashSet<Expenses>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Expenses> Expenses { get; set; }
    }
}
