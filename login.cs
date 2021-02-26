using BL;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mantenedor
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UsuarioEntidades oUsuario = UsuarioBL.login(usuario.Text, password.Text);
            if (oUsuario != null)
            {
                Principal p = new Principal();
                p.Visible = true;
                this.Dispose(false);
            }
            else
            {
                MessageBox.Show("El usuario ingresado no se encuentra registrado en la BD");
            }
        }
    }
}
