using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoSeminario.Models.Dao;
using ProyectoSeminario.Models.Dto;

namespace ProyectoSeminario
{
    public partial class Inventario : Form
    {
        public Inventario()
        {
            InitializeComponent();
            this.fill();
        }

        public void fill()
        {
            this.data_grip.Rows.Clear();
            List<Product> prds = ProductManagment.ObtenerTodosLosProductos();
            foreach (Product prd in prds)
            {
                this.data_grip.Rows.Add(prd.id, prd.name, prd.description, prd.price, prd.stock);
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

        }
    }
}
