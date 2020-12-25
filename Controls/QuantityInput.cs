using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Retail_Management_System.Controls
{
    public partial class QuantityInput : UserControl
    {
        public int Quantity = 1;

        public event EventHandler QuantityChanged;
        protected virtual void OnQuantityChanged(EventArgs e)
        {
            QuantityChanged?.Invoke(this, e);
        }
        public QuantityInput()
        {
            InitializeComponent();
        }

        private void QuantityInput_Load(object sender, EventArgs e)
        {
        }

        private void product_quantity_ValueChanged(object sender, EventArgs e)
        {
            Quantity = (int)product_quantity.Value;
            OnQuantityChanged(EventArgs.Empty);
        }
        public void SetQuantity(int quantity)
        {
            Quantity = quantity;
            product_quantity.Value = quantity;
        }
    }
}
