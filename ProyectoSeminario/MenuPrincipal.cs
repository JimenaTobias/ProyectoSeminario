using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoSeminario
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }
        public void openForm(Form formHijo)
        {
            panel_container.Controls.Clear();
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            panel_container.Controls.Add(formHijo);
            panel_container.Tag = formHijo;
            formHijo.Show();
        }


        private void btn_prod_Click(object sender, EventArgs e)
        {
            this.openForm(new Producto());
        }

        private void btn_inv_Click(object sender, EventArgs e)
        {
            this.openForm(new Inventario());
        }
    }
}
