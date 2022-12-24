using System;
using System.Data.SqlClient;
using System.Data;
using Microsoft.Win32;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Net;
using System.Reflection;
using System.Xml.Linq;

namespace GymPro
{
    public static class Singleton
    {
        public static readonly SqlConnection con = new SqlConnection();
        public static readonly SqlCommand cmd = new SqlCommand();
        public static SqlDataAdapter DA;
        public static DataSet DS = new DataSet();

        public static void InitilizeVars()
        {
            con.ConnectionString = "data source=LAPTOP-LTT8NJF2;  database = GYM; integrated security = True ";
            cmd.Connection = con;
        }

        public static void Command(SqlCommand cmd)
        {
            DA = new SqlDataAdapter(cmd);
            DS = new DataSet();
            DA.Fill(DS);
        }
    }
}