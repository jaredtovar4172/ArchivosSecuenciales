using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace ArchivosSecuenciales
{
    class Secuenciales
    {
        public string Matricula;
        public string Nombre;
        public string Paterno;
        public string Materno;
        public string Especialidad;
        public int Semestre;
        public int Promedio;

        public string matricula
        {
            set { value = Matricula; }
            get { return (Matricula); }
        }
        public string nombre
        {
            set { value = Nombre; }
            get { return (Nombre); }
        }
        public string paterno
        {
            set { value = Paterno; }
            get { return (Paterno); }
        }
        public string materno
        {
            set { value = Materno; }
            get { return (Materno); }
        }
        public string especialidad
        {
            set { value = Especialidad; }
            get { return (Especialidad); }
        }
        public int semestere
        {
            set { value = Semestre; }
            get { return (Semestre); }
        }
        public int promedio
        {
            set { value = Promedio; }
            get { return (Promedio); }
        }
        public void Altas()
        {
            FormsProgreso fp = new FormsProgreso();
            StreamWriter sw = new StreamWriter("..ArchivoDatos.txt", true, Encoding.ASCII);
            DialogBoxAltas altas = new DialogBoxAltas();
            if (altas.ShowDialog() == DialogResult.OK)
            {
                sw.WriteLine(altas.matricula);
                sw.WriteLine(altas.nombre);
                sw.WriteLine(altas.paterno);
                sw.WriteLine(altas.materno);
                sw.WriteLine(altas.especialidad);
                sw.WriteLine(altas.semestre);
                sw.WriteLine(altas.promedio);
                fp.Show();
                //MessageBox.Show("Datos del alumno almacenados en el archivo", "Archivos secuenciales", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            sw.Close();
        }
        public void ConsultaGeneral(ListView caja)
        {
            StreamReader sr = new StreamReader("..ArchivoDatos.txt");
            string matricula = sr.ReadLine();
            string nombre = sr.ReadLine();
            string paterno = sr.ReadLine();
            string materno = sr.ReadLine();
            string especialidad = sr.ReadLine();
            string semestre = sr.ReadLine();
            string promedio = sr.ReadLine();
            while (matricula != null)
            {
                ListViewItem datos = new ListViewItem(matricula);
                datos.SubItems.Add(nombre);
                datos.SubItems.Add(paterno);
                datos.SubItems.Add(materno);
                datos.SubItems.Add(especialidad);
                datos.SubItems.Add(semestre);
                datos.SubItems.Add(promedio);
                caja.Items.Add(datos);
                matricula = sr.ReadLine();
                nombre = sr.ReadLine();
                paterno = sr.ReadLine();
                materno = sr.ReadLine();
                especialidad = sr.ReadLine();
                semestre = sr.ReadLine();
                promedio = sr.ReadLine();
            }
            sr.Close();
        }
        public void MostrarNombre(ListView caja)
        {
            bool sw = false;
            StreamReader sr = new StreamReader("..ArchivoDatos.txt");
            DialogBoxBuscarNombre busca = new DialogBoxBuscarNombre();
            if (busca.ShowDialog() == DialogResult.OK)
            {
                string matricula = sr.ReadLine();
                string nombre = sr.ReadLine();
                string paterno = sr.ReadLine();
                string materno = sr.ReadLine();
                string especialidad = sr.ReadLine();
                string semestre = sr.ReadLine();
                string promedio = sr.ReadLine();
                while (matricula != null)
                {
                    if (nombre.ToLower() == busca.nombre.ToLower())
                    {
                        sw = true;
                        ListViewItem datos = new ListViewItem(matricula);
                        datos.SubItems.Add(nombre);
                        datos.SubItems.Add(paterno);
                        datos.SubItems.Add(materno);
                        datos.SubItems.Add(especialidad);
                        datos.SubItems.Add(semestre);
                        datos.SubItems.Add(promedio);
                        caja.Items.Add(datos);
                    }
                    matricula = sr.ReadLine();
                    nombre = sr.ReadLine();
                    paterno = sr.ReadLine();
                    materno = sr.ReadLine();
                    especialidad = sr.ReadLine();
                    semestre = sr.ReadLine();
                    promedio = sr.ReadLine();
                }
                sr.Close();
            }
            if (sw == false)
            {
                MessageBox.Show("El nombre del alumno que se busca no existe en el archivo", "Archivos Secuenciales", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void MostrarMatricula(ListView caja)
        {
            bool sw = false;
            StreamReader sr = new StreamReader("..ArchivoDatos.txt");
            DialogBoxBuscarMatricula busca = new DialogBoxBuscarMatricula();
            if (busca.ShowDialog() == DialogResult.OK)
            {
                string matricula = sr.ReadLine();
                string nombre = sr.ReadLine();
                string paterno = sr.ReadLine();
                string materno = sr.ReadLine();
                string especialidad = sr.ReadLine();
                string semestre = sr.ReadLine();
                string promedio = sr.ReadLine();
                while (matricula != null)
                {
                    if (matricula.ToLower() == busca.matricula.ToLower())
                    {
                        sw = true;
                        ListViewItem datos = new ListViewItem(matricula);
                        datos.SubItems.Add(nombre);
                        datos.SubItems.Add(paterno);
                        datos.SubItems.Add(materno);
                        datos.SubItems.Add(especialidad);
                        datos.SubItems.Add(semestre);
                        datos.SubItems.Add(promedio);
                        caja.Items.Add(datos);
                    }
                    matricula = sr.ReadLine();
                    nombre = sr.ReadLine();
                    paterno = sr.ReadLine();
                    materno = sr.ReadLine();
                    especialidad = sr.ReadLine();
                    semestre = sr.ReadLine();
                    promedio = sr.ReadLine();
                }
                sr.Close();
            }
            if (sw == false)
            {
                MessageBox.Show("La matricula del alumno que se busca no existe en el archivo", "Archivos Secuenciales", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void MostrarPromedio(ListView caja)
        {
            bool sw = false;
            StreamReader sr = new StreamReader("..ArchivoDatos.txt");
            DialogBoxBuscarPromedio busca = new DialogBoxBuscarPromedio();
            if (busca.ShowDialog() == DialogResult.OK)
            {
                string matricula = sr.ReadLine();
                string nombre = sr.ReadLine();
                string paterno = sr.ReadLine();
                string materno = sr.ReadLine();
                string especialidad = sr.ReadLine();
                string semestre = sr.ReadLine();
                string promedio = sr.ReadLine();
                while (matricula != null)
                {
                    if (promedio.ToLower() == busca.promedio.ToLower())
                    {
                        sw = true;
                        ListViewItem datos = new ListViewItem(matricula);
                        datos.SubItems.Add(nombre);
                        datos.SubItems.Add(paterno);
                        datos.SubItems.Add(materno);
                        datos.SubItems.Add(especialidad);
                        datos.SubItems.Add(semestre);
                        datos.SubItems.Add(promedio);
                        caja.Items.Add(datos);
                    }
                    matricula = sr.ReadLine();
                    nombre = sr.ReadLine();
                    paterno = sr.ReadLine();
                    materno = sr.ReadLine();
                    especialidad = sr.ReadLine();
                    semestre = sr.ReadLine();
                    promedio = sr.ReadLine();
                }
                sr.Close();
            }
            if (sw == false)
            {
                MessageBox.Show("El promedio del alumno que se busca no existe en el archivo", "Archivos Secuenciales", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void MostrarSemestre(ListView caja)
        {
                bool sw = false;
                StreamReader sr = new StreamReader("..ArchivoDatos.txt");
                DialogBoxBuscarSemestre busca = new DialogBoxBuscarSemestre();
                if (busca.ShowDialog() ==DialogResult.OK)
                {
                string matricula = sr.ReadLine();
                string nombre = sr.ReadLine();
                string paterno = sr.ReadLine();
                string materno = sr.ReadLine();
                string especialidad = sr.ReadLine();
                string semestre = sr.ReadLine();
                string promedio = sr.ReadLine();
                while (matricula != null)
                {
                        if (semestre.ToLower() ==busca.semestre.ToLower())
                        {
                        sw = true;
                    ListViewItem datos = new ListViewItem(matricula);
                    datos.SubItems.Add(nombre);
                    datos.SubItems.Add(paterno);
                    datos.SubItems.Add(materno);
                    datos.SubItems.Add(especialidad);
                    datos.SubItems.Add(semestre);
                    datos.SubItems.Add(promedio);
                    caja.Items.Add(datos);
                        }
                    matricula = sr.ReadLine();
                    nombre = sr.ReadLine();
                    paterno = sr.ReadLine();
                    materno = sr.ReadLine();
                    especialidad = sr.ReadLine();
                    semestre = sr.ReadLine();
                    promedio = sr.ReadLine();
                }
                sr.Close();
                }
            if (sw == false)
            {
                MessageBox.Show("El semestre del alumno que se busca no existe en el archivo", "Archivos Secuenciales", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void MostrarEspecialidad(ListView caja)
        {
            bool sw = false;
            StreamReader sr = new StreamReader("..ArchivoDatos.txt");
            DialogBoxBuscarEspecialidad busca = new DialogBoxBuscarEspecialidad();
            if (busca.ShowDialog() == DialogResult.OK)
            {
                string matricula = sr.ReadLine();
                string nombre = sr.ReadLine();
                string paterno = sr.ReadLine();
                string materno = sr.ReadLine();
                string especialidad = sr.ReadLine();
                string semestre = sr.ReadLine();
                string promedio = sr.ReadLine();
                while (matricula != null)
                {
                    if (especialidad.ToLower() == busca.especialidad.ToLower())
                    {
                        sw = true;
                        ListViewItem datos = new ListViewItem(matricula);
                        datos.SubItems.Add(nombre);
                        datos.SubItems.Add(paterno);
                        datos.SubItems.Add(materno);
                        datos.SubItems.Add(especialidad);
                        datos.SubItems.Add(semestre);
                        datos.SubItems.Add(promedio);
                        caja.Items.Add(datos);
                    }
                    matricula = sr.ReadLine();
                    nombre = sr.ReadLine();
                    paterno = sr.ReadLine();
                    materno = sr.ReadLine();
                    especialidad = sr.ReadLine();
                    semestre = sr.ReadLine();
                    promedio = sr.ReadLine();
                }
                sr.Close();
            }
            if (sw == false)
            {
                MessageBox.Show("La especialidad del alumno que se busca no existe en el archivo", "Archivos Secuenciales", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void Bajas ()
        {
            bool swit = false;
            DialogBoxBajas baja = new DialogBoxBajas();
            if(baja.ShowDialog()==DialogResult.OK)
            {
                StreamReader sr = new StreamReader("..ArchivoDatos.txt");
                StreamWriter sw = new StreamWriter("..Auxiliar.txt", false, Encoding.ASCII);
                string matricula = sr.ReadLine();
                string nombre = sr.ReadLine();
                string paterno = sr.ReadLine();
                string materno = sr.ReadLine();
                string especialidad = sr.ReadLine();
                string semestre = sr.ReadLine();
                string promedio = sr.ReadLine();
                while (matricula != null)
                {
                    if (matricula == baja.matricula)
                    {
                        swit = true;
                    }
                    if (matricula != baja.matricula)
                    {
                        sw.WriteLine(matricula);
                        sw.WriteLine(nombre);
                        sw.WriteLine(paterno);
                        sw.WriteLine(materno);
                        sw.WriteLine(especialidad);
                        sw.WriteLine(semestre);
                        sw.WriteLine(promedio);
                       }
                            matricula = sr.ReadLine();
                            nombre = sr.ReadLine();
                            paterno = sr.ReadLine();
                            materno = sr.ReadLine();
                            especialidad = sr.ReadLine();
                            semestre = sr.ReadLine();
                            promedio = sr.ReadLine();
                    }
                sw.Close();
                sr.Close();
                StreamReader sr1 = new StreamReader("..Auxiliar.txt");
                StreamWriter sw1 = new StreamWriter("..ArchivoDatos.txt", false, Encoding.ASCII);
                matricula = sr1.ReadLine();
                nombre = sr1.ReadLine();
                paterno = sr1.ReadLine();
                materno = sr1.ReadLine();
                especialidad = sr1.ReadLine();
                semestre = sr1.ReadLine();
                promedio = sr1.ReadLine();
                while (matricula != null)
                {
                    sw1.WriteLine(matricula);
                    sw1.WriteLine(nombre);
                    sw1.WriteLine(paterno);
                    sw1.WriteLine(materno);
                    sw1.WriteLine(especialidad);
                    sw1.WriteLine(semestre);
                    sw1.WriteLine(promedio);
                    matricula = sr1.ReadLine();
                    nombre = sr1.ReadLine();
                    paterno = sr1.ReadLine();
                    materno = sr1.ReadLine();
                    especialidad = sr1.ReadLine();
                    semestre = sr1.ReadLine();
                    promedio = sr1.ReadLine();
                }
                sr1.Close();
                sw1.Close();
                if (swit == false)
                {
                    MessageBox.Show("La matricula del alumno no existe en los datos del archivo", "Archivos Secuenciales", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Se elimino los datos del alumno del archivo", "Archivos Secuenciales", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                string matricula = sr.ReadLine();
                string nombre = sr.ReadLine();
                string paterno = sr.ReadLine();
                string materno = sr.ReadLine();
                string especialidad = sr.ReadLine();
                string semestre = sr.ReadLine();
                string promedio = sr.ReadLine();
                while (matricula != null)
                {
                    if (matricula != modificar.matricula)
                    {
                        sw.WriteLine(matricula);
                        sw.WriteLine(nombre);
                        sw.WriteLine(paterno);
                        sw.WriteLine(materno);
                        sw.WriteLine(especialidad);
                        sw.WriteLine(semestre);
                        sw.WriteLine(promedio);
                    }
                    if (matricula == modificar.matricula)
                    {
                        swit = true;
                        DialogBoxAltas crea = new DialogBoxAltas();
                        if(crea.ShowDialog() == DialogResult.OK)
                        {
                            sw.WriteLine(crea.matricula);
                            sw.WriteLine(crea.nombre);
                            sw.WriteLine(crea.paterno);
                            sw.WriteLine(crea.materno);
                            sw.WriteLine(crea.especialidad);
                            sw.WriteLine(crea.semestre);
                            sw.WriteLine(crea.promedio);
                        }
                    }
                    swit = true;
                    matricula = sr.ReadLine();
                    nombre = sr.ReadLine();
                    paterno = sr.ReadLine();
                    materno = sr.ReadLine();
                    especialidad = sr.ReadLine();
                    semestre = sr.ReadLine();
                    promedio = sr.ReadLine();
                }
                sw.Close();
                sr.Close();
                StreamReader sr1 = new StreamReader("..Auxiliar.txt");
                StreamWriter sw1 = new StreamWriter("..ArchivoDatos.txt", false, Encoding.ASCII);
                matricula = sr1.ReadLine();
                nombre = sr1.ReadLine();
                paterno = sr1.ReadLine();
                materno = sr1.ReadLine();
                especialidad = sr1.ReadLine();
                semestre = sr1.ReadLine();
                promedio = sr1.ReadLine();
                while (matricula != null)
                {
                    sw1.WriteLine(matricula);
                    sw1.WriteLine(nombre);
                    sw1.WriteLine(paterno);
                    sw1.WriteLine(materno);
                    sw1.WriteLine(especialidad);
                    sw1.WriteLine(semestre);
                    sw1.WriteLine(promedio);
                    matricula = sr1.ReadLine();
                    nombre = sr1.ReadLine();
                    paterno = sr1.ReadLine();
                    materno = sr1.ReadLine();
                    especialidad = sr1.ReadLine();
                    semestre = sr1.ReadLine();
                    promedio = sr1.ReadLine();
                }
                sr1.Close();
                sw1.Close();
                if (swit == false)
                {
                    MessageBox.Show("La matricula del alumno no existe en los datos del archivo", "Archivos Secuenciales", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Los datos del alumno se modificaron del archivo", "Archivos Secuenciales", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}

