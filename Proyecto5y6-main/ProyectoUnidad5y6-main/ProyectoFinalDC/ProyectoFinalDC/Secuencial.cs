using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace ProyectoFinalDC
{
    class Secuencial
    {
        public string Fecha;
        public string Nombre;
        public int Cantidad;
        public double Precio;
        public double Total;
        public string fecha
        {
            set { value = Fecha; }
            get { return (Fecha); }
        }
        public string nombre
        {
            set { value = Nombre; }
            get { return (Nombre); }
        }
        public int cantidad
        {
            set { value = Cantidad; }
            get { return (Cantidad); }
        }
        public double precio
        {
            set { value = Precio; }
            get { return (Precio); }
        }
        public double total
        {
            set { value = Total; }
            get { return (Total); }
        }
        public void Ventas()
        {
            StreamWriter sw = new StreamWriter("..ArchivoDatos.txt", true, Encoding.ASCII);
            PuntoDeVenta ventas = new PuntoDeVenta();
            if (ventas.ShowDialog() == DialogResult.OK)
            {
                sw.WriteLine(ventas.fecha);
                sw.WriteLine(ventas.nombre);
                sw.WriteLine(ventas.cantidad);
                sw.WriteLine(ventas.precio);
                sw.WriteLine(ventas.total);

                sw.Close();
            }
        }
        public void ConsultaVenta(ListView caja)
        {
            StreamReader sr = new StreamReader("..ArchivoDatos.txt");
            string fecha = sr.ReadLine();
            string nombre = sr.ReadLine();
            string cantidad = sr.ReadLine();
            string precio = sr.ReadLine();
            string total = sr.ReadLine();
            while (fecha != null)
            {
                ListViewItem datos = new ListViewItem(fecha);
                datos.SubItems.Add(nombre);
                datos.SubItems.Add(cantidad);
                datos.SubItems.Add(precio);
                datos.SubItems.Add(total);
                caja.Items.Add(datos);
                fecha = sr.ReadLine();
                nombre = sr.ReadLine();
                cantidad = sr.ReadLine();
                precio = sr.ReadLine();
                total = sr.ReadLine();
            }
            sr.Close();
        }
        public void ConsultaNombre(ListView caja)
        {
            bool sw = false;
            StreamReader sr = new StreamReader("..ArchivoDatos.txt");
            DialogBoxBuscarProducto busca = new DialogBoxBuscarProducto();
            if (busca.ShowDialog() == DialogResult.OK)
            {
                string fecha = sr.ReadLine();
                string nombre = sr.ReadLine();
                string cantidad = sr.ReadLine();
                string precio = sr.ReadLine();
                while (fecha != null)
                {
                    if (nombre.ToLower() == busca.nombre.ToLower())
                    {
                        sw = true;
                        ListViewItem datos = new ListViewItem(fecha);
                        datos.SubItems.Add(nombre);
                        datos.SubItems.Add(cantidad);
                        datos.SubItems.Add(precio);
                        caja.Items.Add(datos);
                    }
                    fecha = sr.ReadLine();
                    nombre = sr.ReadLine();
                    cantidad = sr.ReadLine();
                    precio = sr.ReadLine();
                }
                sr.Close();
            }
            if (sw == false)
            {
                MessageBox.Show("El nombre del producto que se busca no existe en el archivo", "Archivos Secuenciales", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void Baja()
        {
            bool swit = false;
            DialogBoxBajaProducto baja = new DialogBoxBajaProducto();
            if (baja.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader("..ArchivoDatos.txt");
                StreamWriter sw = new StreamWriter("..Auxiliar.txt", false, Encoding.ASCII);
                string fecha = sr.ReadLine();
                string nombre = sr.ReadLine();
                string cantidad = sr.ReadLine();
                string precio = sr.ReadLine();
                while (fecha != null)
                {
                    if (fecha == baja.fecha)
                    {
                        swit = true;
                    }
                    if (fecha != baja.fecha)
                    {
                        sw.WriteLine(fecha);
                        sw.WriteLine(nombre);
                        sw.WriteLine(cantidad);
                        sw.WriteLine(precio);
                    }
                    fecha = sr.ReadLine();
                    nombre = sr.ReadLine();
                    cantidad = sr.ReadLine();
                    precio = sr.ReadLine();
                }
                sw.Close();
                sr.Close();
                StreamReader sr1 = new StreamReader("..Auxiliar.txt");
                StreamWriter sw1 = new StreamWriter("..ArchivoDatos.txt", false, Encoding.ASCII);
                fecha = sr1.ReadLine();
                nombre = sr1.ReadLine();
                cantidad = sr1.ReadLine();
                precio = sr1.ReadLine();
                while (fecha != null)
                {
                    sw1.WriteLine(fecha);
                    sw1.WriteLine(nombre);
                    sw1.WriteLine(cantidad);
                    sw1.WriteLine(precio);
                    fecha = sr1.ReadLine();
                    nombre = sr1.ReadLine();
                    cantidad = sr1.ReadLine();
                    precio = sr1.ReadLine();
                }
                sr1.Close();
                sw1.Close();
                if (swit == false)
                {
                    MessageBox.Show("La fecha del producto no existe en los datos del archivo", "Archivos Secuenciales", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Se elimino los datos del producto del archivo", "Archivos Secuenciales", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        public void MoidificarDatos()
        {
            bool swit = false;
            DialogBoxModificar modificar = new DialogBoxModificar();
            if (modificar.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader("..ArchivoDatos.txt");
                StreamWriter sw = new StreamWriter("..Auxiliar.txt", false, Encoding.ASCII);
                string fecha = sr.ReadLine();
                string nombre = sr.ReadLine();
                string cantidad = sr.ReadLine();
                string precio = sr.ReadLine();
                while (fecha != null)
                {
                    if (fecha != modificar.fecha)
                    {
                        sw.WriteLine(fecha);
                        sw.WriteLine(nombre);
                        sw.WriteLine(cantidad);
                        sw.WriteLine(precio);
                    }
                    if (fecha == modificar.fecha)
                    {
                        swit = true;
                        PuntoDeVenta crea = new PuntoDeVenta();
                        if (crea.ShowDialog() == DialogResult.OK)
                        {
                            sw.WriteLine(crea.fecha);
                            sw.WriteLine(crea.nombre);
                            sw.WriteLine(crea.cantidad);
                            sw.WriteLine(crea.precio);
                        }
                    }
                    swit = true;
                    fecha = sr.ReadLine();
                    nombre = sr.ReadLine();
                    cantidad = sr.ReadLine();
                    precio = sr.ReadLine();
                }
                sw.Close();
                sr.Close();
                StreamReader sr1 = new StreamReader("..Auxiliar.txt");
                StreamWriter sw1 = new StreamWriter("..ArchivoDatos.txt", false, Encoding.ASCII);
                fecha = sr1.ReadLine();
                nombre = sr1.ReadLine();
                cantidad = sr1.ReadLine();
                precio = sr1.ReadLine();
                while (fecha != null)
                {
                    sw1.WriteLine(fecha);
                    sw1.WriteLine(nombre);
                    sw1.WriteLine(cantidad);
                    sw1.WriteLine(precio);
                    fecha = sr1.ReadLine();
                    nombre = sr1.ReadLine();
                    cantidad = sr1.ReadLine();
                    precio = sr1.ReadLine();
                }
                sr1.Close();
                sw1.Close();
                if (swit == false)
                {
                    MessageBox.Show("La fecha del producto no existe en los datos del archivo", "Archivos Secuenciales", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Los datos del producto se modificaron del archivo", "Archivos Secuenciales", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        public void PrecioAlto(ListView caja)
        {
          
        }
        public void BuscarVentasPorFecha(ListView caja)
        {
            double suma = 0;
            DialogBoxBuscaPorFecha busca = new DialogBoxBuscaPorFecha();
            if (busca.ShowDialog()==DialogResult.OK)
            {
                StreamReader sr = new StreamReader("..ArchivoDatos.txt");
                string fecha = sr.ReadLine();
                string nombre = sr.ReadLine();
                string cantidad = sr.ReadLine();
                string precio = sr.ReadLine();
                string total = sr.ReadLine();
                while (fecha != null)
                {
                    if (fecha.ToUpper() == busca.fecha.ToUpper())
                    {
                        suma += double.Parse(total);
                        ListViewItem datos = new ListViewItem(fecha);
                        datos.SubItems.Add(nombre);
                        datos.SubItems.Add(cantidad);
                        datos.SubItems.Add(precio);
                        datos.SubItems.Add(total);
                        caja.Items.Add(datos);
                    }
                    fecha = sr.ReadLine();
                    nombre = sr.ReadLine();
                    cantidad = sr.ReadLine();
                    precio = sr.ReadLine();
                    total = sr.ReadLine();
                }
                sr.Close();
            }
            MessageBox.Show("El monto total de esa fecha es de: " + suma);
        }
    }
}
