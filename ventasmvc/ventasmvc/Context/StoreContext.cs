using System.Data.Entity;
using ventasmvc.Models;

namespace ventasmvc.Context
{
    public class StoreContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public System.Data.Entity.DbSet<ventasmvc.Models.DocumentType> DocumentTypes { get; set; }

        public System.Data.Entity.DbSet<ventasmvc.Models.Employee> Employees { get; set; }
    }
}