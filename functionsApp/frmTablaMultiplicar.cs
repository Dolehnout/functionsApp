using functionsApp.functions;
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
    public partial class frmTablaMultiplicar : Form
    {
        public frmTablaMultiplicar()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int tabla = Convert.ToInt32(txtNum.Text);
            string resultado = functionsApp.functions.miscellaneous.tablaMultiplicar(tabla);
            this.txtResultado.Text = resultado;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
