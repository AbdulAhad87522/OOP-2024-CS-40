using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challange2
{
    internal class Product
    {
        public int ID;
        public string Name;
        public int Price;
        public string Catagory;
        public string BrandName;
        public string Country;
        public Product(int id , string name, int price , string catagory , string brandname , string country)
        {
            ID = id;
            Name = name;
            Price = price;
            Catagory = catagory;
            BrandName = brandname;
            Country = country;
        }
        public void Showproducts()
        {
            Console.WriteLine($"Product ID; {ID} , Product Name : {Name} , Product Price : {Price} , Catagory : {Catagory} , name of brand : {BrandName} , name of country : {Country}");
        }
    }
}
