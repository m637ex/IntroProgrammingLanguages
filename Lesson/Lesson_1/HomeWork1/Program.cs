﻿/*Домашнее задание
Вычислить значение формулы (a * b) / (c + d),
где a, b, c, d — некоторые целые числа.
Результат вывести на экран.
*/

int a = 15;
int b = 2;
int c = 3;
float d = 4;                // если int, то  резултат мат операции округленное целое число типа int
double result = (a * b) / (c + d);
Console.WriteLine(result);