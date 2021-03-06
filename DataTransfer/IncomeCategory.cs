﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AuthAPI.DataTransfer
{
    public class IncomeCategory
    {
        public int Id { get; set; }

        [Column(TypeName = "VARCHAR(50)")]
        [StringLength(50)]
        public string Name { get; set; }

        [Column(TypeName = "VARCHAR(150)")]
        [StringLength(150)]
        public string IncomeDescription { get; set; }

        public List<Income> Incomes { get; set; }
    }
}
