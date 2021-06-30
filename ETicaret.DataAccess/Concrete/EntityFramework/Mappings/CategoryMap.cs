using ETicaret.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.DataAccess.Concrete.EntityFramework.Mappings
{
    public class CategoryMap : EntityTypeConfiguration<Category>
    {
        public CategoryMap()
        {
            ToTable(@"Categories", @"dbo");
            HasKey(x => x.Id);

            Property(x => x.Parent_Id).HasColumnName("Parent_Id");
            Property(x => x.Name).HasColumnName("Name");
            Property(x => x.Description).HasColumnName("Description");
            Property(x => x.IsDeleted).HasColumnName("IsDeleted");
            Property(x => x.AddedDate).HasColumnName("AddedDate");
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate");
        }
    }
}