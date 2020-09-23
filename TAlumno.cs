using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPR_1___Parcial
{
    class TAlumno
    {

        public string Nombre;
        public string Apellido;

        public override string ToString()
        {
            return string.Format("{0} | {1}",  Nombre, Apellido);
        }

    }
}
