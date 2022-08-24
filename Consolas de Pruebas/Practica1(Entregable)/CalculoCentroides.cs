using MATLAB_Library;
using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Practica1_Entregable
{
    class CalculoCentroides
    {
        static async Task Main(string[] _)
        {
            //---------------------------------------------------------------------------------------------------------------------------------
            //Forma lineal
            //Declaramos el uso de reloj interno
            Stopwatch tiempo = new Stopwatch();
            //Iniciamos el reloj
            tiempo.Start();

            var fig1 = Rectangulo();
            var fig2 = Semicirculo1();
            var fig3 = Semicirculo2();
            var fig4 = Cuadrado();

            double SumaAreas = fig1.Item1 - fig2.Item1 - fig3.Item1 + fig4.Item1;
            double SumaXA = fig1.Item2 - fig2.Item2 - fig3.Item2 + fig4.Item2;
            double SumaYA = fig1.Item3 - fig2.Item3 - fig3.Item3 + fig4.Item3;

            double CX = SumaXA / SumaAreas;
            double CY = SumaYA / SumaAreas;

            tiempo.Stop();

            Console.WriteLine("\n\nForma lineal");
            //Console.WriteLine("\nRectangulo:\nArea: " + fig1.Item1 + "\nXa: " + fig1.Item2 + "\nYa: " + fig1.Item3);
            //Console.WriteLine("\nSemicirculo1:\nArea: " + fig2.Item1 + "\nXa: " + fig2.Item2 + "\nYa: " + fig2.Item3);
            //Console.WriteLine("\nSemicirculo2\nArea: " + fig3.Item1 + "\nXa: " + fig3.Item2 + "\nYa: " + fig3.Item3);
            //Console.WriteLine("\nCuadrado\nArea: " + fig4.Item1 + "\nXa: " + fig4.Item2 + "\nYa: " + fig4.Item3);
            Console.WriteLine("Suma de areas: " + SumaAreas);
            Console.WriteLine("Centroide en X: " + CX + "\nCentroide en Y: " + CY);

            //-----------------------------------------------------------------------------------------------------------------------------------------
            //Forma concurrente1
            Stopwatch tiempo1 = new Stopwatch();
            tiempo1.Start();

            Task<Tuple<double, double, double>> figura1 = new Task<Tuple<double, double, double>>(Rectangulo);
            Task<Tuple<double, double, double>> figura2 = new Task<Tuple<double, double, double>>(Semicirculo1);
            Task<Tuple<double, double, double>> figura3 = new Task<Tuple<double, double, double>>(Semicirculo2);
            Task<Tuple<double, double, double>> figura4 = new Task<Tuple<double, double, double>>(Cuadrado);

            figura1.Start();
            figura2.Start();
            figura3.Start();
            figura4.Start();


            var f1 = await figura1;
            var f2 = await figura2;
            var f3 = await figura3;
            var f4 = await figura4;

            double SA = f1.Item1 - f2.Item1 - f3.Item1 + f4.Item1;
            double SXA = f1.Item2 - f2.Item2 - f3.Item2 + f4.Item2;
            double SYA = f1.Item3 - f2.Item3 - f3.Item3 + f4.Item3;

            double CTX = SXA / SA;
            double CTY = SYA / SA;

            tiempo1.Stop();
            Console.WriteLine("\n\nForma concurrente 1");
            //Console.WriteLine("\nRectangulo:\nArea: " + f1.Item1 + "\nXa: " + f1.Item2 + "\nYa: " + f1.Item3);
            //Console.WriteLine("\nSemicirculo1:\nArea: " + f2.Item1 + "\nXa: " + f2.Item2 + "\nYa: " + f2.Item3);
            //Console.WriteLine("\nSemicirculo2\nArea: " + f3.Item1 + "\nXa: " + f3.Item2 + "\nYa: " + f3.Item3);
            //Console.WriteLine("\nCuadrado\nArea: " + f4.Item1 + "\nXa: " + f4.Item2 + "\nYa: " + f4.Item3);
            Console.WriteLine("Suma de areas: " + SA);
            Console.WriteLine("Centroide en X: " + CTX + "\nCentroide en Y: " + CTY);

            //-----------------------------------------------------------------------------------------------------------------------------------------
            //Forma concurrente2
            Stopwatch tiempo2 = new Stopwatch();
            tiempo1.Start();

            Task<Tuple<double, double, double>> calculo1 = new Task<Tuple<double, double, double>>(Calculos1);
            Task<Tuple<double, double, double>> calculo2 = new Task<Tuple<double, double, double>>(Calculos2);

            calculo1.Start();
            calculo2.Start();

            var C1 = await calculo1;
            var C2 = await calculo2;

            double sa = C1.Item1 - C2.Item1;
            double ctx = (C1.Item2 - C2.Item2) / sa;
            double cty = (C1.Item3 - C2.Item3) / sa;

            tiempo2.Stop();

            Console.WriteLine("\n\nForma concurrente 2");
            Console.WriteLine("Suma de areas: " + sa);
            Console.WriteLine("Centroide en X: " + ctx + "\nCentroide en Y: " + cty);
            Console.WriteLine("\nTiempo de ejecución lineal: " + tiempo.ElapsedMilliseconds + " milisegundos");
            Console.WriteLine("Tiempo de ejecución concurrente1: " + tiempo1.ElapsedMilliseconds + " milisegundos");
            Console.WriteLine("Tiempo de ejecución concurrente2: " + tiempo2.ElapsedMilliseconds + " milisegundos");
            Console.Read();
        }

        //Métodos
        public static Tuple<double, double, double> Rectangulo()
        {
            //Declaramos el uso de muetra libreria
            Basics MATLAB = new Basics();

            double largo = 8;
            double ancho = 9;
            double area = MATLAB.Prod(largo, ancho);
            double Cx = MATLAB.Div(largo, 2);
            double Cy = MATLAB.Div(ancho, 2);
            double C_X = MATLAB.Prod(Cx, area);
            double C_Y = MATLAB.Prod(Cy, area);

            return new Tuple<double, double, double>(area, C_X, C_Y);
        }

        public static Tuple<double, double, double> Semicirculo1()
        {
            //Declaramos el uso de muetra libreria
            Basics MATLAB = new Basics();

            double radio = 4.5;
            double area = (MATLAB.Prod(Math.PI, Math.Pow(radio, 2))) / 4;
            double C = MATLAB.Prod(4, radio) / MATLAB.Prod(3, Math.PI);
            double C_X = MATLAB.Prod(C, area);
            double C_Y = MATLAB.Prod(C, area);

            return new Tuple<double, double, double>(area, C_X, C_Y);
        }

        public static Tuple<double, double, double> Semicirculo2()
        {
            //Declaramos el uso de muetra libreria
            Basics MATLAB = new Basics();

            double radio = 6;
            double area = (MATLAB.Prod(Math.PI, Math.Pow(radio, 2))) / 4;
            double C = MATLAB.Prod(4, radio) / MATLAB.Prod(3, Math.PI);
            double C_X = MATLAB.Prod(C, area);
            double C_Y = MATLAB.Prod(C, area);

            return new Tuple<double, double, double>(area, C_X, C_Y);
        }

        public static Tuple<double, double, double> Cuadrado()
        {
            //Declaramos el uso de muetra libreria
            Basics MATLAB = new Basics();

            double largo = 9;
            double ancho = 9;
            double area = MATLAB.Prod(largo, ancho);
            double Cx = MATLAB.Div(largo, 2);
            double Cy = MATLAB.Div(ancho, 2);
            double C_X = MATLAB.Prod(Cx, area);
            double C_Y = MATLAB.Prod(Cy, area);

            return new Tuple<double, double, double>(area, C_X, C_Y);
        }

        public static Tuple<double, double, double> Calculos1()
        {
            //Declaramos el uso de muetra libreria
            Basics MATLAB = new Basics();

            double largo = 17;
            double alto = 9;

            //Rectangulo
            double area1 = MATLAB.Prod(largo - alto, alto);
            double Cx1 = MATLAB.Div(largo - alto, 2);
            double Cy1 = MATLAB.Div(alto, 2);
            double C_X1 = MATLAB.Prod(Cx1, area1);
            double C_Y1 = MATLAB.Prod(Cy1, area1);

            //Cuadrado
            double area4 = MATLAB.Prod(alto, alto);
            double Cx4 = MATLAB.Div(alto, 2);
            double Cy4 = MATLAB.Div(alto, 2);
            double C_X4 = MATLAB.Prod(Cx4, area4);
            double C_Y4 = MATLAB.Prod(Cy4, area4);

            double areaT = area1 + area4;
            double SumaXA = C_X1 + C_X4;
            double SumaYA = C_Y1 + C_Y4;

            return new Tuple<double, double, double>(areaT, SumaXA, SumaYA);
        }

        public static Tuple<double, double, double> Calculos2()
        {
            //Declaramos el uso de muetra libreria
            Basics MATLAB = new Basics();

            double radio1 = 4.5;
            double radio2 = 6;

            //Circulo 1
            double area2 = (MATLAB.Prod(Math.PI, Math.Pow(radio1, 2))) / 4;
            double C1 = MATLAB.Prod(4, radio1) / MATLAB.Prod(3, Math.PI);
            double C_X2 = MATLAB.Prod(C1, area2);
            double C_Y2 = MATLAB.Prod(C1, area2);

            //Circulo 2
            double area3 = (MATLAB.Prod(Math.PI, Math.Pow(radio2, 2))) / 4;
            double C2 = MATLAB.Prod(4, radio2) / MATLAB.Prod(3, Math.PI);
            double C_X3 = MATLAB.Prod(C2, area3);
            double C_Y3 = MATLAB.Prod(C2, area3);

            double areaT = area2 + area3;
            double SumaXA = C_X2 + C_X3;
            double SumaYA = C_Y2 + C_Y3;

            return new Tuple<double, double, double>(areaT, SumaXA, SumaYA);
        }
    }
}