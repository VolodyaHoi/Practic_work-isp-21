﻿/*
 * Напечатать в возрастающем порядке все трехзначные числа, в десятичной 
записи которых нет одинаковых цифр
 */

for (int i = 1; i < 10; i++)
    for (int j = 0; j < 10; j++)
        for (int k = 0; k < 10; k++)
            if (i != j && j != k && k != i)
                Console.WriteLine($"{i}{j}{k}");