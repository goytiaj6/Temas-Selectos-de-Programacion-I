using System;
using MATLAB_Library;

namespace Pruebas
{
    class BarridoyErroresCargas
    {
        static void Main(string[] _)
        {
            //Llamamos a nuestra biblioteca
            Basics prueba = new Basics();

            //Console.Write("Hola Mundo");
            //Console.ReadLine();

            //Entradas
            double q1 = 8 * Math.Pow(10, -6);
            double q2 = 6 * Math.Pow(10, -6);
            double q3 = 7 * Math.Pow(10, -6);

            Console.WriteLine("\nEl valor de q1 es: {0} C", q1);
            Console.WriteLine("\nEl valor de q2 es: {0} C", q2);
            Console.WriteLine("\nEl valor de q3 es: {0} C", q3);

            double[] r1 = prueba.Linspace(0, .12, .001); //Se prueba la función de linspace con primer y ultimo dato de vector, con escalon
            double[] r2 = prueba.Linspace(.12, 0, .001);
            
            double[] F13 = FuerzaVect(r1, q1, q3);
            double[] F23 = FuerzaVect(r2, q2, q3);

            Console.WriteLine("\nVector resultante r1: ");
            Basics.PrintArray(r1);
            Console.WriteLine("\nVector resultante r2: ");
            Basics.PrintArray(r2);
            Console.WriteLine("Fuerza en 3 debido a 1: ");
            Basics.PrintArrayE(F13);
            Console.WriteLine("Fuerza en 3 debido a 2: ");
            Basics.PrintArrayE(F23);
            //Console.WriteLine("Vector resultante: [" + String.Join(", ", F13) + "]");
            //Console.WriteLine("Vector resultante: [" + String.Join("  ", F23) + "]");
            //Console.WriteLine("Vector resultante: " + String.Join(" ", array4));

            double[] FT = prueba.DiffArray(F13, F23);
            Console.WriteLine("Arreglo de fuerzas totales: ");
            Basics.PrintArrayE(FT);

            double[] EC = prueba.ECM(FT, 35);
            Console.WriteLine("Arreglo de errores cuadráticos: ");
            Basics.PrintArrayE(EC);

            Console.Read();
        }
        
        //Clase martes 14 de septiembre
        private static double Fuerza(double q, double q3, double r)
        {
            double k = (9 * Math.Pow(10, 9));
            double FT = (k* q * q3) / (Math.Pow(r, 2));

            return FT;
        }

        private static double[]FuerzaVect(double[] a, double q, double q3)
        {
            double[] output = new double[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                output[i] = Fuerza(q, q3, a[i]);
            }
            return output;
        }
    }
}
