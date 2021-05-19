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
    public partial class DialogBoxBuscarEspecialidad : Form
    {
        public DialogBoxBuscarEspecialidad()
        {
            InitializeComponent();
        }
        public string especialidad
        {
            get { return (comboBox1.Text); }
        }
        private void DialogBoxBuscarEspecialidad_Load(object sender, EventArgs e)
        {
            comboBox1.Text = "";
        }
    }
}
