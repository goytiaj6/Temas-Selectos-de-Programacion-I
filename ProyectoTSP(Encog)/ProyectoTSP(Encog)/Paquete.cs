using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTSP_Encog_
{
    class Paquete
    {
        //Cadena para la frecuencia de R
        public string R { get; set; }
        //Cadena para la frecuencia de G
        public string G { get; set; }
        //Cadena para la frecuencia de B
        public string B { get; set; }
        //Cadena para el tamaño del paquete
        public string Tamaño { get; set; }
        //Cadena para el tipo de etiquetado (color)
        public string Etiqueta { get; set; }

        /// <summary>
        /// Método para normalizar los datos del paquete que se reciben de Arduino, basada en la ecuacion en el manual de Encog
        /// </summary>
        /// <param name="valor_norm"> Dato de entrada normalizado </param>
        /// <param name="nH">  </param>
        /// <param name="nL">  </param>
        /// <param name="dH">  </param>
        /// <param name="dL">  </param>
        /// <returns></returns>
        public double Normalizar(double valor_norm, double nH, double nL, double dH, double dL)
        {
            double Norma = (((valor_norm - dL) * (nH - nL)) / (dH - dL)) + nL;
            return Norma;
        }
    }
}
