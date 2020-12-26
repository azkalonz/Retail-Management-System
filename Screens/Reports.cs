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
using Retail_Management_System.DB;

namespace Retail_Management_System.Screens
{
    public partial class Reports : MaterialForm
    {
        public Reports()
        {
            InitializeComponent();
            Theme.MaterialSkin.ApplyTheme(this);
            guna2DataGridView1.ColumnHeadersHeight = 40;
            BuildSalesTable();
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            var query = Connection.Query("SELECT SUM([TotalItems]) as Total FROM [SalesOrder]", Connection.GetConnection());
            if (query != null)
            {
                if (query["data"].Read())
                {
                    items_sold.Text = query["data"]["Total"].ToString()+" pcs";
                }
            query["con"].Close();
            }
            query = Connection.Query("SELECT SUM([Total]) as Total FROM [SalesOrder]", Connection.GetConnection());
            if (query != null)
            {
                if (query["data"].Read())
                {
                    gross_sales.Text = "PHP "+query["data"]["Total"].ToString("N2");
                }
            query["con"].Close();
            }
            query = Connection.Query(@"SELECT 
[Sales].Subtotal - ([Products].Cost * [Sales].Quantity) as [Total]
FROM [SalesOrderDetail] as [Sales]
INNER JOIN [Products]
ON [Products].ProductID = [Sales].ProductID;", Connection.GetConnection());
            if (query != null)
            {
                float gross = 0;
                while (query["data"].Read())
                {
                    gross += (float)query["data"]["Total"];
                    sales.Text = "PHP " + gross.ToString("N2");
                }
            query["con"].Close();
            }
        }
        public void BuildSalesTable()
        {
            var query = Connection.Query("SELECT * FROM [SalesOrder]", Connection.GetConnection());
            if (query != null)
            {
                if (query["data"].HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Columns.Add("Sales ID");
                    dt.Columns.Add("Items");
                    dt.Columns.Add("Total");
                    dt.Columns.Add("Order Date");
                    dt.Columns.Add("Note");
                    dt.Columns.Add("Tendered Amount");
                    dt.Columns.Add("Change");
                    while (query["data"].Read())
                    {
                        DataRow row = dt.NewRow();
                        float total, tendered, change;
                        total = (float)query["data"]["Total"];
                        tendered = (float)query["data"]["TenderedAmount"];
                        change = tendered - total;
                        row["Sales ID"] = query["data"]["SalesID"].ToString();
                        row["Items"] = query["data"]["TotalItems"].ToString();
                        row["Total"] = total.ToString("N2");
                        row["Order Date"] = query["data"]["OrderDate"].ToString();
                        row["Note"] = query["data"]["Note"].ToString();
                        row["Tendered Amount"] = tendered.ToString("N2");
                        row["Change"] = change.ToString("N2");
                        dt.Rows.Add(row);
                    }
                    guna2DataGridView1.DataSource = dt;
                }
            query["con"].Close();
            }
        }
    }
}
