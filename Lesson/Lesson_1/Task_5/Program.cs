/*Задача 5
Дано натуральное число N. Вывести на экран числа от 1 до N.
Пример 1
N = 4
1 2 3 4
Пример 2
N = 9
1 2 3 4 5 6 7 8 9   */

int n = 4;
Console.WriteLine("Решение 1:");
for (int i = 1; i <= n; i++)
{
    //Console.WriteLine(i);
    Console.Write(i);
    Console.Write(' ');
}

Console.WriteLine();
Console.WriteLine("Решение 2:");
int j = 1;
while (j <= n)
{
    Console.Write(j);
    Console.Write(' ');
    j++;
}

