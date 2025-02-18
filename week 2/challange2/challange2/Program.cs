using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challange2
{
    internal class Program
    {
        static List<Product> product = new List<Product>();
        static void Main(string[] args)
        {
            int option = Menu();
            while(option != 6)
            {
                switch(option)
                {
                    case 1:
                        Console.Clear();
                        Program.addproduct();
                        break;
                    case 2:
                        Console.Clear();
                        showproducts();
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        totalprice();
                        break;
                    case 4:
                        updateProduct();
                        break;
                    case 5:
                        DeleteProduct();
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
                option = Menu();
            }

        }
        static int Menu()
        {
            Console.Clear();
            Console.WriteLine("1.Add product.");
            Console.WriteLine("2.show product.");
            Console.WriteLine("3.total price of products.");
            Console.WriteLine("4.Update a product.");
            Console.WriteLine("5.Delete a product.");
            Console.WriteLine("6.Exit.");
            Console.WriteLine("Enter your option: ");
            int option = int.Parse(Console.ReadLine());
            return option;
        }
        static   void addproduct()
        {
            Console.WriteLine("Enter product ID; ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter name of the product: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter price of the product: ");
            int price = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Catagory of the product: ");
            string catagory =Console.ReadLine();
            Console.WriteLine("Enter the Brand name: ");
            string brandname = Console.ReadLine();
            Console.WriteLine("Enter the Country name: ");
            string country = Console.ReadLine();
            Product shop = new Product(id, name, price, catagory, brandname, country);
            product.Add(shop);
        }
        static void showproducts()
        {
            if(product.Count == 0 )
            {
                Console.WriteLine("No products found.");
            }
            foreach(Product shop in product)
            {
                shop.Showproducts();
            }
        }
        static void totalprice()
        {
            int total;
            if(product.Count == 0)
            {
                Console.WriteLine("No product found.");
            }
            double totalworth = 0;
            foreach(Product p in product)
            {
                totalworth += p.Price;
            }
            Console.WriteLine($"the total worthof the store is : {totalworth}");
            Console.ReadKey();
        }
        static void updateProduct()
        {
            Console.WriteLine("Enter the ID of the product :");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the new name of the product: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the new Price of the product:");
            int price = int.Parse(Console.ReadLine());
            if ( product.Count == 0 )
            {
                Console.WriteLine("No product found.");
            }
            else
            {
                foreach(Product update in product)
                {
                    if(update.ID == id)
                    {
                        update.Name = name;
                        update.Price = price;
                    }
                    else
                    {
                        Console.WriteLine("invcalid Id");
                        Console.WriteLine("No such products found.");
                    }
                }
            }

        }
        static void DeleteProduct()
        {
            Console.WriteLine("Enter the ID of the product: ");
            int id = int.Parse(Console.ReadLine());

            // Find the product with the given ID
            Product productToDelete = product.Find(p => p.ID == id);

            if (productToDelete != null)
            {
                // Remove the product from the list
                product.Remove(productToDelete);
                Console.WriteLine("Product deleted successfully.");
            }
            else
            {
                Console.WriteLine("Product with the given ID not found.");
            }
        }
    }
}
