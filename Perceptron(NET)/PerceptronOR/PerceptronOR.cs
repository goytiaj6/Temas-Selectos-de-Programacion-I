using Encog;
using Encog.Engine.Network.Activation;
using Encog.ML.Data;
using Encog.ML.Data.Basic;
using Encog.ML.Train;
using Encog.Neural.Networks;
using Encog.Neural.Networks.Layers;
using Encog.Neural.Networks.Training.Propagation.Resilient;
using System;

namespace Perceptron_NET_
{
    class PerceptronOR
    {
        /// <summary>
        /// Entradas de para funcion OR.
        /// </summary>
        public static double[][] ORInput =
        {
            new[] {0.0, 0.0},
            new[] {0.0, 1.0},
            new[] {1.0, 0.0},
            new[] {1.0, 1.0}
        };

        /// <summary>
        /// Salidas deseadas para la funcion OR.
        /// </summary>
        public static double[][] ORIdeal =
        {
            new[] {0.0},
            new[] {1.0},
            new[] {1.0},
            new[] {1.0}
        };

        static void Main(string[] _)
        {
            // Se crea una red nueronal basica de la clase BasicNetwork
            var network = new BasicNetwork();
            //Al ser la capa de entradas no existe funcion de activacion pero existe un bias de 1
            network.AddLayer(new BasicLayer(null, true, 2));
            //Nuestra unica neurona, por lo que es solo una capa, y por ello la salida
            network.AddLayer(new BasicLayer(new ActivationStep(), true, 1));
            //Se termina de construir la red
            network.Structure.FinalizeStructure();
            network.Reset();

            // Se crea el conjunto de datos de entrenamiento
            IMLDataSet trainingSet = new BasicMLDataSet(ORInput, ORIdeal);

            // Se entrena la red nueronal con los datos para entrenamiento
            IMLTrain train = new ResilientPropagation(network, trainingSet);

            //Epoca es las veces en las que se recorre todas las entradas para la normalización de los datos
            int epoch = 1;

            do
            {
                //Se inicia el entrenamiento de la red nueronal
                train.Iteration();
                //Se muestra la epoca y el error para la iteracion actual
                Console.WriteLine(@"Epoca #" + epoch + @" Error:" + train.Error);
                epoch++;
            } while (train.Error > 0.01);

            //Termina el entrenamiento cuando el error es menor a .01
            train.FinishTraining();

            //Se realiza la prueba de la nuerona entrenada
            Console.WriteLine(@"Resultados de la red nuronal:");
            foreach (IMLDataPair pair in trainingSet)
            {
                //Se computan los pares de entradas para la red entrenada
                IMLData output = network.Compute(pair.Input);
                Console.WriteLine(pair.Input[0] + @"," + pair.Input[1]
                                  + @", actual=" + output[0] + @", ideal=" + pair.Ideal[0]);
            }
            EncogFramework.Instance.Shutdown();
            Console.Read();
        }
    }
}