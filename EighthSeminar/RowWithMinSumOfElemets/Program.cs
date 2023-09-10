/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2 = 15
5 9 2 3 = 19
8 4 2 4 = 18
5 2 6 7 = 20
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

int[,] array = GenerateArray(5,5);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Минимальная сумма элементов в {FindRowWithMinSumOfElements(array) + 1} строке");

int FindRowWithMinSumOfElements(int[,] array)
{
     int[] resultOfSumOfElements = SumOfElementsInRows(array);
     int minSum = resultOfSumOfElements[0];
     int index = 0;
     for (int i = 1; i < resultOfSumOfElements.Length; i++)
     {
        if (resultOfSumOfElements[i] < minSum)
        {
            minSum = resultOfSumOfElements[i];
            index = i;
        }
     }
     return index;   
}

int[] SumOfElementsInRows(int[,] array)
{
    int[] newArray = new int[array.GetLength(0)];
    int sumOfElements = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumOfElements += array[i,j];
        }
        newArray[i] = sumOfElements;
        sumOfElements = 0;
    }
    return newArray;
}


int[,] GenerateArray(int rows, int column)
{
    Random random = new Random();
    int[,] array = new int[rows, column];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = random.Next(0,10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
           Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}
