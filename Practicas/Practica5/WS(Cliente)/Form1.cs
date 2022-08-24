using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WS_Cliente_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void BttnExit_Click(object sender, EventArgs e)
        {
            //Cerramos el programa
            Application.Exit();
        }

        private void BttnCalcular_Click(object sender, EventArgs e)
        {
            //Conversion de datos de los textBox
            double R1 = Convert.ToDouble(txtBoxR1.Text);
            double RF = Convert.ToDouble(txtBoxRF.Text);
            double Ve = Convert.ToDouble(txtBoxVe.Text);
            try
            {
                //Creamos la instancia de la WS creada
                using (WSAmpOp.WSAmpOpClient cliente = new WSAmpOp.WSAmpOpClient())
                {
                    //Usamos un var, ya que el amplificador es una clase dentro de nuestra WS
                    var AmpOp = cliente.Ganancia(R1, RF, Ve);
                    //Mostramos el voltaje de salida que se le asigna al amplificador en un textbox
                    txtBoxVs.Text = Convert.ToString(AmpOp.Vs);
                }
            }
            catch (Exception excepcion)
            {
                MessageBox.Show(excepcion.Message);
            }
        }
    }
}
