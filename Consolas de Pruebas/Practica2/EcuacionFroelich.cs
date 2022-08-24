using System;
using SpreadsheetLight;
using SpreadsheetLight.Charts;
using MATLAB_Library;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] _)
        {
            //Hacemos el llamado de la API/libreria del MIT para el manejo de archivos en Excel
            SLDocument sl = new SLDocument();
            //Nuestra libreria
            Basics MATLAB = new Basics();

            //Creamos las cabeceras para nuestros dados
            sl.SetCellValue("C2", "Iex[A]");
            sl.SetCellValue("D2", "VL (Calculado) [V]");
            sl.SetCellValue("E2", "VL (Iex ->) [V]");
            sl.SetCellValue("F2", "VL (Iex <-) [V]");

            //Arreglos de datos leidos en prueba de laboratorio
            double[] Iex = new double[] { .48, .50, .60, .70, .80, .90, 1, 1.1, 1.2, 1.3, 1.4, 1.5, 1.6 };
            double[] VL1 = new double[] { 49, 50, 57, 65, 71, 80, 87, 98, 103, 108, 115, 118, 125 };
            double[] VL2 = new double[] { 52, 56, 64, 71, 78, 86, 94, 99, 105, 111, 115, 118, 125 };

            //Insertamos las lecturas de corriente
            int jColumn = 3;
            int iRow = 3;
            for (int i = 0; i < Iex.Length; ++i)
            {
                sl.SetCellValue(iRow, jColumn, Iex[i]);
                iRow++;
            }

            //Insertamos las lecturas de Voltaje con conrriente incremental
            jColumn = 5;
            iRow = 3;
            for (int i = 0; i < VL1.Length; ++i)
            {
                sl.SetCellValue(iRow, jColumn, VL1[i]);
                iRow++;
            }

            //Insertamos las lecturas de Voltaje con conrriente decremental
            jColumn = 6;
            iRow = 3;
            for (int i = 0; i < VL2.Length; ++i)
            {
                sl.SetCellValue(iRow, jColumn, VL2[i]);
                iRow++;
            }

            //Insertamos los valores calculados
            jColumn = 4;
            iRow = 3;
            for (int i = 0; i < Iex.Length; ++i)
            {
                double Calculo = ((MATLAB.Prod(2.542, Iex[i]))/(MATLAB.Sum(2.489,Iex[i]))) * (125.664);
                sl.SetCellValue(iRow, jColumn, Calculo);
                iRow++;
            }

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
            sl.SaveAs("GraficaVacio.xlsx");

            Console.WriteLine("Programa terminado, archivo creado con exito");
            Console.ReadLine();
        }
    }
}
