using ETicaret.Core.DataAccess;
using ETicaret.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {
        List<Product> GetProductDetails();
    }
}