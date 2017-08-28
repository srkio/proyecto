using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class Banda
    {
        string Tbl = "banda";
        string cons = "";

        #region Metodos;
        gDatos objDat = new gDatos();
        public DataSet Bandas()
        {
            cons = "select codBanda, nombre from banda";
            objDat.CONSULTA = cons;
            objDat.TB = Tbl;
            objDat.Conectar();
            objDat.CrearTablaenRam();
            return objDat.ds;
        }
        #endregion
    }
}