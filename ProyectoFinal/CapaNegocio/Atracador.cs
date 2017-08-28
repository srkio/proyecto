using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class Atracador
    {
        string Tbl = "persona";
        string cons = "";

        #region Metodos;
        gDatos objDat = new gDatos();
        public DataSet Atracadores()
        {
            cons = "select * from persona inner join atracador on persona.ci = atracador.ciP";
            objDat.CONSULTA = cons;
            objDat.TB = Tbl;
            objDat.Conectar();
            objDat.CrearTablaenRam();
            return objDat.ds;
        }

        public DataSet GuardarAtracador(string ciex, string nombre, string apP, string apM, char gen, string fecNac, int codBanda)
        {
            objDat.GuardarSP(ciex, nombre, apP, apM, gen, fecNac, codBanda);
            return objDat.ds;
        }

        public DataSet EliminarAtracador(int ci)
        {
            objDat.EliminarSP(ci);
            return objDat.ds;
        }
        #endregion
    }
}
