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
    public partial class DialogBoxBajas : Form
    {
        public DialogBoxBajas()
        {
            InitializeComponent();
        }
        public string matricula
        {
            get { return (textBox1.Text); }
        }
        private void DialogBoxBajas_Load(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Focus();
        }
    }
}
