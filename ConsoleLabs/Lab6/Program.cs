/**
 * Найти 15 первых натуральных чисел, делящихся нацело на 19 и находящихся в интервале, левая граница которого равна 100.
 */

int number = 100;
int counter = 0;

while (counter < 15)
{
    number++;
    if (number % 19 == 0)
    {
        Console.WriteLine($"{++counter}: {number}");
    }
}