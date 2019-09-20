#include <Arduino.h>
#line 1 "C:\\Users\\victo\\Desktop\\sketch_sep17a\\sketch_sep17a.ino"
#line 1 "C:\\Users\\victo\\Desktop\\sketch_sep17a\\sketch_sep17a.ino"
int val;                                         //Declaramos variable de tipo entero val
#define DEBUG(a)
#line 3 "C:\\Users\\victo\\Desktop\\sketch_sep17a\\sketch_sep17a.ino"
void setup();
#line 10 "C:\\Users\\victo\\Desktop\\sketch_sep17a\\sketch_sep17a.ino"
void loop();
#line 3 "C:\\Users\\victo\\Desktop\\sketch_sep17a\\sketch_sep17a.ino"
void setup() {
Serial.begin (9600);                             //Inicializamos la comunicacion serial a 9600bps
pinMode(A1,INPUT);                               //Asignamos el pin A1 como entrada (Sensor de Temperatura)
pinMode(6,OUTPUT);                               //Asignamos el pin 6 como salida (Led Verde)
pinMode(7,OUTPUT);                               //Asignamos el pin 7 como salida (Led Rojo)
}

void loop() {
  
val = analogRead (A1);                           //Realiza la lectura del pin A1 (Sensor) y el valor lo guarda en la variable val
double mv = (val/1024.0)*5000;                    //Declaramos variable de tipo float y operamos para obtener el resultado en celsius (grados centigrados)
double temp = mv/10;                            //Declaramos variable de tipo float y operamos para obtener el resultado en celsius (grados centigrados)
temp = rand()%((585-347)+1)+347;
temp = temp/10;
Serial.print (temp);                             //Imprimimos el valor de la variable temp
//Serial.print ("°C");
Serial.println();
if (Serial.available() > 0)
   {
      String str = Serial.readStringUntil(temp);
      int data = str.toInt();
      DEBUG(data);
   }
if(temp>37.6){                                   //Si temp es mayor que 37.6
    digitalWrite(6,LOW);                         //Apaga el Led Verde
    digitalWrite(7,HIGH);                        //Prende el Led Rojo
}
else{                                            //Si temp NO es mayor que 37.6
  digitalWrite(6,HIGH);                          //Prende el Led Verde
  digitalWrite(7,LOW);                           //Apaga el Led Rojo
  }
delay(1000);                                     //Espera de 1 segundo
}

