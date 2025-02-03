using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Challange2
{
    internal class Product
    {
        public string Name;
        public string Category;
        public int Price;
        public int Stock;
        public float tax;
        
        public Product(string name , string catagory, int price , int stock)
        {
            Name = name;
            Category = catagory;
            Price = price;
            Stock = stock;
            Calculatetax();
        }
        public void showProducts()
        {
            Console.WriteLine($"Name : {Name}, Catagory : {Category} , Price : {Price} , stock : {Stock}");
        }
        public void Calculatetax()
        {
            if(Category == "Groceries")
            {
                tax = (Price / 100) * 10;
            }
            else if (Category == "fruit")
            {
                tax = (Price / 100) * 5;
            }
            else
            {
                tax = (Price / 100) * 15;
            }
        }
    }
}
