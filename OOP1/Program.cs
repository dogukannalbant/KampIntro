using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product producut1 = new Product();
            producut1.Id = 1;
            producut1.CategoryId = 2;
            producut1.ProductName = "Masa";
            producut1.UnitPrice = 500;
            producut1.UnitInStock = 3;

            Product product2 = new Product
            {
                Id = 2,
                CategoryId = 5,
                UnitInStock = 5,
                ProductName = "Kalem",
                UnitPrice = 35
            };
            //PascalCase     //camelCase
            //case sensitive )büyük küçük harf duyarlılığı vardır(
            ProductManager productManager = new ProductManager();
            productManager.Add(producut1);
            Console.WriteLine(producut1.ProductName);

        }
    }
}
