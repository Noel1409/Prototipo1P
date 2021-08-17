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
using System.Collections;

namespace Prototipo1P
{
    public partial class frmIngresoProd : Form
    {
        public frmIngresoProd()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            ingreso();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cargacombo()
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

            var marcas= new ArrayList();
            var lineas = new ArrayList();
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
            }
            catch (OdbcException)
            {

            }

            cmbLinea.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMarca.DropDownStyle = ComboBoxStyle.DropDownList;

            for (int i = 0; i < marcas.Count; i++)
            {
                cmbMarca.Items.Add(marcas[i].ToString());
            }

            for (int i = 0; i < lineas.Count; i++)
            {
                cmbLinea.Items.Add(lineas[i].ToString());
            }
            con.Close();
        }

        private void frmIngresoProd_Load(object sender, EventArgs e)
        {
            cargacombo();
        }

        private void ingreso()
        {
            //string ingreso = "insert into productos values ("codigoP","nombreP","codL","codM",exist,"1");";
            string codigo = txtCod.Text;
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
            string mnsj = "¿Desea ingresar este producto?";
            string titulo = "Confirmación";
            MessageBoxButtons btns = MessageBoxButtons.YesNo;
            DialogResult resultado;
            resultado = MessageBox.Show(mnsj, titulo, btns);
            if (resultado == System.Windows.Forms.DialogResult.Yes)
            {
                string comando = "insert into productos values('"+codigo+"','"+nombre+"','"+codLinea+"','"+codMarca+"',"+exist+",'1');";
                OdbcCommand ing = new OdbcCommand(comando, con);
                ing.ExecuteNonQuery();

                MessageBox.Show("Se ha insertado el producto");
                txtCod.Text = "";
                txtNom.Text = "";
                txtExistencia.Text = "";
            }
            else
            {
                MessageBox.Show("No se ingresara este producto");
            }
            

            con.Close();
        }
    }
}
