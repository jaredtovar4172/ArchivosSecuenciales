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
    public partial class DialogBoxAltas : Form
    {
        public DialogBoxAltas()
        {
            InitializeComponent();
        }
        public string matricula
        {
            get { return (textBox1.Text); }
        }
        public string nombre
        {
            get { return (textBox2.Text); }
        }
        public string paterno
        {
            get { return (textBox3.Text); }
        }
        public string materno
        {
            get { return (textBox4.Text); }
        }
        public string especialidad
        {
            get { return (comboBox1.Text); }
        }
        public string semestre
        {
            get { return (comboBox2.Text); }
        }
        public string promedio
        {
            get { return (textBox5.Text); }
        }
        private void DialogBoxAltas_Load(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
            textBox1.Focus();
        }
    }
}
