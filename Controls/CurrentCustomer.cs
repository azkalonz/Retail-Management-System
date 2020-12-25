using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Retail_Management_System.Models;

namespace Retail_Management_System.Controls
{
    public partial class CurrentCustomer : UserControl
    {
        public CurrentCustomer()
        {
            InitializeComponent();
        }
        public event EventHandler CustomerChanged;
        protected virtual void OnCustomerChanged(EventArgs e)
        {
            CustomerChanged?.Invoke(this, e);
        }
        private void customerComboBox1_CustomerChanged(object sender, EventArgs e)
        {
            try
            {
                if (User.SelectedUser != null)
                {
                    user_name.Text = User.SelectedUser.Name;
                    user_id.Text = User.SelectedUser.UserID.ToString();
                    OnCustomerChanged(EventArgs.Empty);
                }
            } catch(Exception ex)
            {

            }
        }
        public void Reset()
        {
            user_name.Text = "Select a customer";
            user_id.Text = "0";
            customerComboBox1.Reset();
        }
        private void CurrentCustomer_Load(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
