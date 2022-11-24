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
    public partial class frmPow : Form
    {
        public frmPow()
        {
            InitializeComponent();
        }

        
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Calcula la potencia de un número
        /// </summary>
        /// <param name="b"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        int poot(int b, int e)
        {
            int res = 1;
            for (int k = 1; k <= e; k++)
            {
                res *= b;
            }
            return res;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(this.txtBase.Text);
            int expo = Convert.ToInt32(this.txtExponente.Text);
            this.lblResultado.Text = $"El resultado es: {poot(num,expo)}";

        }
    }
}
