using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_management.DAO
{
    public class DataProvider
    {
        private static DataProvider instance;

        public static DataProvider Instance {
            get {if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
            private set { DataProvider.instance = value; }

        }

        private DataProvider() { }

        private string connectionString = @"Data Source=LAPTOP-STMTDDPG;Initial Catalog=QuanLiNhaHang;Integrated Security=True";

        public DataTable ExecuteQuery(string query, object[] attribute = null)
        {
            DataTable data = new DataTable();
            using (SqlConnection Connec = new SqlConnection(connectionString))
            {
                Connec.Open();
                SqlCommand command = new SqlCommand(query, Connec);

                if (attribute != null)
                {
                    string[] listAttr = query.Split(' ');
                    int i = 0;
                    foreach (string item in listAttr)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, attribute[i]);
                            i++;
                        }
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                Connec.Close();

            }
            return data;
        }

        public int ExecuteNonQuery(string query, object[] attribute = null)
        {
            int data = 0;
            using (SqlConnection Connec = new SqlConnection(connectionString))
            {
                Connec.Open();
                SqlCommand command = new SqlCommand(query, Connec);

                if (attribute != null)
                {
                    string[] listAttr = query.Split(' ');
                    int i = 0;
                    foreach (string item in listAttr)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, attribute[i]);
                            i++;
                        }
                    }
                }
                data = command.ExecuteNonQuery();

                Connec.Close();

            }
            return data;
        }


        public object ExecuteScalar(string query, object[] attribute = null)
        {
            object data = 0;
            using (SqlConnection Connec = new SqlConnection(connectionString))
            {
                Connec.Open();
                SqlCommand command = new SqlCommand(query, Connec);

                if (attribute != null)
                {
                    string[] listAttr = query.Split(' ');
                    int i = 0;
                    foreach (string item in listAttr)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, attribute[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteScalar();
                Connec.Close();

            }
            return data;
        }
    }
}
