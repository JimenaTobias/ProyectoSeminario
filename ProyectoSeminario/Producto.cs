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

namespace ProyectoSeminario
{
    public partial class Producto : Form
    {
        public Producto()
        {
            InitializeComponent();
        }

        public void clearText()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    TextBox txt = (TextBox)control;
                    txt.Text = "";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = txt_name.Text;
            string description = txt_description.Text;
            string price = txt_price.Text;
            string stock = txt_stock.Text;

            // Obtener la categoría seleccionada
            ComboBoxItem selectedCategoria = (ComboBoxItem)cb_categoria.SelectedItem;
            int categoriaId = selectedCategoria.Id;

            // Guardar el producto con la categoría seleccionada
            ProductManagment.AgregarProducto(new Models.Dto.Product(name, description, Convert.ToDecimal(price), Convert.ToInt32(stock), categoriaId));

            MessageBox.Show("Producto agregado.");
            this.clearText();
        }

        private void Producto_Load(object sender, EventArgs e)
        {
            FillCategoriasComboBox();
        }
        private void FillCategoriasComboBox()
        {
            List<ProyectoSeminario.Models.Dto.Categoria> categorias = ManejoCategorias.ObtenerCategorias(); // Método que obtiene las categorías
            cb_categoria.Items.Clear();

            foreach (ProyectoSeminario.Models.Dto.Categoria categoria in categorias)
            {
                cb_categoria.Items.Add(new ComboBoxItem(categoria.id, categoria.nombre));
            }

            if (cb_categoria.Items.Count > 0)
            {
                cb_categoria.SelectedIndex = 0; // Selecciona el primer elemento por defecto.
            }
        }

        // Clase auxiliar para mostrar el nombre pero obtener el ID de la categoría
        public class ComboBoxItem
        {
            public int Id { get; set; }
            public string Name { get; set; }

            public ComboBoxItem(int id, string name)
            {
                Id = id;
                Name = name;
            }

            public override string ToString()
            {
                return Name; // Lo que se mostrará en el ComboBox
            }
        }
    }
}
