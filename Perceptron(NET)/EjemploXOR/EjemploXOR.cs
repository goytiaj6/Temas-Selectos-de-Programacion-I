using System;
using Encog.Neural.Networks;
using Encog.Neural.Networks.Layers;
using Encog.Engine.Network.Activation;
using Encog.ML.Data;
using Encog.Neural.Networks.Training.Propagation.Resilient;
using Encog.ML.Train;
using Encog.ML.Data.Basic;
using Encog;
using System.Text;
using System.Collections.Generic;
using System.IO;

namespace EjemploXOR2
{
    class Program
    {
        /// <summary>
        /// Input for the XOR function.
        /// </summary>
        public static double[][] XORInput =
        {
            new[] {0.01, 0.1098},
            new[] {0.02, 0.2097},
            new[] {0.03, 0.4097},
            new[] {0.04, 0.1097},
            new[] {0.05, 0.2097},
            new[] {0.52, 0.72},
            new[] {0.53, 0.615},
            new[] {0.54, 0.813},
            new[] {0.55, 0.8125},
            new[] {0.56, 1.0}
        };

        /// <summary>
        /// Ideal output for the XOR function.
        /// </summary>
        public static double[][] XORIdeal =
        {
            new[] {0.0},
            new[] {0.0},
            new[] {0.0},
            new[] {0.0},
            new[] {0.0},
            new[] {1.0},
            new[] {1.0},
            new[] {1.0},
            new[] {1.0},
            new[] {1.0}
        };

        static void Main(string[] _)
        {
            // create a neural network, without using a factory
            var network = new BasicNetwork();
            network.AddLayer(new BasicLayer(null, true, 2));
            network.AddLayer(new BasicLayer(new ActivationSigmoid(), true, 4));
            network.AddLayer(new BasicLayer(new ActivationSigmoid(), false, 1));
            //ActivationReLU
            network.Structure.FinalizeStructure();
            network.Reset();

            // create training data
            //Para entrenar la red neuronal, se construye un objeto IMLDataSet. 
            //Este objeto contiene las entradas y las salidas esperadas. 
            //Para construir este objeto, se crean dos matrices. 
            //La primera matriz contendrá los valores de entrada para el operador XOR. 
            //La segunda matriz contendrá las salidas ideales para cada uno de los cuatro valores de entrada correspondientes.
            IMLDataSet trainingSet = new BasicMLDataSet(XORInput, XORIdeal);

            // train the neural network
            IMLTrain train = new ResilientPropagation(network, trainingSet);


            int epoch = 1;
            do
            {
                train.Iteration();
                Console.WriteLine(@"Epoch #" + epoch + @" Error:" + train.Error);
                epoch++;
                if (epoch > 1000)
                {
                    epoch = 0;
                    network.Reset();
                }
            } while (train.Error > 0.001);

            Console.WriteLine("-----------------------------------------------");
            for (int i = 0; i < network.Flat.Weights.Length; i++)
            {
                Console.WriteLine(network.Flat.Weights[i]);
            }

            double[][,] pesos = new double[network.LayerCount - 1][,];
            int capa = network.LayerCount - 2;
            for (int k = 0; k <= network.LayerCount - 2; k++)
            {
                pesos[k] = new double[network.Flat.LayerFeedCounts[k], network.Flat.LayerCounts[k + 1]];
                for (int i = 0; i < pesos[k].GetLength(0); i++)
                {
                    for (int j = 0; j < pesos[k].GetLength(1); j++)
                    {
                        pesos[k][i, j] = network.GetWeight(capa, j, i);
                    }
                }
                capa--;
            }



            // test the neural network
            Console.WriteLine(@"Neural Network Results:");


            //El método Compute acepta una clase IMLData y también devuelve otro objeto IMLData.
            //Solo necesito pasar el arrelgo de entrada a una entrada de tipo IMLData
            //El objeto devuelto contiene la salida de la red neuronal, que se muestra al usuario. 
            //Con la ejecución del programa, primero se muestran los resultados del entrenamiento.

            //Salidas necesitando IMLDataPair
            double[] Entrada = { 0.045, 0.2500 };
            double[] Salida = { 0 };
            IMLData IN = new BasicMLData(Entrada);
            IMLData OUT = new BasicMLData(Salida);
            //Entradas y salidas
            IMLDataPair Prueba = new BasicMLDataPair(IN, OUT);
            IMLData Teoria = network.Compute(Prueba.Input);
            Console.WriteLine("{0} XOR {1} ---->Esperado:{2}---->Obtenido:{3}", Prueba.Input[0], Prueba.Input[1], Prueba.Ideal[0], Teoria[0]);

            //Salidas sin necesitar IMLDataPair
            double[] Entrada2 = { 0.60, 0.7500 };
            double[] Salida2 = { 1 };
            IMLData IN2 = new BasicMLData(Entrada2);
            IMLData Teoria2 = network.Compute(IN2);
            Console.WriteLine("{0} XOR {1} ---->Esperado:{2}---->Obtenido:{3}", Entrada2[0], Entrada2[1], Salida2[0], Teoria2[0]);

            //Imptimir pesos
            Escribir_pesos(pesos);

            //Transportar pesos

            /*
            foreach (IMLDataPair pair in trainingSet)
            {
                
                IMLData output = network.Compute(pair.Input);
                Console.WriteLine(pair.Input[0] + @"," + pair.Input[1] 
                    + @", actual=" + output[0] + @",ideal=" + pair.Ideal[0]);
            }
            */
            EncogFramework.Instance.Shutdown();
            Console.ReadLine();
        }
        /// <summary>
        /// Imprime una matriz de pesos
        /// </summary>
        /// <param name="W"></param>
        public static void Imprimirmatriz(double[,] W)
        {
            /*  Peso asociado de la neurona m a la neourona m
             *      N1|  N2| N3|...|Nm
             * ------------------------
             * N1 |   |    |   |   |
             * ------------------------
             * N2 |   |    |   |   | 
             * ----------------------
             * N3 |   |    |   |   |
             * ------------------------
             * .
             * .
             * .
             * ----------------------
             * Nn |   |    |    |   |
             */

            for (int j = 0; j < W.GetLength(1); j++)
            {
                Console.Write("  |       N{0}", j + 1);
            }
            Console.WriteLine("|");

            for (int i = 0; i < W.GetLength(0); i++)
            {
                Console.Write("N{0}", i + 1);
                for (int j = 0; j < W.GetLength(1); j++)
                {
                    Console.Write("|{0}", Math.Round(W[i, j], 8));
                }
                Console.WriteLine("|");
            }
        }

