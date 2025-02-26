using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab2;
using Mysqlx.Crud;

namespace messagingsystem.BL
{
    internal class Muser
    {
        public string name;
        public string password;

        public Muser()
        {
        }

        public Muser(string name,string password)
        {
            this.name = name;
            this.password = password;
        }
        public void adduser()
        {
            string query = $"INSERT INTO signup VALUES('{name}','{password}')";
            DatabaseHelper.Instance.Update(query);
        }

    }

}
