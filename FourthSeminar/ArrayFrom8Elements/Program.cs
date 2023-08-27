// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

PrintArray(GenerateArray(8));

int[] GenerateArray(int lenght)
{
    int[] array = new int[lenght];
    for (int i = 0; i < lenght; i++)
    {
        array[i] = new Random().Next(0,10);
    }

    return array;
}

void PrintArray(int[] array)
{
    foreach (int i in array)
    {
        Console.Write($"{i} ");
    }
}
