//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace challange2
//{
//    internal class Product
//    {
//        public int ID;
//        public string Name;
//        public int Price;
//        public string Catagory;
//        public string BrandName;
//        public string Country;
//        public Product(int id , string name, int price , string catagory , string brandname , string country)
//        {
//            ID = id;
//            Name = name;
//            Price = price;
//            Catagory = catagory;
//            BrandName = brandname;
//            Country = country;
//        }
//        public void Showproducts()
//        {
//            Console.WriteLine($"Product ID; {ID} , Product Name : {Name} , Product Price : {Price} , Catagory : {Catagory} , name of brand : {BrandName} , name of country : {Country}");
//        }
//    }
//}

using System;

namespace challange2
{
    internal class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Category { get; set; }
        public string BrandName { get; set; }
        public string Country { get; set; }

        public Product(int id, string name, int price, string category, string brandName, string country)
        {
            ID = id;
            Name = name;
            Price = price;
            Category = category;
            BrandName = brandName;
            Country = country;
        }

        public void ShowProducts()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Product ID: {ID}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Price: {Price:C}");
            Console.WriteLine($"Category: {Category}");
            Console.WriteLine($"Brand: {BrandName}");
            Console.WriteLine($"Country: {Country}");
            Console.WriteLine(new string('-', 30));
            Console.ResetColor();
        }
    }
}