        public static void Escribir_pesos(double[][,] W)
        {
            string ruta = @"C:\Users\jorge\Documents\Facultad\SEM2022-1\Temas Selectos de Programación I\Perceptron(NET)\EjemploXOR\Pesos.txt";
            File.Delete(ruta);

            //Pesos de capa oculta y capa de salida
            for (int j = 0; j < W.GetLength(0); j++)
            {
                Guardar_pesos(W[j], ruta);
                Console.WriteLine("----------------------Pesos" + j + " -------------------------");
                Imprimirmatriz(W[j]);
            }


        }
        public static void Guardar_pesos(double[,] W, string ruta)
        {
            string cadena = "";
            List<String> lista = new List<string>();
            for (int j = 0; j < W.GetLength(1); j++)
            {
                cadena = cadena + "     |      N" + Convert.ToString(j + 1);
            }
            lista.Add(cadena);
            for (int i = 0; i < W.GetLength(0); i++)
            {
                cadena = "N" + Convert.ToString(i + 1) + "|";
                for (int j = 0; j < W.GetLength(1); j++)
                {
                    if (j == W.GetLength(1) - 1)
                    {
                        cadena += Convert.ToString(W[i, j]);
                    }
                    else
                    {
                        cadena = cadena + Convert.ToString(W[i, j]) + "|";
                    }
                }
                lista.Add(cadena);
            }
            cadena = "----------------------------------------------------------------------\n";
            lista.Add(cadena);
            for (int j = 0; j < lista.Count; j++)
            {
                File.AppendAllText(ruta, lista[j] + "\n");
            }
        }
    }
}