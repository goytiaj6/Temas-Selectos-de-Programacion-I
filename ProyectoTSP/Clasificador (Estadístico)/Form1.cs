using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MATLAB_Library;

namespace Clasificador__Estadístico_
{
    public partial class Form1 : Form
    {
        //Variables globales
        //Creamos un objeto de la clase paquete
        readonly Paquete paquete = new Paquete();
        //Instancia de la libreria de estadistica
        readonly Stadistics funcion = new Stadistics();
        //Cadena para guardar el mensaje
        string MensajeSerial;
        int totales = 0;
        int totalesM = 0;
        int totalesN = 0;

        //Creamos los objetos de la clase frecuencia
        //Para el morado, con sus promedios y desviaciones por frecuencias
        readonly Frecuencia MR = new Frecuencia(204.46, 54.3117704);
        readonly Frecuencia MG = new Frecuencia(295.12, 93.1874756);
        readonly Frecuencia MB = new Frecuencia(163.1, 52.6574781);
        //Para el naranja, con sus promedios y desviaciones por frecuencias
        readonly Frecuencia NR = new Frecuencia(52.9, 21.7690147);
        readonly Frecuencia NG = new Frecuencia(174.1, 60.5419689);
        readonly Frecuencia NB = new Frecuencia(175.62, 57.0886644);

        //Creamos instancia para el puerto serial
        readonly SerialPort Arduino;
        //Condicional para cerrar la comunicacion serial
        bool IsClosed = false;

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
                //Vinculamos el evento de cerrar formulario
                this.FormClosing += Form1_FormClosing;
            }
            catch (Exception excepcion)
            {
                //Mensaje en caso de alguna excepcion
                MessageBox.Show(excepcion.Message);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Mientras el formulario esta cerrandose
            try
            {
                IsClosed = true;
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

        private void BttnConectarSerial_Click(object sender, EventArgs e)
        {
            //Iniciamos la conexion serial con arduino
            try
            {
                Arduino.PortName = "COM3";
                Arduino.BaudRate = 9600;
                //Abrimos la conexion serial
                Arduino.Open();
                bttnConectarSerial.Enabled = false;
                bttnDesconectarSerial.Enabled = true;
            }
            //Mensaje en caso de alguna excepcion
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void BttnDesconectarSerial_Click(object sender, EventArgs e)
        {
            //Terminamos la conexion serial con arduino
            try
            {
                //Cerramos la conexion serial
                Arduino.Close();
                bttnConectarSerial.Enabled = true;
                bttnDesconectarSerial.Enabled = false;

            }
            //Mensaje en caso de alguna excepcion
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void BttnExit_Click(object sender, EventArgs e)
        {
            //Cerramos el programa
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Trabajamos con Arduino en el hilo principal del programa
            Thread Hilo1 = new Thread(EscucharSerial);
            Hilo1.Start();
        }

        private void EscucharSerial()
        {
            //Mientras la comunicacion serial no este cerrada
            while (!IsClosed)
            {
                try
                {
                    //Guardamos la cadena de Arduino
                    MensajeSerial = Arduino.ReadLine();
                    //Separamos los valores mediante comas
                    string[] valores = MensajeSerial.Split(',');
                    //Si nuestro arreglo de valores está completo
                    if (valores.Length == 4)
                    {
                        //Aqui solucionamos nuestro problema de no recibir ni poder trabajar con los datos de Arduino
                        //Mientras estamos recibiendo los datos, los trabajamos de manera paralela
                        this.BeginInvoke(new EventHandler(delegate
                        {
                            if (MensajeSerial != null)
                            {
                                //Guardamos los valores del paquete
                                paquete.R = valores[0];
                                paquete.G = valores[1];
                                paquete.B = valores[2];
                                paquete.Tamaño = valores[3];

                                //Calculamos los likelihood de cada frecuencia, por colores
                                //Morado
                                double LMR = funcion.Normpdf(Convert.ToDouble(paquete.R), MR.Promedio, MR.Desviacion);
                                double LMG = funcion.Normpdf(Convert.ToDouble(paquete.G), MG.Promedio, MG.Desviacion);
                                double LMB = funcion.Normpdf(Convert.ToDouble(paquete.B), MB.Promedio, MB.Desviacion);
                                //Naranja
                                double LNR = funcion.Normpdf(Convert.ToDouble(paquete.R), NR.Promedio, NR.Desviacion);
                                double LNG = funcion.Normpdf(Convert.ToDouble(paquete.G), NG.Promedio, NG.Desviacion);
                                double LNB = funcion.Normpdf(Convert.ToDouble(paquete.B), NB.Promedio, NB.Desviacion);
                                //Obtenemos las probabilidades totales
                                double LM = LMR + LMG + LMB;
                                double LN = LNR + LNG + LNB;
                                //MessageBox.Show(LMR + "  " + LMG + "  " + LMB + "-" + LNR + "  " + LNG + "  " + LNB);
                                //MessageBox.Show(LM + "  " + LN);

                                //Aqui comparamos los resultados
                                //El caso de detectar un morado
                                if (LM > LN)
                                {
                                    txtActualE.Text = "Morado";
                                    paquete.Etiqueta = "Morado";
                                    totalesM++;
                                    txtMorados.Text = Convert.ToString(totalesM);
                                    txtTamaño.Text = paquete.Tamaño;
                                    Color.BackColor = System.Drawing.Color.Purple;
                                }
                                //Aqui comparamos los resultados
                                //El caso de detectar un naranja
                                if (LM < LN)
                                {
                                    txtActualE.Text = "Naranja";
                                    paquete.Etiqueta = "Naranja";
                                    totalesN++;
                                    txtNaranjas.Text = Convert.ToString(totalesN);
                                    txtTamaño.Text = paquete.Tamaño;
                                    Color.BackColor = System.Drawing.Color.Orange;
                                }
                            }
                            //Indicamos el total de paquetes sensados
                            totales++;
                            txtTotal.Text = Convert.ToString(totales);
                        }));
                    }
                }
                catch
                {

                }
            }
        }
    }
}
