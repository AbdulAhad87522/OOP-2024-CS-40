//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace challange2
//{
//    internal class Program
//    {
//        static List<Product> product = new List<Product>();
//        static void Main(string[] args)
//        {
//            int option = Menu();
//            while(option != 6)
//            {
//                switch(option)
//                {
//                    case 1:
//                        Console.Clear();
//                        Program.addproduct();
//                        break;
//                    case 2:
//                        Console.Clear();
//                        showproducts();
//                        Console.ReadKey();
//                        break;
//                    case 3:
//                        Console.Clear();
//                        totalprice();
//                        break;
//                    case 4:
//                        updateProduct();
//                        break;
//                    case 5:
//                        DeleteProduct();
//                        break;
//                    default:
//                        Console.WriteLine("Invalid input");
//                        break;
//                }
//                option = Menu();
//            }

//        }
//        static int Menu()
//        {
//            Console.Clear();
//            Console.WriteLine("1.Add product.");
//            Console.WriteLine("2.show product.");
//            Console.WriteLine("3.total price of products.");
//            Console.WriteLine("4.Update a product.");
//            Console.WriteLine("5.Delete a product.");
//            Console.WriteLine("6.Exit.");
//            Console.WriteLine("Enter your option: ");
//            int option = int.Parse(Console.ReadLine());
//            return option;
//        }
//        static   void addproduct()
//        {
//            Console.WriteLine("Enter product ID; ");
//            int id = int.Parse(Console.ReadLine());
//            Console.WriteLine("Enter name of the product: ");
//            string name = Console.ReadLine();
//            Console.WriteLine("Enter price of the product: ");
//            int price = int.Parse(Console.ReadLine());
//            Console.WriteLine("Enter Catagory of the product: ");
//            string catagory =Console.ReadLine();
//            Console.WriteLine("Enter the Brand name: ");
//            string brandname = Console.ReadLine();
//            Console.WriteLine("Enter the Country name: ");
//            string country = Console.ReadLine();
//            Product shop = new Product(id, name, price, catagory, brandname, country);
//            product.Add(shop);
//        }
//        static void showproducts()
//        {
//            if(product.Count == 0 )
//            {
//                Console.WriteLine("No products found.");
//            }
//            foreach(Product shop in product)
//            {
//                shop.Showproducts();
//            }
//        }
//        static void totalprice()
//        {
//            int total;
//            if(product.Count == 0)
//            {
//                Console.WriteLine("No product found.");
//            }
//            double totalworth = 0;
//            foreach(Product p in product)
//            {
//                totalworth += p.Price;
//            }
//            Console.WriteLine($"the total worthof the store is : {totalworth}");
//            Console.ReadKey();
//        }
//        static void updateProduct()
//        {
//            Console.WriteLine("Enter the ID of the product :");
//            int id = int.Parse(Console.ReadLine());
//            Console.WriteLine("Enter the new name of the product: ");
//            string name = Console.ReadLine();
//            Console.WriteLine("Enter the new Price of the product:");
//            int price = int.Parse(Console.ReadLine());
//            if ( product.Count == 0 )
//            {
//                Console.WriteLine("No product found.");
//            }
//            else
//            {
//                foreach(Product update in product)
//                {
//                    if(update.ID == id)
//                    {
//                        update.Name = name;
//                        update.Price = price;
//                    }
//                    else
//                    {
//                        Console.WriteLine("invcalid Id");
//                        Console.WriteLine("No such products found.");
//                    }
//                }
//            }

//        }
//        static void DeleteProduct()
//        {
//            Console.WriteLine("Enter the ID of the product: ");
//            int id = int.Parse(Console.ReadLine());

//            // Find the product with the given ID
//            Product productToDelete = product.Find(p => p.ID == id);

