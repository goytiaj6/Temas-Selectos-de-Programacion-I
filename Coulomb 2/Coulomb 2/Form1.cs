using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coulomb_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void bttnCalcular_Click(object sender, EventArgs e)
        {
            //Inicializamos las variables en 0
            double q1 = 0;
            double q2 = 0;
            double q3 = 0;
            double d = 0;
            double r = 0;

            try
            {
                //Se convierte los string de los textbox del form en valores tipo double
                q1 = Convert.ToDouble(textBoxQ1.Text);
                q2 = Convert.ToDouble(textBoxQ2.Text);
                q3 = Convert.ToDouble(textBoxQ3.Text);
                d = Convert.ToDouble(textBoxD.Text);
                r = Convert.ToDouble(textBoxR.Text);

                //Límites para el eje X
                chart1.ChartAreas[0].AxisX.Minimum = 0;
                chart1.ChartAreas[0].AxisX.Maximum = d;
                //Límites para el eje Y
                chart1.ChartAreas[0].AxisY.Minimum = -.2;
                chart1.ChartAreas[0].AxisY.Maximum = .2;

                //Colocación de las cargas en el gráfico
                chart1.Series[0].Points.AddXY(0, 0);
                chart1.Series[1].Points.AddXY(d, 0);
                chart1.Series[2].Points.AddXY(r, 0);

                //Llamamos a la función Formula para calcular las fuerzas f1 y f2 y obtener la resultante
                double Fuerza = Formula(q1, q2, q3, d, r);
                TextBoxFr.Visible = Enabled;

                //Convertimos en string para mostrar en interfaz
                TextBoxFr.Text = Convert.ToString(Fuerza);
            }

            catch
            {

            }
        }

        private void bttnReset_Click(object sender, EventArgs e)
        {
            //Se limpian todos los datos del grafico
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            chart1.Series[2].Points.Clear();
            //Se limpian todos los campos con texto
            textBoxQ1.Clear();
            textBoxQ2.Clear();
            textBoxQ3.Clear();
            textBoxD.Clear();
            textBoxR.Clear();
            TextBoxFr.Clear();
            TextBoxFr.Visible = false;
        }

        private void bttnExit_Click(object sender, EventArgs e)
        {
            //Salimos de la aplicación
            Application.Exit();
        }

        public double Formula(double a, double b, double c, double d, double r)
        {
            //Función para el cálculo de la fuerza de tipo double con valores normalizados
            double res1 = 0;
            double res2 = 0;
            res1 = (9 * Math.Pow(10, 9) * a * Math.Pow(10, -6) * c * Math.Pow(10, -6)) / (Math.Pow(r * Math.Pow(10, -3), 2));
            res2 = (9 * Math.Pow(10, 9) * c * Math.Pow(10, -6) * b * Math.Pow(10, -6)) / (Math.Pow((d-r) * Math.Pow(10, -3), 2));

            //Regresa el resultado calculado
            return res1 -res2;
        }
    }
}
