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
    public partial class ProductComboBox : UserControl
    {

        public ProductComboBox()
        {
            InitializeComponent();
        }

        public event EventHandler ProductChanged;
        protected virtual void OnProductChanged(EventArgs e)
        {
            ProductChanged?.Invoke(this, e);
        }
        private void ProductComboBox_Load(object sender, EventArgs e)
        {
            try
            {
                comboBox2.DataSource = new BindingSource(Products.collection, null);
                comboBox2.DisplayMember = "Text";
                comboBox2.ValueMember = "Value";
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }

        private void comboBox2_KeyDown(object sender, KeyEventArgs e)
        {
            comboBox2.DroppedDown = true;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Products.SelectedProduct = (Product)(comboBox2.SelectedItem);
            OnProductChanged(EventArgs.Empty);
        }

    }
}
