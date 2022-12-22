/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9
*/


int[,] CreateRandom2dArray()
{
    Console.Write("Введите количество строк массива: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов массива: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите минимальное значение элементов массива: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите максимальное значение элементов массива: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue, maxValue + 1);
    
    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + "\t");
        
        Console.WriteLine();
    }
    Console.WriteLine();
}





/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, 
что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

1 7 -> числа с такими индексами в массиве нет
*/

void CheckArray(int [,] array)
{
    Console.Write("Введите индекс i = ");
    int i = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите индекс j = ");
    int j = Convert.ToInt32(Console.ReadLine());
    if (i <= array.GetLength(0)-1 && j <= array.GetLength(1) - 1)
    {
        int result = array[i,j];
        Console.Write($"Элемент массива с индексами i = {i}, j = {j} равен " + result);
    }
    else
    {
        Console.Write("Числа с такими индексами в массиве нет");
    }
}

/*
int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
CheckArray(myArray);
*/

/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

void ArithmeticMeanColumn(int[,] array)
{
    double [] resultArray = new double [array.GetLength(1)];
    double result = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        result = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            result += array[i,j];
        }
        result = Math.Round(result / array.GetLength(0), 2);
        Console.Write(result + "\t");
    }
}

/*
int [,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
ArithmeticMeanColumn(myArray);
*/