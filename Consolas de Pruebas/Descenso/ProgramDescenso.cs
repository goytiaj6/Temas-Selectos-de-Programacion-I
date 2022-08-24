using System;

namespace Descenso
{
    class ProgramDescenso
    {
        private static void Main(string[] _)
        {
            //Entradas
            double q1 = 8 * Math.Pow(10, -6);
            double q2 = 6 * Math.Pow(10, -6);
            double q3 = 7 * Math.Pow(10, -6);
            double d = 0.12;
            double r1 = 0.11;  //Este es el valor aleatorio
            double valor = 35;
            double paso = .001;

            //Se imprimen los datos en pantalla
            Console.WriteLine("\nEl valor de q1 es: {0} [C]", q1);
            Console.WriteLine("\nEl valor de q2 es: {0} [C]", q2);
            Console.WriteLine("\nEl valor de q3 es: {0} [C]", q3);
            Console.WriteLine("\nLa distancia total es: {0} [m]", d);
            Console.WriteLine("\nEl valor aleatorio es: {0} [m]", r1);
            Console.WriteLine("\nEl valor deseado es: {0} [N]", valor);
            Console.WriteLine("\nEl valor del paso es: {0} [m]", paso);

            //Hacemos el llamado de las funciones
            //Se hace la primera iteracion de la función descenso
            Descenso(q1, q2, q3, d, r1, valor, paso);

            Console.Read();
        }

        private static double Fuerzas(double q1, double q2, double q3, double d, double r1)
        {
            //Se obtiene la difrencia entre d y el valor aleatorio
            double r2 = d - r1;

            double k = (9 * Math.Pow(10, 9));
            //Se calculan ambas fuerzas
            double F31 = (k * q1 * q3) / (Math.Pow(r1, 2));
            double F32 = (k * q2 * q3) / (Math.Pow(r2, 2));
            //Se obtiene la fuerza total
            double FT = F31 - F32;

            return FT;
        }
 
        private static void Descenso(double q1, double q2, double q3, double d, double r1, double valor, double paso)
        {
            //Error cuadratico inicial
            double FT1;
            double EC1;

            do
            {
                //Error cuadratico inicial
                FT1 = Fuerzas(q1, q2, q3, d, r1);
                EC1 = Math.Pow((FT1 - valor), 2);

                //Eligimos un punto superior y se calcula la fuerza en ese punto
                double r1S = r1 + paso;
                double FT2 = Fuerzas(q1, q2, q3, d, r1S);
                double EC2 = Math.Pow((FT2 - valor), 2); //Se calcula el error en este punto

                //Eligimos un punto inferior y se calcula la fuerza en ese punto
                double r1I = r1 - paso;
                double FT3 = Fuerzas(q1, q2, q3, d, r1I);
                double EC3 = Math.Pow((FT3 - valor), 2); //Se calcula el error en este punto

                //Calculamos las pendientes asociadas
                double pend1 = Math.Truncate(((EC2 - EC1) / (r1S - r1)) * 1000) / 1000;
                double pend2 = Math.Truncate(((EC1 - EC3) / (r1 - r1I)) * 1000) / 1000;

                //Comparamos los errores
                if (EC1 > EC2)
                {
                    r1 = Math.Truncate(r1S * 1000) / 1000;
                    Console.WriteLine("\nEl valor de pendiente es: {0}", pend1);
                    Console.WriteLine("\nEl valor de r1 ahora es: {0} [mm]", r1);
                }

                else if (EC1 > EC3)
                {
                    r1 = Math.Truncate(r1I * 1000) / 1000;
                    Console.WriteLine("\nEl valor de pendiente es: {0}", pend2);
                    Console.WriteLine("\nEl valor de r1 ahora es: {0} [mm]", r1);
                }
            } while (EC1 > 1E-25);
        }
    }
}
