using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AuthAPI.DataTransfer
{
    public class IncomeSourceCategory
    {
        public int IncomeSourceCategoryId { get; set; }

        [Column(TypeName = "VARCHAR(50)")]
        [StringLength(50)]
        public string IncomeDescription { get; set; }

        public List<IncomeSource> Incomes { get; set; }
    }
}
