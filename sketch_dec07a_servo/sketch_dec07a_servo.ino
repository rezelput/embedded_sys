#include <Servo.h>

Servo serv1;

void setup() {
  // put your setup code here, to run once:
serv1.attach(9);
Serial.begin(9600);
}

void loop() {
  // put your main code here, to run repeatedly:
if(Serial.available())
{
  int c = Serial.read();
  serv1.write(c);
  delay(15);
  }
}
