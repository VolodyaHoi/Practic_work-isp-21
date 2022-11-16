/*
 * Сформировать одномерный массив из сумм элементов строк матрицы.
 */

const int matrixSize = 10;
Random random = new Random();

int[,] matrix = new int[matrixSize, matrixSize];

for (int i = 0; i < matrixSize; i++)
{
    for (int j = 0; j < matrixSize; j++)
    {
        int element = random.Next(-100, 100);

        matrix[i, j] = element;
        Console.Write($"{element} ");
    }
    Console.Write('\n');
}

int[] array = new int[matrixSize];

for (int i = 0; i < matrixSize; i++)
{
    array[i] = 0;
    for (int j = 0; j < matrixSize; j++)
        array[i] += matrix[i, j];
}

Console.WriteLine($"Массив из матрицы: [{string.Join(", ", array)}]");