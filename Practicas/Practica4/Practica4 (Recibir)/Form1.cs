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

namespace Practica4__Recibir_
{
    public partial class Form1 : Form
    {
        //Variables globales
        string MensajeSerial;
        //Creamos instancia para el puerto serial
        readonly SerialPort Arduino;
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

        private void BttnConectar_Click(object sender, EventArgs e)
        {
            try
            {
                Arduino.PortName = "COM3";
                Arduino.BaudRate = 9600;
                //Abrimos la conexion serial
                Arduino.Open();
                bttnConectar.Enabled = false;
                bttnDesconectar.Enabled = true;
            }
            //Mensaje en caso de alguna excepcion
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void BttnDesconectar_Click(object sender, EventArgs e)
        {
            try
            {
                //Cerramos la conexion serial
                Arduino.Close();
                bttnConectar.Enabled = true;
                bttnDesconectar.Enabled = false;

            }
            //Mensaje en caso de alguna excepcion
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void BttnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void EscucharSerial()
        {
            //Mientras la comunicacion serial no este cerrada
            while (!IsClosed)
            {
                try
                {
                    //Leemos la comunicación serial de arduino
                    MensajeSerial = Arduino.ReadLine();
                    //Separamos los valores por comas y los guardamos en un arreglo
                    string[] valores = MensajeSerial.Split(',');
                    //Indicamos el valor final de la cadena
                    string[] valor = valores[2].Split('\r');

                    if(valores.Length == 3)
                    {
                        //ejecutamos otro delegado para poder procesar la informacion al momento de recibirla
                        this.BeginInvoke(new EventHandler(delegate
                        {
                            if (MensajeSerial != null)
                            {
                                //Mostramos los valores separados
                                txtBoxR.Text = valores[0];
                                txtBoxG.Text = valores[1];
                                txtBoxB.Text = valores[2];
                            }
                        }));
                    }
                }
                catch
                {

                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Traemos la informacion del arduino al hilo principal del programa
            Thread Hilo = new Thread(EscucharSerial);
            Hilo.Start();
        }
    }
}
