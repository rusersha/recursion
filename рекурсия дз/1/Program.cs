﻿// Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

 void PrintNaturalNumbers(int m, int n)
    {
        if (m <= n)
        {
            Console.WriteLine(m);
            PrintNaturalNumbers(m + 1, n);
        }
    }


    
        int m = 1;
        int n = 5;

        Console.WriteLine($"Натуральные числа от {m} до {n}:");
        PrintNaturalNumbers(m, n);