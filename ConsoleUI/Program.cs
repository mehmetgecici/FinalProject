using Business.Concrete;
using System;
using DataAccess.Concrete.InMemory;
namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new InMemoryProductDal());
            foreach (var obj in productManager.GetAll())
            {
                Console.WriteLine(obj.ProductName);
            } 
        }
    }
}
