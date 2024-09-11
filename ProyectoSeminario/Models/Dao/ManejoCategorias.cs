using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using ProyectoSeminario.Models.Dto;

namespace ProyectoSeminario.Models.Dao
{
    public class ManejoCategorias
    {
        public ManejoCategorias () { }

        // Método para agregar categorías
        public static bool AgregarCategoria (Categoria categoria)
        {
            Connection conn = new Connection();
            try
            {
                conn.conn.Open();
                string query = "INSERT INTO Categorias (nombre_categoria, descripcion_categoria) " +
                               "VALUES (@nombre_categoria, @descripcion_categoria)";
                MySqlCommand cmd = new MySqlCommand(query, conn.conn);
                cmd.Parameters.AddWithValue("@nombre_categoria", categoria.nombre);
                cmd.Parameters.AddWithValue("@descripcion_categoria", categoria.descrip);
                cmd.ExecuteNonQuery();
                conn.conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al agregar producto: " + ex.Message);
                conn.conn.Close();
                return false;
            }
        }

        // Método para obtener categorías
        public static List<Categoria> ObtenerCategorias()
        {
            List<Categoria> categorias = new List<Categoria>();
            Connection conn = new Connection();
            try
            {
                conn.conn.Open();
                string query = "SELECT * FROM Categorias";
                MySqlCommand cmd = new MySqlCommand(query, conn.conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Categoria categoria = new Categoria
                    {
                        id = reader.GetInt32("id_categoria"),
                        nombre = reader.GetString("nombre_categoria"),
                        descrip = reader.IsDBNull(reader.GetOrdinal("descripcion_categoria")) ? null : reader.GetString("descripcion_categoria"),
                    };
                    categorias.Add(categoria);
                }
                reader.Close();
                conn.conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener las categorías: " + ex.Message);
                conn.conn.Close();
            }
            return categorias;
        }

        // Método para actualizar categoría
        public static bool ActualizarCategoria(Categoria categoria, int id)
        {
            Connection conn = new Connection();
            try
            {
                conn.conn.Open();
                string query = "UPDATE Categorias SET nombre = @nombre_categoria, descripcion_categoria = @descripcion_categoria" +
                               "WHERE id_categoria = @id_categoria";
                MySqlCommand cmd = new MySqlCommand(query, conn.conn);
                cmd.Parameters.AddWithValue("@nombre_categoria", categoria.nombre);
                cmd.Parameters.AddWithValue("@descripcion_categoria", categoria.descrip);
                cmd.Parameters.AddWithValue("@id_categoria", id);
                cmd.ExecuteNonQuery();
                conn.conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al actualizar la categoría: " + ex.Message);
                conn.conn.Close();
                return false;
            }
        }

        // Método para eliminar categorías
        public static bool EliminarCategoria(int idCategoria)
        {
            Connection conn = new Connection();
            try
            {
                conn.conn.Open();
                string query = "DELETE FROM Categorias WHERE id_categoria = @id_categoria";
                MySqlCommand cmd = new MySqlCommand(query, conn.conn);
                cmd.Parameters.AddWithValue("@id_categoria", idCategoria);
                cmd.ExecuteNonQuery();
                conn.conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al eliminar la categoría seleccionada: " + ex.Message);
                conn.conn.Close();
                return false;
            }
        }
    }
}
