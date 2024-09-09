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
    public partial class InicioSesion : Form
    {
        public InicioSesion()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text;
            string password = txt_password.Text;
            bool loggued = Auth.Login(username, password);
            if (loggued)
            {
                this.Visible = false;
                MenuPrincipal frm = new MenuPrincipal();
                frm.ShowDialog();
                this.Visible = true;
                return;
            }
            MessageBox.Show("Usuario o Contraseña incorrectos");
        }
    }
}
