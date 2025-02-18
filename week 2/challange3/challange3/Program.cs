using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using challange2;

namespace challange3
{
    internal class Program
    {
        static List<Product> product = new List<Product>();
        static List<Page> array = new List<Page>();
        static void Main(string[] args)
        {
            string act ="";
            int option = Menu();
            while (option != 3)
            {
                switch (option)
                {
                    case 1:
                        signup();
                        break;
                    case 2:
                        Console.WriteLine("Enter your name: ");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter your password: ");
                        string password = Console.ReadLine();
                        if (array.Count == 0)
                        {
                            Console.WriteLine("No user registered found");
                        }
                        foreach (Page page in array)
                        {
                            if((page.Username == name) && (page.Password == password))
                            {
                                Console.WriteLine($"{name} have signed in as {page.Role}");
                                 act = page.Role;
                            }
                            else
                            {
                                Console.WriteLine("Invalid credentials entered ");
                                Console.WriteLine("Please sign up first.");
                            }
                        }
                        if(act == "admin")
                        {
                            Console.WriteLine("admin menu");
                            int login = menu();
                            while(login != 6)
                            {
                                switch(login)
                                {
                                    case 1:
                                        addproduct();
                                        break;
                                    case 2:
                                        showproducts();
                                        Console.ReadLine();
                                            break;
                                    case 3:
                                        totalprice();
                                        break;
                                    case 4:
                                        updateProduct();
                                        break;
                                    case 5:
                                        DeleteProduct();
                                        break;
                                }
                                login = menu();
                            }
                        }
                        else if(act == "user")
                        {
                            Console.WriteLine("user");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Exiting the program.");
                        break;
                    default:
                        Console.WriteLine("Invalid option entered.");
                        break;
                }
                option = Menu();
            }
        }
        public static int Menu()
        {
            Console.WriteLine("1.Sign up");
            Console.WriteLine("2.Sign in");
            Console.WriteLine("3.Exit.");
            Console.WriteLine("Enter your option: ");
            int option = int.Parse(Console.ReadLine());
            return option;
        }
        public static void signup()
        {
            string name,password,role;
            Console.WriteLine("Enter your name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter the password: ");
            password = (Console.ReadLine());
            Console.WriteLine("Enter your role: ");
            role = Console.ReadLine();
            Page user = new Page(name, password, role);
            array.Add(user);
        }
        public static void signin()
        {
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your password: ");
            string password = Console.ReadLine();
            
        }
        static int menu()
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
        
        static void addproduct()
        {
            Console.WriteLine("Enter product ID; ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter name of the product: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter price of the product: ");
            int price = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Catagory of the product: ");
            string catagory = Console.ReadLine();
            Console.WriteLine("Enter the Brand name: ");
            string brandname = Console.ReadLine();
            Console.WriteLine("Enter the Country name: ");
            string country = Console.ReadLine();
            Product shop = new Product(id, name, price, catagory, brandname, country);
            product.Add(shop);
        }
        static void showproducts()
        {
            if (product.Count == 0)
            {
                Console.WriteLine("No products found.");
            }
            foreach (Product shop in product)
            {
                shop.Showproducts();
            }
        }
        static void totalprice()
        {
            int total;
            if (product.Count == 0)
            {
                Console.WriteLine("No product found.");
            }
            double totalworth = 0;
            foreach (Product p in product)
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
            if (product.Count == 0)
            {
                Console.WriteLine("No product found.");
            }
            else
            {
                foreach (Product update in product)
                {
                    if (update.ID == id)
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
    class Page
    {   
        public string Username;
        public string Password;
        public string Role;

 

        public Page(string name , string password , string role)
        {
            Username = name;
            Password = password;
            Role = role;
        }
    }
}
