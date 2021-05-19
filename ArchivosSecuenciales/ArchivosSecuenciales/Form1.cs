using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArchivosSecuenciales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Secuenciales obj = new Secuenciales();
        private void altasDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            obj.Altas();
        }

        private void generalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            obj.ConsultaGeneral(listView1);
        }

        private void nombresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            obj.MostrarNombre(listView1);
             
        }

        private void especialidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            obj.MostrarEspecialidad(listView1);
        }

        private void matriculaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            obj.MostrarMatricula(listView1);
        }

        private void promedioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            obj.MostrarPromedio(listView1);
        }

        private void semestreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            obj.MostrarSemestre(listView1);
        }

        private void bajasDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            obj.Bajas();

        }
    }
}
