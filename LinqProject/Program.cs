using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqProject
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Category> categories = new List<Category>
            {
                new Category {CategoryId = 1, CategoryName = "Computer"},
                new Category {CategoryId = 2, CategoryName = "Phone"}
            };

            List<Product> products = new List<Product>
            {
                new Product {ProductId = 1, CategoryId = 1, ProductName = "Acer-Laptop",QuantityPerUnit = "8 GB Ram", UnitPrice = 10000,UnitInstock = 5},
                new Product {ProductId = 2, CategoryId = 1, ProductName = "Asus-Laptop",QuantityPerUnit = "16 GB Ram", UnitPrice = 8000,UnitInstock = 2},
                new Product {ProductId = 3, CategoryId = 1, ProductName = "HP-Laptop",QuantityPerUnit = "32 GB Ram", UnitPrice = 12000,UnitInstock = 4},
                new Product {ProductId = 4, CategoryId = 2, ProductName = "Samsung-Phone",QuantityPerUnit = "4 GB Ram", UnitPrice = 2000,UnitInstock = 3},
                new Product {ProductId = 5, CategoryId = 2, ProductName = "Apple-Phone",QuantityPerUnit = "8 GB Ram", UnitPrice = 4000,UnitInstock = 0}
            };


            Console.WriteLine("Algoritmik --------------");
            foreach (var product in products)
            {
                if (product.UnitPrice > 5000 && product.UnitInstock > 2)
                {
                    Console.WriteLine(product.ProductName);
                }

            }

            Console.WriteLine("Linq --------------");
            var result = products.Where(p => p.UnitPrice > 5000 && p.UnitInstock > 2);

            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }

            Console.ReadLine();

            GetProducts(products);

        }

        // Algoritmik
        static List<Product> GetProducts(List<Product> products)
        {

            List<Product> filterProducts = new List<Product>();

            foreach (var product in products)
            {
                if (product.UnitPrice > 5000 && product.UnitInstock > 2)
                {
                    filterProducts.Add(product);
                }
            }
            return filterProducts;
        }

        // Linq
        static List<Product> GetProductsLinq(List<Product> products)
        {
            return products.Where(p => p.UnitPrice > 5000 && p.UnitInstock > 2).ToList();
        }

        class Product
        {

            public int ProductId { get; set; }
            public int CategoryId { get; set; }
            public string ProductName { get; set; }
            public string QuantityPerUnit { get; set; }
            public decimal UnitPrice { get; set; }
            public int UnitInstock { get; set; }

        }

        class Category
        {
            public int CategoryId { get; set; }
            public string CategoryName { get; set; }
        }

    }
}
