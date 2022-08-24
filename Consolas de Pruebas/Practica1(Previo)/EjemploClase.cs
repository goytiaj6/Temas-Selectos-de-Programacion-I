using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Practica1_Previo_
{
    class EjemploClase
    {
        static async Task Main(string[] _)
        {
            //DateTime inicio = new DateTime;
            //Declaramos el uso de reloj interno
            Stopwatch tiempo = new Stopwatch();
            //Iniciamos el reloj
            tiempo.Start();
            double Resultado1 = Sumatoria1();
            double Resultado2 = Sumatoria2();
            double Resultado3 = Sumatoria3();
            double RF = Resultado1 + Resultado2 + Resultado3;

            tiempo.Stop();
            Console.WriteLine(RF + " " + ":" + tiempo.ElapsedMilliseconds);
            
            Stopwatch tiempo1 = new Stopwatch();
            tiempo1.Start();
            Task<double> suma1 = new Task<double>(Sumatoria1);
            Task<double> suma2 = new Task<double>(Sumatoria2);
            Task<double> suma3 = new Task<double>(Sumatoria3);

            suma1.Start();
            suma2.Start();
            suma3.Start();


            double r1 = await suma1;
            double r2 = await suma2;
            double r3 = await suma3;

            double rf = r1 + r2 + r3;

            tiempo1.Stop();

            Console.WriteLine(rf + " " + ": " + tiempo1.ElapsedMilliseconds);
            Console.Read();
        }

        //Primer método
        private static double Sumatoria1()
        {
            double suma = 0;

            for(int i = 0; i < 100; i++)
            {
                suma += Math.Pow(i, 2);
            }
            return suma;
        }

        //Segundo método
        private static double Sumatoria2()
        {
            double suma = 0;

            for (int i = 0; i < 100; i++)
            {
                suma += Math.Pow((i + 3), 2);
            }
            return suma;
        }

        //Tercer método
        private static double Sumatoria3()
        {
            double suma = 0;

            for (int i = 0; i < 100; i++)
            {
                suma += (Math.Pow(i, 2) + 3);
            }
            return suma;
        }
    }
}
