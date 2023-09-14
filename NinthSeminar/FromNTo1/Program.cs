/*
Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

Console.Write("Введите число N: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine();
Console.WriteLine(PrintNumbersFromNto1(number));

string PrintNumbersFromNto1(int number)
{
    if (number == 1)
    {
        return number.ToString();
    }
    return number + " " + PrintNumbersFromNto1(number - 1);
}