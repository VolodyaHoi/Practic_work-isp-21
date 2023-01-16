/* Практическая работа №14. Мансуров В. ИСП-21
 * Задание №1:
 * Описать функцию Even(K) логического типа, возвращающую True, если целый 
параметр K является четным, и False в противном случае. С ее помощью найти количество 
четных чисел в наборе из 10 целых чисел. */

Boolean Even(int K)
{
    Boolean status = false;

    if (K % 2 == 0)
    {
        status = true;
    } else { status = false; }
    Console.WriteLine(status);

    return status;
}

int count = 0, value;
Console.WriteLine("Введите 10 чисел: ");

do
{
    value = Convert.ToInt32(Console.ReadLine());
    Even(value);
    count++;
} while (count != 10);

