using Data.DataConnection;
using System;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            AppDbContext db = new AppDbContext();
            db.Products.Add(new Data.Models.Models.Product()
            {
                ProductName = "Samsung S20",
                CurrentCountInWarehouse = 80,
                ProductPrice = 1670
            });
            db.SaveChanges();
        }
    }
}
