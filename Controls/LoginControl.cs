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
using Retail_Management_System.Models;
using System.Data.OleDb;
using Retail_Management_System.Screens;

namespace Retail_Management_System
{
    public partial class LoginControl : UserControl
    {
        public Form loginForm;
        public bool isLocked = false;
        public Locked parent;
        public LoginControl()
        {
            InitializeComponent();
        }

        private void Login()
        {
            if (!Connection.TestConnection())
            {
                MessageBox.Show(Connection.ErrorMessage);
            }
            OleDbParameter[] parameters = new OleDbParameter[]
            {
                new OleDbParameter("@username", username.Text),
                new OleDbParameter("@pass", password.Text),
            };
            var query = Connection.Query("SELECT Users.*, UserType.UserType as UserType, UserType.Description as Description FROM Users INNER JOIN UserType ON Users.UserType = UserType.UserType WHERE Username = @username AND Pass = @pass", Connection.GetConnection(), parameters);
            if (query["data"].Read()) 
            {
                if (!isLocked) {
                    User theuser = new User(query["data"]);
                    Dashboard dashboardform = new Dashboard(theuser);
                    User.CurrentUser = theuser;
                    dashboardform.actions.Add(() =>
                    {
                        loginForm.Close();
                    });
                    dashboardform.actions.Add(() =>
                    {
                        dashboardform.Hide();
                        loginForm.Show();
                    });
                    dashboardform.Show();
                    loginForm.Hide();
                } else
                {
                    if (parent != null)
                    {
                        parent.Dispose();
                    }
                }
            } else
            {
                MessageBox.Show("Invalid username/password");
            }
            query["con"].Close();

        }

        private void username_KeyDown(object sender, KeyEventArgs e)
        {
            if((int)e.KeyCode == 13)
            {
                Login();
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Login();
        }
    }
}
