using AutoMapper;
using ETicaret.Business.Abstract;
using ETicaret.DataAccess.Abstract;
using ETicaret.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;
        readonly IMapper _mapper;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        public List<Product> GetAllList()
        {

            var products = _mapper.Map<List<Product>>(_productDal.GetList());
            return products;
        }
    }
}