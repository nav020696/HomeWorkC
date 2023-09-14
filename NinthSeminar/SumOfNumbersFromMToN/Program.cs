/*
Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

Console.WriteLine(SumOfNumbers(5,100));

int SumOfNumbers(int start, int end)
{
    if (start == end)
    {
        return end;
    }
    return start + SumOfNumbers(start + 1, end);
}