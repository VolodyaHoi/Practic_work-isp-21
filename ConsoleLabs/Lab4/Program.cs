/*
 * Введите целое число n100 и два произвольных числа x и y. В зависимости от 
значения k младшей цифры числа n вычислите значение переменной z по одной из 
следующих формул: z=1 при k=0; z=x+y при k=1, 7; z=x2
exp(y) при k=2, 5; z=xy при 
k=8, 9; z=xsin(y) при k=3, 4; z=xln(y) при k= 6.
 * */

Console.Write("Input n (n <= 100): ");
int n = int.Parse(Console.ReadLine());

Console.Write("Input x: ");
double x = double.Parse(Console.ReadLine());

Console.Write("Input y: ");
double y = double.Parse(Console.ReadLine());

double z;

switch (n % 10)
{
    case 0:
        z = 1;
        break;

    case 1:
    case 7:
        z = x + y;
        break;

    case 2:
    case 5:
        z = x * x * Math.Exp(y);
        break;

    case 3:
    case 4:
        z = x * Math.Sin(y);
        break;

    case 6:
        z = x * Math.Log(Math.Abs(y));
        break;

    case 8:
    case 9:
        z = x * y;
        break;

    default:
        throw new Exception("Непредвиденное значение k");

}

Console.WriteLine($"z = {z}");