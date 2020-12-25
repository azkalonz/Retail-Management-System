using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using Theme = Retail_Management_System.Theme;
using Retail_Management_System.Models;
using Retail_Management_System.DB;

namespace Retail_Management_System.Screens
{
    public partial class CustomerPurchases : MaterialForm
    {
        public CustomerPurchases()
        {
            InitializeComponent();
            Theme.MaterialSkin.ApplyTheme(this);
            guna2DataGridView1.ColumnHeadersHeight = 40;
        }

        private void CustomerPurchases_Load(object sender, EventArgs e)
        {
            customer_name.Text = User.SelectedUser.Name;
            user_id.Text = User.SelectedUser.UserID.ToString();
            if (User.SelectedUser.SalesOrders.Count <= 0)
            {
                string command = "SELECT * FROM SalesOrder WHERE [CustomerID] = " + User.SelectedUser.UserID;
                var SalesOrders = Connection.Query(command, Connection.GetConnection());
                if(User.SelectedUser.SalesOrders!=null)
                    Console.WriteLine("Before "+User.SelectedUser.SalesOrders.Count);
                if (SalesOrders != null) {
                    if (SalesOrders["data"].HasRows)
                    {
                        while (SalesOrders["data"].Read())
                        {
                            User.SelectedUser.SalesOrders.Add(new SalesOrder(SalesOrders["data"]));
                        }
                    }
                    SalesOrders["con"].Close();
                }
            }
            if (User.SelectedUser.SalesOrders != null)
            {

                Console.WriteLine("after " + User.SelectedUser.SalesOrders.Count);
                DataTable dt = BuildSalesTable(User.SelectedUser.SalesOrders);
                guna2DataGridView1.DataSource = dt;
            }
        }
        public DataTable BuildSalesTable(List<SalesOrder> sales)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Sales ID");
            dt.Columns.Add("Items");
            dt.Columns.Add("Total");
            dt.Columns.Add("Order Date");
            dt.Columns.Add("Note");
            dt.Columns.Add("Tendered Amount");
            dt.Columns.Add("Change");
            foreach (SalesOrder order in sales)
            {
                DataRow row = dt.NewRow();
                row["Sales ID"] = order.SalesID;
                row["Items"] = order.TotalItems;
                row["Total"] = order.Total;
                row["Order Date"] = order.OrderDate;
                row["Note"] = order.Note;
                row["Tendered Amount"] = order.TenderedAmount;
                row["Change"] = order.TenderedAmount - order.Total;
                dt.Rows.Add(row);
            }
            return dt;
        }
    }
}
