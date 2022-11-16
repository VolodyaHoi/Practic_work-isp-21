/*
 * Дана непустая последовательность чисел, оканчивающаяся числом 1000. 
Последовательность является неубывающей. Несколько чисел, идущих подряд, равны 
между собой. Найти количество таких чисел. Сколько различных чисел имеется в 
последовательности?
 */

int value;
int previous = int.MinValue;
int duplicateCount = 0;
int counter = 0;

Console.WriteLine("Введите неубывающую последовательность чисел, оканчивающуюся тысячей");

do
{
    value = int.Parse(Console.ReadLine());
    if (value == previous)
        duplicateCount++;
    else
        counter++;
    previous = value;
}
while (value < 1000);

Console.WriteLine($"Количество повторений: {duplicateCount}\n{counter} различных чисел");