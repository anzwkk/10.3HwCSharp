﻿Console.WriteLine("Введіть рядок, де слова розділені комами: ");
string input = Console.ReadLine();

string result = input.Replace(" ", "");
Console.WriteLine($"Результат без пробілів: {result} ");