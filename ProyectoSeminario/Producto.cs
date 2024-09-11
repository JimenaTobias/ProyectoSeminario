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
            string categoria = cb_categoria.Text;
            ProductManagment.AgregarProducto(new Models.Dto.Product(name, description, Convert.ToDecimal(price), Convert.ToInt32(stock), 1));
            MessageBox.Show("Producto agregado.");
            this.clearText();
        }

        private void Producto_Load(object sender, EventArgs e)
        {

        }
    }
}
