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
double Rojo_Frec = 0;
double Verde_Frec = 0;
double Azul_Frec = 0;

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
  delay(100);
  
// Configura el filtro VERDE para tomar lectura
  digitalWrite(S2,HIGH);
  digitalWrite(S3,HIGH);
  delay(100);
  Verde_Frec = pulseIn(sensorSalida, LOW);
  delay(100);
  
// Configura el filtro AZUL para tomar lectura
  digitalWrite(S2,LOW);
  digitalWrite(S3,HIGH);
  delay(100);
  Azul_Frec = pulseIn(sensorSalida, LOW);
  delay(100);
//Si se detecta un valor diferente al color de fondo, se envía la lectura
  if(Rojo_Frec<400){
    Serial.println(String(Rojo_Frec)+","+String(Verde_Frec)+","+String(Azul_Frec));
  delay(3000);
  }
}
