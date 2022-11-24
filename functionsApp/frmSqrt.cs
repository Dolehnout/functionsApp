using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace functionsApp
{
    public partial class frmSqrt : Form
    {
        public frmSqrt()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Calcula el cuadrado de un número entero
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        int cuadrado(int num)
        {
            return (num * num);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (this.txtNum.Text.Length == 0)
            {
                //Length devuelve la longitud de la cadena ingresada 
                MessageBox.Show("Debes ingresar un valor numérico");
                this.txtNum.Focus(); //Ubica el cursor en el control 
                return;
            }

            bool flag = Int32.TryParse(this.txtNum.Text, out int num);
            if (!flag)
            {
                MessageBox.Show("Debes ingresar un valor numérico");
                this.txtNum.Focus();
                return; 
            }
            //int num = Convert.ToInt32(this.txtNum.Text);
            this.txtResultado.Text = cuadrado(num).ToString();
        }
    }
}
