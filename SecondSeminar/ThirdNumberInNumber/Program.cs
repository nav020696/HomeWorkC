int number = new Random().Next(-1000000, 1000001);
Console.WriteLine($"Введенное число: {number}");

if (number > -100 && number < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    if (number < 0)
    {
        number = number * -1;
    }
    while (number > 999)
    {
        number = number / 10;
    }
    Console.WriteLine($"Третья цифра в числе: {number % 10}");
}