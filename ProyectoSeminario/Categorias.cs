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
    public partial class Categoría : Form
    {
        public Categoría()
        {
            InitializeComponent();
            this.fill();
        }

        public void fill()
        {
            this.dgv_categoria.Rows.Clear();
            List<Categoria> ctgr = ManejoCategorias.ObtenerCategorias();
            foreach (Categoria ctg in ctgr)
            {
                this.dgv_categoria.Rows.Add(ctg.id, ctg.nombre, ctg.descrip);
            }
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

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            string nombre = txt_categoria.Text;
            string descrip = txt_descrip.Text;
            ManejoCategorias.AgregarCategoria(new Models.Dto.Categoria(nombre, descrip));
            MessageBox.Show("Categoría agregada.");
            this.clearText();
        }

        private void btn_refrescar_Click(object sender, EventArgs e)
        {
            this.fill();
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgv_categoria.SelectedRows[0].Cells[0].Value);
            string nombre = dgv_categoria.SelectedRows[0].Cells[1].Value.ToString();
            string descrip = dgv_categoria.SelectedRows[0].Cells[2].Value.ToString();
            Categoria ctg = new Categoria(nombre, descrip);
            ManejoCategorias.ActualizarCategoria(ctg, id);
            MessageBox.Show("Categoría actualizada.");
        }

        private void dgv_categoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgv_categoria.SelectedRows[0].Cells[0].Value);
            ManejoCategorias.EliminarCategoria(id);
            MessageBox.Show("Categoría eliminado.");
            this.fill();
        }

        private void Categoría_Load(object sender, EventArgs e)
        {

        }
    }
}
