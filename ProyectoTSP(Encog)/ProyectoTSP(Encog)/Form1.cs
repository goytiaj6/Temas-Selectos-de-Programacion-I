using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Windows.Forms;
using SpreadsheetLight;
using System.IO;

using Encog;
using Encog.App.Analyst;
using Encog.App.Analyst.CSV.Normalize;
using Encog.App.Analyst.Report;
using Encog.App.Analyst.Wizard;
using Encog.Engine.Network.Activation;
using Encog.ML.Data;
using Encog.ML.Data.Basic;
using Encog.ML.Train;
using Encog.Neural.Networks;
using Encog.Neural.Networks.Layers;
using Encog.Neural.Networks.Training.Propagation.Resilient;
using Encog.Persist;
using Encog.Util.CSV;
using System.Threading;

namespace ProyectoTSP_Encog_
{
    public partial class Form1 : Form
    {
        //Variables globales
        string MensajeSerial;
        int entradas;
        int salidas;
        readonly int datos = 100;
        int totales = 0;
        int totalesM = 0;
        int totalesN = 0;

        //Creamos un objeto de la clase paquete
        readonly Paquete paquete = new Paquete();
        //Path del archivo Original en formato .xlxs
        string PATHOriginalxlxs;
        //Path del archivo Original en formato .csv
        string PATHOriginalcsv;
        //Path del archivo Normalizado para entrenamiento en formato .csv
        string PATHNormalizadoscsv;
        //Path que debe cambiarse en cada equipo, por la direccion donde contenga los archivos
        readonly string path = @"C:\Users\jorge\Documents\Facultad\SEM2022-1\Temas Selectos de Programación I\ProyectoTSP(Encog)\ProyectoTSP(Encog)\Files";
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

        private void BttnExaminar_Click(object sender, EventArgs e)
        {
            // ver los datos del excel original .xlxs 
            OpenFileDialog buscar = new OpenFileDialog();
            // obtengo la ruta del excel
            if (buscar.ShowDialog() == DialogResult.OK)
            {
                PATHOriginalxlxs = buscar.FileName;
            }
            txtBoxPATH.Text = PATHOriginalxlxs;
        }

        private void BttnVisualizar_Click(object sender, EventArgs e)
        {
            //Dado que los archivo de Excel tienen cabeceras, empezamos en el segundo renglón
            int iRow = 2;
            //Se despliega con API de Spreadsheets el excel orginal en los dos gridviews 
            List<Paquete> lista = new List<Paquete>();
            //List<Paquete> PaquetesLista = new List<Paquete>();
            //Abrimos nuestro archivo de excel con el que se va a trabajar o extraer datos
            SLDocument s1 = new SLDocument(PATHOriginalxlxs);
            //Mientras no detectemos una celda vacia, vamos agregando paquetes a la lista
            while (!string.IsNullOrEmpty(s1.GetCellValueAsString(iRow, 1)))
            {
                Paquete paquete = new Paquete
                {
                    R = s1.GetCellValueAsString(iRow, 1),
                    G = s1.GetCellValueAsString(iRow, 2),
                    B = s1.GetCellValueAsString(iRow, 3),
                    Etiqueta = s1.GetCellValueAsString(iRow, 4)
                };

                lista.Add(paquete);
                iRow++;
            }
            //Mostramos la lista de paquetes
            dataGridView1.DataSource = lista;
        }

        private void BttnExaminar2_Click(object sender, EventArgs e)
        {
            //Obtenemos la ruta del archivo con los datos originales en CSV
            OpenFileDialog buscar = new OpenFileDialog();
            if (buscar.ShowDialog() == DialogResult.OK)
            {
                PATHOriginalcsv = buscar.FileName;
            }
            textBoxPATHCSVo.Text = PATHOriginalcsv;
        }

        private void BttnExaminar3_Click(object sender, EventArgs e)
        {
            //Obtenemos la ruta del archivo con los datos normalizados para el entrenemiento en CSV
            OpenFileDialog buscar = new OpenFileDialog();
            if (buscar.ShowDialog() == DialogResult.OK)
            {
                PATHNormalizadoscsv = buscar.FileName;
            }
            textBoxPATHCSVn.Text = PATHNormalizadoscsv;
        }

        private void BttnNormalizar_Click(object sender, EventArgs e)
        {
            //Esto despliega el analisis de Encog y normaliza los datos guardando todo en un .CSV
            var sourceFile = new FileInfo(PATHOriginalcsv);
            var targetFile = new FileInfo(PATHNormalizadoscsv);
            var Analisis = new FileInfo(path + "Analisis.html");
            var analyst = new EncogAnalyst();
            analyst.AddAnalystListener(new ConsoleAnalystListener());
            var wizard = new AnalystWizard(analyst);
            wizard.Wizard(sourceFile, true, AnalystFileFormat.DecpntComma);
            var report = new AnalystReport(analyst);
            report.ProduceReport(Analisis);

            entradas = analyst.DetermineInputCount();
            salidas = analyst.DetermineOutputCount();

            var norm = new AnalystNormalizeCSV();
            norm.Analyze(sourceFile, true, CSVFormat.English, analyst);
            norm.ProduceOutputHeaders = true;
            norm.Normalize(targetFile);
            MessageBox.Show("Analisis Listo");
            MessageBox.Show("Inputs: "+ Convert.ToString(entradas) + " Outputs: " + Convert.ToString(salidas));
        }

