/*
 Name:		Arduino.ino
 Created:	2020/3/10 14:49:50
 Author:	sunha
*/
#include <EEPROM.h>
struct Keys
{
    byte key = B0000;
    byte strLength = 0;
    char str[233] = "";
} keys;
// the setup function runs once when you press reset or power the board
void setup() {
    Serial.begin(115200);
    EEPROM.get(0, keys);
    Serial.println(keys.key);
    Serial.println(keys.str);
}

// the loop function runs over and over again until power down or reset
void loop() {
    if (Serial.available > 0)
    {
        String key = Serial.readStringUntil('|');
        keys.key = 0;
        for (int i = 0; i < 4; i++)
        {
            key += key[i] << i;
        }
        strcpy(keys.str, Serial.readStringUntil('>').c_str());
        keys.strLength = strlen(keys.str);
        EEPROM.put(0, keys);
    }

}
