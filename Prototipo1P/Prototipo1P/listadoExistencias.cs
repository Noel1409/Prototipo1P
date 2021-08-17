using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototipo1P
{
    public partial class listadoExistencias : Form
    {
        public listadoExistencias()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listadoExistencias_Load(object sender, EventArgs e)
        {
            obtenerInfo();
        }

        public void obtenerInfo()
        {
            OdbcConnection con = new OdbcConnection("Dsn=Proto1P");
            try
            {
                con.Open();
            }
            catch (OdbcException)
            {
                Console.WriteLine("No se pudo conectar\n");
            }

            string sql = "select codigo_producto as Codigo, nombre_producto as Nombre, codigo_linea, codigo_marca, existencia_producto as existencia, estatus_producto as estado from productos;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, con);

            DataTable table = new DataTable();
            dataTable.Fill(table);

            dgvExitencias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvExitencias.DataSource = table;
            con.Close();
        }

        private void btnActu_Click(object sender, EventArgs e)
        {
            obtenerInfo();
        }
    }
}
