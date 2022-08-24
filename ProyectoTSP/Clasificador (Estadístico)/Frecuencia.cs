using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clasificador__Estadístico_
{
    class Frecuencia
    {
        public double Promedio { get; set; }
        public double Desviacion { get; set; }

        public Frecuencia(double dato1, double dato2)
        {
            Promedio = dato1;
            Desviacion = dato2;
        }
    }
}
