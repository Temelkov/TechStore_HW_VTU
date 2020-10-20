using Data.Models.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Models.Models
{
    public class Customer : BaseModel
    {
        public string CustomerNumber { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }

        public ICollection<SellerCustomer> SellerCustomers { get; set; }
    }
}
