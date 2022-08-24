using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Windows.Forms;
using System.IO;

using Encog;
using Encog.ML.Data;
using Encog.ML.Data.Basic;
using Encog.Neural.Networks;
using Encog.Persist;
using System.Threading;

namespace Clasificador_Encog_
{
    public partial class Form1 : Form
    {
        //Variables globales
        //Cadena para guardar el mensaje
        string MensajeSerial;
        int totales = 0;
        int totalesM = 0;
        int totalesN = 0;

        //Creamos un objeto de la clase paquete
        readonly Paquete paquete = new Paquete();
        //Path que debe cambiarse en cada equipo, por la direccion donde contenga los archivos para la normalizacion
        //y analisis con Encog
        readonly string path = @"C:\Users\jorge\Documents\Facultad\SEM2022-1\Temas Selectos de Programación I\ProyectoTSP(Encog)\ProyectoTSP(Encog)\Files";
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
            //Mientras el formulario está cerrandose
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
            //Terminamos la conexion serial con Arduino
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
                    string[] valores = MensajeSerial.Split(',');
                    //string[] valor = valores[3].Split('\r');
                    if (valores.Length == 4)
                    {
                        //Aqui solucionamos nuestro problema de no recibir ni poder trabajar con los datos de Arduino
                        //Mientras estamos recibiendo los datos, los trabajamos de forma paralela
                        this.BeginInvoke(new EventHandler(delegate
                        {
                            if (MensajeSerial != null)
                            {
                                //Guardamos los valores del paquete
                                paquete.R = valores[0];
                                paquete.G = valores[1];
                                paquete.B = valores[2];
                                paquete.Tamaño = valores[3];
                                //Generamos la matriz de datos normalizados para computar las entradas de la red
                                double[][] Arduino = { new[] { paquete.Normalizar(Convert.ToDouble(paquete.R), 1.0, -1.0, 305.0, 25.0), paquete.Normalizar(Convert.ToDouble(paquete.G), 1.0, -1.0, 727.0, 90.0), paquete.Normalizar(Convert.ToDouble(paquete.B), 1.0, -1.0, 317.0, 92.0) } };
                                //Generamos las entradas de la red neuronal recibiendo los datos la matriz Arduino
                                IMLData Input = new BasicMLData(Arduino[0]);
                                //Ubicación de la red entrenada junto con su nombre
                                var NeuronaEntrenada = new FileInfo(path + "NeuronaEntrenada.eg");
                                //Creamos la red neruonal cargando los datos del archivo .eg
                                var red = (BasicNetwork)EncogDirectoryPersistence.LoadObject(NeuronaEntrenada);
                                //Generamos las salidas de la red computando las entradas obtenidas
                                IMLData output = red.Compute(Input);
                                //Cerramos la red neuronal
                                EncogFramework.Instance.Shutdown();
                                //Con esto probamos los valores para definir los rangos
                                //MessageBox.Show(output[0] + "  " + output[1]);

                                //Aqui comparamos las salidas de los datos normalizados por el calculo de la red
                                if (output[0] < 1.5 && output[0] > 0.5 && output[1] > -1.5 && output[1] < -0.5)
                                {
                                    txtActualE.Text = "Morado";
                                    paquete.Etiqueta = "Morado";
                                    totalesM++;
                                    txtMorados.Text = Convert.ToString(totalesM);
                                    txtTamaño.Text = paquete.Tamaño;
                                    Color.BackColor = System.Drawing.Color.Purple;
                                }
                                //Aqui comparamos las salidas de los datos normalizados por el calculo de la red
                                if (output[0] > -1.5 && output[0] < -0.5 && output[1] < 1.5 && output[1] > 0.5)
                                {
                                    txtActualE.Text = "Naranja";
                                    paquete.Etiqueta = "Naranja";
                                    totalesN++;
                                    txtNaranjas.Text = Convert.ToString(totalesN);
                                    txtTamaño.Text = paquete.Tamaño;
                                    Color.BackColor = System.Drawing.Color.Orange;
                                }
                            }
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

        private void Label3_Click(object sender, EventArgs e)
        {

        }
    }
}
