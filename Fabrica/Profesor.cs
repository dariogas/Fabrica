using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrica
{
    public class Profesor:Integrantes
    {
        public int experiencia = 0;

        public Profesor(string nombre, string apellido, long dni, DateOnly fech, int experiencia) : base(nombre, apellido, dni, fech)
        {
            this.experiencia = experiencia;
        }
    }
}
