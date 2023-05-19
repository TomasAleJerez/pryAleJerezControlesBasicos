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

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            string TextoConcatenar = "";

            if (chkArroz.Checked == true)
            {
                lblSeleccionar.Text = "Arroz";
                TextoConcatenar = TextoConcatenar + "Arroz";
            }
            if (chkMostaza.Checked == true)
            {
                lblSeleccionar.Text = "Mostaza";
                TextoConcatenar = TextoConcatenar + "Mostaza";
            }
            if (chkPollo.Checked == true)
            {
                lblSeleccionar.Text = "Pollo";
                TextoConcatenar = TextoConcatenar + "Pollo";
            }
            lblSeleccionar.Text = TextoConcatenar;

        }
    }
}



