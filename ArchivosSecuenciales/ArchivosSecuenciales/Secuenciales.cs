using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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

    }
}
