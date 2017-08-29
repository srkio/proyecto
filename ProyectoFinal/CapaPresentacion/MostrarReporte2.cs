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
    public partial class MostrarReporte2 : Form
    {
        public MostrarReporte2()
        {
            InitializeComponent();
        }
        public int cant { get; set; }
        private void MostrarReporte2_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet1.Cantidad_Mafiosos' Puede moverla o quitarla según sea necesario.
            this.Cantidad_MafiososTableAdapter.Fill(this.DataSet1.Cantidad_Mafiosos,cant);

            this.reportViewer1.RefreshReport();
        }
    }
}
