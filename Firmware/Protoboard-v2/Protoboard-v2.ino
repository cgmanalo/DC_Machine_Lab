//Computer-based DC Machinery Laboratory
//EE200D- Capstone Project
//Copyright (c) 2019-2020, D. Muniz, A. Marcaida, Cesar G. Manalo, Jr. (Adviser)

#include <EEPROM.h>
#include <avr/wdt.h>

String SerialData;
void(* resetFunc) (void) = 0;
#define Voltmeter1APin A0
#define Voltmeter1BPin A1
#define AmmeterPin1 A2
#define AmmeterPin2 A3
#define FieldPin 11
#define PowerPin 12
#define SpeedPin A4
#define TorquePin A5

//>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>


void setup() {
 Serial.begin(9600);
 pinMode(FieldPin, OUTPUT);
 pinMode(PowerPin, OUTPUT);
 analogWrite(FieldPin,100.0);
 analogWrite(PowerPin,100.0);
 //PORTD = (PORTD & B11101111) | B00001100; //set comms. channel to UART/PLC
 
// getConfiguration();
 Preamble();
 //watchdogSetup();
}

//>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

void loop() {
  //wdt_reset();
  SerialData = GetSerialData();
  String CommandField = ExtractField(SerialData,1);
  if (CommandField == "E1R1"){
    SR("E1R1|" + (String) RVoltmeter1APin());
  }
  if (CommandField == "E1R2"){
    SR("E1R2|" + (String) RVoltmeter1BPin());
  }
  
  if (CommandField == "E1"){
    SR("E1|" + (String) ReadE1());
  }
  if (CommandField == "E2"){
    SR("E2|" + (String) ReadE2());
  }
  if (CommandField == "I1"){
    SR("I1|" + (String) ReadI1());
  }
  if (CommandField == "I2"){
    SR("I2|" + (String) ReadI2());
  }
  if (CommandField == "N1"){
    String DataField = ExtractField(SerialData,2);
    if (DataField == ""){
      SR("N1|" + (String) ReadN1());
    }
    else{
      SR("N1|" + (String) AdjustN1(DataField.toInt()));
    }
  }
  else if (CommandField == "HB"){
    SR("OK.");
  }
}

//***** SUBROUTINES *****//

float RVoltmeter1APin(){
  return (analogRead(Voltmeter1APin));
}

float RVoltmeter1BPin(){
  return (analogRead(Voltmeter1BPin));
}

float ReadE1(){
  float ReadingPos = 0.0;
  float ReadingNeg = 0.0;

  for(int i=0;i<10;i++){
    ReadingPos += analogRead(Voltmeter1APin);
    ReadingNeg += analogRead(Voltmeter1BPin);
    delay(100);
  }
  if (ReadingPos >= ReadingNeg){return (26.0/203.0)*(ReadingPos/10);}
  else {return (-1.0*ReadingNeg*(26.0/203.0)/10);}
}

float ReadE2(){
  float ReadingPos = 0.0;
  float ReadingNeg = 0.0;

  for(int i=0;i<10;i++){
    ReadingPos += analogRead(Voltmeter1APin);
    ReadingNeg += analogRead(Voltmeter1BPin);
    delay(100);
  }
  if (ReadingPos >= ReadingNeg){return (ReadingPos/10);}
  else {return (-1.0*ReadingNeg/10);}
}

float ReadI1(){
  return ((0.05*analogRead(AmmeterPin1))-25.55);
}

float ReadI2(){
  return analogRead((0.05*AmmeterPin2)-25.55);
}

float AdjustN1(int DutyCycle){
  analogWrite(FieldPin,DutyCycle*(255/100));
  delay(100);
  return ReadN1();
}

float ReadN1(){
  return analogRead(SpeedPin);
}

void serialFlush(){
  while(Serial.available() > 0) {
    char t = Serial.read();
  }
}

void SR(String replyMessage){
  Serial.println(replyMessage);
}

void setPA1Channel(){
  PORTD = (PORTD & B11100011);
  delay(100);
}

void setPA2Channel(){
  PORTD = (PORTD & B11100111) | B00000100;
  delay(100);
}

void setPA3Channel(){
  PORTD = (PORTD & B11101011) | B00001000;
  delay(100);
}

void setPLCChannel(){
  PORTD = (PORTD & B11101111) | B00001100;
  delay(100);
}

void sendCharDirect(char charToSend){
  Serial.print(charToSend);
}

String GetSerialData(){
  Serial.setTimeout(10);
  return Serial.readStringUntil('\n');
}

String ExtractField(String rawString, int fieldNum){
   char dataArray[30];
   char fieldArray[25];   
   char inChar;
   
   rawString.toCharArray(dataArray,rawString.length()+1);

   //first field
   if (fieldNum == 1){
     int i=0;
     for(i;i<rawString.length();i++){
       inChar = dataArray[i];
       if (inChar == '|'){
         break;
       }
       fieldArray[i] = inChar;
     } 
     fieldArray[i]='\0';
     return fieldArray;
   }

   //second field
   else if (fieldNum == 2) {
     int i = rawString.indexOf('|')+1;
     int j=i;
     for(i;i<rawString.length();i++){
       inChar = dataArray[i];
       if (inChar == '|'){
         break;
       }
       fieldArray[i-j] = inChar;
     }
     fieldArray[i-j]='\0';
     return fieldArray;
   }

  //third field
   else if (fieldNum == 3) {
     int i = rawString.indexOf('|',rawString.indexOf('|')+1)+1;
     int j=i;
     for(i;i<rawString.length();i++){
       inChar = dataArray[i];
       if (inChar == '|'){
         break;
       }
       fieldArray[i-j] = inChar;
     }
     fieldArray[i-j]='\0';
     return fieldArray;
   }
   else if (fieldNum == 4) {
     int i = rawString.indexOf('|',rawString.indexOf('|',rawString.indexOf('|')+1)+1)+1;
     int j=i;
     for(i;i<rawString.length();i++){
       inChar = dataArray[i];
       if (inChar == '|'){
         break;
       }
       fieldArray[i-j] = inChar;
     }
     fieldArray[i-j]='\0';
     return fieldArray;
   }
     
   return "";
}

