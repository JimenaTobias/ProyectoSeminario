using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ProyectoSeminario.Models.Dao;
using ProyectoSeminario.Models.Dto;

namespace ProyectoSeminario
{
    public partial class Inventario : Form
    {
        public Inventario()
        {
            InitializeComponent();
            //this.fill();
        }

        // verificar error al dar clic en botón de "Refrescar"
        public void fill()
        {
            this.data_grip.Rows.Clear();
            List<Product> prds = ProductManagment.ObtenerTodosLosProductos();

            foreach (Product prd in prds)
            {
                string categoriaNombre = ProductManagment.ObtenerNombreCategoria(prd.idCategory);
                this.data_grip.Rows.Add(prd.id, prd.name, prd.description, prd.price, prd.stock, prd.idCategory);
            }
        }

        private void data_grip_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(data_grip.SelectedRows[0].Cells[0].Value);
            ProductManagment.EliminarProducto(id);
            MessageBox.Show("Producto eliminado.");
            this.fill();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.fill();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(data_grip.SelectedRows[0].Cells[0].Value);
            string name = data_grip.SelectedRows[0].Cells[1].Value.ToString();
            string description = data_grip.SelectedRows[0].Cells[2].Value.ToString();
            decimal price = Convert.ToDecimal(data_grip.SelectedRows[0].Cells[3].Value);
            int stock = Convert.ToInt32(data_grip.SelectedRows[0].Cells[4].Value);
            Product prd = new Product(name, description, price, stock, 0);
            ProductManagment.updateProduct(prd, id);
            MessageBox.Show("Producto actualizado.");
        }

        private void Inventario_Load(object sender, EventArgs e)
        {
            CargarCategorias();
        }

        private void cb_filtro_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idCategoriaSeleccionada = (int)((KeyValuePair<int, string>)cb_filtro.SelectedItem).Key;
            MostrarProductosPorCategoria(idCategoriaSeleccionada);
        }

        private void CargarCategorias()
        {
            Connection conn = new Connection();
            {
                conn.conn.Open();
                string query = "SELECT id_categoria, nombre_categoria FROM Categorias";
                MySqlCommand cmd = new MySqlCommand(query, conn.conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                Dictionary<int, string> categorias = new Dictionary<int, string>();

                while (reader.Read())
                {
                    categorias.Add(reader.GetInt32("id_categoria"), reader.GetString("nombre_categoria"));
                }

                cb_filtro.DataSource = new BindingSource(categorias, null);
                cb_filtro.DisplayMember = "Value";
                cb_filtro.ValueMember = "Key";
            }
        }

        private void MostrarProductosPorCategoria(int idCategoria)
        {
            data_grip.Columns.Clear();

            Connection conn = new Connection();
            {
                conn.conn.Open();
                string query = "SELECT id_producto, nombre, descripcion, precio, cantidad_stock, id_categoria FROM productos WHERE id_categoria = @idCategoria";
                MySqlCommand cmd = new MySqlCommand(query, conn.conn);
                cmd.Parameters.AddWithValue("@idCategoria", idCategoria);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                data_grip.DataSource = dt;
            }
        }
    }
}
