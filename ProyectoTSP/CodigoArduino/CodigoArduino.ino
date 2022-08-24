// Sensor de Color
//
//    Arduino   TCS230 SENSOR COLOR
//      8         OUT
//      7         S3
//      6         S2
//      5         S1
//      4         S0
//      5V        VCC
//      GND       GND
//
#define S0 4
#define S1 5
#define S2 6
#define S3 7
#define sensorSalida 8
int Rojo_Frec = 0;
int Verde_Frec = 0;
int Azul_Frec = 0;

void setup() {
  pinMode(S0, OUTPUT);
  pinMode(S1, OUTPUT);
  pinMode(S2, OUTPUT);
  pinMode(S3, OUTPUT);
  pinMode(sensorSalida, INPUT);
  
// Se configura la escala de Frecuencia en 20%
  digitalWrite(S0,HIGH);
  digitalWrite(S1,LOW);
  
  Serial.begin(9600);
}
void loop() {
// Configura el filtro ROJO para tomar lectura
  digitalWrite(S2,LOW);
  digitalWrite(S3,LOW);
  delay(100);
  Rojo_Frec = pulseIn(sensorSalida, LOW);
  Serial.print(" R= "); Serial.print(Rojo_Frec);
  delay(100);
  
// Configura el filtro VERDE para tomar lectura
  digitalWrite(S2,HIGH);
  digitalWrite(S3,HIGH);
  delay(100);
  Verde_Frec = pulseIn(sensorSalida, LOW);
  Serial.print(" V= "); Serial.print(Verde_Frec);
  delay(100);
  
// Configura el filtro AZUL para tomar lectura
  digitalWrite(S2,LOW);
  digitalWrite(S3,HIGH);
  delay(100);
  Azul_Frec = pulseIn(sensorSalida, LOW);
  Serial.print(" A= "); Serial.print(Azul_Frec);
  delay(100);

//Valores obtenidos en la calibracion del sensor, son propios de cada usuario o entorno donde se emplee el sensor
 if (Rojo_Frec < 85 && Verde_Frec > 80 && Azul_Frec > 80)  Serial.print(" . *** ROJO ***");
 if (Rojo_Frec > 80 && Verde_Frec > 100 && Azul_Frec < 80)  Serial.print(" . *** AZUL ***");
 if (Rojo_Frec > 185 && Verde_Frec < 140 && Azul_Frec < 130)  Serial.print(" . *** VERDE ***");
 if (Rojo_Frec < 35 && Verde_Frec < 35 && Azul_Frec < 35)  Serial.print(" . *** BLANCO ***");
 if (Rojo_Frec > 130 && Verde_Frec > 200 && Azul_Frec >150)  Serial.print(" . *** NEGRO ***");

 Serial.println("*");
 delay(5000);
}
/*
// Sensor Ultrasónico
//
//  Arduino     HC-SR04 Sensor Ultrasónico
//     10                 Trigger
//     9                    Eco
//    GND                   GND
//    VCC                   VCC
//
#define TRIG 10
#define ECHO 9
// VARIABLES PARA CALCULOS
unsigned int TIME = 0;
unsigned int DIST = 0;
 
void setup()
{
  // PREPARAR LA COMUNICACION SERIAL
  Serial.begin(9600);
  // CONFIGURAR PINES DE ENTRADA Y SALIDA
  pinMode(ECHO, INPUT);
  pinMode(TRIG, OUTPUT);
}
 
void loop() {
// ENVIAR PULSO DE DISPARO EN EL PIN "TRIGGER"
  digitalWrite(TRIG, LOW);
  delayMicroseconds(2);
  digitalWrite(TRIG, HIGH);
// EL PULSO DURA AL MENOS 10 uS EN ESTADO ALTO
  delayMicroseconds(10);
  digitalWrite(TRIG, LOW);
// MEDIR EL TIEMPO EN ESTADO ALTO DEL PIN "ECHO" EL PULSO ES PROPORCIONAL A LA DISTANCIA MEDIDA
  TIME = pulseIn(ECHO, HIGH);
// LA VELOCIDAD DEL SONIDO ES DE 340 M/S O 29 MICROSEGUNDOS POR CENTIMETRO
// DIVIDIMOS EL TIEMPO DEL PULSO ENTRE 58, TIEMPO QUE TARDA RECORRER IDA Y VUELTA UN CENTIMETRO LA ONDA SONORA
  DIST = TIME / 58;
// ENVIAR EL RESULTADO AL MONITOR SERIAL
  Serial.print(DIST);
  Serial.println(" cm");
  delay(200);
}
*/
