using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ecommerce.Models
{
    public class EcommerceContext : DbContext
    {
        public EcommerceContext() : base("DefaultConnection")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }


        public DbSet<Department> Departments { get; set; }

        public System.Data.Entity.DbSet<ecommerce.Models.City> Cities { get; set; }

        public System.Data.Entity.DbSet<ecommerce.Models.Company> Companies { get; set; }
    }
}