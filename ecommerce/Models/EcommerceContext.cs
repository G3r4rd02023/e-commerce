using System.Data.Entity;

namespace ecommerce.Models
{
    public class EcommerceContext : DbContext
    {
        public EcommerceContext() : base("DefaultConnection")
        {
        }

        public DbSet<Department> Departments { get; set; }

        public System.Data.Entity.DbSet<ecommerce.Models.City> Cities { get; set; }
    }
}