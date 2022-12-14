/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/
/*
int[] CreateRandomArray(int size)
{
    int maxValue = 999;
    int minValue = 99;
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue);
    }

    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]+ " ");
    }
    Console.WriteLine();
}

int CountMethod(int [] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
            count = count + 1;
    }
    return count;
}

Console.Write("Введите количество элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int [] myArray = CreateRandomArray(size);
ShowArray(myArray);
int result = CountMethod(myArray);
Console.Write(result);
*/

/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
НЕЧЕТНЫМИ ПОЗИЦИЯМИ СЧИТАЕМ НЕЧЕТНЫЕ ПОРЯДКОВЫЕ НОМЕРА ЭЛЕМЕНТОВ МАССИВА, Т.Е. I = 0 ИЛИ 2 ИЛИ 4 И Т.Д. - > НЕЧЕТНЫЙ ЭЛЕМЕНТ 
*/
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }

    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]+ " ");
    }
    Console.WriteLine();
}

int SumNegativePosition(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if((i+1) % 2 != 0)
            sum += array[i];
    }
    return sum;
}

Console.Write("Введите количество элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение элемента массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение элемента массива: ");
int max = Convert.ToInt32(Console.ReadLine());

int [] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);
int result = SumNegativePosition(myArray);
Console.Write(result);
*/

/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }

    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]+ " ");
    }
    Console.WriteLine();
}

int SubMinMax(int[] array)
{
    int index_min = 0;
    int index_max = 0;
    int sub = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > array[index_max])
        {
            index_max = i;
        }
        else
        {
            if(array[i] < array[index_min])
                index_min = i;
        }
    }
    int maximal = array[index_max];
    int minimal = array[index_min];
    sub = maximal - minimal;
    Console.WriteLine(minimal);
    Console.WriteLine(maximal);
    return sub;
}

Console.Write("Введите количество элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение элемента массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение элемента массива: ");
int max = Convert.ToInt32(Console.ReadLine());

int [] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);
int result = SubMinMax(myArray);
Console.Write(result);
