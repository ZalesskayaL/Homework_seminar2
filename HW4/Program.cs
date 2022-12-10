﻿/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16
*/
/*
int Grade(int num1, int num2)
{
    int res = 1;

    for(int i = 1; i <= num2; i++)
    {
        res = num1 * res;
    }
return res;
}

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень, в которую число возвести: ");
int b = Convert.ToInt32(Console.ReadLine());
int result = Grade(a, b);
Console.Write($"Число {a} в степени {b} = {result}");
*/

/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12
*/




/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]
*/

void CreateArray(int size)
{
    int [] array = new int [size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите элемент массива №{i+1}: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    for (int i = 0; i < size; i++)
    {
        Console.Write(array[i] + " ");
    }
}

Console.Write("Введите, сколько будет элементов в массиве: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());
CreateArray(sizeArray);