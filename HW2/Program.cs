/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/
/*
int Second(int num)
{
    num = num /10 %10;
    return num;
}

Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = Second(number);
Console.Write(result);
*/


/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

/*
int ThirdNum(int num, int leng)
{
    int a = 1;
    int n = 1;
    leng = leng - 3;

    while (n <= leng)
    {
        a = a * 10;
        n = n + 1;
    }

    int result = num / a % 10;
    return result;
}


Console.Write("Введите число: ");
string q = Console.ReadLine();
int number = Convert.ToInt32(q);
int length = q.Length;
if (length >= 3)
{
    int result = ThirdNum(number, length);
    Console.Write("Третья цифра во введенном числе - это " + result);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}

*/

/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет */

bool Week(int day)
{
    bool result;
    if (day < 6)
    {
        result = false;
    }
    else
    {
        result = true;
    }
    return result;
}

Console.Write("Напишите порядковый номер дня недели: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write(Week(num));
