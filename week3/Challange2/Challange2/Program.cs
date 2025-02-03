using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challange2
{
    internal class Program
    {
        static List<Product> shop = new List<Product>();
        static void Main(string[] args)
        {
            int option = Menu();
            while (option != 6)
            {
                switch (option)
                {
                    case 1:
                        addproduct();
                        break;
                    case 2:
                        Showproduct();
                        break;
                    case 3:
                        highestprice();
                        break;
                    case 4:
                        salestax();
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
                option = Menu();
            }
        }
        static public int Menu()
        {
            Console.Clear();
            Console.WriteLine("1.Add product");
            Console.WriteLine("2.View all products");
            Console.WriteLine("3.Find Product with the Highest Unit Price");
            Console.WriteLine("4.View Sales Tax of All Products.");
            Console.WriteLine("5.Products to be Ordered. (less than the threshold)");
            Console.WriteLine("Enter your option: ");
            int option = int.Parse(Console.ReadLine());
            return option;
        }
        static void addproduct()
        {
            Console.WriteLine("1.Enter name of the product.");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the catagory of the product.");
            string catagory = Console.ReadLine();
            Console.WriteLine("Enter the price of the product.");
            int price = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the stock.");
            int stock = int.Parse(Console.ReadLine());
            Product product = new Product(name, catagory, price, stock);
            shop.Add(product);
        }
        static void Showproduct()
        {
            if (shop.Count == 0)
            {
                Console.WriteLine("No Products found.");
            }
            else
            {
                foreach (Product p in shop)
                {
                    p.showProducts();
                }
            }
        }
        static void highestprice()
        {
            var highprice = new List<Product>(shop);
            highprice.Sort((s1, s2) => s2.Price.CompareTo(s1.Price));
            var highestprice = highprice[0];
            Console.WriteLine(highestprice.Price);
        }
        static void salestax()
        {
            if (shop.Count == 0)
            {
                Console.WriteLine("No products found.");
            }
            else
            {
                foreach (Product p in shop)
                {
                    Console.WriteLine($"name : {p.Name}, tax: {p.tax}");
                }
            }
        }
    }
}