using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Retail_Management_System.State;
using Retail_Management_System.Models;

namespace Retail_Management_System.Controls
{
    public partial class CustomerComboBox : UserControl
    {
        public CustomerComboBox()
        {
            InitializeComponent();
        }
        public event EventHandler CustomerChanged;
        protected virtual void OnCustomerChanged(EventArgs e)
        {
            CustomerChanged?.Invoke(this, e);
        }
        private void CustomerComboBox_Load(object sender, EventArgs e)
        {
            try
            {
                comboBox1.DataSource = new BindingSource(Customers.collection, null);
                comboBox1.DisplayMember = "Text";
                comboBox1.ValueMember = "Value";
                comboBox1.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            comboBox1.DroppedDown = true;
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            User.SelectedUser = (User)(comboBox1.SelectedItem);
            OnCustomerChanged(EventArgs.Empty);
        }
        public void Reset()
        {
            comboBox1.SelectedIndex = -1;
        }
    }
}
