/*
 * Найти сумму цифр, содержащихся в заданной строке и удалить все цифры «0».
Вывести строку. Затем удалить все не цифровые символы.
 */

/*
* 0 - 48
* 1 - 49
* 2 - 50
* 3 - 51
* 4 - 52
* 5 - 53
* 6 - 54
* 7 - 55
* 8 - 56
* 9 - 57
 */

Console.Write("Введите строку: ");

string str = Console.ReadLine() ?? string.Empty;

int sumOfNumbers = 0;

string numStr = string.Empty;

for (int i = 0; i < str.Length;)
{
    char currentCharacter = str[i];

    if (!char.IsDigit(currentCharacter))
    {
        i++;
        continue;
    }

    if (currentCharacter - '0' == 0)
        str = str.Remove(i, 1);
    
    sumOfNumbers += currentCharacter - '0';
    numStr += currentCharacter.ToString();
    i++;
}

Console.WriteLine($"Сумма цифр строки: {sumOfNumbers}\nСтрока без цифры \"0\": {(str.Length > 0 ? str : "[Пустая строка]")}");
Console.WriteLine($"Строка только с цифрами: {(numStr.Length > 0 ? numStr : "[Строка не имеет цифр]")}");