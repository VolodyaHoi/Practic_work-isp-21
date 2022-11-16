/*
 * Даны три числа a, b, c. Определить количество отрицательных и количество 
положительных чисел.
 * */

int positive = 0;
int negative = 0;

Console.Write("Input a: ");
double a = double.Parse(Console.ReadLine());

Console.Write("Input b: ");
double b = double.Parse(Console.ReadLine());

Console.Write("Input c: ");
double c = double.Parse(Console.ReadLine());

if (a > 0)
    positive++;
else if (a < 0)
    negative++;

if (b > 0)
    positive++;
else if (b < 0)
    negative++;

if (c > 0)
    positive++;
else if (c < 0)
    negative++;

Console.WriteLine($"{positive} положительных");
Console.WriteLine($"{negative} отрицательных");