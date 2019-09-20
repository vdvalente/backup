# 1 "C:\\Users\\victo\\Documents\\Arduino\\pruebaSensorTemp\\pruebaSensorTemp.ino"
# 1 "C:\\Users\\victo\\Documents\\Arduino\\pruebaSensorTemp\\pruebaSensorTemp.ino"
int val; //Declaramos variable de tipo entero val

void setup() {
Serial.begin (9600); //Inicializamos la comunicacion serial a 9600bps
pinMode(A1,0x0); //Asignamos el pin A1 como entrada (Sensor de Temperatura)
pinMode(6,0x1); //Asignamos el pin 6 como salida (Led Verde)
pinMode(7,0x1); //Asignamos el pin 7 como salida (Led Rojo)
}

void loop() {

val = analogRead (A1); //Realiza la lectura del pin A1 (Sensor) y el valor lo guarda en la variable val
float mv = (val/1024.0)*5000; //Declaramos variable de tipo float y operamos para obtener el resultado en celsius (grados centigrados)
float temp = mv/10; //Declaramos variable de tipo float y operamos para obtener el resultado en celsius (grados centigrados)


Serial.print (temp); //Imprimimos el valor de la variable temp
//Serial.print ("°C");
Serial.println();
if (Serial.available() > 0)
   {
      String str = Serial.readStringUntil(temp);
      int data = str.toInt();
      ;
   }
if(temp>37.6){ //Si temp es mayor que 37.6
    digitalWrite(6,0x0); //Apaga el Led Verde
    digitalWrite(7,0x1); //Prende el Led Rojo
}
else{ //Si temp NO es mayor que 37.6
  digitalWrite(6,0x1); //Prende el Led Verde
  digitalWrite(7,0x0); //Apaga el Led Rojo
  }
delay(1000); //Espera de 1 segundo
}
