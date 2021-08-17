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
    public partial class listaCodigos : Form
    {
        public listaCodigos()
        {
            InitializeComponent();
        }

        private void btnActu_Click(object sender, EventArgs e)
        {
            obtenerInfo();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void obtenerInfo()
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

            string sql = "select codigo_linea as codigo, nombre_linea as nombre, estatus_linea as estado from lineas;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, con);

            DataTable table = new DataTable();
            dataTable.Fill(table);

            dgvCodigos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCodigos.DataSource = table;

            con.Close();
        }

        private void listaCodigos_Load(object sender, EventArgs e)
        {
            obtenerInfo();
        }
    }
}
