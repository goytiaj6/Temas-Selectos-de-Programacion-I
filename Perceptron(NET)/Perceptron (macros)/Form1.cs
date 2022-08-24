using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perceptron__macros_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Patron1_Click(object sender, EventArgs e)
        {
            //Valor de X1 para el patron 1
            txtBoxX1.Text = txtX11.Text;
            //Valor de X2 para el patron 1
            txtBoxX2.Text = txtX12.Text;
            //Valor deseado para el patron 1
            txtBoxD.Text = txtD1.Text;
        }

        private void Patron2_Click(object sender, EventArgs e)
        {
            //Valor de X1 para el patron 
            txtBoxX1.Text = txtX21.Text;
            //Valor de X2 para el patron 2
            txtBoxX2.Text = txtX22.Text;
            //Valor deseado para el patron 2
            txtBoxD.Text = txtD2.Text;
        }

        private void Patron3_Click(object sender, EventArgs e)
        {
            //Valor de X1 para el patron 3
            txtBoxX1.Text = txtX31.Text;
            //Valor de X2 para el patron 3
            txtBoxX2.Text = txtX32.Text;
            //Valor deseado para el patron 3
            txtBoxD.Text = txtD3.Text;
        }

        private void Patron4_Click(object sender, EventArgs e)
        {
            //Valor de X1 para el patron 4
            txtBoxX1.Text = txtX41.Text;
            //Valor de X2 para el patron 4
            txtBoxX2.Text = txtX42.Text;
            //Valor deseado para el patron 4
            txtBoxD.Text = txtD4.Text;
        }

        private void TxtBoxBias_TextChanged(object sender, EventArgs e)
        {

        }

        private void Entrenamiento_Click(object sender, EventArgs e)
        {
            try
            {
                //Conversion de los datos contenidos en los textBox en tipo double
                double X1 = Convert.ToDouble(txtBoxX1.Text);
                double X2 = Convert.ToDouble(txtBoxX2.Text);
                double W1 = Convert.ToDouble(txtBoxW1.Text);
                double W2 = Convert.ToDouble(txtBoxW2.Text);
                double D = Convert.ToDouble(txtBoxD.Text);
                double bias = Convert.ToDouble(txtBoxBias.Text);
                double factor = Convert.ToDouble(txtBoxFactor.Text);
                //Se hace la suma ponderada dentro de la neurona
                double valor = Funcion(X1, X2, W1, W2, bias);
                txtBoxSuma.Text = Convert.ToString(valor);
                //Funcion de activacion
                double Y = Activacion(valor);
                txtBoxY.Text = Convert.ToString(Y);
                //Se calcula el error
                double error = Error(D, Y);
                txtError.Text = Convert.ToString(error);
                //Se calculan los deltas
                double delta1 = Delta(factor, error, X1);
                double delta2 = Delta(factor, error, X2);
                txtDelta1.Text = Convert.ToString(delta1);
                txtDelta2.Text = Convert.ToString(delta2);
                //Se recalculan los pesos
                W1 += delta1;
                W2 += delta2;
                txtNW1.Text = Convert.ToString(W1);
                txtNW2.Text = Convert.ToString(W2);
                //Se recalcula el bias
                bias += -(factor * error);
                txtNBias.Text = Convert.ToString(bias);
            }
            catch
            {

            }
        }

        private void Actualizar_Click(object sender, EventArgs e)
        {
            try
            {
                //Se reasignas los valores calculados a las celdas correspondientes
                txtBoxW1.Text = txtNW1.Text;
                txtBoxW2.Text = txtNW2.Text;
                txtBoxBias.Text = txtNBias.Text;
            }
            catch
            {

            }
        }

        /// <summary>
        /// Calcula la suma ponderadadentro de la neurona
        /// </summary>
        /// <param name="x1"> Entrada 1 </param>
        /// <param name="x2"> Entrada 2 </param>
        /// <param name="w1"> Peso de la entrada 1 </param>
        /// <param name="w2"> Peso de la entrada 2 </param>
        /// <param name="bias"> Sesgo </param>
        /// <returns> Suma </returns>
        public double Funcion(double x1, double x2, double w1, double w2, double bias)
        {
            double output;
            output = (x1 * w1) + (x2 * w2) - bias;
            output = Math.Round(output, 4);
            return output;
        }

        /// <summary>
        /// Funcion de activacion tipo escalon
        /// </summary>
        /// <param name="valor"> Resultado de la suma ponderada </param>
        /// <returns> Uno o Cero </returns>
        public double Activacion(double valor)
        {
            double output;
            if (valor >= 0)
                output = 1;
            else
                output = 0;
            return output;
        }

        /// <summary>
        /// Calcula el error de la salida del entrenamiento segun el valor deseado
        /// </summary>
        /// <param name="deseado"> Valor deseado </param>
        /// <param name="y"> Salida final por la funcion de activacion </param>
        /// <returns> Diferencia D-Y </returns>
        public double Error(double deseado, double y)
        {
            double output;
            output = deseado - y;
            return output;
        }

        /// <summary>
        /// Se calcula el valor delta para recalcular los pesos
        /// </summary>
        /// <param name="factor"> Factor de aprendizaje </param>
        /// <param name="error"> Error calculado </param>
        /// <param name="x"> Valor de la entrada asociada al peso a calcular </param>
        /// <returns> Constante para recalcular pesos </returns>
        public double Delta(double factor, double error, double x)
        {
            double output;
            output = factor * error * x;
            output = Math.Round(output, 4);
            return output;
        }
    }
}
