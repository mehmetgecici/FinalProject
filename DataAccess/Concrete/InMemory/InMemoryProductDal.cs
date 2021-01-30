using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product> {
                new Product{ProductId=1,CatogoryId=1,ProductName= "Bardak", UnitPrice=15,UnitsInStocks=15 },
                new Product{ProductId=2,CatogoryId=2,ProductName= "Kamera", UnitPrice=500,UnitsInStocks=3 },
                new Product{ProductId=3,CatogoryId=3,ProductName= "Telefon", UnitPrice=1500,UnitsInStocks=2 },
                new Product{ProductId=4,CatogoryId=4,ProductName= "Klavye", UnitPrice=150,UnitsInStocks=65 },
                new Product{ProductId=5,CatogoryId=5,ProductName= "Fare", UnitPrice=85,UnitsInStocks=1 }
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product productToDelete = _products.SingleOrDefault(p => p.ProductId == product.CatogoryId);

            _products.Remove(productToDelete);
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public void Update(Product product)
        {
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.CatogoryId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CatogoryId = product.CatogoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStocks = product.UnitsInStocks;
        }

        List<Product> IProductDal.GetAllByCategory(int categoryId)
        {
           return _products.Where(p => p.CatogoryId == categoryId).ToList();
        }
    }
}
