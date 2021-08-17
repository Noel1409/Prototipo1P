using System;
using System.Collections;
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
    public partial class frmDarBaja : Form
    {
        public frmDarBaja()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDarBaja_Load(object sender, EventArgs e)
        {
            cargaCombo();
        }

        private void cargaCombo()
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

            string sql3 = "select codigo_producto from productos;";
            var prods = new ArrayList();
            try
            {
                OdbcCommand busI3 = new OdbcCommand(sql3, con);
                OdbcDataReader lecto3 = busI3.ExecuteReader();
                while (lecto3.Read())
                {
                    prods.Add(lecto3[0]);
                }
            }
            catch (OdbcException)
            {

            }

            cmbProducto.DropDownStyle = ComboBoxStyle.DropDownList;

            for (int i = 0; i < prods.Count; i++)
            {
                cmbProducto.Items.Add(prods[i].ToString());
            }
            con.Close();
        }

        private void cmbProducto_SelectedIndexChanged(object sender, EventArgs e)
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
            string codigo = cmbProducto.Text;
            string sql = "select codigo_producto as Codigo, nombre_producto as Nombre, codigo_linea, codigo_marca, existencia_producto as existencia, estatus_producto as estado from productos where codigo_producto='" + codigo + "';";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, con);

            DataTable table = new DataTable();
            dataTable.Fill(table);

            dgvDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDatos.DataSource = table;
            con.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            dardebaja();
        }

        private void dardebaja()
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
            string mnsj = "¿Desea dar de baja este producto?";
            string titulo = "Confirmación";
            MessageBoxButtons btns = MessageBoxButtons.YesNo;
            DialogResult resultado;
            resultado = MessageBox.Show(mnsj, titulo, btns);
            if (resultado == System.Windows.Forms.DialogResult.Yes)
            {
                string comando = "update productos set estatus_producto='0' where codigo_producto='" + cmbProducto.Text + "';";
                OdbcCommand modif = new OdbcCommand(comando, con);
                modif.ExecuteNonQuery();

                MessageBox.Show("Se ha dado de baja el producto");
                dgvDatos.DataSource = null;
            }
            else
            {
                MessageBox.Show("No se dará de baja este producto");
            }


            con.Close();
        }
    }
}
