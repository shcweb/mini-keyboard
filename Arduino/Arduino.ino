/*
 Name:		Arduino.ino
 Created:	2020/3/10 14:49:50
 Author:	sunha
*/
#include <Keyboard.h>
#include <EEPROM.h>
#define LPIN 9
#define RPIN 13
struct Keys
{
    byte Lkey = B0000;
    byte LstrLength = 0;
    char Lstr[50] = "";
    byte Rkey = B0000;
    byte RstrLength = 0;
    char Rstr[50] = "";
} keys;
// the setup function runs once when you press reset or power the board
void setup() {
    pinMode(LPIN, INPUT_PULLUP);
    pinMode(RPIN, INPUT_PULLUP);
    Serial.begin(115200);
    EEPROM.get(0, keys);
    Serial.println(keys.Lkey);
    Serial.println(keys.Lstr);
    Serial.println(keys.Rkey);
    Serial.println(keys.Rstr);
    Keyboard.begin();
}

// the loop function runs over and over again until power down or reset
void loop() {
    if (Serial.available() > 0)
    {
        String key;
        key = Serial.readStringUntil(29);
        keys.Lkey = 0;
        for (int i = 0; i < 4; i++)
        {
            keys.Lkey += key[i] << i;
        }
        strcpy(keys.Lstr, Serial.readStringUntil(29).c_str());
        key = Serial.readStringUntil(29);
        keys.Rkey = 0;
        for (int i = 0; i < 4; i++)
        {
            keys.Rkey += key[i] << (3 - i);
        }
        strcpy(keys.Rstr, Serial.readStringUntil(29).c_str());
        keys.RstrLength = strlen(keys.Rstr);
        EEPROM.put(0, keys);
    }
    if (digitalRead(LPIN))
    {
        if (keys.Lkey & B0001)
            Keyboard.press(KEY_LEFT_CTRL);
        if (keys.Lkey & B0010)
            Keyboard.press(KEY_LEFT_SHIFT);
        if (keys.Lkey & B0100)
            Keyboard.press(KEY_LEFT_ALT);
        if (keys.Lkey & B1000)
            Keyboard.press(KEY_LEFT_ALT);
        for (int i = 0; i < keys.LstrLength; i++)
            Keyboard.press(keys.Lstr[i]);
    }
    else
    {
        if (keys.Lkey & B0001)
            Keyboard.release(KEY_LEFT_CTRL);
        if (keys.Lkey & B0010)
            Keyboard.release(KEY_LEFT_SHIFT);
        if (keys.Lkey & B0100)
            Keyboard.release(KEY_LEFT_ALT);
        if (keys.Lkey & B1000)
            Keyboard.release(KEY_LEFT_ALT);
        for (int i = 0; i < keys.LstrLength; i++)
            Keyboard.release(keys.Lstr[i]);
    }
    if (digitalRead(RPIN))
    {
        if (keys.Rkey & B0001)
            Keyboard.press(KEY_LEFT_CTRL);
        if (keys.Rkey & B0010)
            Keyboard.press(KEY_LEFT_SHIFT);
        if (keys.Rkey & B0100)
            Keyboard.press(KEY_LEFT_ALT);
        if (keys.Rkey & B1000)
            Keyboard.press(KEY_LEFT_ALT);
        for (int i = 0; i < keys.RstrLength; i++)
            Keyboard.press(keys.Rstr[i]);
    }
    else
    {
        if (keys.Rkey & B0001)
            Keyboard.release(KEY_LEFT_CTRL);
        if (keys.Rkey & B0010)
            Keyboard.release(KEY_LEFT_SHIFT);
        if (keys.Rkey & B0100)
            Keyboard.release(KEY_LEFT_ALT);
        if (keys.Rkey & B1000)
            Keyboard.release(KEY_LEFT_ALT);
        for (int i = 0; i < keys.RstrLength; i++)
            Keyboard.release(keys.Rstr[i]);
    }
}
