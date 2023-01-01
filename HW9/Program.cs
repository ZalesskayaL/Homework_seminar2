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

/*
int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
int minSumRow = MinSumRow(myArray) + 1;
Console.Write("Номер строки с минимальной суммой: " + minSumRow);
*/

/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

int[,] ArrayMultiplication (int[,] arrayFirst, int[,] arraySecond)
{
    int[,] result = new int[arrayFirst.GetLength(0), arraySecond.GetLength(1)];
    int temp = 0;
    for (int i = 0; i < arrayFirst.GetLength(0); i++)
    {
        for (int b = 0; b < arraySecond.GetLength(1); b++)
        {
            temp = 0;
            for (int j = 0, a = 0; j < arrayFirst.GetLength(1); j++, a++)
            {
                temp += arrayFirst[i,j] * arraySecond[a,b];
            }
            result[i,b] = temp;
        }       
    }
        return result;
    
}
/*
Console.WriteLine("Матрица №1");
int[,] myArrayFirst = CreateRandom2dArray();
Show2dArray(myArrayFirst);
Console.WriteLine("Матрица №2");
int[,] myArraySecond = CreateRandom2dArray();
Show2dArray(myArraySecond);

if(myArrayFirst.GetLength(1) == myArraySecond.GetLength(0))
{
    int[,] resultArray = ArrayMultiplication(myArrayFirst, myArraySecond);
    Console.WriteLine("Результат умножения матриц:");
    Show2dArray(resultArray);
}
else
{
    Console.WriteLine("Ошибка: количество столбцов Матрицы №1 должно быть равно количеству строк Матрицы №2");
}
*/

/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

void Show3DArray(int[,,] array)
{
    Console.WriteLine("Полученный массив:");
    for (int x = 0; x < array.GetLength(0); x++)
    {
        for (int y = 0; y < array.GetLength(1); y++)
        {
            for (int z = 0; z < array.GetLength(2); z++)
            {
                Console.Write(array[x,y,z] + $"({x}, {y}, {z})" + "\t");
            } 

            Console.WriteLine();             
        }
        
    }
}

bool SearchSame(int[,,] array, int x, int y, int z, int num)
{
    int n, l, m;
    bool result = false;
    
    for (n = 0; result == false && n < array.GetLength(0); n++)
    {
        for (l = 0; result == false && l < array.GetLength(1); l++)
        {
            for (m = 0; result == false && m < array.GetLength(2); m++)
            {
                if(array[n,l,m] == num)
                {
                    result = true;
                }                          
            }
        }
                    
    }
    return result;
}

int[,,] Create3DArray(int x, int y, int z)
{
    
    int min = 10;
    int max = 99;
    int[,,] newArray = new int[x,y,z];
    bool search;

    for (x = 0; x < newArray.GetLength(0); x++)
    {
        for (y = 0; y < newArray.GetLength(1); y++)
        {
            for (z = 0; z < newArray.GetLength(2); z++)
            {
                search = true;
                int temp;
                while (search == true)
                {
                    temp = new Random().Next(min,max);
                    search = SearchSame(newArray, x, y, z, temp);
                    newArray[x,y,z] = temp;
                }
                                    
            }
        }
    }
    return newArray;

}

/*
Console.Write("Введите количество элементов массива по оси X: ");
int i = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество элементов массива по оси Y: ");
int j = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество элементов массива по оси Z: ");
int h = Convert.ToInt32(Console.ReadLine());
if(i * j * h <= 89)
{
    int[,,] new3DArray = Create3DArray(i, j, h);
    Show3DArray(new3DArray);
}
else
{
    Console.Write("Нельзя создать массив такого размера с неповторяющимися двузначными числами");
}
*/
/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

int[,] CreateSpiralArray()
{
    Console.Write("Введите количество строк массива: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов массива: ");
    int columns = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];
    int size = rows * columns;
    int i = 0;
    int j = 0;
    int n = 0;
    int count;
    if(rows > 2 && columns > 2)
    {
        if(rows <= columns)
        {
            count = rows - 2;
        }
        else
        {
            count = columns - 2;
        }
    }
    else
    {
        count = 1;
    }
    
    int minI = 0;
    int minJ = 0;
    int maxI = array.GetLength(0) - 1;
    int maxJ = array.GetLength(1) - 1;

    while(count > 0)
    {
        Console.WriteLine("Цикл");
        if(i == minI && j == minJ && n <= size)
        {   
            for(j = minJ, i = minI; j <= maxJ && n <= size; j++, n++)
            {
                array[i,j] = n;
            }
            minI++;
            i = minI;
            j = maxJ;
        }
        if(i == minI && j == maxJ && n < size)
        {
            for (i = minI, j = maxJ; i <= maxI && n <= size; i++, n++)
            {
                array[i,j] = n;
            }
            maxJ--;
            i = maxI;
            j = maxJ;
        }
        if(i == maxI && j == maxJ && n < size)
        {
            for (j = maxJ, i = maxI; j >= minJ && n < size; j--, n++)
            {
                array[i,j] = n;
            }
            maxI--;
            i = maxI;
            j = minJ;
        }
        if(i == maxI && j == minJ && n < size)
        {
            for (i = maxI, j = minJ; i >= minI && n < size; i--, n++)
            {
                array[i,j] = n;
            }
            minJ++;
            i = minI;
            j = minJ;
        }   
        count--;    
        
    }

    
    return array;
}

int[,] myArray = CreateSpiralArray();
Show2dArray(myArray);