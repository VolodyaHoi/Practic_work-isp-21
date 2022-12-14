// Практическая работа №10. Мансуров В. ИСП-21

// Сформировать одномерный массив из сумм элементов строк матрицы.

int w, h, sum = 0;

Random rnd = new Random();

Console.WriteLine("Введите кол-во строк: ");
w = Convert.ToInt32(Console.ReadLine());

int[] arr = new int[w];

Console.WriteLine("Введите кол-во столбцов: ");
h = Convert.ToInt32(Console.ReadLine());

int[,] matr = new int[w, h];

for (int i = 0; i < w; i++) // создание массива
{
    for (int j = 0; j < h; j++)
    {
        matr[i, j] = rnd.Next(200);
    }
}

for (int i = 0; i < w; i++)
{
    for (int j = 0; j < h; j++)
    {
        sum = matr[i, j] + sum; // сумма строки i
        arr[i] = sum;
    }
    sum = 0;
}

Console.WriteLine("Одномерный массив из сумм элементов строк матрицы: ");

for (int d = 0; d < arr.GetLength(0); d++)
{
    Console.Write("{0} ", arr[d]);
}
