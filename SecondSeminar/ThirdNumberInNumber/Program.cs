int number = 233;

if (number > -100 && number < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
else if ((number >= -100 && number <= -999) || (number >= 100 && number <= 999))
{
    Console.WriteLine($"Третья цифра в числе: {number % 10}");
} 
else
{
    
}