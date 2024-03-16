#define Pin1 22
#define Pin2 21
#define PWM1 23

#define Pin3 17
#define Pin4 18
#define PWM2 19

#include <WiFi.h>

#define WIFI_STA_NAME "SiC-2.4GHz"
#define WIFI_STA_PASS "sicsicsic"

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
        if (client.available() >= 4) {
          int rt_rx, lt_rx;
          client.readBytes((char*)&rt_rx, sizeof(rt_rx));
          client.readBytes((char*)&lt_rx, sizeof(lt_rx));

          int rtmap = map(rt_rx, 0, 1023, 0, 255);
          int ltmap = map(lt_rx, 0, 1023, 0, 255);

          Forward(rtmap);
          Backward(ltmap);
        }
        command = client.read();
        Serial.write(command);

        switch (command) {
//          case 'F':
//            Forward();
//            break;
//          case 'B':
//            Backward();
//            break;
          case 'L':
            Left();
            break;
          case 'R':
            Right();
            break;
          case 'S':
            Stop();
            break;
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

void Forward(int Speed) {
  digitalWrite(Pin1, HIGH);
  digitalWrite(Pin2, LOW);
  analogWrite(PWM1, Speed);
  digitalWrite(Pin3, HIGH);
  digitalWrite(Pin4, LOW);
  analogWrite(PWM2, Speed);
}

void Backward(int Speed) {
  digitalWrite(Pin1, LOW);
  digitalWrite(Pin2, HIGH);
  analogWrite(PWM1, Speed);
  digitalWrite(Pin3, LOW);
  digitalWrite(Pin4, HIGH);
  analogWrite(PWM2, Speed);
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
