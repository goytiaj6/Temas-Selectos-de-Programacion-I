using System;
using System.Windows.Forms;
using System.IO.Ports; 

namespace Practica4
{
    public partial class Form1 : Form
    {
        //Creamos instancia para el puerto serial
        static SerialPort Arduino;

        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
            try
            {
                
                //Declaramos el puerto serial
                Arduino = new SerialPort
                {
                    PortName = "COM3",  //Se sustituye según el puerto donde se conecte el microcontrolador
                    BaudRate = 9600
                };
                //Abrimos la conexión al puerto serial
                Arduino.Open();
                //Vinculamos el evento de cerrar formulario
                this.FormClosing += Form1_FormClosing;
            }
            catch (Exception excepcion)
            {
                //Mensaje en caso de alguna excepcion
                MessageBox.Show(excepcion.Message);
            }
        }

        private void BttnExit_Click(object sender, EventArgs e)
        {
            //Se cierra el programa
            Application.Exit();
        }

        private void TrackBar1_Scroll(object sender, EventArgs e)
        {
            try
            {
                //Si la comunicación serial está abierta
                if (Arduino.IsOpen)
                {
                    //Numero de grados en trackbar
                    int grados = trackBar1.Value;
                    //Se envia el valor del ángulo a arduino
                    Arduino.Write(Convert.ToString(grados) + "\n");
                    //Mostramos debajo del trackbar el valor actual
                    label4.Text = "Actual: " + Convert.ToString(grados) + "°";
                }
            }
            catch (Exception excepcion)
            {
                //Mensaje en caso de alguna excepcion
                MessageBox.Show(excepcion.Message);
            }
        }

        private void BttnEnvio_Click(object sender, EventArgs e)
        {
            try
            {
                //Si la comunicación serial está abierta
                if (Arduino.IsOpen)
                {
                    //Numero de grados en textBox
                    string grados = txtAngulo.Text;
                    //Se envia el valor del ángulo a arduino
                    Arduino.Write(grados + "\n");
                    //Mostramos debajo del trackbar el valor actual (enviado)
                    label4.Text = "Actual: " + grados + "°";
                    //Movemos el trackBar hasta el valor enviado
                    trackBar1.Value = Convert.ToInt32(grados);
                }
            }
            catch (Exception excepcion)
            {
                //Mensaje en caso de alguna excepcion
                MessageBox.Show(excepcion.Message);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                //Si la comunicacion serial esta abierta
                if (Arduino.IsOpen)
                {
                    Arduino.Close(); //Se cierra la comunicacion serial
                }
            }
            catch (Exception excepcion)
            {
                //Mensaje en caso de alguna excepcion
                MessageBox.Show(excepcion.Message);
            }
        }
    }
}
