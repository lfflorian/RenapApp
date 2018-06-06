using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
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

        public Persona Solicitud(string CUI)
        {
            StringBuilder Texto = new StringBuilder();
            try
            {
                cnn.Open();
                string query = string.Empty;
                SqlCommand command;
                SqlDataReader dataReader;

                try
                {
                    query = $"SELECT * FROM Persona Where CUI = '{CUI}'";
                    command = new SqlCommand(query, cnn);
                    dataReader = command.ExecuteReader();
                    Texto.AppendLine("Tabla1");
                dataReader.Close();
            }
            catch (Exception)
            {
                return new Persona();
            }
            try
                {
                    query = $"SELECT * FROM Persona_2 Where CUI = '{CUI}'";
                    command = new SqlCommand(query, cnn);
                    dataReader = command.ExecuteReader();
                    Texto.AppendLine("Tabla2");
                    dataReader.Close();
                }
                catch (Exception es)
                {
                    return new Persona();
                }
                try
                {
                    query = $"SELECT * FROM Persona_3 Where CUI = '{CUI}'";
                    command = new SqlCommand(query, cnn);
                    dataReader = command.ExecuteReader();
                    Texto.AppendLine("Tabla3");
                    dataReader.Close();
                }
                catch (Exception)
                {
                    return new Persona();
                }
                try
                {
                    query = $"SELECT * FROM Persona_4 Where CUI = '{CUI}'";
                    command = new SqlCommand(query, cnn);
                    dataReader = command.ExecuteReader();
                    Texto.AppendLine("Tabla4");
                }
                catch (Exception)
                {
                    return new Persona();
                }
                
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
                    Password = dataReader["Password"].ToString(),
                    Log = Texto.ToString()
                };

                command.Dispose();
                cnn.Close();
                return persona;
            }
            catch (Exception es)
            {
                //throw es;
                return new Persona();
            }
        }
    }
}