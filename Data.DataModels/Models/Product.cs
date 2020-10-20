using Data.Models.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Data.Models.Models
{
    public class Product : BaseModel
    {
        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string ProductName { get; set; }
        [Required]
        public decimal ProductPrice { get; set; }
        public int CurrentCountInWarehouse { get; set; }
    }
}
