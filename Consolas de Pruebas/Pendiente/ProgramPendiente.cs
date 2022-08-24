using MATLAB_Library;
using System;

namespace Pendiente
{
    class ProgramPendiente
    {
        static void Main(string[] _)
        {
            //Declaracion de MATLAB para el uso de la libreria
            Basics MATLAB = new Basics();
            //Creamos el arreglo de elementos de X entre .1 y 1
            double[] X = MATLAB.Linspace(.1, 1, .1);

            //Declaramos los valores de pendientes y ordenadas al origen de cada una de las rectas
            //Primera recta (ideal)
            double m1 = 1;
            double b1 = 0;

            //Segunda recta
            double m2 = .1;
            double b2 = 0;

            //Creamos el arreglo de la primera recta
            double[] y1 = MATLAB.ProdDot(X, m1); //Producto de la pendiente
            double[] Y1 = MATLAB.SumDot(y1, b1); //Sumando la ordenada

            //Creamos el arreglo de la segunta recta
            double[] y2 = MATLAB.ProdDot(X, m2); //Producto de la pendiente
            double[] Y2 = MATLAB.SumDot(y2, b2); //Sumando la ordenada

            //Creamos el arreglo de los errores porcentuales
            double[] errores = MATLAB.ErrorPrc(y1, y2);

            //Suma total de los errores porcentuales
            double sumaErrores = MATLAB.SumList(errores);
            /*
            Console.WriteLine("Arreglo de X: ");
            Basics.PrintArray(X);
            Console.WriteLine("Arreglo de Y1: ");
            Basics.PrintArray(Y1);
            Console.WriteLine("Arreglo de Y2: ");
            Basics.PrintArray(Y2);
            Console.WriteLine("Arreglo de errores: ");
            Basics.PrintArray(errores);
            Console.WriteLine("Errores totales: {0}\n", sumaErrores);
            */
            //Prueba Descenso
            double punto = -2; //Valor para la pendiente
            double paso = .1;
            //Mostramos el arreglo buscado
            Console.WriteLine("Arreglo ideal: ");
            Basics.PrintArray(Y1);
            //Mostramos los valores ideales para el arreglo de datos que se busca
            Console.WriteLine("Pendiente ideal: {0}\nOrdenada ideal: {1}\nOrdenada de recta de prueba: {2}\n", m1, b1, b2);
            //Hacemos el descenso
            MATLAB.Descenso(punto, b2, X, Y1, paso);

            Console.Read();
        }
    }
}
