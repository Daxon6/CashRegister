using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat1.Klase
{
    internal class Database
    {
        private static SqlConnection conn = null;

        public static void createConnection()
        {
            if (conn == null)
            {
                conn = new SqlConnection("Data Source=DESKTOP-ISCCHGA\\SQLEXPRESS;Initial Catalog=\"Projekat kasa\";Integrated Security=True;Encrypt=False;TrustServerCertificate=True");
                conn.Open();
            }
        }
        public static void closeConnection()
        {
            conn.Close();
            conn = null;
        }

        public static SqlDataReader select(string query, Dictionary <string, string> parameters)
        {
            createConnection();
            SqlDataReader reader = null;
            SqlCommand cmd = new SqlCommand(query, conn);
            foreach (var key in parameters.Keys)
            {
                cmd.Parameters.AddWithValue($"@{key}", parameters[key]);
            }
            reader = cmd.ExecuteReader();
            return reader;
        }

        public static void insert(string query, Dictionary<string, string> parameters)
        {
            createConnection();
            SqlCommand cmd = new SqlCommand(query, conn);
            foreach (var key in parameters.Keys)
            {
                cmd.Parameters.AddWithValue($"@{key}", parameters[key]);
            }
            cmd.ExecuteNonQuery();
            closeConnection();
        }

        public static void update(string query, Dictionary<string, string> parameters)
        {
            insert(query, parameters);
        }

        public static void delete(string query, Dictionary<string, string> parameters)
        {
            insert(query, parameters);
        }
    }
}
