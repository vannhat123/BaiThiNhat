using System;
using System.Collections.Generic;

namespace ExamPaperNhat
{
      class Program
    {
        private static List<Product> listProducts = new List<Product>();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("==========Product Manage==========");
                Console.WriteLine("1. Add product");
                Console.WriteLine("2. Display product records");
                Console.WriteLine("3. Delete product by Id");
                Console.WriteLine("4. Exit");
                var choice = Int32.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        AddProduct();
                        break;
                    case 2:
                        DisplayProduct();
                        break;
                    case 3:
                        DeleteProduct();
                        break;
                    case 4:
                        Environment.Exit(1);
                        break;
                }
            }
        }
        
        // Nhập và add Product vào list
        public static void AddProduct()
        {
            Console.WriteLine("-----------Add----------------");
            Console.Write("Enter the product Id: ");
            var productId = Console.ReadLine();
            Console.Write("Enter the product Name:");
            var productName = Console.ReadLine();
            Console.Write("Enter the product Price:");
            var productPrice = Double.Parse(Console.ReadLine());
            Product product = new Product(productName, productId, productPrice);
            listProducts.Add(product);
            Console.WriteLine("Succes!!");
        }
        
        // Hiển thị list Product Managae
        public static void DisplayProduct()
        {
            Console.WriteLine("--------------Display-----------------");
            Console.WriteLine("{0,-17} {1,-13} {2,-5}", "Product ID", "Product Name", "Price");
            if (listProducts.Count > 0)
            {
                foreach (var product in listProducts)
                {
                    Console.WriteLine("{0,-17} {1,-13} {2,-5}", product.ProductId, product.ProductName,
                        "$" + product.Price);
                }
            }
            else
            {
                Console.WriteLine("No product added !!");
            }
        }
    
        // xóa 1 product theo ID
        public static void DeleteProduct()
        {
            Console.WriteLine("============Product Manage===============");
            Console.Write("Please enter the product Id to delete: ");
            var idDelete = Console.ReadLine();
            int count = 0;
            for (int i = 0; i < listProducts.Count; i++)
            {
                if (listProducts[i].ProductId == idDelete)
                {
                    listProducts.RemoveAt(i);
                    Console.WriteLine("Delete Success");
                    break;
                }
                count++;
            }

            if (count == listProducts.Count)
            {
                Console.WriteLine("There is no product id : " + idDelete);
            }
            
            
            
        }
    }
}