        private void BttnEntrenar_Click(object sender, EventArgs e)
        {
            //Realizamos el entrenamiento de nuestra red
            var targetFile = new FileInfo(PATHNormalizadoscsv);
            //Recuperamos los datos que genera Encog sobre nuestra neurona entrenada
            var NeuronaEntrenada = new FileInfo(path + "NeuronaEntrenada.eg");
            var csv = new ReadCSV(targetFile.ToString(), true, CSVFormat.English);
            double[][] Entradas = new double[datos][];
            double[][] ideales = new double[datos][];

            int contador = 0;
            while (csv.Next())
            {
                double[] auxin = new double[entradas];
                double[] auxid = new double[salidas];
                for (int i = 0; i < entradas + salidas; i++)
                {
                    double n = Convert.ToDouble(csv.Get(i));
                    if (i < entradas)
                    {
                        auxin[i] = n;
                    }
                    else
                    {
                        auxid[i - entradas] = n;
                    }
                }
                Entradas[contador] = auxin;
                ideales[contador] = auxid;
                contador++;
            }
            //Creamos el DataSet para rellenar nuestra red
            IMLDataSet Set_entreno = new BasicMLDataSet(Entradas, ideales);
            var red = new BasicNetwork();
            red.AddLayer(new BasicLayer(null, false, entradas));
            red.AddLayer(new BasicLayer(new ActivationTANH(), true, 4));
            red.AddLayer(new BasicLayer(new ActivationTANH(), true, salidas));
            red.Structure.FinalizeStructure();
            red.Reset();
            //Se realiza el entrenamiento
            IMLTrain entreno = new ResilientPropagation(red, Set_entreno);
            int epoch = 1;
            do
            {
                entreno.Iteration();
                Console.WriteLine(@"Epoch #" + epoch + @" Error:" + entreno.Error);
                epoch++;
            } while (entreno.Error > 0.01);

            if (entreno.Error < 0.01)
                MessageBox.Show("Red entrenada");
            //Guardamos la neurona
            EncogDirectoryPersistence.SaveObject(NeuronaEntrenada, red);
        }
        
        private void EscucharSerial()
        {
            while (!IsClosed)
            {
                try
                {
                    MensajeSerial = Arduino.ReadLine();
                    string[] valores = MensajeSerial.Split(',');
                    string[] valor = valores[3].Split('\r');
                    if (valores.Length == 4)
                    {
                        this.BeginInvoke(new EventHandler(delegate
                        {
                            if (MensajeSerial != null)
                            {
                                paquete.R = valores[0];
                                paquete.G = valores[1];
                                paquete.B = valores[2];
                                paquete.Tamaño = valores[3];

                                double[][] Arduino =  { new [] {paquete.Normalizar(Convert.ToDouble(paquete.R), 1.0, -1.0, 305.0, 25.0), paquete.Normalizar(Convert.ToDouble(paquete.G), 1.0, -1.0, 727.0, 90.0) , paquete.Normalizar(Convert.ToDouble(paquete.B), 1.0, -1.0, 317.0, 92.0) } };

                                IMLData Input = new BasicMLData(Arduino[0]);
                                //Ubicación de la red entrenada
                                var NeuronaEntrenada = new FileInfo(path + "NeuronaEntrenada.eg");
                                var red = (BasicNetwork)EncogDirectoryPersistence.LoadObject(NeuronaEntrenada);
                                IMLData output = red.Compute(Input);
                                EncogFramework.Instance.Shutdown();

                                //MessageBox.Show(output[0] + "  " + output[1]); //Con esto promabos los valores para definir los rangos
                                //Aqui comparamos las salidas de los datos normalizados mediante el calculo
                                if (output[0] < 1.5 && output[0] > 0.5 && output[1] > -1.5 && output[1] < -0.5)
                                {
                                    txtActualE.Text = "Morado";
                                    paquete.Etiqueta = "Morado";
                                    totalesM++;
                                    txtMorados.Text = Convert.ToString(totalesM);
                                    txtTamaño.Text = paquete.Tamaño;
                                }

                                if (output[0] > -1.5 && output[0] < -0.5 && output[1] < 1.5 && output[1] > 0.5)
                                {
                                    txtActualE.Text = "Naranja";
                                    paquete.Etiqueta = "Naranja";
                                    totalesN++;
                                    txtNaranjas.Text = Convert.ToString(totalesN);
                                    txtTamaño.Text = paquete.Tamaño;
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

        private void Form1_Load(object sender, EventArgs e)
        {
            Thread Hilo1 = new Thread(EscucharSerial);
            Hilo1.Start();
        }

        private void BttnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BttnConectarSerial_Click(object sender, EventArgs e)
        {
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
    }
}
