﻿// Задача 4
Console.WriteLine("Введите 3 числа:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int max = a;

            if (b > max)
            {
                max = b;
            }

            if (c > max)
            {
                max = c;
            }

            Console.WriteLine("Наибольшее из введённых чисел " + max);