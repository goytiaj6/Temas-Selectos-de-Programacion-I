using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MATLAB_Library;

namespace DistribucionTomatesJitomates
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        //Instancia de nuestra libreria
        readonly Basics MATLAB1 = new Basics();
        readonly Stadistics MATLAB2 = new Stadistics();

        private void BttnGraficas_Click(object sender, EventArgs e)
        {
            //Para el jitomate
            double[] R1 = { 193, 195, 189, 195, 210, 192, 188, 254, 241, 224 };
            double[] G1 = { 4, 47, 3, 46, 26, 27, 51, 47, 25, 52 };
            double[] B1 = { 8, 45, 6, 42, 28, 42, 58, 5, 4, 16 };
            Array.Sort(R1);
            Array.Sort(G1);
            Array.Sort(B1);
            //Para el tomate
            double[] R2 = { 137, 147, 114, 129, 127, 140, 109, 108, 91, 82 };
            double[] G2 = { 181, 168, 144, 127, 176, 177, 142, 151, 128, 109 };
            double[] B2 = { 60, 75, 46, 48, 87, 108, 29, 9, 15, 30 };
            Array.Sort(R2);
            Array.Sort(G2);
            Array.Sort(B2);
            //Obtenemos los promedios y desviaciones estandar
            //Para el jitomate
            double mR1 = MATLAB2.Mean(R1);
            double desvR1 = MATLAB2.Std(R1);
            double mG1 = MATLAB2.Mean(G1);
            double desvG1 = MATLAB2.Std(G1);
            double mB1 = MATLAB2.Mean(B1);
            double desvB1 = MATLAB2.Std(B1);
            //Para el tomate
            double mR2 = MATLAB2.Mean(R2);
            double desvR2 = MATLAB2.Std(R2);
            double mG2 = MATLAB2.Mean(G2);
            double desvG2 = MATLAB2.Std(G2);
            double mB2 = MATLAB2.Mean(B2);
            double desvB2 = MATLAB2.Std(B2);
            //Creamos un nuevo arreglo con inicio y final para la distribución siendo mu-3sigma
            //y mu+3sigma los límites
            double[] XR1 = MATLAB1.Linspace((mR1 - (3 * desvR1)), (mR1 + (3 * desvR1)), 1);
            double[] XR2 = MATLAB1.Linspace((mR2 - (3 * desvR2)), (mR2 + (3 * desvR2)), 1);
            //Creamos un nuevo arreglo con inicio y final para la distribución siendo mu-3sigma
            //y mu+3sigma los límites
            double[] XG1 = MATLAB1.Linspace((mG1 - (3 * desvG1)), (mG1 + (3 * desvG1)), 1);
            double[] XG2 = MATLAB1.Linspace((mG2 - (3 * desvG2)), (mG2 + (3 * desvG2)), 1);
            //Creamos un nuevo arreglo con inicio y final para la distribución siendo mu-3sigma
            //y mu+3sigma los límites
            double[] XB1 = MATLAB1.Linspace((mB1 - (3 * desvB1)), (mB1 + (3 * desvB1)), 1);
            double[] XB2 = MATLAB1.Linspace((mB2 - (3 * desvB2)), (mB2 + (3 * desvB2)), 1);
            //Creamos las distribuciones
            //Para el rojo
            double[] FR1 = MATLAB2.Normpdf(XR1, mR1, desvR1);
            double[] FR2 = MATLAB2.Normpdf(XR2, mR2, desvR2);
            //Para el verde
            double[] FG1 = MATLAB2.Normpdf(XG1, mG1, desvG1);
            double[] FG2 = MATLAB2.Normpdf(XG2, mG2, desvG2);
            //Para el azul
            double[] FB1 = MATLAB2.Normpdf(XB1, mB1, desvB1);
            double[] FB2 = MATLAB2.Normpdf(XB2, mB2, desvB2);
            
            //Mostramos los datos en el gráfico para R
            for (int i = 0; i < XR1.Length; i++)
            {
                //Se realiza la primera distribución
                chart1.Series[0].Points.AddXY(XR1[i],FR1[i]);
                chart1.Update();
            }
            for (int i = 0; i < XR2.Length; i++)
            {
                //Graficamos la siguiente distribucion
                chart1.Series[1].Points.AddXY(XR2[i], FR2[i]);
                chart1.Update();
            }

            //Mostramos los datos en el gráfico para G
            for (int i = 0; i < XG1.Length; i++)
            {
                //Se realiza la primera distribución
                chart2.Series[0].Points.AddXY(XG1[i], FG1[i]);
                chart2.Update();
            }
            for (int i = 0; i < XG2.Length; i++)
            {
                //Graficamos la siguiente distribucion
                chart2.Series[1].Points.AddXY(XG2[i], FG2[i]);
                chart2.Update();
            }
            //Mostramos los datos en el gráfico para B
            for (int i = 0; i < XB1.Length; i++)
            {
                //Se realiza la primera distribución
                chart3.Series[0].Points.AddXY(XB1[i], FB1[i]);
                chart3.Update();
            }
            for (int i = 0; i < XB2.Length; i++)
            {
                //Graficamos la siguiente distribucion
                chart3.Series[1].Points.AddXY(XB2[i], FB2[i]);
                chart3.Update();
            }
        }

        private void BttnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
