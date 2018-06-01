using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace wsRenap
{
    public class ConexionDB
    {
        private string ConnectionString;
        SqlConnection cnn;

        public ConexionDB()
        {
            ConnectionString = ConfigurationManager.ConnectionStrings[""].ConnectionString;
            cnn = new SqlConnection(ConnectionString);
        }

        public SqlDataReader Solicitud(string query)
        {
            try
            {
                cnn.Open();
                SqlCommand command = new SqlCommand(query, cnn);
                SqlDataReader dataReader;
                dataReader = command.ExecuteReader();
                dataReader.Close();
                command.Dispose();
                cnn.Close();
                return dataReader;
            }
            catch (Exception)
            {
                throw;
            }
            
        }
    }
}