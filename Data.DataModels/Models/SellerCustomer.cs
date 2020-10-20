using Data.Models.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Models.Models
{
    public class SellerCustomer : BaseModel
    {
        public string SellerId { get; set; }
        public Seller Seller { get; set; }
        public string CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
