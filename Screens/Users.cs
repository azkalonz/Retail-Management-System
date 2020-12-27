using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaterialSkin.Controls;
using theme = Retail_Management_System.Theme;
using Retail_Management_System.DB;
using System.Windows.Forms;
using Retail_Management_System.Models;

namespace Retail_Management_System.Screens
{
    public partial class Users : MaterialForm
    {
        private bool _shouldUpdateSelection;
        public Users()
        {
            InitializeComponent();
            Theme.MaterialSkin.ApplyTheme(this);
        }

        private void Users_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }
        private void LoadUsers(bool shouldUpdate=true, string uname=null)
        {
            guna2DataGridView1.ColumnHeadersHeight = 40;
            int currentUserId = User.CurrentUser.UserID;
            string additionalParam = "";
            if (uname != null) {
                additionalParam = $"AND [Username] = '{uname}'";
            }
            string sql = $"SELECT * FROM [Users] WHERE [UserID] <> {currentUserId} {additionalParam} ORDER BY [UserID] DESC";
            Console.WriteLine(sql);
            var query = Connection.Query(sql, Connection.GetConnection());
            Console.WriteLine(Connection.ErrorMessage);
            if (query != null)
            {
                if (query["data"].HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Columns.Add("ID");
                    dt.Columns.Add("Username");
                    dt.Columns.Add("First Name");
                    dt.Columns.Add("Last Name");
                    dt.Columns.Add("Password");
                    dt.Columns.Add("Type");
                    while (query["data"].Read())
                    {
                        DataRow row = dt.NewRow();
                        row["ID"] = query["data"]["UserID"].ToString();
                        row["Username"] = query["data"]["Username"].ToString();
                        row["First Name"] = query["data"]["FirstName"].ToString();
                        row["Last Name"] = query["data"]["LastName"].ToString();
                        row["Password"] = query["data"]["Pass"].ToString();
                        row["Type"] = query["data"]["UserType"].ToString();
                        dt.Rows.Add(row);
                    }
                    _shouldUpdateSelection = shouldUpdate;
                    guna2DataGridView1.DataSource = dt;
                }
                query["con"].Close();
            }
        }

        private void guna2DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (guna2DataGridView1.CurrentRow == null) return;
                int index = guna2DataGridView1.CurrentRow.Index;
                DataGridViewRow row = guna2DataGridView1.Rows[index];
                string id = row.Cells[0].Value.ToString();
                string uname = row.Cells[1].Value.ToString();
                string firstName = row.Cells[2].Value.ToString();
                string lastName = row.Cells[3].Value.ToString();
                string name = firstName + " " + lastName;
                string pass = row.Cells[4].Value.ToString();
                string type = row.Cells[5].Value.ToString();
                int selectedIndex = 0;
                if(type == "cashier")
                {
                    selectedIndex = 1;
                } else if(type == "admin")
                {
                    selectedIndex = 2;
                }
                if (_shouldUpdateSelection)
                {
                    firstname_lastname.Text = name;
                    userid.Text = id;
                    username.Text = uname;
                    firstname.Text = firstName;
                    lastname.Text = lastName;
                    password.Text = pass;
                    usertype.SelectedIndex = selectedIndex;
                }
            }
            catch (Exception) { }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(userid.Text) || string.IsNullOrWhiteSpace(userid.Text)) { return; }
            Connection.NonQuery($"DELETE FROM [Users] WHERE [UserID] = {userid.Text}");
            LoadUsers();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            UpdateOrInsertUser("UPDATE");
        }
        private void UpdateOrInsertUser(string action)
        {
            List<dynamic> labels = new List<dynamic>() {
            userid,
            username,
            firstname,
            lastname,
            password
            };
            string utype = "Customer";
            int selectedIndex = usertype.SelectedIndex;
            if (selectedIndex == 1)
            {
                utype = "cashier";
            }
            else if (selectedIndex == 2)
            {
                utype = "admin";
            }

            foreach (dynamic label in labels)
            {
                if (string.IsNullOrEmpty(label.Text))
                {
                    MessageBox.Show("Please enter the required fields.");
                    return;
                }
            }
            if(action == "UPDATE")
            {
                Connection.NonQuery($"UPDATE [Users] SET [FirstName] = '{firstname.Text}', [LastName] = '{lastname.Text}', [Pass] = '{password.Text}', [UserType] = '{utype}' WHERE [UserID] = {userid.Text}");
            } else if (action == "INSERT")
            {
                Connection.NonQuery($"INSERT INTO [Users]([Username],[Pass],[FirstName],[LastName],[UserType]) VALUES('{username.Text}','{password.Text}','{firstname.Text}','{lastname.Text}','{utype}')");
            }
            LoadUsers(false);
            MessageBox.Show("Success");
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            UpdateOrInsertUser("INSERT");
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            LoadUsers(true, username.Text);
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            firstname_lastname.Text = "Select a user";
            userid.Text = "0";
            username.Text = "";
            firstname.Text = "";
            lastname.Text = "";
            password.Text = "";
            usertype.SelectedIndex = 0;
        }
    }
}
