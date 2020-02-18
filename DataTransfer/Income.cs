using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AuthAPI.DataTransfer
{
    public class Income
    {
        public int IncomeId { get; set; }

        public int UserId { get; set; }

        [Column(TypeName = "VARCHAR(50)")]
        [StringLength(50)]
        public string Name { get; set; }

        public int CategoryId { get; set; }

        public IncomeCategory Category { get; set; }

        [Column(TypeName = "VARCHAR(250)")]
        [StringLength(250)]
        public string Description { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Amount { get; set; }
        
        public DateTime? PayDate { get; set; }

        public int MonthId { get; set; }
    }
}
