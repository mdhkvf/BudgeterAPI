using System;
using System.Collections.Generic;

namespace AuthAPI.DataModels
{
    public partial class IncomeCategories
    {
        public IncomeCategories()
        {
            Income = new HashSet<Income>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string IncomeDescription { get; set; }

        public virtual ICollection<Income> Income { get; set; }
    }
}
