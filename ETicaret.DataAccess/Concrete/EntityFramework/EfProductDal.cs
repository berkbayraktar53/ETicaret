using ETicaret.Core.DataAccess.EntityFramework;
using ETicaret.DataAccess.Abstract;
using ETicaret.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, ETicaretContext>, IProductDal
    {
        public List<Product> GetProductDetails()
        {
            using (ETicaretContext context = new ETicaretContext())
            {
                var result = from p in context.Product
                             select new Product
                             {
                                 Id = p.Id,
                                 Category_Id = p.Category_Id,
                                 Name = p.Name,
                                 Description = p.Description,
                                 Price = p.Price,
                                 IsContinued = p.IsContinued,
                                 UnitsInStock = p.UnitsInStock,
                                 StarPoint = p.StarPoint,
                                 StarGivenMemberCount = p.StarGivenMemberCount,
                                 ProductImageName = p.ProductImageName,
                                 IsDeleted = p.IsDeleted,
                                 AddedDate = p.AddedDate,
                                 ModifiedDate = p.ModifiedDate
                             };
                return result.ToList();
            }
        }
    }
}