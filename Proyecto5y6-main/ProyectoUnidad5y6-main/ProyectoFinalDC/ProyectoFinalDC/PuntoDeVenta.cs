using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ProyectoFinalDC
{
    public partial class PuntoDeVenta : Form
    {
        public PuntoDeVenta()
        {
            InitializeComponent();
        }
        public string fecha
        {
            get { return (dateTimePicker1.Text); }
        }
        public string nombre
        {
            get { return (textBox1.Text); }
        }
        public string cantidad
        {
            get { return (textBox2.Text); }
        }
        public string precio
        {
            get { return (textBox3.Text); }
        }
        public string total
        {
            get { return (textBox4.Text); }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 F = new Form1();
            F.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PuntoDeVenta_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Text = "";
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox1.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double precio = double.Parse(textBox2.Text);
            int cantidad = int.Parse(textBox3.Text);
            double pago = double.Parse(textBox5.Text);
            double total = precio * cantidad;
            double cambio =  pago-total;
            textBox4.Text = Convert.ToString(total);
            textBox6.Text = Convert.ToString(cambio);
        }
    }
}
