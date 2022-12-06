/*
Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да
*/
/*
void Palindrom(int num)
{
    int first = num / 10000;
    int second = num % 10000 / 1000;
    int fourth = num % 100 / 10;
    int fiveth = num % 10;
    if (first == fiveth && second == fourth) 
    {
        Console.WriteLine("Число является палиндромом");
    }
    else
    {
        Console.WriteLine("Число НЕ является палиндромом");
    }
}

Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
Palindrom(number);
*/

/*
Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53
*/

/*
void Dist(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double x = x2 - x1;
    double y = y2 - y1;
    double z = z2 - z1;
    double gip = Math.Round(Math.Sqrt(Math.Pow(x,2) + Math.Pow(y,2) + Math.Pow(z,2)),2);
    Console.Write("Расстояние между точками А и В = " + gip);
}
Console.Write("Введите координаты точки А, xA = ");
double xA = Convert.ToDouble(Console.ReadLine());
Console.Write("yA = ");
double yA = Convert.ToDouble(Console.ReadLine());
Console.Write("zA = ");
double zA = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты точки B, xB = ");
double xB = Convert.ToDouble(Console.ReadLine());
Console.Write("yB = ");
double yB = Convert.ToDouble(Console.ReadLine());
Console.Write("zB = ");
double zB = Convert.ToDouble(Console.ReadLine());
Dist(xA, yA, zA, xB, yB, zB);
*/

/*
Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

void Cube(int num)
{
    int count = 1;
    while(count <= num)
    {
        Console.Write(Math.Pow(count,3) + " ");
        count++;
    }
}
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Cube(number);