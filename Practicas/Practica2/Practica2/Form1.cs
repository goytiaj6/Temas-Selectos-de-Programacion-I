using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpreadsheetLight;
using SpreadsheetLight.Charts;
using MATLAB_Library;

namespace Practica2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();

            //Creamos las cabeceras para nuestros dados
            sl.SetCellValue("C2", "Iex[A]");
            sl.SetCellValue("D2", "VL (Calculado) [V]");
            sl.SetCellValue("E2", "VL (Iex ->) [V]");
            sl.SetCellValue("F2", "VL (Iex <-) [V]");
        }
        //Hacemos el llamado de la API/libreria del MIT para el manejo de archivos en Excel
        readonly SLDocument sl = new SLDocument();
        //Nuestra libreria
        readonly Basics MATLAB = new Basics();

        private void BttnExit_Click(object sender, EventArgs e)
        {
            //Cerramos la aplicacion
            Application.Exit();
        }

        private void BttnGG_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtBoxNombre.Text;
                //Dimensiones de aspecto para el gráfico
                double fChartHeight = 15.0;
                double fChartWidth = 7;

                //Creacion del objeto grafica de excel
                SLChart chart;

                //Modificaciones de los parametros de nuestro grafico a generar
                chart = sl.CreateChart("C2", "D15");
                chart.SetChartType(SLLineChartType.StackedLineWithMarkers);
                chart.SetChartStyle(SLChartStyle.Style5);
                chart.SetChartPosition(1, 9, 1 + fChartHeight, 9 + fChartWidth);
                sl.InsertChart(chart);

                //Guardado y nombrado de nuestro Excel creado
                sl.SaveAs(nombre + ".xlsx");

                MessageBox.Show("Archivo creado y guardado con exito");
            }
            catch
            {

            }
        }
        /*
        //Arreglos de datos leidos en prueba de laboratorio
        double[] Iex = new double[] { .48, .50, .60, .70, .80, .90, 1, 1.1, 1.2, 1.3, 1.4, 1.5, 1.6 };
        double[] VL1 = new double[] { 49, 50, 57, 65, 71, 80, 87, 98, 103, 108, 115, 118, 125 };
        double[] VL2 = new double[] { 52, 56, 64, 71, 78, 86, 94, 99, 105, 111, 115, 118, 125 };
        */
        //Arreglos de datos leidos en prueba de laboratorio
        readonly static double[] Iex = new double[13];
        readonly static double[] VL1 = new double[13];
        readonly static double[] VL2 = new double[13];

        //Índices para el menejo de la hoja de calculo
        readonly int jColumn1 = 3;
        readonly int jColumn4 = 4;
        readonly int jColumn2 = 5;
        readonly int jColumn3 = 6;
        int iRow = 3;
        int i = 0;

        private void BttnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if(i == Iex.Length)
                {
                    MessageBox.Show("Ya se han tomado todas las lecturas");
                }
                else
                {
                    //Conversion de los datos
                    double IexD = Convert.ToDouble(txtBoxIex.Text);
                    double VL1D = Convert.ToDouble(txtBoxVL1.Text);
                    double VL2D = Convert.ToDouble(txtBoxVL2.Text);
                    //Comenzamos a agregar los datos en los arreglos
                    Iex[i] = IexD;
                    VL1[i] = VL1D;
                    VL2[i] = VL2D;
                    //Insertamos la lectura de corriente
                    sl.SetCellValue(iRow, jColumn1, Iex[i]);
                    //Insertamos las lecturas de Voltaje con conrriente incremental
                    sl.SetCellValue(iRow, jColumn2, VL1[i]);
                    //Insertamos las lecturas de Voltaje con conrriente decremental
                    sl.SetCellValue(iRow, jColumn3, VL2[i]);
                    //Insertamos los valores calculados
                    double Calculo = Froelich(IexD);
                    sl.SetCellValue(iRow, jColumn4, Calculo);
                    iRow++;
                    i++;
                    //Se muestran los datos agregados
                    label10.Text = Convert.ToString(IexD);
                    label11.Text = Convert.ToString(VL1D);
                    label12.Text = Convert.ToString(VL2D);
                    label13.Text = Convert.ToString(Calculo);
                    //Limpiamos los campos
                    txtBoxIex.Clear();
                    txtBoxVL1.Clear();
                    txtBoxVL2.Clear();
                }
                
            }
            catch
            {

            }
        }

        /// <summary>
        /// Calculamos el voltaje de linea con la ecuacion de Froelich
        /// </summary>
        /// <param name="Iex"> Corriente leida </param>
        /// <returns></returns>
        private double Froelich(double Iex)
        {
            double output;
            output = ((MATLAB.Prod(2.542, Iex)) / (MATLAB.Sum(2.489, Iex))) * (125.664);
            output = Math.Round(output, 3);
            return output;
        }
    }
}
