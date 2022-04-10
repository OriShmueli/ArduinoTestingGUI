int ledPin = 13;
int number = 0;

void setup() {
  pinMode(ledPin, OUTPUT);
  Serial.begin(9600);
}

void loop() {
  
  while(Serial.available() > 0){
    char serial = Serial.read();
    if(serial == '0'){
      digitalWrite(ledPin, LOW);
    }

    if(serial == '1'){
      digitalWrite(ledPin, HIGH);
    }
  }
  
  

}
