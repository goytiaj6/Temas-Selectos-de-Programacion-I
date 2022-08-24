using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WSPractica
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    //Creamos la clase AmpOp en la WS que hereda de la interfaz IWSAmpOp
    public class WSAmpOp : IWSAmpOp
    {
        //Este es el método que heremdamos por la interfaz, que corresponde a nuestra clase amplificador
        public Amplificador Ganancia(double R1, double RF, double Input)
        {
            double output = ((RF/R1)+1)*Input;
            return new Amplificador() { Res1 = R1, ResF = RF, Ve = Input, Vs = output };
        }
    }
}
