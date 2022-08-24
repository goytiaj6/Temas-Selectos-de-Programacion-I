using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Normalization
{
    class Data
    {
        public string Sepal_Lenght { get; set; }
        public string Sepal_Width { get; set; }
        public string Petal_Lenght { get; set; }
        public string Petal_Width { get; set; }
        public string Class { get; set; }

        public double Normalize(double valor_norm, double nH, double nL, double dH, double dL)
        {
            double Norma = (((valor_norm - dL) * (nH - nL)) / (dH - dL)) + nL;
            return Norma;
        }
    }
}
