using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MATLAB_Library;

namespace Coulomb_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        //Instancia de la libreria
        readonly Basics MATLAB = new Basics();
        private void BttnCalcular_Click(object sender, EventArgs e)
        {
            //Conversión de las entradas en double
            double q1 = Convert.ToDouble(textBoxQ1.Text) * Math.Pow(10, -6);
            double q2 = Convert.ToDouble(textBoxQ2.Text) * Math.Pow(10, -6);
            double q3 = Convert.ToDouble(textBoxQ3.Text) * Math.Pow(10, -6);
            double d = Convert.ToDouble(textBoxD.Text);
            //Realizamos el arreglo de la distancia de q1 a q3
            double[] r1 = MATLAB.Linspace(.001, d - .001, .001);
            //Realizamos el arreglo de la distancia de q3 a q2
            double[] r2 = MATLAB.Linspace(d - .001, .001, .001);
            //Calculamos las fuerzas
            double[] F31 = FuerzaVect(r1, q3, q1);
            double[] F32 = FuerzaVect(r2, q3, q2);
            //Fuerza total
            double[] FT = MATLAB.DiffArray(F31, F32);
            //Mostramos el grafico
            for (int i = 0; i < r1.Length; i++)
            {
                chart1.Series[0].Points.AddXY(r1[i], FT[i]);
                chart1.Update();
            }
        }

        private void BttnReset_Click(object sender, EventArgs e)
        {
            //Limpiamos los cuadros de texto
            textBoxQ1.Clear();
            textBoxQ2.Clear();
            textBoxQ3.Clear();
            textBoxD.Clear();

            //Limpiamos los datos del chart
            //chart1.Series.Clear();
        }

        private void BttnExit_Click(object sender, EventArgs e)
        {
            //Cerramos la aplicación
            Application.Exit();
        }

        private double Fuerza(double q, double q3, double r)
        {
            double k = (9 * Math.Pow(10, 9));
            double FT = (k * q * q3) / (Math.Pow(r, 2));

            return FT;
        }

        private double[] FuerzaVect(double[] a, double q, double q3)
        {
            double[] output = new double[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                output[i] = Fuerza(q, q3, a[i]);
                output[i] = Math.Round(output[i], 4);
            }
            return output;
        }
    }
}
