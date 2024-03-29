#define Pin1 22
#define Pin2 21
#define PWM1 23

#define Pin3 17
#define Pin4 18
#define PWM2 19

#include <WiFi.h>
//#include <DynamixelMEGA_Shield.h>

#define WIFI_STA_NAME "TIMAUTISTIC"
#define WIFI_STA_PASS "LoongTis"

int Speed;
int Offset = 25;
int DefSpeed = 150;

int joystickX;
int joystickY;

int speedMode = 1;

int camMode = 1;

unsigned long previousMillis = 0;   // will store last time LED was updated
const long interval = 1000;        // interval at which to blink (milliseconds)

float busV, shuntV, loadV, current, pwr;

WiFiServer server(80);

void setup() {
  pinMode(Pin1, OUTPUT);
  pinMode(Pin2, OUTPUT);
  pinMode(Pin3, OUTPUT);
  pinMode(Pin4, OUTPUT);
  Serial.begin(115200);

  //Dynamixel.begin(1000000);

  Serial.print("Connecting to ");
  Serial.println(WIFI_STA_NAME);

  WiFi.mode(WIFI_STA);
  WiFi.begin(WIFI_STA_NAME, WIFI_STA_PASS);

  while (WiFi.status() != WL_CONNECTED) {
    delay(500);
    Serial.print(".");
  }
  Serial.println("");
  Serial.println("WiFi connected");
  Serial.println("IP address: ");
  Serial.println(WiFi.localIP());
  server.begin();
}

void loop() {
  WiFiClient client = server.available();

  if (client) {
    Serial.println("new client");
    while (client.connected()) {
      char command;
      if (client.available()) {
        command = client.read();
        Serial.write(command);

        switch (command) {
          case 'F':
            Forward();
            break;
          case 'B':
            Backward();
            break;
          case 'L':
            Left();
            break;
          case 'R':
            Right();
            break;
          case 'S':
            Stop();
            break;
          case 'T':
            Stop();
            break;
          case '1':
            if (speedMode == 1) {
              speedMode += 1;
              Speed = Speed;
              //Serial.println("Speed 1");
              client.println("Speed 1");
              delay(75);
            }
            else if (speedMode == 2) {
              speedMode += 1;
              Speed = Speed + Offset;
              //Serial.println("Speed 2");
              client.println("Speed 2");
              delay(75);
            }
            else if (speedMode == 3) {
              speedMode = 1;
              Speed = Speed + Offset;
              //Serial.println("Speed 3");
              client.println("Speed 3");
              delay(75);
            }
            break;
          case 'U':
            servoUp();
            //calculateIK();
            //Dynamixel.moveSpeed(5, map(joystickY, 0, 128, 0, 1023), 100);
            //            Dynamixel.move(1, map(baseAngle, 0, 128, 0, 1023));
            //            Dynamixel.move(2, map(armAngle, 0, 128, 0, 1023));
            //            Dynamixel.move(3, map(gripperAngle, 0, 128, 0, 1023));
            break;
          case 'D':
            servoDown();
            //calculateIK();
            //Dynamixel.moveSpeed(5, map(joystickY, 0, 128, 0, 1023), 100);
            //            Dynamixel.move(1, map(baseAngle, 0, 128, 0, 1023));
            //            Dynamixel.move(2, map(armAngle, 0, 128, 0, 1023));
            //            Dynamixel.move(3, map(gripperAngle, 0, 128, 0, 1023));
            break;

            /*case '2':
              if (camMode == 1) {
                speedMode += 1;
                Dynamixel.move(6, 512);
                Serial.println("camMode 3");
              }
              else if (camMode == 2) {
                speedMode += 1;
                Dynamixel.move(6, 614);
                Serial.println("camMode 3");
                delay(75);
              }
              else if (camMode == 3) {
                speedMode = 1;
                Dynamixel.move(6, 1023);
                Serial.println("camMode 3");
                delay(75);
              }*/
        }
      }
      client.println();
      //delayMicroseconds(250);
    }
    client.stop();
    Serial.println("client disonnected");
    Stop();
  }
  delay(10);
}

void Forward() {
  digitalWrite(Pin1, HIGH);
  digitalWrite(Pin2, LOW);
  analogWrite(PWM1, 255);
  digitalWrite(Pin3, HIGH);
  digitalWrite(Pin4, LOW);
  analogWrite(PWM2, 255);
}

void Backward() {
  digitalWrite(Pin1, LOW);
  digitalWrite(Pin2, HIGH);
  analogWrite(PWM1, 255);
  digitalWrite(Pin3, LOW);
  digitalWrite(Pin4, HIGH);
  analogWrite(PWM2, 255);
  //Serial.println("Backward");
}

void Left() {
  digitalWrite(Pin3, LOW);
  digitalWrite(Pin4, HIGH);
  analogWrite(PWM1, 255);
  digitalWrite(Pin1, HIGH);
  digitalWrite(Pin2, LOW);
  analogWrite(PWM2, 255);
  //Serial.println("Left");
}

void Right() {
  digitalWrite(Pin3, HIGH);
  digitalWrite(Pin4, LOW);
  analogWrite(PWM1, 255);
  digitalWrite(Pin1, LOW);
  digitalWrite(Pin2, HIGH);
  analogWrite(PWM2, 255);
  //Serial.println("Right");
}

void Stop() {
  digitalWrite(Pin1, LOW);
  digitalWrite(Pin2, LOW);
  digitalWrite(Pin3, LOW);
  digitalWrite(Pin4, LOW);
}

void servoUp() {
  if (joystickY < 128) {
    joystickY += 1;
    Serial.println(joystickY);
  }
}

void servoDown() {
  if (joystickY > 0) {
    joystickY -= 1;
    Serial.println(joystickY);
  }
}
