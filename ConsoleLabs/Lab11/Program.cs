/*
 * В матрице n*m отсортируйте столбцы в порядке возрастания.
 */

Random random = new Random();

int n = random.Next(10);
int m = random.Next(10);

int[,] matrix = new int[n, m];

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        int element = random.Next(-25, 25);

        matrix[i, j] = element;
        Console.Write($"{element} ");
    }
    Console.Write('\n');
}

Console.WriteLine("Матрица с отсортированными столбцами:");

for (int i = 0; i < n; i++)
{
    int unsortedLength = m;
    while (unsortedLength --> 1)
    {
        for (int j = 0; j < unsortedLength; j++)
        {
            if (matrix[i, j] > matrix[i, j + 1])
                (matrix[i, j], matrix[i, j + 1]) = (matrix[i, j + 1], matrix[i, j]);
        }
    }

    for (int j = 0; j < m; j++)
        Console.Write($"{matrix[i, j]} ");

    Console.Write("\n");
}