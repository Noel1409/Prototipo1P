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
    public partial class listaMarcas : Form
    {
        public listaMarcas()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listaMarcas_Load(object sender, EventArgs e)
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

            string sql = "select codigo_marca as codigo, nombre_marca as marca, estatus_marca as estado from marcas;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, con);

            DataTable table = new DataTable();
            dataTable.Fill(table);

            dgvMarcas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMarcas.DataSource = table;
            con.Close();
        }

        private void btnActu_Click(object sender, EventArgs e)
        {
            obtenerInfo();
        }
    }
}
