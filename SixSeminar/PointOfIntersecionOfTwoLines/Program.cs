/* Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
y = k1 * x + b1, y = k2 * x + b2; значения k1, b1, k2 и b2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

//k1 * x + b1 = k2 * x + b2;
//k1 * x - k2 * x = b2 - b1;
// (k1-k2) * x = b2 - b1
// x = (b2 - b1) / (k1 - k2)

Console.WriteLine ("Уравнение y = k * x + b");
int[] newArray = GenerateArray();
Print(newArray);
PrintPoints(newArray);

int[] GenerateArray()
{
    int[] array = new int[4];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = GetMessage(i);
    }

    return array;
}

void Print(int[] array)
{
    Console.WriteLine($"Первое уравнение: y = {array[0]} * x + {array[1]}");
    Console.WriteLine($"Второе уравнение: y = {array[2]} * x + {array[3]}");
}

int GetMessage(int index)
{
    if (index == 1 || index == 3)
    {
        Console.WriteLine($"Введите b элемент");
    }
    else
    {
        Console.WriteLine($"Введите k элемент");
    }
    return int.Parse(Console.ReadLine());
}

int FindCoordinateX(int[] array)
{
    return (array[3] - array[1]) / (array[0] - array[2]);
}

int FindCoordinateY(int[] array)
{
    int x = FindCoordinateX(array);
    return array[0] * x + array[1];
}

void PrintPoints(int[] array)
{
    Console.WriteLine($"Координаты пересечения двух прямых ({FindCoordinateX(array)} , {FindCoordinateY(array)})");
}