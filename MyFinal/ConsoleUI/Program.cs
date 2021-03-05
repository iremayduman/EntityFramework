using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            Console.WriteLine("-------CategoryId=2------");
            foreach (var product in productManager.GetAllByCategoryId(2))
            {
                
                Console.WriteLine(product.ProductName);
            }
            Console.WriteLine("--------Fiyatı 50 ile 100 arasında olan ürünler--------");
            foreach (var product in productManager.GetByUnitPrice(50,100))
            {
               
                Console.WriteLine(product.ProductName);
            }
        }
    }
}
