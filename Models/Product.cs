using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace Retail_Management_System.Models
{
    public class Product : ICloneable
    {
        public string Text { get; set; }
        public int Value { get; set; }
        public string ProductName;
        public float Price, Cost;
        public int Quantity, ProductID;
        public int CartQuantity,CartID;

        public Product(OleDbDataReader product)
        {
            ProductName = product["ProductName"].ToString();
            Price = float.Parse(product["Price"].ToString());
            Quantity = int.Parse(product["Quantity"].ToString());
            Cost = float.Parse(product["Cost"].ToString());
            ProductID = (int)product["ProductID"];
        }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
