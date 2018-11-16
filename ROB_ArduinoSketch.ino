//define pins on board
int armsClosed = 13;                  
int armsOpen = 12;

int armsRight = 17;
int armsLeft = 16;

int armsDown = 15;
int armsUp = 14;

int ledTop1 = 18;
int ledTop2 = 19;

int ledEyes1 = 20;
int ledEyes2 = 21;

int incomingByte = 0;
                
void setup()                      
{
  pinMode(armsClosed, OUTPUT);    
  pinMode(armsOpen, OUTPUT);      
  pinMode(armsRight, OUTPUT);
  pinMode(armsLeft, OUTPUT);
  pinMode(armsDown, OUTPUT);
  pinMode(armsUp, OUTPUT); 
  pinMode(ledTop1, OUTPUT);
  pinMode(ledTop2, OUTPUT);
  pinMode(ledEyes1, OUTPUT); 
  pinMode(ledEyes2, OUTPUT);

  Serial.begin(9600); //Starts the serial connection
}

void loop()                       
{
  if(Serial.available() > 0){
    
    incomingByte = Serial.read(); //Removes the message from the serial cache
    //Serial.print(incomingByte);
    
    if(incomingByte == 49){
      digitalWrite(ledEyes2, LOW);
      digitalWrite(ledEyes1, HIGH);
      digitalWrite(ledTop2, LOW);
      digitalWrite(ledTop1, HIGH); 
    }
    if(incomingByte == 50){
      digitalWrite(ledEyes2, LOW);
      digitalWrite(ledEyes1, LOW);
      digitalWrite(ledTop2, LOW);
      digitalWrite(ledTop1, LOW); 
    }
    if(incomingByte == 51){
      digitalWrite(armsLeft, LOW);
      digitalWrite(armsRight, HIGH); 
      delay(1000);     // waits for 4 seconds
    }
    if(incomingByte == 52){
      digitalWrite(armsLeft, HIGH);
      digitalWrite(armsRight, LOW); 
      delay(1000);     // waits for 4 seconds
    }
    if(incomingByte == 53){
      digitalWrite(armsUp, LOW);
      digitalWrite(armsDown, HIGH); 
      delay(1000);     // waits for 4 seconds
    }
    if(incomingByte == 54){
      digitalWrite(armsDown, LOW);
      digitalWrite(armsUp, HIGH); 
      delay(1000);     // waits for 4 seconds
    }
    if(incomingByte == 55){
      digitalWrite(armsOpen, LOW);
      digitalWrite(armsClosed, HIGH); 
      delay(500);     // waits for 2 seconds
    }
    if(incomingByte == 56){
      digitalWrite(armsOpen, HIGH);
      digitalWrite(armsClosed, LOW); 
      delay(500);     // waits for 2 seconds
    }
  }
  else
  {
    digitalWrite(armsRight, LOW);
    digitalWrite(armsLeft, LOW);
    digitalWrite(armsUp, LOW);
    digitalWrite(armsDown, LOW); 
    digitalWrite(armsOpen, LOW);
    digitalWrite(armsClosed, LOW);
  }
}
