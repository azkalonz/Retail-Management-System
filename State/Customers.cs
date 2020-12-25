using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Retail_Management_System.Models;
using Retail_Management_System.DB;
using System.Data.OleDb;

namespace Retail_Management_System.State
{
    class Customers
    {
        public static List<User> collection = new List<User>();

        public static List<User> Get()
        {
            if (Customers.collection.Count <= 0)
            {
                var query = Connection.Query("SELECT Users.*, UserType.UserType as UserType, UserType.Description as Description FROM Users INNER JOIN UserType ON Users.UserType = UserType.UserType", Connection.GetConnection(), null);
                if (query != null)
                {
                    while (query["data"].Read())
                    {
                        User user = new User(query["data"]);
                        user.Text = query["data"]["FirstName"].ToString()+" "+ query["data"]["LastName"].ToString();
                        user.Value = (int)query["data"]["UserID"];
                        Customers.collection.Add(user);
                    }
                    query["con"].Close();
                }
                else
                {
                    Console.WriteLine(Connection.ErrorMessage);
                    return null;
                }
            }
            return Customers.collection;
        }
    }
}
