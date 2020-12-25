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
using Retail_Management_System.State;
using MaterialSkin.Controls;
using Retail_Management_System.DB;
using System.Data.OleDb;
using Theme = Retail_Management_System.Theme;

namespace Retail_Management_System.Screens
{
    public partial class Dashboard : MaterialForm
    {
        public List<Action> actions = new List<Action>();
        private bool isFullScreen = true;
        private string Note = "";
        public Dashboard(User user)
        {
            InitializeComponent();
            Theme.MaterialSkin.ApplyTheme(this);
            dashboardMenu2.actions = actions;
            Products.Get();
            Customers.Get();
        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            actions[0]();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            guna2DataGridView1.ColumnHeadersHeight = 40;
            guna2DataGridView1.ColumnCount = 5;
            guna2DataGridView1.Columns[0].HeaderText = "Description";
            guna2DataGridView1.Columns[1].HeaderText = "Price";
            guna2DataGridView1.Columns[2].HeaderText = "Quantity";
            guna2DataGridView1.Columns[3].HeaderText = "Subtotal";
            guna2DataGridView1.Columns[4].HeaderText = "CartID";
            guna2DataGridView1.Columns[4].Visible = false;
            EnableCustomerButtons(false);
        }
        public void EnableCustomerButtons(bool status)
        {
            guna2Button2.Enabled = status;
            guna2CircleButton1.Enabled = status;
        }

        private void GoFullscreen(bool fullscreen)
        {
            if (fullscreen)
            {
                this.WindowState = FormWindowState.Normal;
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                this.Bounds = Screen.PrimaryScreen.Bounds;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            }
            this.isFullScreen = !this.isFullScreen;
        }

        private void fullscreen_icon_Click(object sender, EventArgs e)
        {
            this.GoFullscreen(isFullScreen);
        }

        private void productComboBox1_ProductChanged_1(object sender, EventArgs e)
        {
            ResetProducts();
        }
        public void ResetProducts()
        {
            quantityInput2.SetQuantity(1);
            product_name.Text = Products.SelectedProduct.ProductName;
            inventory_quantity.Text = Products.SelectedProduct.Quantity.ToString();
            product_price.Text = "PHP " + Products.SelectedProduct.Price.ToString("N2");
        }

