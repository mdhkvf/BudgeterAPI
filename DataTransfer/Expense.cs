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
        public int ExpenseCategoryId { get; set; }
        public int UserId { get; set; }

        [Column(TypeName = "VARCHAR(50)")]
        [StringLength(50)]
        public string ExpenseName { get; set; }

        [Column(TypeName = "VARCHAR(250)")]
        [StringLength(250)]
        public string ExpenseDescription { get; set; }
        
        [Column(TypeName = "decimal(18,2)")]
        public decimal Amount { get; set; }
          
        public DateTime ExpenseDate { get; set; }

        [Column(TypeName = "VARCHAR(30)")]
        [StringLength(30)]
        public string Frequency { get; set; }
    }
}
