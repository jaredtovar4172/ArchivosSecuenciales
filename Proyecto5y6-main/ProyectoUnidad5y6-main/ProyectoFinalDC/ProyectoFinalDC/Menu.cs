using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalDC
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        Secuencial obj = new Secuencial();

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 F = new Form1();
            F.Show();
        }

        private void mostrarTodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            obj.Ventas();
        }

        private void consultaDeVentasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            obj.ConsultaVenta(listView1);
        }

        private void consultaPorNombreDelProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            obj.ConsultaNombre(listView1);
        }


        private void modificarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            obj.MoidificarDatos();
        }

        private void bajaDeEToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            obj.Baja();
        }

        private void mostrarPorFechasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            obj.BuscarVentasPorFecha(listView1);

        }

        private void Menu_Load(object sender, EventArgs e)
        {
            
        }
    }
}
