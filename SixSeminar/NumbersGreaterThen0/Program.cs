/* Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

Console.WriteLine("Введите количество элементов");
int count = int.Parse(Console.ReadLine());
int[] newArray = GenerateArray(count);
PrintArray(newArray);
Console.WriteLine($"Количество элементов больше 0: {CountNumbersGreaterThen0(newArray)}");


int[] GenerateArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = GetMessage(i);
    }
    return array;
}

void PrintArray(int[] array)
{
    foreach (int i in array)
    {
        Console.Write($"{i} ");
    }
    Console.WriteLine();
}

int GetMessage(int index)
{
    Console.WriteLine($"Введите {index+1} элемент");
    return int.Parse(Console.ReadLine());
}

int CountNumbersGreaterThen0(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            result++;
        }
    }
    return result;
}