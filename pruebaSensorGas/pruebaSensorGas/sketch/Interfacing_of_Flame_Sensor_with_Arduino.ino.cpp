#include <Arduino.h>
#line 1 "C:\\Users\\victo\\Downloads\\Interfacing of Flame Sensor with Arduino\\Interfacing of Flame Sensor with Arduino\\Interfacing_of_Flame_Sensor_with_Arduino\\Interfacing_of_Flame_Sensor_with_Arduino.ino"
#line 1 "C:\\Users\\victo\\Downloads\\Interfacing of Flame Sensor with Arduino\\Interfacing of Flame Sensor with Arduino\\Interfacing_of_Flame_Sensor_with_Arduino\\Interfacing_of_Flame_Sensor_with_Arduino.ino"
#include <LiquidCrystal.h>
#define DEBUG(a)
LiquidCrystal lcd(13, 12, 11, 10, 9, 8);

int Flame = 7;
String val;
#line 7 "C:\\Users\\victo\\Downloads\\Interfacing of Flame Sensor with Arduino\\Interfacing of Flame Sensor with Arduino\\Interfacing_of_Flame_Sensor_with_Arduino\\Interfacing_of_Flame_Sensor_with_Arduino.ino"
void setup();
#line 22 "C:\\Users\\victo\\Downloads\\Interfacing of Flame Sensor with Arduino\\Interfacing of Flame Sensor with Arduino\\Interfacing_of_Flame_Sensor_with_Arduino\\Interfacing_of_Flame_Sensor_with_Arduino.ino"
void loop();
#line 7 "C:\\Users\\victo\\Downloads\\Interfacing of Flame Sensor with Arduino\\Interfacing of Flame Sensor with Arduino\\Interfacing_of_Flame_Sensor_with_Arduino\\Interfacing_of_Flame_Sensor_with_Arduino.ino"
void setup() {
  Serial.begin(9600);
  pinMode(A1,INPUT);
  pinMode(6,OUTPUT);
  pinMode(7,OUTPUT);
  pinMode(Flame, INPUT_PULLUP);
  lcd.begin(20, 4);
  lcd.setCursor(0,0);
  lcd.print("Flame : ");
  lcd.setCursor(1,2);
  lcd.print("www.TheEngineering");
  lcd.setCursor(4,3);
  lcd.print("Projects.com");
}

void loop() {
  val=analogRead (A1);
  String mv = val;
  Serial.println();
  if(digitalRead(Flame) == HIGH)
   {
    lcd.setCursor(8,0);lcd.print("Detected    ");
    Serial.print("1");
    DEBUG(1);
    }
   if(digitalRead(Flame) == LOW )
  {
    lcd.setCursor(8,0);lcd.print("Not Detected");
    Serial.println("0");
    DEBUG(0); 
  }
  delay(1000);
}


