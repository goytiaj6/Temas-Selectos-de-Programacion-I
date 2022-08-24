using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coulomb1
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

        private void bttnCalcular_Click(object sender, EventArgs e)
        {
            //Inicializamos las variables en 0
            double q1 = 0;
            double q2 = 0;
            double q3 = 0;
            double dist = 0;

            try
            {
                //Se convierte los string de los textbox del form en double
                q1 = Convert.ToDouble(txtboxq1.Text);
                q2 = Convert.ToDouble(txtboxq2.Text);
                q3 = Convert.ToDouble(txtboxq3.Text);
                dist = Convert.ToDouble(txtboxdist.Text);

                //Límites para el eje X
                chart1.ChartAreas[0].AxisX.Minimum = 0;
                chart1.ChartAreas[0].AxisX.Maximum = dist;
                //Límites para el eje Y
                chart1.ChartAreas[0].AxisY.Minimum = -.2;
                chart1.ChartAreas[0].AxisY.Maximum = .2;

                //Colocación de las cargas en el gráfico
                chart1.Series[0].Points.AddXY(0, 0);
                chart1.Series[1].Points.AddXY(dist, 0);
                chart1.Series[2].Points.AddXY(dist / 2, 0);

                //Llamamos a la función Formula para calcular las fuerzas f1 y f2
                double f31 = Formula(q1, q3, dist);
                double f32 = Formula(q3, q2, dist);

                //Se calcula la resultante
                double Fuerza = f31 - f32;

                txtboxFr.Visible = Enabled;
                //Convertimos en string para mostrar en interfaz
                txtboxFr.Text = Convert.ToString(Fuerza);
            }

            catch
            {

            }
        }

        private void bttnReset_Click(object sender, EventArgs e)
        {
            //Se limpian todos los campos del chart
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            chart1.Series[2].Points.Clear();
            //Se limpian todos los campos con texto
            txtboxq1.Clear();
            txtboxq2.Clear();
            txtboxq3.Clear();
            txtboxdist.Clear();
            txtboxFr.Clear();
            txtboxFr.Visible = false;   
        }

        private void bttnExit_Click(object sender, EventArgs e)
        {
            //Salimos de la aplicación
            Application.Exit();
        }

        public double Formula(double a, double b, double d)
        {
            //Función para el cálculo de la fuerza de  tipo double con valores normalizados
            double res = 0;
            res = (9*Math.Pow(10, 9) * a*Math.Pow(10,-6) * b*Math.Pow(10,-6)) / (Math.Pow((d*Math.Pow(10,-3) / 2),2));

            return res;       //Regresa el resultado calculado
        }
    }
}
