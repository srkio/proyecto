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

        // Esta variable es necesaria para que se pueda guardar el ci al momento de modificar
        int CI = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                // Carga el DataGridView con la lista de atracadores
                listadoAtracador.DataSource = objAtracador.Atracadores().Tables[0];

                // Carga el combo con las bandas que existen
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
                if (mas)
                {
                    gen = 'm';
                }
                else if (fem)
                {
                    gen = 'f';
                }
                string fecN = fecha.Value.ToString();

                // Se selecciona el "id" de la banda
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

            // Se hace un casting del valor del datagrid por que este es de tipo Object
            // un casting es una conversion de tipos de datos
            int ci = (int)listadoAtracador.Rows[row].Cells[0].Value;
            listadoAtracador.DataSource = objAtracador.EliminarAtracador(ci).Tables[0];
        }

        private void button4_Click(object sender, EventArgs e)
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
                if (mas)
                {
                    gen = 'm';
                }
                else if (fem)
                {
                    gen = 'f';
                }
                string fecN = fecha.Value.ToString();
                int codBanda = listadoDeBandas.SelectedIndex + 1;
                listadoAtracador.DataSource = objAtracador.ModificarAtracador(CI, cx, nom, apP, apM, gen, fecN, codBanda).Tables[0];
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void listadoAtracador_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                int row = listadoAtracador.CurrentCell.RowIndex;
                CI = (int)listadoAtracador.Rows[row].Cells[0].Value;
                ciex.Text = (string)listadoAtracador.Rows[row].Cells[1].Value;
                nombre.Text = (string)listadoAtracador.Rows[row].Cells[2].Value;
                apePaterno.Text = (string)listadoAtracador.Rows[row].Cells[3].Value;
                apeMaterno.Text = (string)listadoAtracador.Rows[row].Cells[4].Value;
                string gen = (string)listadoAtracador.Rows[row].Cells[5].Value;
                if (gen == "m")
                {
                    masculino.Checked = true;
                }
                else
                {
                    femenino.Checked = true;
                }

                // Probar alguna de las opciones para cargar la fecha al componente
                // fecha.Value = DateTime.Parse((string)listadoAtracador.Rows[row].Cells[6].Value).ToShortDateString();
                // fecha.Value = DateTime.Parse((string)listadoAtracador.Rows[row].Cells[6].Value).Date;

                listadoDeBandas.SelectedIndex = ((int)listadoAtracador.Rows[row].Cells[9].Value) - 1;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
