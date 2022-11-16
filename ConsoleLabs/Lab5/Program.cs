double anltFunc = Math.PI * Math.Cos(1) / 8;
double calcFunc = 0;

for (int n = 1; n < 50; n++)
    calcFunc += (n * Math.Sin(2 * n)) / ((2 * n - 1) * (2 * n + 1));


Console.WriteLine($"anltFunc = {anltFunc}\ncalcFunc = {calcFunc}");
Console.WriteLine($"Расчёт произведён {(Math.Abs(anltFunc - calcFunc) < 0.1 ? "правильно" : "неправильно")}");