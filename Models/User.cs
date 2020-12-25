using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Retail_Management_System.DB;
using System.Data.OleDb;

namespace Retail_Management_System.Models
{
    public class User
    {
        public static User SelectedUser;
        public string Text { get; set; }
        public int Value { get; set; }
        public int UserID;
        public string Username, Pass, FirstName, LastName, UserType, Description;
        public static User CurrentUser;
        public List<SalesOrder> SalesOrders;
        public string Name 
        {
            get { return this.FirstName+ " "+this.LastName; }
            set { this.Name = value; }
        }
        public User(OleDbDataReader user)
        {
            SalesOrders = new List<SalesOrder>();
            this.Username = user["Username"].ToString();
            this.UserID = int.Parse(user["UserID"].ToString());
            this.Pass = user["Pass"].ToString();
            this.FirstName = user["FirstName"].ToString();
            this.LastName = user["LastName"].ToString();
            this.UserType = user["UserType"].ToString();
            this.Description = user["Description"].ToString();
        }
        public void CreateUser()
        {
            OleDbParameter[] parameters = new OleDbParameter[]
            {
                new OleDbParameter("@username", this.Username),
                new OleDbParameter("@fname", this.FirstName),
                new OleDbParameter("@lname", this.LastName),
                new OleDbParameter("@pass", this.Pass),
            };
            string command = "INSERT INTO Users (Username, FirstName, LastName, Pass) VALUES (@username,@fname,@lname,@pass)";
            Connection.NonQuery(command, parameters);
        }
    }
}
