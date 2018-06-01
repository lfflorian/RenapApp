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
            ConnectionString = ConfigurationManager.ConnectionStrings["DbContext"].ConnectionString;
            cnn = new SqlConnection(ConnectionString);
        }

        public Persona Solicitud(string query)
        {
            try
            {
                cnn.Open();
                SqlCommand command = new SqlCommand(query, cnn);
                SqlDataReader dataReader;
                dataReader = command.ExecuteReader();
                dataReader.Read();
                Persona persona = new Persona
                {
                    CUI = dataReader["CUI"].ToString(),
                    PrimerNombre = dataReader["PrimerNombre"].ToString(),
                    SegundoNombre = dataReader["SegundoNombre"].ToString(),
                    PrimerApellido = dataReader["PrimerApellido"].ToString(),
                    SegundoApellido = dataReader["SegundoApellido"].ToString(),
                    FechaNacimiento = Convert.ToDateTime(dataReader["FechaNacimiento"].ToString()),
                    LugarNacimiento = dataReader["LugarNacimiento"].ToString(),
                    Genero = dataReader["Genero"].ToString(),
                    Obervaciones = dataReader["Observaciones"].ToString(),
                    Password = dataReader["PassWord"].ToString()
                };

                command.Dispose();
                cnn.Close();
                return persona;
            }
            catch (Exception)
            {
                return new Persona();
            }
        }
    }
}