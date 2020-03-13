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
bool is_press_left = true, is_press_right = true;

struct Keys
{
	int Lkey = B00000000;
	byte LstrLength = 0;
	char Lstr[100] = "";
	int Rkey = B00000000;
	byte RstrLength = 0;
	char Rstr[100] = "";
} keys;

void selectMode()
{
	int checker = 0;
	if (keys.LstrLength > 5)
		is_press_left = false;
	for (int i = 0; i < keys.LstrLength; i++)
	{
		int val = keys.Lstr[i] - 'a';
		if ((checker & (1 << val)) > 0)
		{
			is_press_left = false;
		}
		checker |= (1 << val);
	}
	checker = 0;
	if (keys.RstrLength > 5)
		is_press_left = false;
	for (int i = 0; i < keys.RstrLength; i++)
	{
		int val = keys.Rstr[i] - 'a';
		if ((checker & (1 << val)) > 0)
		{
			is_press_right = false;
		}
		checker |= (1 << val);
	}
}

// the setup function runs once when you press reset or power the board
void setup() {
	pinMode(LPIN, INPUT_PULLUP);
	pinMode(RPIN, INPUT_PULLUP);
	Serial.begin(9600);
	EEPROM.get(0, keys);
	Keyboard.begin();
	selectMode();
}

// the loop function runs over and over again until power down or reset
void loop() {
	if (Serial.available() > 0)
	{

		String key;
		key = Serial.readStringUntil((char)29);
		keys.Lkey = 0;
		for (int i = 0; i < 8; i++)
		{
			keys.Lkey += (key[i] - '0') << i;
		}
		//Serial.println(key);
		//Serial.println(keys.Lkey, BIN);
		strcpy(keys.Lstr, Serial.readStringUntil((char)29).c_str());
		//Serial.println(keys.Lstr);
		key = Serial.readStringUntil((char)29);
		keys.Rkey = 0;
		for (int i = 0; i < 8; i++)
		{
			keys.Rkey += (key[i] - '0') << i;
		}
		//Serial.println(key);
		//Serial.println(keys.Rkey, BIN);
		strcpy(keys.Rstr, Serial.readStringUntil((char)29).c_str());
		//Serial.println(keys.Rstr);
		keys.LstrLength = strlen(keys.Lstr);
		keys.RstrLength = strlen(keys.Rstr);
		EEPROM.put(0, keys);
		while (Serial.available() > 0)
			Serial.read();
		selectMode();
	}

	if (!digitalRead(LPIN) && !is_left_pressed)
	{
		//Serial.println(keys.Lkey, BIN);
		if (keys.Lkey & B00000001)
			Keyboard.press(KEY_LEFT_CTRL);
		if (keys.Lkey & B00000010)
			Keyboard.press(KEY_LEFT_SHIFT);
		if (keys.Lkey & B00000100)
			Keyboard.press(KEY_LEFT_ALT);
		if (keys.Lkey & B00001000)
			Keyboard.press(KEY_LEFT_GUI);
		if (keys.Lkey & B00010000)
			Keyboard.press(KEY_TAB);
		if (keys.Lkey & B00100000)
			Keyboard.press(KEY_DELETE);
		if (keys.Lkey & B01000000)
			Keyboard.press(KEY_ESC);
		if (keys.Lkey & B10000000)
			Keyboard.press(KEY_BACKSPACE);
		if (is_press_left)
			for (int i = 0; i < keys.LstrLength; i++)
				Keyboard.press(keys.Lstr[i]);
		else
			Keyboard.print(keys.Lstr);
		is_left_pressed = true;
		while (!digitalRead(LPIN));
		delay(70);
	}
	else if (digitalRead(LPIN) && is_left_pressed)
	{
		if (is_press_left)
			for (int i = 0; i < keys.LstrLength; i++)
				Keyboard.release(keys.Lstr[i]);
		if (keys.Lkey & B00000001)
			Keyboard.release(KEY_LEFT_CTRL);
		if (keys.Lkey & B00000010)
			Keyboard.release(KEY_LEFT_SHIFT);
		if (keys.Lkey & B00000100)
			Keyboard.release(KEY_LEFT_ALT);
		if (keys.Lkey & B00001000)
			Keyboard.release(KEY_LEFT_GUI);
		if (keys.Lkey & B00010000)
			Keyboard.release(KEY_TAB);
		if (keys.Lkey & B00100000)
			Keyboard.release(KEY_DELETE);
		if (keys.Lkey & B01000000)
			Keyboard.release(KEY_ESC);
		if (keys.Lkey & B10000000)
			Keyboard.release(KEY_BACKSPACE);
		is_left_pressed = false;
	}
	if (!digitalRead(RPIN) && !is_right_pressed)
	{
		//Serial.println(keys.Rkey, BIN);
		if (keys.Rkey & B00000001)
			Keyboard.press(KEY_LEFT_CTRL);
		if (keys.Rkey & B00000010)
			Keyboard.press(KEY_LEFT_SHIFT);
		if (keys.Rkey & B00000100)
			Keyboard.press(KEY_LEFT_ALT);
		if (keys.Rkey & B00001000)
			Keyboard.press(KEY_LEFT_GUI);
		if (keys.Rkey & B00010000)
			Keyboard.press(KEY_TAB);
		if (keys.Rkey & B00100000)
			Keyboard.press(KEY_DELETE);
		if (keys.Rkey & B01000000)
			Keyboard.press(KEY_ESC);
		if (keys.Rkey & B10000000)
			Keyboard.press(KEY_BACKSPACE);
		if (is_press_right)
			for (int i = 0; i < keys.RstrLength; i++)
				Keyboard.press(keys.Rstr[i]);
		else
			Keyboard.print(keys.Rstr);
		is_right_pressed = true;
		while (!digitalRead(LPIN));
		delay(70);
	}
	else if (digitalRead(RPIN) && is_right_pressed)
	{
		if (is_press_right)
			for (int i = 0; i < keys.RstrLength; i++)
				Keyboard.release(keys.Rstr[i]);
		if (keys.Rkey & B00000001)
			Keyboard.release(KEY_LEFT_CTRL);
		if (keys.Rkey & B00000010)
			Keyboard.release(KEY_LEFT_SHIFT);
		if (keys.Rkey & B00000100)
			Keyboard.release(KEY_LEFT_ALT);
		if (keys.Rkey & B00001000)
			Keyboard.release(KEY_LEFT_GUI);
		if (keys.Rkey & B00010000)
			Keyboard.release(KEY_TAB);
		if (keys.Rkey & B00100000)
			Keyboard.release(KEY_DELETE);
		if (keys.Rkey & B01000000)
			Keyboard.release(KEY_ESC);
		if (keys.Rkey & B10000000)
			Keyboard.release(KEY_BACKSPACE);
		is_right_pressed = false;
	}
}
