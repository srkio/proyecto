using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class MostrarReporte : Form
    {
        public MostrarReporte()
        {
            InitializeComponent();
        }
        public string Nombre { get; set; }
        
        private void MostrarReporte_Load(object sender, EventArgs e)
        {
            
            // TODO: esta línea de código carga datos en la tabla 'DataSet1.Juez_Caso' Puede moverla o quitarla según sea necesario.
            this.Juez_CasoTableAdapter.Fill(this.DataSet1.Juez_Caso,Nombre);

            this.reportViewer1.RefreshReport();
        }
    }
}
