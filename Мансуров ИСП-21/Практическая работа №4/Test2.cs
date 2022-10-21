// Практическая работа №4. Мансуров В.Ю ИСП-21. Вариант №9

// Введите целое число n=<100 и два произвольных числа x и y. В зависимости от 
// значения k младшей цифры числа n вычислите значение переменной z по одной из 
// следующих формул: z = 1 при k = 0; z = x + y при k = 1, 7; z = x
// * exp(y) при k = 2, 5; z = x * y при 
// k=8, 9; z = x * sin(y) при k = 3, 4; z = x * ln(| y |) при k = 6

int n;
double x, y, k, z;

Console.WriteLine("Введите n: ");
n = Convert.ToInt32(Console.ReadLine());

k = n % 10;


if (k > 6 && k != 0)
{
    Console.WriteLine("Значение k не подходит под данные значения");
}
else 
{
    Console.WriteLine("Введите x: ");
    x = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите y: ");
    y = Convert.ToInt32(Console.ReadLine());

    switch (k)
    {
        case 1:
            z = 1;
            Console.WriteLine("Ответ: {0}", z);
            break;

        case 2:
            z = x + y;
            Console.WriteLine("Ответ: {0}", z);
            break;

        case 3:
            z = Math.Pow(x, 2) * Math.Exp(y);
            Console.WriteLine("Ответ {0}", z);
            break;

        case 4:
            z = x * y;
            Console.WriteLine("Ответ: {0}", z);
            break;

        case 5:
            z = x * Math.Sin(y);
            Console.WriteLine("Ответ: {0}", z);
            break;
        case 6:
            z = x * Math.Log(Math.Sqrt(y));
            Console.WriteLine("Ответ: {0}", z);
            break;
    }
}