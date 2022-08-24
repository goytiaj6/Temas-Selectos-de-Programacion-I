using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WSPractica
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    //Define un contrato de servicio, dicho de otra forma, nos dice que se puede hacer con nuestra WS
    [ServiceContract]
    //Se define nuestra interfaz de la WS
    public interface IWSAmpOp
    {
        //Definimos los parametros que emplean nuestras operaciones y sus valores de retorno
        [OperationContract]
        Amplificador Ganancia(double R1, double RF, double Input);
        // TODO: agregue aquí sus operaciones de servicio
    }

    //Se definen los tipos de dato con los que trabaja nuestra WS, que es la clase amplificador
    //y sus atributos
    [DataContract]
    public class Amplificador
    {
        //Se especifica que el WS puede trabajar con los valores de estos atributos
        [DataMember]
        public double Res1 { get; set; }
        [DataMember]
        public double ResF { get; set; }
        [DataMember]
        public double Ve { get; set; }
        [DataMember]
        public double Vs { get; set; }
    }
    // Utilice un contrato de datos, como se ilustra en el ejemplo siguiente, para agregar tipos compuestos a las operaciones de servicio.
}
