using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _producDal;

        public ProductManager(IProductDal producDal)
        {
            _producDal = producDal;
        }

        public List<Product> GetAll()
        {
           return _producDal.GetAll();
        }
    }
}
