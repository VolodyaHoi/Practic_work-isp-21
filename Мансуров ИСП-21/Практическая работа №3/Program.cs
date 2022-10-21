// 28.09.22 Практическая работа №3 Вариант №9
// Даны три числа a, b, c. Определить количество отрицательных и количество 
// положительных чисел.

int a, b, c, plus = 0, minus = 0;

Console.WriteLine("Введите a: ");
a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите b: ");
b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите c: ");
c = Convert.ToInt32(Console.ReadLine());

if (a > 0)
{
    plus++;
}
else if (a != 0) { minus++; }

if (b > 0)
{
    plus++;
}
else if (b != 0) { minus++; }

if (c > 0)
{
    plus++;
}
else if (c != 0) { minus++; }

Console.WriteLine("Положительных: {0}", plus);
Console.WriteLine("Отрицательных: {0}", minus);