        private void quantityInput1_QuantityChanged(object sender, EventArgs e)
        {
            Console.WriteLine(quantityInput2.Quantity);
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            if (Products.SelectedProduct != null)
            {
                if(Products.SelectedProduct.Quantity >= quantityInput2.Quantity)
                {
                    var ProductName = Products.SelectedProduct.ProductName;
                    var Price = Products.SelectedProduct.Price;
                    var Quantity = quantityInput2.Quantity;
                    float total = Quantity * Price;

                    var cartId = Cart.AddToCart((Product)Products.SelectedProduct.Clone(), Quantity);
                    guna2DataGridView1.Rows.Add(ProductName, Price, Quantity, total, cartId);
                    cart_total.Text = "PHP " + Cart.Total.ToString("N2");
                } else
                {
                    MessageBox.Show("Insufficient quantity");
                }
            }
        }
        private void guna2DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            var index = guna2DataGridView1.CurrentRow?.Index;
            if (index != null)
            {
                DataGridViewRow row = guna2DataGridView1.Rows[(int)index];
                Product product = Cart.list.Find(item => item.CartID == (int)row.Cells[4].Value);
                if (product != null)
                {
                    product_name.Text = product.ProductName;
                    product_price.Text = "PHP " + product.Price.ToString("N2");
                    quantityInput2.SetQuantity(product.CartQuantity);
                }
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            var index = guna2DataGridView1.CurrentRow?.Index;
            DataGridViewRow row = null;
            if (index!=null)
            {
                 row = guna2DataGridView1.Rows[(int)index];
            } else if(guna2DataGridView1.Rows.Count>=1)
            {
                 row = guna2DataGridView1.Rows[0];
            }
            if (row != null)
            {
                Product product = null;
                product = Cart.list.Find(item => item.CartID == (int)row.Cells[4].Value);
                if (product != null)
                {
                    Cart.RemoveToCart(product);
                    quantityInput2.SetQuantity(1);
                    guna2DataGridView1.Rows.Remove(row);
                    cart_total.Text = "PHP "+ Cart.Total.ToString("N2");
                }
            }
        }
        public void SetTenderedAmount(float amount)
        {
            int customerID = -1;
            if (User.SelectedUser != null)
            {
                customerID = User.SelectedUser.UserID;
            }
            string command = "INSERT INTO SalesOrder([TotalItems], [Total], [OrderDate], [CashierID], [TenderedAmount], [Note], [CustomerID]) VALUES (@items,@total,@date,@cashier,@amount,@note,@customer)";
            OleDbParameter[] parameters = new OleDbParameter[]
            {
                new OleDbParameter("@items", Cart.TotalItems),
                new OleDbParameter("@total", Cart.Total),
                new OleDbParameter("@date", DateTime.Now.ToString()),
                new OleDbParameter("@cashier", User.CurrentUser.UserID),
                new OleDbParameter("@amount", amount),
                new OleDbParameter("@note", Note),
                new OleDbParameter("@customer", customerID),
            };
            Connection.NonQuery(command,parameters);
            command = "SELECT * FROM SalesOrder ORDER BY SalesID DESC";
            var salesOrder = Connection.Query(command, Connection.GetConnection());
            if (salesOrder != null)
            {
                if (salesOrder["data"].HasRows && salesOrder["data"].Read())
                {
                    int id = (int)salesOrder["data"]["SalesID"];
                    foreach(Product product in Cart.list)
                    {
                        Product productRef = Products.collection.Find(item => item.ProductID == product.ProductID);
                        if (productRef != null)
                        {
                            productRef.Quantity -= product.CartQuantity;
                            ResetProducts();
                            command = "UPDATE Products SET [Quantity] = @quantity WHERE [ProductID] = @product";
                            parameters = new OleDbParameter[]
                            {
                                new OleDbParameter("@quantity", productRef.Quantity),
                                new OleDbParameter("@product", productRef.ProductID),
                            };
                            Connection.NonQuery(command, parameters);
                        }
                        float subtotal = product.CartQuantity * product.Price;
                        command = "INSERT INTO SalesOrderDetail([SalesID], [ProductID], [Quantity], [SubTotal]) VALUES (@id,@product,@quantity,@subtotal)";
                        parameters = new OleDbParameter[]
                        {
                            new OleDbParameter("@id", id),
                            new OleDbParameter("@product", product.ProductID),
                            new OleDbParameter("@quantity", product.CartQuantity),
                            new OleDbParameter("@subtotal", subtotal),
                        };
                        Connection.NonQuery(command, parameters);
                    }
                }
                salesOrder["con"].Close();
                Cart.Checkout(()=>
                {
                    cart_total.Text = "PHP 0.00";
                    guna2DataGridView1.Rows.Clear();
                });
            }
        }
        private void guna2Button5_Click(object sender, EventArgs e)
        {
            TenderedAmount form = new TenderedAmount();
            form.parent = this;
            form.ShowDialog();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Locked form = new Locked();
            form.ShowDialog();
        }
        public void SetNote(string note)
        {
            this.Note = note;
        }
        private void guna2Button7_Click(object sender, EventArgs e)
        {
            Note form = new Note();
            form.parent = this;
            form.ShowDialog();
        }
        private void currentCustomer1_CustomerChanged(object sender, EventArgs e)
        {
            if (User.SelectedUser != null)
            {
                EnableCustomerButtons(true);
            }
        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            CustomerPurchases form = new CustomerPurchases();
            form.Show();
        }

        private void guna2CircleButton1_Click_1(object sender, EventArgs e)
        {
            currentCustomer1.Reset();
            EnableCustomerButtons(false);
        }
    }
}
