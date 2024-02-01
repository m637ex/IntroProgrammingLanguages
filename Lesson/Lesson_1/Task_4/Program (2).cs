/* Задача 4
Дано 5 гирь.
найти вес самой тяжёлой гири */

int a = 5;
int b = 6;
int c = 7;
int d = 8;
int e = 9;

int max = a;
if (b > max){
    max = b;    
}
if (c > max){
    max = c;    
}
if (d > max){
    max = d;
}
if (e > max){
    max = e;  
}

Console.WriteLine(max);
