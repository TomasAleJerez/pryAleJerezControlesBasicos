using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryAleJerezControlesBasicos
{
    public partial class frmCajaDeTexto : Form
    {
        public frmCajaDeTexto()
        {
            InitializeComponent();
        }

        private void txtCaja_TextChanged(object sender, EventArgs e)
        {
            lblCopiar.Text = txtCaja.Text;
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            if (optAzul.Checked == true)
            {
                lblCopiar.ForeColor = Color.Blue;
                txtCaja.ForeColor = Color.Blue;
            }
            if (optRojo.Checked == true)
            {
                lblCopiar.ForeColor = Color.Red;
                txtCaja.ForeColor = Color.Red;
            }

        }
      
}
}
