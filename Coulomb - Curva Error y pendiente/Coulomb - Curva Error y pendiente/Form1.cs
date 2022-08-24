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

namespace Coulomb___Curva_Error_y_pendiente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        readonly Basics MATLAB = new Basics();
        
        private void BttnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                //Se obtienen los datos de los textBox
                double q1 = Convert.ToDouble(txtBoxQ1.Text);
                double q2 = Convert.ToDouble(txtBoxQ2.Text);
                double q3 = Convert.ToDouble(txtBoxQ3.Text);
                double deseado = Convert.ToDouble(txtBoxDeseado.Text);
                double d = Convert.ToDouble(txtBoxD.Text);
                //Convertimos en microCoulomb
                q1 *= Math.Pow(10, -6);
                q2 *= Math.Pow(10, -6);
                q3 *= Math.Pow(10, -6);
                //Realizamos el arreglo de la distancia de q1 a q3
                double[] r1 = MATLAB.Linspace(.001, d-.001, .001);
                //Realizamos el arreglo de la distancia de q3 a q2
                double[] r2 = MATLAB.Linspace(d-.001, .001, .001);

                double[] F31, F32, FT, ECM, m;
                //Obtenemos las fuerzas en 3 debido a 1
                F31 = FuerzaVect(r1, q1, q3);
                //Obtenemos las fuerzas en 3 debido a 2
                F32 = FuerzaVect(r2, q2, q3);
                //Obtenemoslas fuerzas resultantes
                FT = MATLAB.DiffArray(F31, F32);
                //Calculamos el ECM para cada FT con el valor deseado
                ECM = MATLAB.ECM(FT, deseado);
                //Creamos el arreglo de las pendientes
                m = Pendientes(r1, ECM);
                //Mostramos los datos en los graficos
                for (int i = 0; i < ECM.Length; i++)
                {
                    //Mostramos las fuerzas resultantes
                    chart1.Series[0].Points.AddXY(r1[i], ECM[i] / Math.Pow(10, 10));
                    chart1.Update();
                }
                for (int i = 0; i < m.Length; i++)
                {
                    //Mostramos las pendientes
                    chart2.Series[0].Points.AddXY(r1[i], m[i] / Math.Pow(10, 10));
                    chart2.Update();
                }
            }
            catch
            {
                
            }
        }

        private void BttnClear_Click(object sender, EventArgs e)
        {
            //Se limpian todos los campos
            txtBoxQ1.Clear();
            txtBoxQ2.Clear();
            txtBoxQ3.Clear();
            txtBoxDeseado.Clear();
            txtBoxD.Clear();
            chart1.Series.Clear();
            chart2.Series.Clear();
        }

        private void BttnExit_Click(object sender, EventArgs e)
        {
            //Salimos de la aplicacion
            Application.Exit();
        }

        /// <summary>
        /// Calcula la fuerza electromotriz de manera puntual
        /// </summary>
        /// <param name="q"> Carga de referencia </param>
        /// <param name="q3"> Carga de prueba </param>
        /// <param name="r"> Distancia entre las cargas </param>
        /// <returns></returns>
        private double Fuerza(double q, double q3, double r)
        {
            double k = (9 * Math.Pow(10, 9));
            double FT = (k * q * q3) / (Math.Pow(r, 2));
            FT = Math.Round(FT, 4);
            return FT;
        }

        /// <summary>
        /// Genera un arreglo de fuerzas electromotrices
        /// </summary>
        /// <param name="r"> Distancias entre las cargas </param>
        /// <param name="q"> Carga de referencia </param>
        /// <param name="q3"> Carga de prueba </param>
        /// <returns></returns>
        private double[] FuerzaVect(double[] r, double q, double q3)
        {
            double[] output = new double[r.Length];
            for (int i = 0; i < r.Length; i++)
            {
                output[i] = Fuerza(q, q3, r[i]);
            }
            return output;
        }
        /// <summary>
        /// Genera un arrgelo que contenga las pendientes tantgentes a cada ECM
        /// </summary>
        /// <param name="r"> Distancias entre las cargas </param>
        /// <param name="errores"> Arreglo de ECM </param>
        /// <returns></returns>
        private double[] Pendientes(double[] r, double[] errores)
        {
            double[] m = new double[errores.Length - 1];
            for (int i = 0; i < errores.Length -1; i++)
            {
                m[i] = (errores[i+1] - errores[i]) / (r[i+1] - r[i]);
            }
            return m;
        }
    }
}
