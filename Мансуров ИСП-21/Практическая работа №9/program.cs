// Практическая работа №9. Мансуров В. ИСП-21
// Составьте программу вычисления в массиве суммы всех чисел, кратных 3

int n, i, sum = 0;

Console.WriteLine("Введите размер массива n: ");
n = Convert.ToInt32(Console.ReadLine());

int[] num = new int[n];

Random rnd = new Random();

for (i = 0; i < n; i++) num[i] = rnd.Next(-100, 100);

for (i = 0; i < n; i++)
{
    if ( num[i] % 3 == 0 )
    {
        sum = sum + num[i];
    }
}
Console.WriteLine("Сумма чисел кратных 3: {0}", sum);