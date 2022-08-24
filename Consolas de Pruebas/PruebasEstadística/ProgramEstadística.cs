using MATLAB_Library;
using System;

namespace PruebasEstadística
{
    class ProgramEstadística
    {
        static void Main(string[] _)
        {
            
            //Prueba para obtener un promedio, desviacion estandar, varianza y distribución gaussiana de un conjunto de datos
            double[] datos_prom = {172, 170, 165, 170, 175, 170, 160, 178, 173, 160};
            double promedio = Math.Round(Mean(datos_prom), 5);
            double desviacion = Math.Round(Std(datos_prom), 5);
            double varianza = Math.Round(Var(datos_prom), 5);
            double[] distribucion = Normpdf(datos_prom, promedio, desviacion);

            //Prueba para obtener el likihood de un valor
            double dato = datos_prom[new Random().Next(0, datos_prom.Length)];
            double likelihood = Normpdf(dato, promedio, desviacion);
            /*
            Console.WriteLine("El promedio es: {0} cm\n", promedio);
            Console.WriteLine("La varianza es: {0} cm\n", varianza);
            Console.WriteLine("La desviación estandar es: {0} cm\n", desviacion);
            Console.WriteLine("La distribución gaussiana que se obtiene para estos datos es: \n");
            Basics.PrintArray(datos_prom);
            Basics.PrintArray(distribucion);
            Console.WriteLine("\nEl likelihood para el dato {0} cm, es: {1}", dato, likelihood);
            */
            double[] y = { 3, 5, 9, 10, 20, 21, 24, 24, 27, 35 };
            double[] x = { 100, 90, 80, 45, 50, 50, 60, 40, 25, 25 };
            var recta = Regression(x, y);
            Console.WriteLine("Arreglo de x:");
            Basics.PrintArray(x);
            Console.WriteLine("Arreglo de y:");
            Basics.PrintArray(y);
            Console.WriteLine("La ecuación de la recta obtenida por regresión lineal es: y = {0} + {1}x", recta.Item1, recta.Item2);
            Console.Read();
        }

        private static double Mean(double[] input)
        {
            //LLamado de nuestra libreria para funciones básicas
            Basics MATLAB = new Basics();
            double output;
            double suma = MATLAB.SumList(input);
            output = Math.Round(MATLAB.Div(suma, input.Length), 4);
            return output;
        }

        private static double Var(double[] input)
        {
            //LLamado de nuestra libreria para funciones básicas
            Basics MATLAB = new Basics();
            double output;
            double promedio = Mean(input);
            double n = input.Length;
            double suma = 0;

            for (int i = 0; i <= n - 1; i++)
            {
                suma = MATLAB.Sum(suma, Math.Pow(MATLAB.Resta(input[i], promedio), 2));
            }

            output = Math.Round(MATLAB.Div(suma, n), 4);
            return output;
        }

        private static double Std(double[] input)
        {
            double output = Math.Round(Math.Sqrt(Var(input)), 4);
            return output;
        }

        private static double[] Normpdf(double[] input, double mean, double std)
        {
            //LLamado de nuestra libreria para funciones básicas
            Basics MATLAB = new Basics();
            double exp;
            double fx;
            double[] output = new double[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                exp = MATLAB.Div(MATLAB.Prod(-1, Math.Pow(MATLAB.Resta(input[i], mean), 2)), MATLAB.Prod(2, Math.Pow(std, 2)));
                fx = MATLAB.Prod(MATLAB.Div(1, MATLAB.Prod(std, Math.Sqrt(MATLAB.Prod(2, Math.PI)))), Math.Exp(exp));
                output[i] = Math.Round(fx, 4);
            }

            return output;
        }

        private static double Normpdf(double input, double mean, double std)
        {
            //LLamado de nuestra libreria para funciones básicas
            Basics MATLAB = new Basics();
            double exp;
            double fx;
            double output;

            exp = MATLAB.Div(MATLAB.Prod(-1, Math.Pow(MATLAB.Resta(input, mean), 2)), MATLAB.Prod(2, Math.Pow(std, 2)));
            fx = MATLAB.Prod(MATLAB.Div(1, MATLAB.Prod(std, Math.Sqrt(MATLAB.Prod(2, Math.PI)))), Math.Exp(exp));
            output = Math.Round(fx, 4);

            return output;
        }

        private static Tuple<double, double> Regression(double[] input1, double[] input2)
        {
            //LLamado de nuestra libreria para funciones básicas
            Basics MATLAB = new Basics();
            //Numero de datos
            int n = input1.Length;
            //Para obtener la ordenada
            //Obtenemos la serie de x al cuadrado
            double[] XX = MATLAB.ProdArray(input1, input1);
            //Sumatoria de x al cuadrado
            double sumXX = MATLAB.SumList(XX);
            //Sumatoria de y
            double sumY = MATLAB.SumList(input2);
            //Obtenemos la serie de xy
            double[] XY = MATLAB.ProdArray(input1, input2);
            //Sumatoria de xy
            double sumXY = MATLAB.SumList(XY);
            //Sumatoria de x
            double sumX = MATLAB.SumList(input1);
            //Obtenemos la ordenada al origen
            double output1 = ((sumXX * sumY) - (sumXY * sumX)) / ((n * sumXX) - (Math.Pow(sumX, 2)));
            //Para obtener la pendiente
            //Promedio de x
            double MeanX = Mean(input1);
            //Promedio de y
            double MeanY = Mean(input2);
            //Obteniendo la pendiente
            double output2 = (sumXY - (n * MeanX * MeanY)) / (sumXX - ((Math.Pow(sumX, 2) / n)));
            output1 = Math.Round(output1, 4);
            output2 = Math.Round(output2, 4);

            return new Tuple<double, double>(output1, output2);
        }
    }
}
