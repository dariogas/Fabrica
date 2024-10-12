using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fabrica

namespace Curso
{
    public class Curso  
    {
        public string nombre;
        public int cupos = 0;
        public Profesor profesor;
        public List<Alumno> alumnos;

        public Curso(string nombre, int cupos, Profesor profesor)
        {
            this.nombre = nombre;
            this.cupos = cupos;
            this.profesor = profesor;
            alumnos = new List<Alumno>();
        }

    }
