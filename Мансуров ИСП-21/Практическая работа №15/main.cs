/* Составить программу, которая:
а) уменьшает первое веденное число в два раза, если оно больше второго 
введенного числа по абсолютной величине. 
б) Если квадратный корень из второго введенного числа меньше первого 
введенного числа, то увеличить второе число в пять раз.
в) Определить сумму из двух веденных чисел, которые кратны трем */

using ClassLibrary1;

int value1, value2;

Console.WriteLine("Введите два числа: ");
value1 = Convert.ToInt32(Console.ReadLine());
value2 = Convert.ToInt32(Console.ReadLine());

Class1.functionA(value1, value2); // вызов функции а

Class1.functionB(value1, value2); // вызов функции б

Class1.functionC(value1, value2); // вызов функции в
