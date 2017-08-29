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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public string nombre { get; set; }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet1.Juez_Caso' Puede moverla o quitarla según sea necesario.
            this.Juez_CasoTableAdapter.Fill(this.DataSet1.Juez_Caso,nombre);

            this.reportViewer1.RefreshReport();
        }
    }
}
