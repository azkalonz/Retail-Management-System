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

namespace Retail_Management_System.Screens
{
    public partial class CustomerPurchases : MaterialForm
    {
        public CustomerPurchases()
        {
            InitializeComponent();
            Theme.MaterialSkin.ApplyTheme(this);
        }

        private void CustomerPurchases_Load(object sender, EventArgs e)
        {
            customer_name.Text = User.SelectedUser.Name;
        }
    }
}
