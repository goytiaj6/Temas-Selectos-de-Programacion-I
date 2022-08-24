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
using SpreadsheetLight;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_Normalization
{
    public partial class Form1 : Form
    {
        //Path del archivo Original .xlxs
        string ruta_Original;
        //Path del archivo Original .csv
        string ruta_Original_csv;
        //Path del archivo normalizado para entrenar.csv
        string ruta_Normalizados_csv;
        //Path que se debe cambiar en cada equipo donde se ejecute
        readonly string path = @"C:\Users\jorge\Documents\Facultad\SEM2022-1\Temas Selectos de Programación I\Data Normalization\Data Normalization\Files";
        //Definimos las variables de entradas, salidas y las muestras
        private int inputs;
        private int outputs;
        private readonly int Datas = 150;

        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void BttnSearchXLSX_Click(object sender, EventArgs e)
        {
            //Vemos los datos del excel original .xlxs 
            OpenFileDialog buscar = new OpenFileDialog();
            //Obtenemos la ruta del archivo
            if (buscar.ShowDialog() == DialogResult.OK)
            {
                ruta_Original = buscar.FileName;
            }
            pathXLSX.Text = ruta_Original;
        }

        private void BttnShowXLXS_Click(object sender, EventArgs e)
        {
            //Posicionamos en el segundo renglon de la hoja de calculo
            int iRow = 2;
            //Se despliega con Spreadsheets el excel orginal en el datagridview
            List<Data> lst = new List<Data>();

            SLDocument s1 = new SLDocument(ruta_Original);
            while (!string.IsNullOrEmpty(s1.GetCellValueAsString(iRow, 1)))
            {
                Data iris = new Data
                {
                    Sepal_Lenght = s1.GetCellValueAsString(iRow, 1),
                    Sepal_Width = s1.GetCellValueAsString(iRow, 2),
                    Petal_Lenght = s1.GetCellValueAsString(iRow, 3),
                    Petal_Width = s1.GetCellValueAsString(iRow, 4),
                    Class = s1.GetCellValueAsString(iRow, 5)
                };
                lst.Add(iris);
                iRow++;
            }
            dataGridView1.DataSource = lst;
        }

        private void BttnSearchOCSV_Click(object sender, EventArgs e)
        {
            OpenFileDialog buscar = new OpenFileDialog(); // obtener ruta del archivo que tendrá los datos originales del entrenamiento
            if (buscar.ShowDialog() == DialogResult.OK)
            {
                ruta_Original_csv = buscar.FileName;
            }
            pathOCSV.Text= ruta_Original_csv;
        }

        private void BttnSearchNCSV_Click(object sender, EventArgs e)
        {
            OpenFileDialog buscar = new OpenFileDialog(); // obtener ruta del archivo que tendrá los datos normalizados del entrenamiento
            if (buscar.ShowDialog() == DialogResult.OK)
            {
                ruta_Normalizados_csv = buscar.FileName;
            }
            pathNCSV.Text = ruta_Normalizados_csv;
        }

        private void BttnNormalize_Click(object sender, EventArgs e)
        {
            // Esto despliega el analisis de Encog y normaliza los datos despositnadolo en .CSV
            var sourceFile = new FileInfo(ruta_Original_csv);
            var targetFile = new FileInfo(ruta_Normalizados_csv);
            var Analisis = new FileInfo(path + "Analisis.html");
            var analyst = new EncogAnalyst();
            analyst.AddAnalystListener(new ConsoleAnalystListener());
            var wizard = new AnalystWizard(analyst);
            wizard.Wizard(sourceFile, true, AnalystFileFormat.DecpntComma);
            var report = new AnalystReport(analyst);
            report.ProduceReport(Analisis);

            inputs = analyst.DetermineInputCount();
            outputs = analyst.DetermineOutputCount();

            var norm = new AnalystNormalizeCSV();
            norm.Analyze(sourceFile, true, CSVFormat.English, analyst);
            norm.ProduceOutputHeaders = true;
            norm.Normalize(targetFile);
            MessageBox.Show("Analysis ready");
            MessageBox.Show("Inputs: " + Convert.ToString(inputs) + "  " + "Outputs: " + Convert.ToString(outputs));
        }

        private void BttnTrain_Click(object sender, EventArgs e)
        {
            // aqui se entrena a la neurona 
            var targetFile = new FileInfo(ruta_Normalizados_csv);
            //Neurona entrenada
            var NeuronaEntrenada = new FileInfo(path + "NeuronaEntrenada.eg");


            var csv = new ReadCSV(targetFile.ToString(), true, CSVFormat.DecimalPoint);
            double[][] Entradas = new double[Datas][];
            double[][] ideales = new double[Datas][];

            int con = 0;
            while (csv.Next())
            {
                double[] auxin = new double[inputs];
                double[] auxid = new double[outputs];
                for (int i = 0; i < inputs + outputs; i++)
                {
                    double n = Convert.ToDouble(csv.Get(i));
                    if (i < inputs)
                    {
                        auxin[i] = n;
                    }
                    else
                    {
                        auxid[i - inputs] = n;
                    }
                }
                Entradas[con] = auxin;
                ideales[con] = auxid;
                con++;
            }


            IMLDataSet Set_entreno = new BasicMLDataSet(Entradas, ideales);
            var red = new BasicNetwork();
            red.AddLayer(new BasicLayer(null, false, inputs));
            red.AddLayer(new BasicLayer(new ActivationTANH(), true, 6));
            red.AddLayer(new BasicLayer(new ActivationTANH(), true, outputs));
            red.Structure.FinalizeStructure();
            red.Reset();

            IMLTrain entreno = new ResilientPropagation(red, Set_entreno);

            int epoch = 1;
            do
            {
                entreno.Iteration();
                Console.WriteLine(@"Epoch #" + epoch + @" Error:" + entreno.Error);
                epoch++;
            } while (entreno.Error > 0.03);

            if (entreno.Error < 0.03)
                MessageBox.Show("Trained neural network");
            
            //Guardamos la neurona
            EncogDirectoryPersistence.SaveObject(NeuronaEntrenada, red);
        }

        private void BttnTesting_Click(object sender, EventArgs e)
        {
            try
            {
                //Esto es la implementacion de la neurona, he creado una funcion con la normalización porque no le entendí a Encog
                ClassPredicted.Text = " ";
                double sepal_lenght = Convert.ToDouble(SP.Text);
                double sepal_width = Convert.ToDouble(SW.Text);
                double petal_lenght = Convert.ToDouble(PL.Text);
                double petal_width = Convert.ToDouble(PW.Text);
                //Neurona entrenada
                var NeuronaEntrenada = new FileInfo(path + "NeuronaEntrenada.eg");
                Data data = new Data();

                double[][] entradas =  {
                new [] {data.Normalize(sepal_lenght, 1.0, -1.0, 7.9, 4.3),data.Normalize(sepal_width, 1.0, -1.0, 4.4, 2.0) ,data.Normalize(petal_lenght, 1.0, -1.0, 6.9, 1.0) ,data.Normalize(petal_width, 1.0, -1.0, 2.5, 0.1) }};

                //Aqui es donde usamos el archivo de entrenamiento para implementarla
                IMLData INPUT = new BasicMLData(entradas[0]);
                var red = (BasicNetwork)EncogDirectoryPersistence.LoadObject(NeuronaEntrenada);
                IMLData output = red.Compute(INPUT);
                //La linea de código debajo, nos permitio determinar mejor los rangos de valores para las salidas
                //MessageBox.Show(Convert.ToString(output[0]) + "  " + Convert.ToString(output[0]));
                EncogFramework.Instance.Shutdown();

                if (output[0] > -1 && output[0] < -0.5)
                {
                    if (output[1] > -0.8 && output[1] < -0.3)
                        ClassPredicted.Text = "iris-setosa";
                }
                if (output[0] < 1 && output[0] > 0.5)
                {
                    if (output[1] > -0.8 && output[1] < -0.3)
                        ClassPredicted.Text = "iris-versicolor";
                }
                if (output[0] > -0.3 && output[0] < 0.3)
                {
                    if (output[1] > 0.7 && output[1] < 1.3)
                        ClassPredicted.Text = "iris-virginica";
                }
            }
            catch
            {

            }
        }

        private void BttnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
