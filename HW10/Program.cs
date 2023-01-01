/*
Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/
/*
void Nums(int num)
{
    if (num >= 1)
    {
        Console.Write(num + " ");
        Nums(num-1);
    }
}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Nums(number);
*/
/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
/*
int Sum(int num1, int num2)
{
    if(num1 < num2)
    {
        return num1 + Sum(num1 + 1, num2);
    }
    return num2;
}

Console.Write("Введите число M: ");
int numM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int numN = Convert.ToInt32(Console.ReadLine());
int SumNM = Sum(numM, numN);
Console.Write("Сумма натуральных чисел между заданными значениями: " + SumNM);
*/

/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

int A(int M, int N)
{
    if(M == 0)
    {
        return N + 1;
    }
    if(M > 0 && N == 0)
    {
        return A(M-1, 1);
    }
    if(M > 0 && N > 0)
    {
        return A(M-1, A(M, N - 1));
    }
    return 0;
}

Console.Write("Введите число M: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int result = A(num1, num2);
Console.WriteLine(result);