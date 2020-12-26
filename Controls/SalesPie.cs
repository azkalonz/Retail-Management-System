using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Wpf;
using Retail_Management_System.DB;

namespace Retail_Management_System.Controls
{
    public partial class SalesPie : UserControl
    {
        public SalesPie()
        {
            InitializeComponent();
            PopulateChart();
        }
        public void PopulateChart()
        {
            var sales = Connection.Query(@"SELECT TOP 5 Count(Sales.ProductID) AS total_count, Products.ProductName,      Sales.ProductID, Products.ProductName FROM SalesOrderDetail AS Sales INNER JOIN Products ON Sales.ProductID = Products.ProductID
              GROUP BY Sales.ProductID, Products.ProductName;",Connection.GetConnection());
            if (sales == null)
            {
                return;
            }
            if (sales["data"].HasRows)
            {
                Func<ChartPoint, string> labelPoint = chartPoint => string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);
                while (sales["data"].Read())
                {
                    pieChart1.Series.Add(new PieSeries
                    {
                        Title = sales["data"]["ProductName"],
                        Values = new ChartValues<double> { (double)sales["data"]["total_count"] },
                        PushOut = 2,
                        DataLabels = true,
                        LabelPoint = labelPoint
                    });
                }
            }
            sales["con"].Close();

            pieChart1.LegendLocation = LegendLocation.Right;
        }
    }
}
