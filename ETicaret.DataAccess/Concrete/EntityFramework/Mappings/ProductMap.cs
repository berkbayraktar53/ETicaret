using ETicaret.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.DataAccess.Concrete.EntityFramework.Mappings
{
    public class ProductMap : EntityTypeConfiguration<Product>
    {
        public ProductMap()
        {
            ToTable(@"Products", @"dbo");
            HasKey(x => x.Id);

            Property(x => x.Category_Id).HasColumnName("Category_Id");
            Property(x => x.Name).HasColumnName("Name");
            Property(x => x.Description).HasColumnName("Description");
            Property(x => x.Price).HasColumnName("Price");
            Property(x => x.IsContinued).HasColumnName("IsContinued");
            Property(x => x.StarPoint).HasColumnName("StarPoint");
            Property(x => x.StarGivenMemberCount).HasColumnName("StarGivenMemberCount");
            Property(x => x.ProductImageName).HasColumnName("ProductImageName");
            Property(x => x.UnitsInStock).HasColumnName("UnitsInStock");
            Property(x => x.IsDeleted).HasColumnName("IsDeleted");
            Property(x => x.AddedDate).HasColumnName("AddedDate");
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate");
        }
    }
}