using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_almacen.Controladores
{
    internal class DbConexion
    {
        private SqlConnection conexion;

        public DbConexion()
        {
            //bd rodri "Server=DESKTOP-TFHCQ27\\SQLEXPRESS;Database=Almacen;Integrated security=true;";
            string conexionDb = "Server=DESKTOP-TFHCQ27\\SQLEXPRESS;Database=Almacen;Integrated security=true;";
            conexion = new SqlConnection(conexionDb);

            try
            {
                conexion.Open();
                Console.WriteLine("Conexión establecida con éxito.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al establecer la conexión: {ex.Message}");
            }
        }

        public void Insertar(string nombreTabla, string[] _solicitudInsercion)
        {
            int primer_valor = 0;
            string[] solicitudInsercion = _solicitudInsercion;

            string query = "INSERT INTO " + nombreTabla + " VALUES (";

            foreach (string valor in solicitudInsercion)
            {
                if (primer_valor != 0)
                {
                    query += ", ";
                }

                if (int.TryParse(valor, out int intValue))
                {
                    query = query + valor;
                }
                else if (double.TryParse(valor, out double doubleValue))
                {
                    query = query + valor;
                }
                else
                {
                    query += "'" + valor + "'";
                }
                primer_valor++;
            }

            query = query + ")";

            SqlCommand comando = new SqlCommand(query, conexion);
            comando.ExecuteNonQuery();

            Console.WriteLine(query);
        }
        public string AutenticarUsuarios(string nombreUsuario, string password)
        {

            string query = "SELECT rol FROM Usuario WHERE nombre=@nombre AND celular=@password AND estado='soltero'";
            using (SqlCommand command = new SqlCommand(query, conexion))
            {
                command.Parameters.AddWithValue("@nombre", nombreUsuario);
                command.Parameters.AddWithValue("@password", password);

                try
                {
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();
                        string rol = reader["rol"].ToString();
                        reader.Close();
                        return rol;
                    }
                    else
                    {
                        reader.Close();
                        return null;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al conectar con la base de datos: " + ex.Message);
                    return null;
                }
            }
        }
    }
}
