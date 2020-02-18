using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AuthAPI.DataTransfer
{
    public class Expense
    {
        public int ExpenseId { get; set; }
        public int UserId { get; set; }

        [Column(TypeName = "VARCHAR(50)")]
        [StringLength(50)]
        public string Name { get; set; }

        [Column(TypeName = "VARCHAR(250)")]
        [StringLength(250)]
        public string Description { get; set; }
        
        [Column(TypeName = "decimal(18,2)")]
        public decimal Amount { get; set; }
          
        public DateTime? ExpenseDate { get; set; }

        public int CategoryId { get; set; }
        public ExpenseCategory Category { get; set; }

        public int MonthId { get; set; }
    }
}
