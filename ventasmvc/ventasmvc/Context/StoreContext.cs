using System.Data.Entity;
using ventasmvc.Models;

namespace ventasmvc.Context
{
    public class StoreContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}