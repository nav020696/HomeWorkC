/*Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76 */

double[] newArray = GenerateArray(5);
PrintArray(newArray);
double result = FindMaxInArray(newArray) - FindMinInArray(newArray);
Console.Write("Разница между максимальным и минимальным элементом массива ");
Console.Write("{0:0.00}", result);

double FindMinInArray(double[] array)
{
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}

double FindMaxInArray(double[] array)
{
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}

double[] GenerateArray(int lenght)
{
    double[] array = new double[lenght];
    for (int i = 0; i < lenght; i++)
    {
        array[i] = new Random().NextDouble() * 100;
    }

    return array;
}

void PrintArray(double[] array)
{
    foreach (double i in array)
    {
        Console.WriteLine("{0:0.00}", i);
    }
    Console.WriteLine();
}
