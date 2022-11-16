/*
 * Составьте программу вычисления в массиве суммы всех чисел, кратных 3
 */

const int arrayLength = 27;
Random random = new Random();

int[] someArray = new int[arrayLength];
int sum = 0;

Console.Write("Сумма кратных трём чисел в массиве [\n\t");

for (int i = 0; i < arrayLength; ++i)
{// А есть смысл в массиве, если можно и без него справиться... 🤔
    int element = random.Next(0, 1000);

    someArray[i] = element;
    Console.Write($"{element} ");

    if (element % 3 == 0)
        sum += element;
}

Console.WriteLine($"\n]: {sum}");