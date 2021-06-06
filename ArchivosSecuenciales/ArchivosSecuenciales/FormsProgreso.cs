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
    public partial class FormsProgreso : Form
    {
        public FormsProgreso()
        {
            InitializeComponent();
        }
        int x = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(1);
            label1.Text = "Loading... Guardando Datos en el Archivo " + progressBar1.Value + "%";
            if (x <= 100)
            {
                progressBar1.Value = x;
                x++;
                if (x == 100)
                {
                    MessageBox.Show("Datos del alumno guardados en el archivo", "Archivos Secuenciales", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    timer1.Enabled = false;
                    this.Close();
                }
            }
        }

        private void FormsProgreso_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            ProgressBar pBar = new ProgressBar();
        }
    }
}
