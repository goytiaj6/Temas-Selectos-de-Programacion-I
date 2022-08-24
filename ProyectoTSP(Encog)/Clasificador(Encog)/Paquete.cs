using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clasificador_Encog_
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
        /// <param name="valor"> Dato de entrada a normalizar </param>
        /// <param name="nH"> Valor alto de normalización (1)</param>
        /// <param name="nL"> Valor bajo de normalización (-1)</param>
        /// <param name="dH"> Valor máximo que puede tener el dato </param>
        /// <param name="dL"> Valor mínimo que puede tener el dato </param>
        /// <returns></returns>
        public double Normalizar(double valor, double nH, double nL, double dH, double dL)
        {
            double output = (((valor - dL) * (nH - nL)) / (dH - dL)) + nL;
            output = Math.Round(output, 4);
            return output;
        }
    }
}
