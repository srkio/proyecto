using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class gDatos
    {
        //codigo relativo a la DB
        #region Atributos
        private string BD = "EntidadBancaria";
        private string tb, cSel;

        // Se crea un objecto dataset
        public DataSet ds = new DataSet();
        SqlConnection miCon;
        SqlDataAdapter adap;
        #endregion

        #region Propiedades
        // Indica que tabla de la base de datos se va a usar
        public string TB
        {
            set { tb = value; }
        }
        // Indica la consulta para generar el listado de datos
        public string CONSULTA
        {
            set { cSel = value; }
        }
        #endregion

        #region Metodos
        public void Conectar()
        {
            // Creando una conexion Sql
            miCon = new SqlConnection();
            miCon.ConnectionString = @" data source =.;initial catalog = " + BD + "; integrated security = true ";
        }
        public void CrearTablaenRam()
        {
            adap = new SqlDataAdapter(CONSULTA, miCon);

            // Se reinstancia el objeto dataset de esta forma se eliminan los datos 
            // de anteriores consultas
            ds = new DataSet();

            // Se llena el dataset ds con los datos de que genera la consulta
            // y luego ds es llamada desde la capa de negocios para ser devuelta a la capa de presentacion
            // y poder llenar el datagrid
            adap.Fill(ds, tb);
        }

        // Guardar mediante procedimiento almacenado
        public void GuardarSP(string ciex, string nombre, string apePaterno, string apeMaterno, char genero, string fecNacimiento, int codBanda)
        {
            // Se indica que procedimiento almacenado se va usar
            SqlCommand cmd = new SqlCommand("Guardar_Atracador", miCon);

            // Se carga los parametros que el SP usa
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@ciex", SqlDbType.Char).Value = ciex;
            cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = nombre;
            cmd.Parameters.Add("@apePaterno", SqlDbType.Char).Value = apePaterno;
            cmd.Parameters.Add("@apeMaterno", SqlDbType.Char).Value = apeMaterno;
            cmd.Parameters.Add("@genero", SqlDbType.Char).Value = genero;
            cmd.Parameters.Add("@fecNacimiento", SqlDbType.Char).Value = fecNacimiento;
            cmd.Parameters.Add("@codBanda", SqlDbType.Char).Value = codBanda;

            // Se abre la conexion para hacer posible la ejecucion del SP
            miCon.Open();

            // Se ejecuta el SP
            cmd.ExecuteNonQuery();

            // Se carga el listado actualizado
            CrearTablaenRam();

            // Se cierra la conexion
            miCon.Close();
        }

        public void ModificarSP(int ci, string ciex, string nombre, string apePaterno, string apeMaterno, char genero, string fecNacimiento, int codBanda)
        {
            SqlCommand cmd = new SqlCommand("Modificar_Atracador", miCon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@ci", SqlDbType.Int).Value = ci;
            cmd.Parameters.Add("@ciex", SqlDbType.Char).Value = ciex;
            cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = nombre;
            cmd.Parameters.Add("@apePaterno", SqlDbType.Char).Value = apePaterno;
            cmd.Parameters.Add("@apeMaterno", SqlDbType.Char).Value = apeMaterno;
            cmd.Parameters.Add("@genero", SqlDbType.Char).Value = genero;
            cmd.Parameters.Add("@fecNacimiento", SqlDbType.Char).Value = fecNacimiento;
            cmd.Parameters.Add("@codBanda", SqlDbType.Char).Value = codBanda;

            miCon.Open();
            cmd.ExecuteNonQuery();
            CrearTablaenRam();
            miCon.Close();
        }

        public void EliminarSP(int ci)
        {
            SqlCommand cmd = new SqlCommand("Eliminar_Atracador", miCon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@ci", SqlDbType.Int).Value = ci;

            miCon.Open();
            cmd.ExecuteNonQuery();
            CrearTablaenRam();
            miCon.Close();
        }
        
        #endregion
    }
}
