using System;
using System.Windows.Forms;
using MATLAB_Library;

namespace DistribucionNormal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        //Inicializamos el uso de nuestras librerias
        readonly Basics MATLAB1 = new Basics();
        readonly Stadistics MATLAB2 = new Stadistics();

        private void BttnGrafica_Click(object sender, EventArgs e)
        {
            try
            {
                double paso = Convert.ToDouble(txtEspaciado.Text);

                txtEspaciado.Enabled = false;

                //Creamos el arreglo de nuestros datos
                double[] datos1 = { 169, 173, 168, 173, 162, 170, 171, 176, 169, 161 };
                double[] datos2 = { 241, 259, 251, 244, 242, 248, 259, 256, 241, 248 };
                Array.Sort(datos1);
                Array.Sort(datos2);

                //Obtenemos promedio y desviación estandar
                double prom1 = MATLAB2.Mean(datos1);
                double desv1 = MATLAB2.Std(datos1);
                double prom2 = MATLAB2.Mean(datos2);
                double desv2 = MATLAB2.Std(datos2);

                //Obtenemos el gráfico
                chart1.ChartAreas[0].AxisX.Minimum = (prom1 - (4 * desv1));     //Límites para el eje X
                chart1.ChartAreas[0].AxisX.Maximum = (prom2 + (4 * desv2));
                chart1.ChartAreas[0].AxisY.Minimum = 0;                       //Límites para el eje Y
                //chart1.ChartAreas[0].AxisY.Maximum = .1;

                //Creamos un nuevo arreglo con inicio y final para la distribución siendo mu-4sigma y mu+4sigma los límites
                double[] EjeX1 = MATLAB1.Linspace((prom1 - (4 * desv1)), (prom1 + (4 * desv1)), paso);
                double[] EjeX2 = MATLAB1.Linspace((prom2 - (4 * desv2)), (prom2 + (4 * desv2)), paso);

                //Obtenemos una nueva distribución ampliada en base a mu-4sigma y mu+4sigma
                double[] FX1 = MATLAB2.Normpdf(EjeX1, prom1, desv1);
                double[] FX2 = MATLAB2.Normpdf(EjeX2, prom2, desv2);

                //Mostramos los dartos en el gráfico
                for ( int i = 0; i < EjeX1.Length; i++)
                {
                    //Se realiza la primera distribución
                    chart1.Series[0].Points.AddXY(EjeX1[i], FX1[i]);
                    chart1.Update();
                    /*//Una vez que termina, se reposiciona el índice para graficar la siguiente distribución
                    if (i == EjeX1.Length-1)
                    {
                        for (i = 0; i <= EjeX2.Length; i++)
                        {
                            //Graficamos la siguiente distribucion
                            chart1.Series[1].Points.AddXY(EjeX2[i], FX2[i]);
                            chart1.Update();
                        }
                    }*/
                }
                for (int i = 0; i < EjeX2.Length; i++)
                {
                    //Graficamos la siguiente distribucion
                    chart1.Series[1].Points.AddXY(EjeX2[i], FX2[i]);
                    chart1.Update();
                }
            }

            catch
            {

            }
        }

        private void BttnClear_Click(object sender, EventArgs e)
        {
            try
            {
                //Limpiamos todos los cuadros de texto y las series del grafico
                txtEspaciado.Clear();
                chart1.Series[0].Points.Clear();
                chart1.Series[1].Points.Clear();
                txtLikelihood.Clear();
                txtLike1.Clear();
                txtLike2.Clear();
                txtEspaciado.Enabled = true;
            }

            catch
            {

            }
        }

        private void BttnLikelihood_Click(object sender, EventArgs e)
        {
            try
            {
                double paso = Convert.ToDouble(txtEspaciado.Text);
                double dato = Convert.ToDouble(txtLikelihood.Text);

                //Creamos el arreglo de nuestros datos
                double[] datos1 = { 169, 173, 168, 173, 162, 170, 171, 176, 169, 161 };
                double[] datos2 = { 241, 259, 251, 244, 242, 248, 259, 256, 241, 248 };
                Array.Sort(datos1);
                Array.Sort(datos2);

                //Obtenemos promedio y desviación estandar
                double prom1 = MATLAB2.Mean(datos1);
                double desv1 = MATLAB2.Std(datos1);
                double prom2 = MATLAB2.Mean(datos2);
                double desv2 = MATLAB2.Std(datos2);

                //Obtenemos y mostramos el likelihood
                double likelihood1 = MATLAB2.Normpdf(dato, prom1, desv1);
                double likelihood2 = MATLAB2.Normpdf(dato, prom2, desv2);
                txtLike1.Text = Convert.ToString(likelihood1);
                txtLike2.Text = Convert.ToString(likelihood2);
            }

            catch
            {

            }
        }

        private void BttnExit_Click(object sender, EventArgs e)
        {
            //Salimos de la aplicación
            Application.Exit();
        }
    }
}
