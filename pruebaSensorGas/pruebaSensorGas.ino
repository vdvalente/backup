#include <LiquidCrystal.h>
#define gas_Pin 7
#define DEBUG
// initialize the library by associating any needed LCD interface pin
// with the arduino pin number it is connected to
const int rs = 13, en = 12, d4 = 11, d5 = 10, d6 = 9, d7 = 8;
LiquidCrystal lcd(rs, en, d4, d5, d6, d7);
int gas_value;
void setup() {
  // set up the LCD's number of columns and rows:
  lcd.begin(16, 2);
  pinMode(6,OUTPUT);
  Serial.begin(9600);
}
void loop()
{
  gas_value = digitalRead(gas_Pin);
  if(gas_value==1)
  {
   digitalWrite(6,HIGH);
   lcd.setCursor (0, 1);
   lcd.print("GAS DEDUCTED");  //MQ-4 Deducted Methane and  CNG Gas
   lcd.display();
   if (Serial.available() > 0)
   {
      String str = Serial.readStringUntil(gas_value);
      DEBUG(gas_value);
   }
   }
   else
   {
    digitalWrite(6,LOW);
    lcd.setCursor (0, 1);
    lcd.print("NO GAS");
    lcd.display();
    if (Serial.available() > 0)
   {
      String str = Serial.readStringUntil(gas_value);
      DEBUG(gas_value);
   }
   }
   delay(1000);
   lcd.clear();
}
