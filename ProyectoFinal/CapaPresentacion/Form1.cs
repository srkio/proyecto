using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class Form1 : Form
    {
        Atracador objAtracador = new Atracador();
        Banda objBanda = new Banda();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                listadoAtracador.DataSource = objAtracador.Atracadores().Tables[0];
                for (int i = 0; i < objBanda.Bandas().Tables[0].Rows.Count; i++)
                {
                    var item = objBanda.Bandas().Tables[0].Rows[i];
                    listadoDeBandas.Items.Add(item[1].ToString());
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string cx = ciex.Text;
                string nom = nombre.Text;
                string apP = apePaterno.Text;
                string apM = apeMaterno.Text;
                bool mas = masculino.Checked;
                bool fem = femenino.Checked;
                char gen = ' ';
                if (mas == true)
                {
                    gen = 'm';
                }
                else if (fem == true)
                {
                    gen = 'f';
                }
                string fecN = fecha.Value.ToString();
                int codBanda = listadoDeBandas.SelectedIndex + 1;
                listadoAtracador.DataSource = objAtracador.GuardarAtracador(cx, nom, apP, apM, gen, fecN, codBanda).Tables[0];
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        // Boton eliminar
        private void button3_Click(object sender, EventArgs e)
        {
            int row = listadoAtracador.CurrentCell.RowIndex;
            int ci = (int)listadoAtracador.Rows[row].Cells[0].Value;
            listadoAtracador.DataSource = objAtracador.EliminarAtracador(ci).Tables[0];
        }

        private void listadoAtracador_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