void watchdogSetup(void)
{
cli();       // disable all interrupts
wdt_reset(); // reset the WDT timer
/*
 WDTCSR configuration:
 WDIE = 1: Interrupt Enable
 WDE = 1 :Reset Enable
 WDP3 = 1 :For 8000ms Time-out
 WDP2 = 0 :For 8000ms Time-out
 WDP1 = 0 :For 8000ms Time-out
 WDP0 = 1 :For 8000ms Time-out
*/
// Enter Watchdog Configuration mode:
WDTCSR |= (1<<WDCE) | (1<<WDE);
// Set Watchdog settings:
 WDTCSR = (1<<WDIE) | (1<<WDE) | (1<<WDP3) | (0<<WDP2) | (0<<WDP1) | (1<<WDP0);
sei();
}

void Preamble()
{
  Serial.println("\nComputer-based DC Machinery Laboratory Protoboard ver. 2.1 - Model A\n");
  Serial.println("EE200D-2019 Capstone Project");
  Serial.println("Copyright (c) 2019-2020, J. Muniz, A. Marcaida, Cesar G. Manalo, Jr. (Adviser)");
}



/*
void getConfiguration()
{
 ROOM_CONTROLLER_ADDR = EEPROM.read(ctlrAddrMap); //retrieve first address
 if (ROOM_CONTROLLER_ADDR < 65 || ROOM_CONTROLLER_ADDR > 90){ROOM_CONTROLLER_ADDR = 65;}
 ROOM_COUNT = EEPROM.read(ctlrAddrCountMap)-48; //retrieve number of addresses
 if (ROOM_COUNT < 1 || ROOM_COUNT > 3){ROOM_COUNT = 3;}
 timeDelayLighting = (EEPROM.read(timeDelayLightingAddr)-48)*500;
 if (timeDelayLighting < 0 || timeDelayLighting > 2500){timeDelayLighting = 0;}
 timeDelayACU = (EEPROM.read(timeDelayACUAddr)-48)*500;
 if (timeDelayACU < 0 || timeDelayACU > 2500){timeDelayACU = 0;}
 transmitWait = (EEPROM.read(transmitWaitAddr)-48)*200;
 if (transmitWait < 0 || transmitWait > 1800){transmitWait = 0;}
 receiveWait = (EEPROM.read(receiveWaitAddr)-48)*200;
 if (receiveWait < 200 || receiveWait > 1000){receiveWait = 200;}
}

String dayAsString(const Time::Day day) {
  switch (day) {
    case Time::kSunday: return "Sun";
    case Time::kMonday: return "Mon";
    case Time::kTuesday: return "Tue";
    case Time::kWednesday: return "Wed";
    case Time::kThursday: return "Thu";
    case Time::kFriday: return "Fri";
    case Time::kSaturday: return "Sat";
  }
  return "???";  //unknown day
}
String getWeekday (int dayNumber){
  String Weekday;  
  switch (dayNumber) {
      case 0:
        Weekday = "Sun";
        break;
      case 1:
        Weekday = "Mon";
        break;
      case 2:
        Weekday = "Tue";
        break;
      case 3:
        Weekday = "Wed";
        break;
      case 4:
        Weekday = "Thu";
        break;
      case 5:
        Weekday = "Fri";
        break;
      case 6:
        Weekday = "Sat";
        break;
      default:
        break;
  }
  return Weekday;
}
String getAMPM(int hourNumber){
  if (hourNumber < 12)
  {
      return "AM";
  }
  else
  {
      return "PM";
  }
}
String getNormalizedHour(int hourNumber){
  String hourString;
 
  if (hourNumber < 13)
  {
    hourString = String(hourNumber); 
  }
  else
  {
    hourString = String(hourNumber-12); 
  }
  if (hourString.length()==1)
  {
      return "0"+hourString;
  }
  else
  {
      return hourString;
  }
}

String getNormalizedMinute(int minuteNumber){
  String minuteString;
 
  minuteString = String(minuteNumber);
  if (minuteString.length()==1)
  {
      return "0"+minuteString;
  }
  else
  {
      return minuteString;
  }
}

String getNormalizedSecond(int secondNumber){
  String secondString;
 
  secondString = String(secondNumber);
  if (secondString.length()==1)
  {
      return "0"+secondString;
  }
  else
  {
      return secondString;
  }
}

unsigned int timeValue(String timeString){

   int AMPMAddress = timeString.length()-2;
   //return timeString.substring(3,5).toInt();

   if (timeString.substring(AMPMAddress)=="AM"){
     return 60*timeString.substring(0,2).toInt()+timeString.substring(3,5).toInt();
   }
   else{
     if (timeString.substring(0,2).toInt()==12){
       return 60*12+timeString.substring(3,5).toInt();
     }
     else{
       return 60*(12+timeString.substring(0,2).toInt())+timeString.substring(3,5).toInt();
     }
   }
}

void blink() {
  if ((long)(micros()-last_micros) > debouncingTime*1000){
    digitalWrite(lighting1Pin,!digitalRead(lighting1Pin));
    last_micros = micros();
  }
}
*/
