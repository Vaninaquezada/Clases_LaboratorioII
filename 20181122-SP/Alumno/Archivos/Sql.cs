using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;
using Entidades;

namespace Archivos
{
    public class Sql : IArchivo<Queue<Patente>>
    {
        private static SqlConnection conexion;
        private static SqlCommand comando;
        private static string connectionString;


        public Sql()
        {
            connectionString = @"Server = .\SQLEXPRESS; Database= patentes-sp-2018; Trusted_Connection = true;";
            conexion = new SqlConnection(connectionString);
            comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = System.Data.CommandType.Text;
        }
        public void Guardar(string tabla, Queue<Patente> datos)
        {
           
            try
            {
                using  (conexion)
                {
                    string command = "INSERT INTO " + tabla + "(patente,tipo) " +
                    "VALUES(@patente,@tipo)";
                    comando.CommandText = command;
                    conexion.ConnectionString = connectionString;

                    comando.Parameters.Add("@patente");
                    comando.Parameters.Add("@tipo");
                    conexion.Open();

                    foreach (Patente item in datos)
                    {
                        comando.Parameters["@patente"].Value = item.CodigoPatente;
                        comando.Parameters["@tipo"].Value = item.TipoCodigo;

                        comando.ExecuteNonQuery();
                    }
                    
                    comando.Parameters.Clear();

                }

            }
            catch (Exception)
            {
                throw new Exception("Error al cargar datos en la base de datos");

            }
            finally
            {
                if (conexion != null && conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                }
            }

      
        }

        public void Leer(string tabla, out Queue<Patente> datos)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string comand = "SELECT patente,tipo FROM " + tabla +";";
                SqlCommand command = new SqlCommand(comand, connection);

                connection.Open();
            
                SqlDataReader dataReader = command.ExecuteReader();
                

                Queue<Patente> patentes = new Queue<Patente>();

                while (dataReader.Read())
                {

                    string patente = dataReader.GetString(0);
                    string tipo = dataReader.GetString(1);
                    
                   Patente pa = new Patente(patente, (Patente.Tipo)Enum.Parse(typeof(Patente.Tipo),tipo));
                    // patentes.Enqueue(patente.ValidarPatente());
                    patentes.Enqueue(pa);
                }
                datos = patentes;
            }
        }
    }
}
