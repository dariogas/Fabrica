using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrica
{
    public class Integrantes
    {
        protected string nombre;
        protected string apellido;
        protected long dni;
        protected DateOnly fech = new();

        public Integrantes(string nombre, string apellido, long dni, DateOnly fech)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.fech = fech;

        }
    }
}
