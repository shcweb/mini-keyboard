/*
 Name:    Arduino.ino
 Created: 2020/3/10 14:49:50
 Author:  sunha
*/

#include <Keyboard.h>
#include <EEPROM.h>

#define LPIN 9
#define RPIN 13

bool is_left_pressed = false, is_right_pressed = false;

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
	Serial.begin(9600);
	EEPROM.get(0, keys);
	Keyboard.begin();
}

// the loop function runs over and over again until power down or reset
void loop() {
	if (Serial.available() > 0)
	{
		String key;
		key = Serial.readStringUntil((char)29);
		keys.Lkey = 0;
		for (int i = 0; i < 4; i++)
		{
			keys.Lkey += key[i] << i;
		}
		Serial.println(key);
		strcpy(keys.Lstr, Serial.readStringUntil((char)29).c_str());
		Serial.println(keys.Lstr);
		key = Serial.readStringUntil((char)29);
		keys.Rkey = 0;
		for (int i = 0; i < 4; i++)
		{
			keys.Rkey += key[i] << i;
		}
		Serial.println(key);
		strcpy(keys.Rstr, Serial.readStringUntil((char)29).c_str());
		Serial.println(keys.Rstr);
		keys.LstrLength = strlen(keys.Lstr);
		keys.RstrLength = strlen(keys.Rstr);
		EEPROM.put(0, keys);
		while (Serial.available() > 0)
			Serial.read();
	}

	if (!digitalRead(LPIN) && !is_left_pressed)
	{
		if (keys.Lkey & B0001)
			Keyboard.press(KEY_LEFT_CTRL);
		if (keys.Lkey & B0010)
			Keyboard.press(KEY_LEFT_SHIFT);
		if (keys.Lkey & B0100)
			Keyboard.press(KEY_LEFT_ALT);
		if (keys.Lkey & B1000)
			Keyboard.press(KEY_LEFT_GUI);
		Keyboard.print(keys.Lstr);
		is_left_pressed = true;
		delay(50);
	}
	else if (digitalRead(LPIN) && is_left_pressed)
	{
		if (keys.Lkey & B0001)
			Keyboard.release(KEY_LEFT_CTRL);
		if (keys.Lkey & B0010)
			Keyboard.release(KEY_LEFT_SHIFT);
		if (keys.Lkey & B0100)
			Keyboard.release(KEY_LEFT_ALT);
		if (keys.Lkey & B1000)
			Keyboard.release(KEY_LEFT_GUI);
		is_left_pressed = false;
	}
	if (!digitalRead(RPIN) && !is_right_pressed)
	{
		if (keys.Rkey & B0001)
			Keyboard.press(KEY_LEFT_CTRL);
		if (keys.Rkey & B0010)
			Keyboard.press(KEY_LEFT_SHIFT);
		if (keys.Rkey & B0100)
			Keyboard.press(KEY_LEFT_ALT);
		if (keys.Rkey & B1000)
			Keyboard.press(KEY_LEFT_GUI);
		Keyboard.print(keys.Rstr);
		is_right_pressed = true;
		delay(50);
	}
	else if (digitalRead(RPIN) && is_right_pressed)
	{
		if (keys.Rkey & B0001)
			Keyboard.release(KEY_LEFT_CTRL);
		if (keys.Rkey & B0010)
			Keyboard.release(KEY_LEFT_SHIFT);
		if (keys.Rkey & B0100)
			Keyboard.release(KEY_LEFT_ALT);
		if (keys.Rkey & B1000)
			Keyboard.release(KEY_LEFT_GUI);
		is_right_pressed = false;
	}
}
