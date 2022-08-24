using MATLAB_Library;
using SpreadsheetLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrizErrores
{
    class MatrizErrores
    {
        static void Main(string[] _)
        {
            //Declaracion de MATLAB para el uso de la libreria
            Basics MATLAB = new Basics();
            //Hacemos el llamado de la API/libreria del MIT para el manejo de archivos en Excel
            SLDocument sl = new SLDocument();
            //Creamos el arreglo de elementos de X entre .1 y 1
            double[] X = MATLAB.Linspace(.1, 1, .1);
            //Declaramos los valores de pendientes y ordenadas al origen de cada una de las rectas
            //Primera recta (ideal)
            double m1 = 1;
            double b1 = 0;
            //Creamos el arreglo de la primera recta
            double[] y1 = MATLAB.ProdDot(X, m1); //Producto de la pendiente
            double[] Y1 = MATLAB.SumDot(y1, b1); //Sumando la ordenada
            //Tenemos la recta ideal creada
            //Creamos los índices de renglón y columna
            int iRow = 2;
            int jColumn = 2;
            //Indicamos la distribución de nuestra hoja de cálculo
            sl.SetCellValue("A1", "m2/b2");
            //Creamos las variables de pendiente y ordenada
            double m2;
            double b2;
            //Creamos las instancias para la creacion de la segunda recta
            double[] y2 = new double[Y1.Length];
            double[] Y2 = new double[Y1.Length];
            double error;
            //Creamos un ciclo para la creación de la segunda recta, teniendo dos ciclos,
            //uno para pendientes y otro para ordenadas
            //Comenzamos a rellenar la matriz
            for (m2 = -2; m2 <= 2; m2 += .1)
            {
                for(b2 = -2; b2 <= 2; b2 += .1)
                {
                    //Creamos el arreglo de la segunta recta
                    y2 = MATLAB.ProdDot(X, m2); //Producto de la pendiente
                    Y2 = MATLAB.SumDot(y2, b2); //Sumando la ordenada
                    error = MATLAB.ErrAccumPrc(Y1, Y2); //Se crea el error acumulado
                    sl.SetCellValue(iRow, jColumn, error);
                    jColumn++;
                }
                jColumn = 2;
                iRow++;
            }
            //Guardado y nombrado de nuestro Excel creado
            sl.SaveAs("MatrizDeErrores.xlsx");
            //Mensaje final del programa
            Console.WriteLine("Programa terminado, archivo creado con exito");
            Console.ReadLine();
        }
    }
}
