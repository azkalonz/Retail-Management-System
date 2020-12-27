using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Retail_Management_System.DB
{
    class Connection
    {
        static String connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\retail_management_system.accdb;Persist Security Info=True";
        public static string ErrorMessage = "";

        public static OleDbConnection GetConnection()
        {
            return new OleDbConnection(Connection.connectionString);
        }

        public static void NonQuery(string queryString, OleDbParameter[] parameters = null)
        {
            OleDbConnection con = Connection.GetConnection();
            con.Open();
            OleDbCommand cmd = new OleDbCommand(queryString, con);
            if (parameters != null)
            {
                cmd.Parameters.Clear();
                cmd.Parameters.AddRange(parameters);
            }
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public static Dictionary<string, dynamic> Query(string queryString, OleDbConnection con, OleDbParameter[] parameters = null  )
        {
            try
            {
                OleDbCommand cmd = new OleDbCommand(queryString, con);
                OleDbDataReader dr = null;
                con.Open();
                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters);
                }
                dr = cmd.ExecuteReader();
                var dict = new Dictionary<string, dynamic>
                {
                    ["data"] = dr,
                    ["con"] = con,
                };
                return dict;
            } catch(Exception e)
            {
                Connection.ErrorMessage = e.Message.ToString();
                return null;
            }
        }
        public static bool TestConnection()
        {
            try
            {
                OleDbConnection con = Connection.GetConnection();
                con.Open();
                con.Close();
                return true;
            }catch(Exception e)
            {
                Connection.ErrorMessage = e.Message.ToString();
                return false;
            }
        }

    }
}