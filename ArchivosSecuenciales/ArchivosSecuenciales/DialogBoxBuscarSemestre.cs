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
    public partial class DialogBoxBuscarSemestre : Form
    {
        public DialogBoxBuscarSemestre()
        {
            InitializeComponent();
        }
        public string semestre
        {
            get { return (comboBox2.Text); }
        }
        private void DialogBoxBuscarSemestre_Load(object sender, EventArgs e)
        {
            comboBox2.Text = "";
        }
    }
}
