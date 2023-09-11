/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

int[,] firstMatrix = GenerateMatrix(2, 2);
int[,] secondMatrix = GenerateMatrix(2, 2);
Console.WriteLine("Первая матрица");
PrintMatrix(firstMatrix);
Console.WriteLine();
Console.WriteLine("Вторая матрица");
PrintMatrix(secondMatrix);
Console.WriteLine();
Console.WriteLine("Произведение матриц");
PrintMatrix(MultiplicationOfMatrix(firstMatrix, secondMatrix));

int[,] MultiplicationOfMatrix(int[,] firstMatrix, int[,] secondMatrix)
{
    int[,] resultMatrix = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            resultMatrix[i, j] = CountTheResultOfElementInResultMatrix(i, j, firstMatrix, secondMatrix);
        }
    }
    return resultMatrix;
}

int CountTheResultOfElementInResultMatrix(int i, int j, int[,] firstMatrixForCount, int[,] SecondMatrixForCount)
{
    int multiplication = 0;
    for (int k = 0; k < firstMatrixForCount.GetLength(1); k++)
    {
        multiplication += firstMatrixForCount[i, k] * SecondMatrixForCount[k, j];
    }
    return multiplication;
}

int[,] GenerateMatrix(int rows, int column)
{
    Random random = new Random();
    int[,] array = new int[rows, column];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(0, 10);
        }
    }
    return array;
}

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}