//            if (productToDelete != null)
//            {
//                // Remove the product from the list
//                product.Remove(productToDelete);
//                Console.WriteLine("Product deleted successfully.");
//            }
//            else
//            {
//                Console.WriteLine("Product with the given ID not found.");
//            }
//        }
//    }
//}


using System;
using System.Collections.Generic;
using ProductManagement;

namespace challange2
{
    internal class Program
    {
        static List<Product> products = new List<Product>();

        static void Main(string[] args)
        {
            int option;
            do
            {
                option = Menu();
                switch (option)
                {
                    case 1:
                        Console.Clear();
                        AddProduct();
                        break;
                    case 2:
                        Console.Clear();
                        ShowProducts();
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        TotalPrice();
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        UpdateProduct();
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.Clear();
                        DeleteProduct();
                        Console.ReadKey();
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine("Exiting the application...");
                        break;
                    default:
                        Console.WriteLine("Invalid input. Please try again.");
                        Console.ReadKey();
                        break;
                }
            } while (option != 6);
        }

        static int Menu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("===================");
            Console.WriteLine("  Product Manager  ");
            Console.WriteLine("===================");
            Console.ResetColor();
            Console.WriteLine("1. Add Product");
            Console.WriteLine("2. Show Products");
            Console.WriteLine("3. Total Price of Products");
            Console.WriteLine("4. Update a Product");
            Console.WriteLine("5. Delete a Product");
            Console.WriteLine("6. Exit");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Enter your option: ");
            Console.ResetColor();
            int option;
            while (!int.TryParse(Console.ReadLine(), out option)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid input. Please enter a number.");
                Console.ResetColor();
                Console.Write("Enter your option: ");
            }
            return option;
        }

        static void AddProduct()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("=== Add Product ===");
            Console.ResetColor();
            Console.Write("Enter Product ID: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Enter Name of the Product: ");
            string name = Console.ReadLine();
            Console.Write("Enter Price of the Product: ");
            int price = int.Parse(Console.ReadLine());
            Console.Write("Enter Category of the Product: ");
            string category = Console.ReadLine();
            Console.Write("Enter the Brand Name: ");
            string brandName = Console.ReadLine();
            Console.Write("Enter the Country Name: ");
            string country = Console.ReadLine();

            Product product = new Product(id, name, price, category, brandName, country);
            products.Add(product);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Product added successfully!");
            Console.ResetColor();
            Console.ReadKey();
        }

        static void ShowProducts()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("=== Product List ===");
            Console.ResetColor();
            if (products.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("No products found.");
                Console.ResetColor();
                return;
            }
            foreach (Product product in products)
            {
                product.ShowProducts();
            }
        }

        static void TotalPrice()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("=== Total Price ===");
            Console.ResetColor();
            if (products.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("No products found.");
                Console.ResetColor();
                return;
            }
            double totalWorth = 0;
            foreach (Product p in products)
            {
                totalWorth += p.Price;
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"The total worth of the store is: {totalWorth:C}");
            Console.ResetColor();
        }

        static void UpdateProduct()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("=== Update Product ===");
            Console.ResetColor();
            Console.Write("Enter the ID of the product: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Enter the new Name of the product: ");
            string name = Console.ReadLine();
            Console.Write("Enter the new Price of the product: ");
            int price = int.Parse(Console.ReadLine());

            Product productToUpdate = products.Find(p => p.ID == id);
            if (productToUpdate != null)
            {
                productToUpdate.Name = name;
                productToUpdate.Price = price;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Product updated successfully!");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Product with the given ID not found.");
                Console.ResetColor();
            }
        }

        static void DeleteProduct()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("=== Delete Product ===");
            Console.ResetColor();
            Console.Write("Enter the ID of the product: ");
            int id = int.Parse(Console.ReadLine());

            Product productToDelete = products.Find(p => p.ID == id);
            if (productToDelete != null)
            {
                products.Remove(productToDelete);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Product deleted successfully!");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Product with the given ID not found.");
                Console.ResetColor();
            }
        }
    }
}