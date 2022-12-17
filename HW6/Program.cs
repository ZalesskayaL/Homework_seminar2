/*
Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
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

int [] CreateArray(int size)
{
    int [] array = new int [size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите число №{i+1}: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
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

int Count(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
            count += 1;
    }
    return count;
}
*/
/*
Console.Write("Введите количество элементов: ");
int m = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateArray(m);
int result = Count(myArray);
Console.Write("Количество элементов массива больше нуля: " + result);
*/
/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

void Point(double b1, double k1, double b2, double k2)
{
    
        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;
        Console.Write($"Точка пересечения прямых имеет координаты x = {x}, y = {y}");

}

Console.WriteLine("Введите коэффициенты уравнения, задающих прямую №1: y = k1 * x + b1");
Console.Write("Коэффициент k1 = ");
double a1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Коэффициент b1 = ");
double c1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("Введите коэффициенты уравнения, задающих прямую №2: y = k2 * x + b2");
Console.Write("Коэффициент k2 = ");
double a2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Коэффициент b2 = ");
double c2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Point(c1, a1, c2, a2);
