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
    public partial class frm3 : Form
    {
        public frm3()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            MostrarReporte mostrar = new MostrarReporte();
            mostrar.Nombre = comboBox1.Text;

            mostrar.ShowDialog();

            
        }

        private void MostrarReportes_Load(object sender, EventArgs e)
        {
       
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MostrarReporte2 mostrar = new MostrarReporte2();
            mostrar.cant =Convert.ToInt32( textBox1.Text);
            mostrar.ShowDialog();
        }
    }
}
