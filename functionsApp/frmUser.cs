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
        int attemps = 5;
        private void btnJoin_Click(object sender, EventArgs e)
        {
            string usuario = txtUser.Text;
            string contraseña = txtPassword.Text;

            if (attemps <= 0) this.Close();
            if (!(functionsApp.functions.miscellaneous.validaUsuario(usuario, contraseña)))
            {
                MessageBox.Show("Usuario y contraseña correcta");
                lblAttemps.Text = $"Te quedan {attemps} intentos para ingresar";
                attemps--;
            }
            else
            {
                MessageBox.Show("Ingreso exitoso");
                principalMenu openMenu = new principalMenu();
                openMenu.Show();
            }
        }
    }
}
