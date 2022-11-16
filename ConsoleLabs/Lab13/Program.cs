/*
 * Записать 150 случайных чисел в файл a.txt. В файл b.txt вывести четные, а в
файл c.txt кратные 5
 */

Console.WriteLine("Генерация и запись случайных чисел в файлы");

Random random = new Random();

StreamWriter writerA = new StreamWriter("a.txt");
StreamWriter writerB = new StreamWriter("b.txt");
StreamWriter writerC = new StreamWriter("c.txt");

for(int i = 0; i < 150; i++)
    writerA.WriteLine(random.Next(0, 1000));
writerA.Close();
Console.WriteLine("a.txt заполнен");

StreamReader readerA = new StreamReader("a.txt");
string? line = readerA.ReadLine();

while (line!=null)
{
    int number = int.Parse(line);

    if (number % 2 == 0)
        writerB.WriteLine(number);

    if (number % 5 == 0)
        writerC.WriteLine(number);

    line = readerA.ReadLine();
}
Console.WriteLine("Файлы b.txt и c.txt заполнены");

writerB.Close();
writerC.Close();