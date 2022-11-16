/*
 * Описать функцию Even(K) логического типа, возвращающую True, если целый
параметр K является четным, и false в противном случае. С ее помощью найти количество
четных чисел в наборе из 10 целых чисел.
 */

static bool Even(int K) //IsEven
{
    return K % 2 == 0;
}

Console.WriteLine("Введите 10 целых чисел");

int count = 0;

for (int i = 0; i < 10; i++)
    if (Even(int.Parse(Console.ReadLine()))) count++;

Console.WriteLine($"Их них чётны: {count} шт");