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
    public partial class ContenedorMDI : Form
    {
        public ContenedorMDI()
        {
            InitializeComponent();
        }

        private void ContenedorMDI_Load(object sender, EventArgs e)
        {

        }

        private void gestiónMarcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmLM = new listaMarcas();
            frmLM.MdiParent = this;
            frmLM.Show();
        }

        private void gestiónExistenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmLX = new listadoExistencias();
            frmLX.MdiParent = this;
            frmLX.Show();
        }

        private void gestiónProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmGP = new frmGestionProductos();
            frmGP.MdiParent = this;
            frmGP.Show();
        }

        private void gestiónCódigosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmLC = new listaCodigos();
            frmLC.MdiParent = this;
            frmLC.Show();
        }

        private void gestiónBodegasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmLB = new listaBodegas();
            frmLB.MdiParent = this;
            frmLB.Show();
        }
    }
}
