using Microsoft.EntityFrameworkCore;
using POS.Model;
using POS_SuperStore.Data;
using POS_SuperStore.ViewModel;

namespace POS_SuperStore.Data
{
    public class POSDBContext:DbContext
    {
        public POSDBContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public  DbSet<RejectReason> RejectReasons { get; set; }
        public DbSet<InventoryDetailVM> InventoryDetails { get; set; }    
        

	}
}
 