// Практическая работа №7. Мансуров В. ИСП-21
// Дана непустая последовательность чисел, оканчивающаяся числом 1000. 
// Последовательность является неубывающей. Несколько чисел, идущих подряд, равны 
// между собой. Найти количество таких чисел. Сколько различных чисел имеется в 
// последовательности?


int value, dupNum = 0, backNum = int.MinValue, count = 0;

Console.WriteLine("Введите последовательность чисел, с 1000 на конце: ");

do
{
    value = Convert.ToInt32(Console.ReadLine());
    if (value == backNum)
        dupNum++;
    else
        count++;
    backNum = value;
}
while (value < 1000);

Console.WriteLine("Количество повторений: {0}", dupNum);
Console.WriteLine("Количество разных чисел: {0}", count - dupNum);