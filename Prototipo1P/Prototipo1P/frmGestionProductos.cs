using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototipo1P
{
    public partial class frmGestionProductos : Form
    {
        public frmGestionProductos()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var frmMP = new frmModificar();
            frmMP.Show();
            frmMP.MdiParent = this.MdiParent;
            this.Close();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            var frmIP = new frmIngresoProd();
            frmIP.Show();
            frmIP.MdiParent = this.MdiParent;
            this.Close();
        }

        private void btnElim_Click(object sender, EventArgs e)
        {
            var frmEP = new frmDarBaja();
            frmEP.Show();
            frmEP.MdiParent = this.MdiParent;
            this.Close();
        }
    }
}
