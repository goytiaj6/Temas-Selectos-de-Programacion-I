//Agregamos la libreria para un manejo más eficiente del servo
#include <Servo.h>
//Se declara nuestro servo a utilizar
Servo servo1;
//Variables a utilizar
char c; //caracter para cortar el mensaje
String info; //donde guardamos la información recibida por Visual Studio
int grados = 0; //donde guardaremos los grados

void setup()
{
  Serial.begin (9600);
  servo1.attach(9); //Indica en donde se envia la señal de control
}

void loop()
{
  Info_Serial(); //Nuestro método para obtener los grados
  servo1.write(grados); //Le indicamos al servo su posición en grados
}
//Método para recibir la información de Visual Studio
void Info_Serial()
{
  //Si queremos recibir mas de un byte de informacion
  while (Serial.available() > 0)
  {
    c = Serial.read(); //Recibimos la información mediante puerto serial
    if(c == '\n')
    {
      break; //Si se detecta el salto de linea, el mensaje se a terminado
    }
    else
    {
      info = info + c; //Guardamos la información de puerto serial
    }
  }
  //Cuando c tiene asignado el salto de linea
  if(c == '\n')
  {
    grados = info.toInt(); //Si se detecta el salto de linea, guardamos el valor del angulo
    c = 0; //Asignamos a c el caracter 0, puesto que se detecto el fin del mensaje
    info = ""; // Se limpia la cadena de informacion
  }
}
