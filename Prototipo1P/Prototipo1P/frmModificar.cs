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
    public partial class frmModificar : Form
    {
        public frmModificar()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmModificar_Load(object sender, EventArgs e)
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

            string sql1 = "select codigo_marca from marcas;";
            string sql2 = "select codigo_linea from lineas";
            string sql3 = "select codigo_producto from productos;";
            var marcas = new ArrayList();
            var lineas = new ArrayList();
            var prods = new ArrayList();
            try
            {
                OdbcCommand busI = new OdbcCommand(sql1, con);
                OdbcDataReader lector = busI.ExecuteReader();
                while (lector.Read())
                {
                    marcas.Add(lector[0]);
                }

                OdbcCommand busI2 = new OdbcCommand(sql2, con);
                OdbcDataReader lecto2 = busI2.ExecuteReader();
                while (lecto2.Read())
                {
                    lineas.Add(lecto2[0]);
                }

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

            cmbLinea.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMarca.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCod.DropDownStyle = ComboBoxStyle.DropDownList;

            for (int i = 0; i < marcas.Count; i++)
            {
                cmbMarca.Items.Add(marcas[i].ToString());
            }

            for (int i = 0; i < lineas.Count; i++)
            {
                cmbLinea.Items.Add(lineas[i].ToString());
            }

            for (int i = 0; i < prods.Count; i++)
            {
                cmbCod.Items.Add(prods[i].ToString());
            }
            con.Close();
        }

        private void cmbCod_SelectedIndexChanged(object sender, EventArgs e)
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
            string codigo = cmbCod.Text;
            string sql = "select codigo_producto as Codigo, nombre_producto as Nombre, codigo_linea, codigo_marca, existencia_producto as existencia, estatus_producto as estado from productos where codigo_producto='"+codigo+"';";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, con);

            DataTable table = new DataTable();
            dataTable.Fill(table);

            dgvDatosActu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDatosActu.DataSource = table;
            con.Close();
        }

        private void modificar()
        {
            string nombre = txtNom.Text;
            string codLinea = cmbLinea.Text;
            string codMarca = cmbMarca.Text;
            string exist = txtExistencia.Text;

            OdbcConnection con = new OdbcConnection("Dsn=Proto1P");
            try
            {
                con.Open();
            }
            catch (OdbcException)
            {
                Console.WriteLine("No se pudo conectar\n");
            }
            string mnsj = "¿Desea modificar este producto?";
            string titulo = "Confirmación";
            MessageBoxButtons btns = MessageBoxButtons.YesNo;
            DialogResult resultado;
            resultado = MessageBox.Show(mnsj, titulo, btns);
            if (resultado == System.Windows.Forms.DialogResult.Yes)
            {
                string comando = "update productos set nombre_producto='"+nombre+"', codigo_linea='"+codLinea+"', codigo_marca='"+codMarca+"', existencia_producto="+exist+" where codigo_producto='"+cmbCod.Text+"';";
                OdbcCommand modif = new OdbcCommand(comando, con);
                modif.ExecuteNonQuery();

                MessageBox.Show("Se ha modificado el producto");
                txtNom.Text = "";
                txtExistencia.Text = "";
                dgvDatosActu.DataSource = null;
            }
            else
            {
                MessageBox.Show("No se modificara este producto");
            }


            con.Close();
        }

        private void btnActu_Click(object sender, EventArgs e)
        {
            modificar();
        }
    }
}
