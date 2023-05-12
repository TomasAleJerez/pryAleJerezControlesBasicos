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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_MouseMove(object sender, MouseEventArgs e)
        {
            lblX.Text = e.X.ToString();
            lblY.Text = e.Y.ToString();
        }

        private void frmPrincipal_Click(object sender, EventArgs e)
        {
            lblBienvenido.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void frmPrincipal_Enter(object sender, EventArgs e)
        {
           
        }

        private void frmPrincipal_MouseEnter(object sender, EventArgs e)
        {
            Random random = new Random();
            int maxWidth = this.Width - lblBienvenido.Width;
            int maxHeight = this.Height - lblBienvenido.Height;
            lblBienvenido.Location = new Point(random.Next(maxWidth), random.Next(maxHeight));
        }
    }
}
