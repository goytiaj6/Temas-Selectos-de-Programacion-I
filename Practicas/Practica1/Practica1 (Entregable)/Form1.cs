using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;
using MATLAB_Library;

namespace Practica1__Entregable_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void BttnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void BttnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                //Declaracion de los relojes para el conteo de tiempo
                Stopwatch tiempo1 = new Stopwatch();
                Stopwatch tiempo2 = new Stopwatch();

                //iniciando el contador de timepo1 para la programacion concurrente
                tiempo1.Start();

                //Asignacion de valores contenidos en los texbox a las variables
                double alto = Convert.ToDouble(txtBoxAlto.Text);
                double largo = Convert.ToDouble(txtBoxLargo.Text);
                double RCirv = Convert.ToDouble(txtBoxRad1.Text);
                double RCirr = Convert.ToDouble(txtBoxRad2.Text);

                //Llamadas de las funciones asincronas mediante tuplas
                (double, double, double) OpRectangulo = await CuadradoRec(largo - alto, alto);
                (double, double, double) OpCuadrado = await CuadradoRec(alto, alto);
                (double, double, double) OpCirculo1 = await CuartCir(RCirv);
                (double, double, double) OpCirculo2 = await CuartCir(RCirr);


                //Llamadas de funciones sincronas para suma de productos y suma de areas
                double SumAreas = Sum(OpRectangulo.Item1, OpCuadrado.Item1, OpCirculo1.Item1, OpCirculo2.Item1);
                double SumAxX = Sum(OpRectangulo.Item2, OpCuadrado.Item2, OpCirculo1.Item2, OpCirculo2.Item2);
                double SumAxY = Sum(OpRectangulo.Item3, OpCuadrado.Item3, OpCirculo1.Item3, OpCirculo2.Item3);

                //Llamada de funciones asincronas para el calculo de centroides
                double CentroideXT = Centroide(SumAreas, SumAxX);
                double CentroideYT = Centroide(SumAreas, SumAxY);

                //se detiene el tiempo de programacion concurrente
                tiempo1.Stop();

                //-------------------------------------------------------------------------------------------------------------------------
                //Inicio de tiempo para porgramacion lineal
                tiempo2.Start();

                //Declaracion de variables para almacenamiento de tuplas
                var fig1 = Cuadrado(alto);
                var fig2 = Rectangulo(largo - alto, alto);
                var fig3 = Semicirculo1(RCirv);
                var fig4 = Semicirculo2(RCirr);


                //Sumas correspondientes a los valores devultos por las tuplas
                double SA = fig1.Item1 + fig2.Item1 - fig3.Item1 - fig4.Item1;
                double SXxA = fig1.Item2 + fig2.Item2 - fig3.Item2 - fig4.Item2;
                double SYxA = fig1.Item3 + fig2.Item3 - fig3.Item3 - fig4.Item3;

                //Calculo de centroides totales
                double CX = SXxA / SA;
                double CY = SYxA / SA;

                //Se detiene el tiempo de la programacion lineal
                tiempo2.Stop();

                //Mostramos resultados en el form 
                txtShow.Text = "Valores concurrentes: " + "\n                    \n" + "Centroide X: " + CentroideXT.ToString() + "\n    \n" + "Centroide Y: " + CentroideYT.ToString() + "\n           \n" + "Valores Lineales: " + "\n                                    \n" + "Centroide X: " + CX.ToString() + "\n    \n" + "Centroide Y: " + CY.ToString();
                txtShow.Show();

                txtShow2.Text = "Tiempo de programacion concurrente: " + tiempo1.ElapsedMilliseconds.ToString() + "\n \n" + "Tiempo de programacion lineal: " + tiempo2.ElapsedMilliseconds.ToString();
                txtShow2.Show();
            }

            catch
            {

            }
        }

        //Metodos concurrentes / asincronos
        /// <summary>
        /// Realiza todas las opeaciones del cuadrado (Area, calculo del centroide en 'x' y 'y',
        /// la multiplicacion del area por su centroide en 'x' y 'y'
        /// </summary>
        /// <param name="ancho"> valor de entrada que es la resta del largo menos el alto </param>
        /// <param name="largo"> valor de entrada del largo de la figura completa </param>
        /// <returns></returns>
        public static async Task<(double, double, double)> CuadradoRec(double ancho, double largo)
        {
            double ACuadrado = Multiplicacion(ancho, largo);
            double CXCuadrado = CcuadRec(ancho);
            double CYCuadrado = CcuadRec(largo);
            double AxCXCuadrado = Multiplicacion(ACuadrado, CXCuadrado);
            double AxCYCuadrado = Multiplicacion(ACuadrado, CYCuadrado);

            (double, double, double) output = (ACuadrado, AxCXCuadrado, AxCYCuadrado);
            return await Task.FromResult(output);
        }

        /// <summary>
        /// realiza todas las operaciones del circulo (Area, calculo del centroide en 'x' y 'y',
        /// la multiplicacion del area por su centroide en 'x' y 'y'
        /// </summary>
        /// <param name="r"> radio del circulo </param>
        /// <returns> Regresa tres parametros, el area del circulo, multiplicain del centroide de x y y </returns>
        public static async Task<(double, double, double)> CuartCir(double r)
        {
            double AcuarCir = CuartCirA(r);
            double CXcuartCir = CcuartCir(r);
            double AxCcuartCir = Multiplicacion(AcuarCir, CXcuartCir);

            (double, double, double) output = (AcuarCir, AxCcuartCir, AxCcuartCir);
            return await Task.FromResult(output);
        }

        //-------------------------------------------------------------------------------------------------------------------------------------
        //Métodos lineales/síncronos

        /// <summary>
        /// Suma de las areas obtenidas de las figuras
        /// </summary>
        /// <param name="ARect"> Area del rectangulo </param>
        /// <param name="ACuad"> Area del cuadrado </param>
        /// <param name="ACir1"> Area del cuarto de circulo1 </param>
        /// <param name="ACir2"> Area del cuarto de circulo2 </param>
        /// <returns> regresa la suma de todos los valores de entrada </returns>
        public static double Sum(double ARect, double ACuad, double ACir1, double ACir2)
        {
            double output;
            output = ARect + ACuad - ACir1 - ACir2;
            return output;
        }

        /// <summary>
        /// Calcula el area del cuadrado 
        /// </summary>
        /// <param name="b"> ancho de la figura </param>
        /// <param name="a"> largo de la figura </param>
        /// <returns></returns>
        public static double Multiplicacion(double b, double a)
        {
            double output;
            output = a * b;
            return output;
        }

        /// <summary>
        /// Calcula el area de un cuato de circulo
        /// </summary>
        /// <param name="r"> radio del circulo </param>
        /// <returns> regresa el area del cuarto de circulo </returns>
        public static double CuartCirA(double r)
        {
            double output;
            output = (Math.PI * (r * r)) / 4;
            return output;
        }

        /// <summary>
        /// Calcula el centroide del cuadrado o rectangulo, ya sea en x o y
        /// </summary>
        /// <param name="m"> ancho de la figura </param>
        /// <returns></returns>
        public static double CcuadRec(double m)
        {
            double output;
            output = m / 2;
            return output;
        }

        /// <summary>
        /// Calcula el centroide del circulo tanto en x como en y
        /// </summary>
        /// <param name="r"> radio del circulo </param>
        /// <returns> regresa el valor del centroide x o y </returns>
        public static double CcuartCir(double r)
        {
            double output;
            output = (4 * r) / (Math.PI * 3);
            return output;
        }

        /// <summary>
        /// Calculo del Centroide total de la figura
        /// </summary>
        /// <param name="sumA"> Suma de todas las areas de las figuras </param>
        /// <param name="SumCxA"> suma de los centroides de la fiuras (puede ser en x o y) </param>
        /// <returns> regresa el valor del centroide la figura (ya sea x o y) </returns>
        public static double Centroide(double sumA, double SumCxA)
        {
            double output;
            output = SumCxA / sumA;
            return output;
        }

        /// <summary>
        ///  Realiza todas las opeaciones del rectangulo (Area, calculo del centroide en 'x' y 'y',
        /// la multiplicacion del area por su centroide en 'x' y 'y' 
        /// </summary>
        /// <param name="largo"> largo de la figura </param>
        /// <param name="ancho"> ancho de la figura </param>
        /// <returns> regresa el area y el valor de los centroide x y y </returns>
        public static Tuple<double, double, double> Rectangulo(double largo, double ancho)
        {
            //Declaramos el uso de muetra libreria
            Basics MATLAB = new Basics();

            double area = MATLAB.Prod(largo, ancho);
            double Cx = MATLAB.Div(largo, 2);
            double Cy = MATLAB.Div(ancho, 2);
            double C_X = MATLAB.Prod(Cx, area);
            double C_Y = MATLAB.Prod(Cy, area);

            return new Tuple<double, double, double>(area, C_X, C_Y);
        }

        /// <summary>
        /// Realiza todas las opeaciones del Cuatro de circulo (Area, calculo del centroide en 'x' y 'y',
        /// la multiplicacion del area por su centroide en 'x' y 'y' 
        /// </summary>
        /// <param name="largo"> radio del cuadrado </param>
        /// <returns> regresa el area y el valor de los centroide x y y </returns>
        public static Tuple<double, double, double> Cuadrado(double largo)
        {
            //Declaramos el uso de muetra libreria
            Basics MATLAB = new Basics();

            double area = MATLAB.Prod(largo, largo);
            double Cx = MATLAB.Div(largo, 2);
            double Cy = MATLAB.Div(largo, 2);
            double C_X = MATLAB.Prod(Cx, area);
            double C_Y = MATLAB.Prod(Cy, area);

            return new Tuple<double, double, double>(area, C_X, C_Y);
        }

        /// <summary>
        /// Realiza todas las opeaciones del Cuatro de circulo (Area, calculo del centroide en 'x' y 'y',
        /// la multiplicacion del area por su centroide en 'x' y 'y' 
        /// </summary>
        /// <param name="radio"> radio del circulo </param>
        /// <returns> regresa el area y el valor de los centroide x y y </returns>
        public static Tuple<double, double, double> Semicirculo1(double radio)
        {
            //Declaramos el uso de muetra libreria
            Basics MATLAB = new Basics();

            double area = (MATLAB.Prod(Math.PI, Math.Pow(radio, 2))) / 4;
            double C = MATLAB.Prod(4, radio) / MATLAB.Prod(3, Math.PI);
            double C_X = MATLAB.Prod(C, area);
            double C_Y = MATLAB.Prod(C, area);

            return new Tuple<double, double, double>(area, C_X, C_Y);
        }

        /// <summary>
        /// Realiza todas las opeaciones del Cuatro de circulo (Area, calculo del centroide en 'x' y 'y',
        /// la multiplicacion del area por su centroide en 'x' y 'y' 
        /// </summary>
        /// <param name="radio"> radio del circulo </param>
        /// <returns> regresa el area y el valor de los centroide x y y </returns>
        public static Tuple<double, double, double> Semicirculo2(double radio)
        {
            //Declaramos el uso de muetra libreria
            Basics MATLAB = new Basics();

            double area = (MATLAB.Prod(Math.PI, Math.Pow(radio, 2))) / 4;
            double C = MATLAB.Prod(4, radio) / MATLAB.Prod(3, Math.PI);
            double C_X = MATLAB.Prod(C, area);
            double C_Y = MATLAB.Prod(C, area);

            return new Tuple<double, double, double>(area, C_X, C_Y);
        }
    }
}