#define Pin1 22
#define Pin2 21
#define PWM1 23

#define Pin3 17
#define Pin4 18
#define PWM2 19

#include <WiFi.h>

#define WIFI_STA_NAME "TIMAUTISTIC"
#define WIFI_STA_PASS "LoongTis"

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
//        Serial.write(command);
//        if (command == 'F') {
//          Forward();
//        }
//        else if (command == 'B') {
//          Backward();
//        }
//        else if (command == 'R') {
//          Right();
//        }
//        else if (command == 'L') {
//          Left();
//        }
//        else {
//          delay(25);
//          Stop();
//        }
        
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
        }
      }
      client.println();
      //delayMicroseconds(250);
    }
    client.stop();
    Serial.println("client disonnected");
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
