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

int[,] array = GenerateArray(6,5);
PrintArray(array);
Console.WriteLine();
SortArray(array);
PrintArray(array);

void SortArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1)-1; j++)
        {
           for (int k = j + 1; k < array.GetLength(1); k++)
           {
             if (array[i,j] < array[i,k])
             {
                int temp = array[i,j];
                array[i,j] = array[i,k];
                array[i,k] = temp;
             }
           }
        }
    }
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