using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Retail_Management_System.DB;

namespace Retail_Management_System.Controls
{
    public partial class SalesBarChart : UserControl
    {
        private string _scope = "ALL";
        private dynamic _data;
        [Description("Scope of sales report: ALL, MONTHLY, THISMONTH"), Category("Data")]
        public string Scope
        {
            get => _scope;
            set => _scope = value;
        }
        public SalesBarChart()
        {
            InitializeComponent();
        }
        public void BuildChart()
        {
            chart1.Series.Add("Date");
            switch (_scope)
            {
                case "ALL": All(); break;
                case "MONTHLY": Monthly(); break;
                case "THISMONTH": Thismonth(); break;
            }
            if (_data != null)
            {
                if (_data["data"].HasRows)
                {
                    if (_scope != "THISMONTH")
                    {
                        while (_data["data"].Read())
                        {
                            chart1.Series["Date"].Points.AddXY(_data["data"]["Date"].ToString(), (float)_data["data"]["Amount"]);
                            Console.WriteLine("ADDING" + _scope);
                        }
                    } else
                    {
                        chart1.Visible = false;
                    }
                }
                _data["con"].Close();
            } else
            {
                Console.WriteLine(Connection.ErrorMessage);
            }
        }
        public void All()
        {
            Console.WriteLine("GETTING ALL");
            _data = Connection.Query(@"SELECT FORMAT([OrderDate], 'dd_yyyy_MM') as [Date], SUM([Total]) as [Amount]
FROM [SalesOrder] GROUP BY FORMAT([OrderDate], 'dd_yyyy_MM')", Connection.GetConnection());
        }
        public void Monthly()
        {
            Console.WriteLine("GETTING MONTHLY");
            _data = Connection.Query(@"SELECT FORMAT([OrderDate], 'yyyy_MM') as [Date], SUM(Total) as [Amount]
FROM [SalesOrder] GROUP BY FORMAT([OrderDate], 'yyyy_MM');", Connection.GetConnection());
        }
        public static dynamic Thismonth()
        {
            Console.WriteLine("GETTING THIS MONTH");
            string date = DateTime.Now.ToString("yyyy_MM");
            return Connection.Query($@"SELECT FORMAT([OrderDate], 'yyyy_MM') as [Date], SUM(Total) as [Amount]
FROM [SalesOrder] WHERE FORMAT([OrderDate], 'yyyy_MM') = '{date}' GROUP BY FORMAT([OrderDate], 'yyyy_MM');", Connection.GetConnection());
        }
        private void SalesBarChart_Load(object sender, EventArgs e)
        {
            BuildChart();
        }
    }
}
