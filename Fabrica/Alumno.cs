using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrica
{
    public class Alumno : Integrantes
    {
        private bool trabaja;

        public Alumno(string nombre, string apellido, long dni, DateOnly fech,bool trabaja) : base(nombre, apellido, dni, fech)
        {
            this.trabaja = trabaja;
        }
    }
}
