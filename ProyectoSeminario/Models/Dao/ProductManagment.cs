using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using ProyectoSeminario.Models.Dto;

namespace ProyectoSeminario.Models.Dao
{
    public class ProductManagment
    {
        public ProductManagment() { }

        // Método para agregar un producto
        public static bool AgregarProducto(Product product)
        {
            Connection conn = new Connection();
            try
            {
                conn.conn.Open();
                string query = "INSERT INTO productos (nombre, descripcion, precio, cantidad_stock, id_categoria) " +
                               "VALUES (@nombre, @descripcion, @precio, @cantidad_stock, @id_categoria)";
                MySqlCommand cmd = new MySqlCommand(query, conn.conn);
                cmd.Parameters.AddWithValue("@nombre", product.name);
                cmd.Parameters.AddWithValue("@descripcion", product.description);
                cmd.Parameters.AddWithValue("@precio", product.price);
                cmd.Parameters.AddWithValue("@cantidad_stock", product.stock);
                cmd.Parameters.AddWithValue("@id_categoria", product.idCategory);
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

        // Método para obtener un producto por su ID
        public Product ObtenerProductoPorId(int idProducto)
        {
            Product producto = null;
            Connection conn = new Connection();
            try
            {
                conn.conn.Open();
                string query = "SELECT * FROM productos WHERE id_producto = @id_producto";
                MySqlCommand cmd = new MySqlCommand(query, conn.conn);
                cmd.Parameters.AddWithValue("@id_producto", idProducto);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    producto = new Product
                    {
                        id = reader.GetInt32("id_producto"),
                        name = reader.GetString("nombre"),
                        description = reader.IsDBNull(reader.GetOrdinal("descripcion")) ? null : reader.GetString("descripcion"),
                        price = reader.GetDecimal("precio"),
                        stock = reader.GetInt32("cantidad_stock"),
                        idCategory = reader.IsDBNull(reader.GetOrdinal("id_categoria")) ? (int?)null : reader.GetInt32("id_categoria")
                    };
                }
                reader.Close();
                conn.conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener producto: " + ex.Message);
                conn.conn.Close();
            }
            return producto;
        }

        // Método para actualizar un producto
        public bool ActualizarProducto(Product product)
        {
            Connection conn = new Connection();
            try
            {
                conn.conn.Open();
                string query = "UPDATE productos SET nombre = @nombre, descripcion = @descripcion, " +
                               "precio = @precio, cantidad_stock = @cantidad_stock, id_categoria = @id_categoria " +
                               "WHERE id_producto = @id_producto";
                MySqlCommand cmd = new MySqlCommand(query, conn.conn);
                cmd.Parameters.AddWithValue("@nombre", product.name);
                cmd.Parameters.AddWithValue("@descripcion", product.description);
                cmd.Parameters.AddWithValue("@precio", product.price);
                cmd.Parameters.AddWithValue("@cantidad_stock", product.stock);
                cmd.Parameters.AddWithValue("@id_categoria", product.idCategory);
                cmd.Parameters.AddWithValue("@id_producto", product.id);
                cmd.ExecuteNonQuery();
                conn.conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al actualizar producto: " + ex.Message);
                conn.conn.Close();
                return false;
            }
        }

        public static bool updateProduct(Product product, int id)
        {
            Connection conn = new Connection();
            try
            {
                conn.conn.Open();
                string query = "UPDATE productos SET nombre = @nombre, descripcion = @descripcion, " +
                               "precio = @precio, cantidad_stock = @cantidad_stock WHERE id_producto = @id_producto";
                MySqlCommand cmd = new MySqlCommand(query, conn.conn);
                cmd.Parameters.AddWithValue("@nombre", product.name);
                cmd.Parameters.AddWithValue("@descripcion", product.description);
                cmd.Parameters.AddWithValue("@precio", product.price);
                cmd.Parameters.AddWithValue("@cantidad_stock", product.stock);
                cmd.Parameters.AddWithValue("@id_producto", id);
                cmd.ExecuteNonQuery();
                conn.conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al actualizar producto: " + ex.Message);
                conn.conn.Close();
                return false;
            }
        }


        // Método para eliminar un producto
        public static bool EliminarProducto(int idProducto)
        {
            Connection conn = new Connection();
            try
            {
                conn.conn.Open();
                string query = "DELETE FROM productos WHERE id_producto = @id_producto";
                MySqlCommand cmd = new MySqlCommand(query, conn.conn);
                cmd.Parameters.AddWithValue("@id_producto", idProducto);
                cmd.ExecuteNonQuery();
                conn.conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al eliminar producto: " + ex.Message);
                conn.conn.Close();
                return false;
            }
        }

        // Método para obtener todos los productos
        public static List<Product> ObtenerTodosLosProductos()
        {
            List<Product> productos = new List<Product>();
            Connection conn = new Connection();
            try
            {
                conn.conn.Open();
                string query = "SELECT * FROM productos";
                MySqlCommand cmd = new MySqlCommand(query, conn.conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Product producto = new Product
                    {
                        id = reader.GetInt32("id_producto"),
                        name = reader.GetString("nombre"),
                        description = reader.IsDBNull(reader.GetOrdinal("descripcion")) ? null : reader.GetString("descripcion"),
                        price = reader.GetDecimal("precio"),
                        stock = reader.GetInt32("cantidad_stock"),
                        idCategory = reader.IsDBNull(reader.GetOrdinal("id_categoria")) ? (int?)null : reader.GetInt32("id_categoria")
                    };
                    productos.Add(producto);
                }
                reader.Close();
                conn.conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener productos: " + ex.Message);
                conn.conn.Close();
            }
            return productos;
        }
        // Método para obtener el nombre de una categoría por su ID
        public static string ObtenerNombreCategoria(int? idCategoria)
        {
            if (!idCategoria.HasValue)
                return string.Empty;

            Connection conn = new Connection();
            string categoriaNombre = string.Empty;
            try
            {
                conn.conn.Open();
                string query = "SELECT nombre FROM categorias WHERE id_categoria = @id_categoria";
                MySqlCommand cmd = new MySqlCommand(query, conn.conn);
                cmd.Parameters.AddWithValue("@id_categoria", idCategoria.Value);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    categoriaNombre = reader.GetString("nombre");
                }
                reader.Close();
                conn.conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener nombre de categoría: " + ex.Message);
                conn.conn.Close();
            }
            return categoriaNombre;
        }
    }
}
