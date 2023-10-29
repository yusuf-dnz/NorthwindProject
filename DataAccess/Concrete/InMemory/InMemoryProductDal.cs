using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _product;

        public InMemoryProductDal()
        {
            _product = new List<Product> 
            {
                new Product {ProductId=1,CategoryId=1,ProductName="Bardak",UnitPrice=10,UnitsInStock=35},
                new Product {ProductId=2,CategoryId=2,ProductName="Kamera",UnitPrice=500,UnitsInStock=12},
                new Product {ProductId=3,CategoryId=2,ProductName="Telefon",UnitPrice=1150,UnitsInStock=150},
                new Product {ProductId=4,CategoryId=2,ProductName="Klavye",UnitPrice=150,UnitsInStock=10},
                new Product {ProductId=5,CategoryId=2,ProductName="Fare",UnitPrice=100,UnitsInStock=1},


            };
        }
        public void Add(Product product)
        {
            _product.Add(product);
        }

        public void Delete(Product product)
        {
            Product productToDelete = _product.SingleOrDefault(p=>p.ProductId == product.ProductId);
            _product.Remove(productToDelete);
            
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _product;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _product.Where(p=>p.CategoryId == categoryId).ToList();
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            Product productToUpdate = _product.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
        }
    }
}
