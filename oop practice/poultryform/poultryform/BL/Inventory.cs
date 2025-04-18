using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace poultryform.BL
{
    internal class Inventory
    {
        private int chicks;
        private int died_chicks;
        private int weight;
        //private const int total_chicks = 10;
        private DateTime date;
        private int price;
        public Inventory(int chicks, int died_chicks, int weight, DateTime date, int price)
        {
            this.chicks = chicks;
            this.died_chicks = died_chicks;
            this.weight = weight;
            this.date = date;
            this.price = price;
        }
        public Inventory() 
        {
        
        }
        public Inventory(int weight,DateTime date,int price)
        {
            this.weight = weight;
            this.date = date;
            this.price = price;
        }
        public int getChicks()
        {
            return chicks;
        }
        public void setchicks(int chicks)
        {
            this.chicks = chicks;
        }

        public int getprice()
        {
            return price;
        }
        public void setprice(int price)
        {
            this.price = price;
        }
        public int getdiedchicks()
        {
            return died_chicks;
        }
        public void setdiedchicks(int died_chicks)
        {
            this.died_chicks = died_chicks;
        }
        public int getweight()
        {
            return weight;
        }
        public void setweight(int weight)
        {
            this.weight = weight;
        }
        public void setdate(DateTime date)
        {
            this.date = date;
        }
        public DateTime GetDate()
        {
            return date;
        }
        public int totalchicks()
        {
            int total_chicks = (chicks - died_chicks);
            return total_chicks;
        }
        public  int gettotal()
        {
            int total;
            total = weight * price;
            return total;
        }
    }
}
