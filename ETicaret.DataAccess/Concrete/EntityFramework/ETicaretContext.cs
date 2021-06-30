using ETicaret.DataAccess.Concrete.EntityFramework.Mappings;
using ETicaret.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.DataAccess.Concrete.EntityFramework
{
    public class ETicaretContext : DbContext
    {
        public ETicaretContext()
        {
            Database.SetInitializer<ETicaretContext>(null);
        }
        public DbSet<Product> Product { get; set; }
        public DbSet<Category> Category { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ProductMap());
            modelBuilder.Configurations.Add(new CategoryMap());
        }
    }
}