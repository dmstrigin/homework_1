﻿// Задача 4: Напишите программу, которая принимает на вход три числа 
// и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22


int Max(int arg1, int arg2, int arg3)
{
    int result =arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

Console.WriteLine("Enter first number");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter second number");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter third number");
int c = Convert.ToInt32(Console.ReadLine());

int max = Max(a, b, c);

Console.Write($"{a} {b} {c} -> {max}");

