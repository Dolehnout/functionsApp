using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace functionsApp
{
    public partial class frmUser : Form
    {
        public frmUser()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnJoin_Click(object sender, EventArgs e)
        {
            string usuario = txtUser.Text;
            string contraseña = txtPassword.Text;

            if (functionsApp.functions.miscellaneous.validaUsuario(usuario, contraseña))
            {
                MessageBox.Show("Usuario y contraseña correcta");
            }
            else
            {
                MessageBox.Show("Debes ingresar el usuairo correcto");
            }
        }
    }
}
