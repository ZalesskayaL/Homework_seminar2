/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
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

void SortDescAtRow(int[,] array)
{
    int temp = 0;
    for (int n = 0; n < array.GetLength(1)-1; n++)
    {
        for (int j = 0; j < array.GetLength(1)-1; j++)
        {
            for (int i = 0; i < array.GetLength(0)-1; i++)
            {
                temp = array[i,j];
                if(array[i,j] > array[i,j+1])
                {
                    array[i,j] = array[i,j+1];
                    array[i,j+1] = temp;
                }
            }
        }
    }
    
}
/*
int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
SortDescAtRow(myArray);
Show2dArray(myArray);
*/

/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

int MinSumRow(int[,] array)
{
    
    int[] sumRows = new int[array.GetLength(0)];
    int sum;
    for (int i = 0;  i < array.GetLength(0); i++)
    {
        sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i,j];
        }
        sumRows[i] = sum;
    }

    for (int i = 0; i < sumRows.GetLength(0); i++)
        {
            Console.WriteLine($"Сумма элементов в строке № {i+1} = {sumRows[i]} ");
        }
        Console.WriteLine();

    int minI = 0;

    for (int i = 0; i < sumRows.GetLength(0); i++)
    {
        if(sumRows[minI] > sumRows[i])
            minI = i;
    }

    return minI;

}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
int minSumRow = MinSumRow(myArray) + 1;
Console.Write("Номер строки с минимальной суммой: " + minSumRow);


/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/
/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/
/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/