using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Prototipo1P
{
    public class conexionODBC
    {
        public OdbcConnection abrirCon()
        {
            OdbcConnection con = new OdbcConnection("Dsn=Proto1P");
            try
            {
                con.Open();
            }
            catch (OdbcException od)
            {
                Console.WriteLine("No se pudo conectar\n"+od);
            }
            return con;
        }
        public void cerrarCon(OdbcConnection con)
        {
            try
            {
                con.Close();
            }
            catch (OdbcException od)
            {
                Console.WriteLine("No se pudo cerrar la conexión\n"+od);
            }
        }
        
    }
}
