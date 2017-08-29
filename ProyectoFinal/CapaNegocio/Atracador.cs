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

            // En la capa de datos se almacena la consulta en la variable CONSULTA
            // y esta variable permanece cargada mientras se realizan todas las operaciones (Guardar, Modificar y Eliminar)
            // es por esto que es posible actualizar la lista en cada operacion sin necesidad de volver a realizar la consulta
            objDat.CONSULTA = cons;

            // Idem que CONSULTA
            objDat.TB = Tbl;
            objDat.Conectar();
            objDat.CrearTablaenRam();
            return objDat.ds;
        }

        public DataSet Atracadores(string cons)
        {
            objDat.CONSULTA = cons;
            objDat.TB = Tbl;
            objDat.Conectar();
            objDat.CrearTablaenRam();
            return objDat.ds;
        }

        public DataSet GuardarAtracador(string ciex, string nombre, string apP, string apM, char gen, string fecNac, int codBanda)
        {
            // Llama al evento GuardarSP de la capa de datos
            objDat.GuardarSP(ciex, nombre, apP, apM, gen, fecNac, codBanda);

            // Obtiene y devuelve el listado actualizado de los atracadores
            return objDat.ds;
        }

        public DataSet ModificarAtracador(int ci, string ciex, string nombre, string apP, string apM, char gen, string fecNac, int codBanda)
        {
            objDat.ModificarSP(ci, ciex, nombre, apP, apM, gen, fecNac, codBanda);
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
