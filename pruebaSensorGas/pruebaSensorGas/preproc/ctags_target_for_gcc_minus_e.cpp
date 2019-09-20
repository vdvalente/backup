# 1 "C:\\Users\\victo\\Downloads\\Interfacing of Flame Sensor with Arduino\\Interfacing of Flame Sensor with Arduino\\Interfacing_of_Flame_Sensor_with_Arduino\\Interfacing_of_Flame_Sensor_with_Arduino.ino"
# 1 "C:\\Users\\victo\\Downloads\\Interfacing of Flame Sensor with Arduino\\Interfacing of Flame Sensor with Arduino\\Interfacing_of_Flame_Sensor_with_Arduino\\Interfacing_of_Flame_Sensor_with_Arduino.ino"
# 2 "C:\\Users\\victo\\Downloads\\Interfacing of Flame Sensor with Arduino\\Interfacing of Flame Sensor with Arduino\\Interfacing_of_Flame_Sensor_with_Arduino\\Interfacing_of_Flame_Sensor_with_Arduino.ino" 2

LiquidCrystal lcd(13, 12, 11, 10, 9, 8);

int Flame = 7;
String val;
void setup() {
  Serial.begin(9600);
  pinMode(A1,0x0);
  pinMode(6,0x1);
  pinMode(7,0x1);
  pinMode(Flame, 0x2);
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
  if(digitalRead(Flame) == 0x1)
   {
    lcd.setCursor(8,0);lcd.print("Detected    ");
    Serial.print("1");
    ;
    }
   if(digitalRead(Flame) == 0x0 )
  {
    lcd.setCursor(8,0);lcd.print("Not Detected");
    Serial.println("0");
    ;
  }
  delay(1000);
}
