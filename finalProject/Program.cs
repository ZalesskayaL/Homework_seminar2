//new project

void ShowArray(string[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]+ " ");
    }
    Console.WriteLine();
}

string [] arrayChanging(string[] array)
{
    int size_newArray = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            size_newArray = size_newArray + 1;
        }
    }
    
    string [] newArray = new string [size_newArray];
    for (int i = 0, j = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[j] = array[i];
            j++;
        }
    }
    return newArray;

}

Console.Write("Укажите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

string [] array = new string [size];

for (int i = 0; i < size; i++)
{
    Console.Write($"Введите значение {i + 1}: ");
    array[i] = Console.ReadLine();
}

Console.Write("Ваш массив: ");
ShowArray(array);
string [] newArray = arrayChanging(array);
Console.Write("Обработанный массив: ");
ShowArray(newArray);



