using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Retail_Management_System.DB;
using System.Data.OleDb;
using Retail_Management_System.Models;

namespace Retail_Management_System.State
{
    class Products
    {
        public static List<Product> collection = new List<Product>();
        public static Product SelectedProduct;
        public static List<Product> Get()
        {
            if(Products.collection.Count <= 0)
            {
                var query = Connection.Query("SELECT * FROM Products", Connection.GetConnection(), null);
                if (query != null)
                {
                    while (query["data"].Read())
                    {
                        Product product = new Product(query["data"]);
                        product.Text = query["data"]["ProductName"].ToString();
                        product.Value = (int)query["data"]["ProductID"];
                        Products.collection.Add(product);
                    }
                    query["con"].Close();
                }
                else
                {
                    Console.WriteLine(Connection.ErrorMessage);
                    return null;
                }
            }
            return Products.collection;
        }
    }
}
