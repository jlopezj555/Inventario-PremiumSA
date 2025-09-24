using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;

namespace CapaModelo
{
    public class conexion
    {
        public OdbcConnection Conexion()
        {
            OdbcConnection conexion = new OdbcConnection("Dsn=Seminario");
            try
            {
                conexion.Open();
                return conexion;
            }
            catch (OdbcException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
        public void desconexion(OdbcConnection conexion)
        {
            if (conexion == null)
            {
                try
                {
                    conexion.Close();
                }
                catch (OdbcException e) 
                {
                    Console.WriteLine("Error al cerrar la conexión"+e.Message);
                }
            }
        }
    }
}
