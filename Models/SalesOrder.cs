using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace Retail_Management_System.Models
{
    public class SalesOrder
    {
        public int SalesID, TotalItems, CustomerID, CashierID;
        public float Total, TenderedAmount;
        public string Note, OrderDate;

        public SalesOrder(OleDbDataReader sales) {
            SalesID = (int)sales["SalesID"];
            TotalItems = (int)sales["TotalItems"];
            CustomerID = (int)sales["CustomerID"];
            CashierID = (int)sales["CashierID"];
            Total = float.Parse(sales["Total"].ToString());
            TenderedAmount = float.Parse(sales["TenderedAmount"].ToString());
            Note = sales["Note"].ToString();
            OrderDate = sales["OrderDate"].ToString();
        }
    }
}
