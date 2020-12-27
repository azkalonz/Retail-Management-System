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
using Retail_Management_System.Screens;

namespace Retail_Management_System.Controls
{
    public partial class DashboardMenu : UserControl
    {
        private bool isMenuOpen = false;
        public List<Action> actions = new List<Action>();
        public DashboardMenu()
        {
            InitializeComponent();
        }
        private void DashboardMenu_Load_1(object sender, EventArgs e)
        {
            if(User.CurrentUser.UserType != "admin")
            {
                reportsbtn.Visible = false;
                users.Visible = false;
            }
            try
            {
                user_dropdown.Height = 0;
                name.Text = User.CurrentUser.Name;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            user_dropdown.Height += isMenuOpen ? 5: -5;
            if(user_dropdown.Height >= 45 || user_dropdown.Height <= 0)
            {
                timer1.Stop();
            }
            Console.WriteLine(user_dropdown.Height);
        }

        private void logout_button_Click(object sender, EventArgs e)
        {

            User.CurrentUser = null;
            actions[1]();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            isMenuOpen = !isMenuOpen;
            timer1.Start();
        }

        private void name_Click(object sender, EventArgs e)
        {

        }

        private void reportsbtn_Click(object sender, EventArgs e)
        {
            Reports form = new Reports();
            form.Show();
        }

        private void users_Click(object sender, EventArgs e)
        {
            Users form = new Users();
            form.ShowDialog();
        }
    }
}
