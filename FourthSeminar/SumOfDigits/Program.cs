// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
int num = new Random().Next(1,100000);
Console.WriteLine($"Число {num}");
Console.WriteLine($"Сумма {SumOfDigitsInNumber(num)}");

int SumOfDigitsInNumber(int number)
{
    int result = default;
    while (number > 0)
    {
        result = result + (number % 10);
        number /= 10;
    }

    return result;
}
